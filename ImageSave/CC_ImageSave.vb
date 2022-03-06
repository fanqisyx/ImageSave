Imports Cognex.VisionPro.ImageFile
Imports Cognex.VisionPro
Imports System.Threading.Thread
Imports ChuangChi.CC_ImageSaveUI
Imports System.Drawing

Public Class CC_ImageSave
    Private ImageQueue As New Queue
    Private ImageQueueBMP As New Queue
    Private ImageNameQueue As New Queue
    Private ImageNameQueueBMP As New Queue
    Private myImageFileForSave As New CogImageFileTool
    Private IsAddingImage As Boolean = False
    Private IsNeedClose As Boolean = False
    Private mythreading As Threading.Thread
    Private mySaveImageUI As New ChuangChi.CC_ImageSaveUI
    Private myNeedSaveBMP As System.Drawing.Bitmap
    Private myNeedSaveBMPPath As String
    Private sleeptime As Integer = 15
    Private ErrorTimes As Integer = 0
    Private UseCognex As Boolean = True
    Private ImageLock As Object = New Object()

    ''' <summary>
    ''' 是否需要使用Cognex的dll保存ICogImage格式的图片
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IsUseCognexdll() As Boolean
        Get
            Return UseCognex
        End Get
        Set(ByVal value As Boolean)
            UseCognex = value
        End Set
    End Property



    ''' <summary>
    ''' 获取队列中所有图像总数
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property QueueCount() As Integer
        Get
            Return ImageQueue.Count + ImageQueueBMP.Count
        End Get
    End Property

    ''' <summary>
    ''' 用于在连续保存图片时保护硬盘以防止软件崩溃
    ''' 单位为：ms，含义是每保存一张图片，会保护硬盘在此时间内不被此程序再次写如
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property SaveImageTimeInterval() As Integer
        Get
            Return sleeptime
        End Get
        Set(ByVal value As Integer)
            sleeptime = value
        End Set
    End Property

    ''' <summary>
    ''' 返回保存图片时出错次数
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property SaveImageErrorTimes() As Integer
        Get
            Return ErrorTimes
        End Get
    End Property


    Private TooFastSafeguard As Boolean = False
    ''' <summary>
    ''' 设置是否需要保护保存图片队列长度。
    ''' 当为True时，要求保存图片过快会导致图片丢弃，以防止软件占用巨大内存，导致软件崩溃
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property IsNeedSafeguard() As Boolean
        Get
            Return TooFastSafeguard
        End Get
        Set(ByVal value As Boolean)
            TooFastSafeguard = value
        End Set
    End Property




    Public Property SaveImageUI() As ChuangChi.CC_ImageSaveUI
        Get
            Return mySaveImageUI
        End Get
        Set(ByVal value As ChuangChi.CC_ImageSaveUI)
            mySaveImageUI = value
        End Set
    End Property

    Private Sub SaveImageQueue()
        While Not IsNeedClose
            Sleep(1)
            Try
                While ImageQueue.Count > 0 And Not IsAddingImage 'And (myImageFileForSave.Operator.IsSynchronized = True)
                    Dim NeedSaveImage As ICogImage
                    Dim NeedSaveImageName As String
                    SyncLock ImageLock
                        NeedSaveImage = ImageQueue.Dequeue()
                        NeedSaveImageName = ImageNameQueue.Dequeue()
                    End SyncLock
                    myImageFileForSave.InputImage = NeedSaveImage
                    myImageFileForSave.Operator.Open(NeedSaveImageName, CogImageFileModeConstants.Write)
                    Try
                        myImageFileForSave.Run()
                    Catch ex As Exception

                    End Try
                    Sleep(sleeptime)
                End While
                While ImageQueueBMP.Count > 0 And Not IsAddingImage
                    SyncLock ImageLock
                        myNeedSaveBMP = ImageQueueBMP.Dequeue()
                        myNeedSaveBMPPath = ImageNameQueueBMP.Dequeue()
                    End SyncLock
                    Try
                        If myNeedSaveBMPPath.EndsWith("bmp") Then
                            myNeedSaveBMP.Save(myNeedSaveBMPPath, Imaging.ImageFormat.Bmp)
                        ElseIf myNeedSaveBMPPath.EndsWith("jpg") Then
                            myNeedSaveBMP.Save(myNeedSaveBMPPath, Imaging.ImageFormat.Jpeg)
                        End If
                    Catch ex As Exception

                    End Try
                    Sleep(sleeptime)
                End While
            Catch ex As Exception
                ErrorTimes += 1
            End Try
        End While
    End Sub

    ''' <summary>
    ''' 保存图像
    ''' </summary>
    ''' <param name="Name">保存图像的文件名</param>
    ''' <param name="Image">需要被保存的图像</param>
    ''' <returns>返回文件保存路径，当bmp和JPG同时保存时，只返回bmp路径。当空间不足时，将返回以“Err”开头字符串</returns>
    ''' <remarks>若磁盘空间不足，将返回以“Err”开头字符串</remarks>
    Public Overloads Function SaveImage(ByVal Image As ICogImage, Optional ByVal Name As String = " ", Optional ByVal ReelNumber As String = " ") As String
        UseCognex = Not SaveImageUI.CK_UseMicroSoftWay.Checked
        Dim svpth As String = ""

        Try

            If UseCognex Then
                If mySaveImageUI.ImageFormatJPG = True And IsDiskSpaceEnough(GetAllPath(ReelNumber, Name, "jpg")) Then
                    AddImageQueue(GetAllPath(ReelNumber, Name, "jpg"), Image)
                    svpth = GetAllPath(ReelNumber, Name, "jpg")
                End If
                If mySaveImageUI.ImageFormatBMP = True And IsDiskSpaceEnough(GetAllPath(ReelNumber, Name, "bmp")) Then
                    AddImageQueue(GetAllPath(ReelNumber, Name, "bmp"), Image)
                    svpth = GetAllPath(ReelNumber, Name, "bmp")
                End If
            Else
                Dim a As Bitmap = Image.ToBitmap.Clone()
                'Dim e As Bitmap=a.PixelFormat.
                Dim b As Bitmap = a.Clone(New Rectangle(0, 0, a.Width, a.Height), Imaging.PixelFormat.Format8bppIndexed)
                'Dim c As Bitmap = a.Clone(New Rectangle(0, 0, a.Width, a.Height), Imaging.PixelFormat.Format16bppGrayScale)
                'Dim d As Bitmap = c.Clone(New Rectangle(0, 0, a.Width, a.Height), Imaging.PixelFormat.Format8bppIndexed)
                If mySaveImageUI.ImageFormatJPG = True And IsDiskSpaceEnough(GetAllPath(ReelNumber, Name, "jpg")) Then
                    AddImageQueue(GetAllPath(ReelNumber, Name, "jpg"), b)
                    AddImageQueue(GetAllPath(ReelNumber, Name, "jpg"), a)
                    svpth = GetAllPath(ReelNumber, Name, "jpg")
                    'AddImageQueue(GetAllPath(Name, "jpg"), c)
                    'AddImageQueue(GetAllPath(Name, "jpg"), d)
                End If
                If mySaveImageUI.ImageFormatBMP = True And IsDiskSpaceEnough(GetAllPath(ReelNumber, Name, "bmp")) Then
                    AddImageQueue(GetAllPath(ReelNumber, Name, "bmp"), b)
                    AddImageQueue(GetAllPath(ReelNumber, Name, "bmp"), a)
                    svpth = GetAllPath(ReelNumber, Name, "bmp")
                    'AddImageQueue(GetAllPath(Name, "bmp"), c)
                    'AddImageQueue(GetAllPath(Name, "bmp"), d)
                End If
            End If
            If IsDiskSpaceEnough(GetAllPath(ReelNumber, Name, "bmp")) = False Then
                Return "Err！磁盘空间不足，未保存图像 Image save Error,Disk free space is not enough"
            End If

        Catch ex As Exception

        End Try
        Return svpth
    End Function

    'Public Overloads Function SaveImage(ByVal Image As System.Drawing.Image, Optional ByVal Name As String = " ") As String
    '    'Dim CogImage As New CogImage24PlanarColor(Image)
    '    ' Dim LishiImagefile As New CogImageFileTool
    '    Dim svpth As String = ""
    '    If mySaveImageUI.ImageFormatJPG = True And IsDiskSpaceEnough(GetAllPath(Name, "jpg")) Then
    '        AddImageQueue(GetAllPath(Name, "jpg"), Image)
    '        svpth = GetAllPath(Name, "jpg")
    '    End If
    '    If mySaveImageUI.ImageFormatBMP = True And IsDiskSpaceEnough(GetAllPath(Name, "bmp")) Then
    '        AddImageQueue(GetAllPath(Name, "bmp"), Image)
    '        svpth = GetAllPath(Name, "bmp")
    '    End If
    '    If IsDiskSpaceEnough(GetAllPath(Name, "bmp")) = False Then
    '        Return "Err！磁盘空间不足，未保存图像 Image save Error,Disk free space is not enough"
    '    End If
    '    Return svpth
    'End Function


    Private Function GetAllPath(Optional ByVal ReelNumber As String = " ", Optional ByVal Name As String = " ", Optional ByVal Format As String = "") As String
        Dim PathDir As String = mySaveImageUI.ImageSavePathEdit + "\" + "图片及数据" + "\" + ReelNumber + "\" + ReelNumber + "\"
        Dim Username As String
        If mySaveImageUI.AutoCreatDateFolder = True Then
            PathDir += Now.Year.ToString() + "-" + Now.Month.ToString() + "-" + Now.Day.ToString() + "\"
        End If
        CreatDir(PathDir)
        Username = Name + "." + Format
        If mySaveImageUI.AutoUseTimeForFileName = True Then
            Username = Now.Hour.ToString() + "-" + Now.Minute.ToString() + "-" + Now.Second.ToString() + "-" + Now.Millisecond.ToString() + " " + Username
        End If
        Return (PathDir + Username)
    End Function

    Private Sub CreatDir(ByVal str As String)
        Try
            If Not IO.Directory.Exists(str) Then
                IO.Directory.CreateDirectory(str)
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Overloads Sub AddImageQueue(Name As String, image As Cognex.VisionPro.ICogImage)
        IsAddingImage = True
        If ImageQueue.Count < 15 Or Not TooFastSafeguard Then
            SyncLock ImageLock
                ImageQueue.Enqueue(image)
                ImageNameQueue.Enqueue(Name)
            End SyncLock
        End If
        IsAddingImage = False
    End Sub

    Private Overloads Sub AddImageQueue(Name As String, image As System.Drawing.Image)
        IsAddingImage = True
        If ImageQueueBMP.Count < 15 Or Not TooFastSafeguard Then
            SyncLock ImageLock
                ImageQueueBMP.Enqueue(image)
                ImageNameQueueBMP.Enqueue(Name)
            End SyncLock
        End If
        IsAddingImage = False
    End Sub

    ''' <summary>
    ''' 判断磁盘空间是否充足
    ''' </summary>
    ''' <param name="path">需要保存文件的文件路径</param>
    ''' <param name="NeedSpace">允许最小剩余空间</param>
    ''' <returns>返回空间是否充足，True为充足，False为不足</returns>
    ''' <remarks></remarks>
    Private Function IsDiskSpaceEnough(path As String, Optional ByVal NeedSpace As Int64 = 500000000) As Boolean
        Dim a() As System.IO.DriveInfo = System.IO.DriveInfo.GetDrives
        Dim b As System.IO.DriveInfo
        Dim diskfreespace As Int64 = 0
        For Each b In a
            If path.StartsWith(b.Name) Then
                If b.TotalFreeSpace < NeedSpace Then
                    Return False
                Else
                    Return True
                End If
            End If
        Next
        Return False
    End Function


    Public Sub Shutdown()
        IsNeedClose = True
        mythreading.Abort()
    End Sub

    Public Sub New()
        mythreading = New Threading.Thread(AddressOf SaveImageQueue)
        mythreading.IsBackground = True
        mythreading.Priority = Threading.ThreadPriority.Lowest
        mythreading.Start()
    End Sub

End Class
