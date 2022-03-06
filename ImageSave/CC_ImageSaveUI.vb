Imports ChuangChi.CC_IniFileIO
Public Class CC_ImageSaveUI
    Public Delegate Sub ButtonClickHandler()
    Public Event ImageSaveOK As ButtonClickHandler
    Public Event ImageSaveCancal As ButtonClickHandler
    Public ApplicationPath As String = My.Application.Info.DirectoryPath
    Public IsBeUsed As Boolean = False
    Private MyIni As New CC_IniFileIO
    Private INISection As String = "ImageSaveParameter"
    Public ImageSavePathEdit As String
    Public ImageFormatJPG As Boolean
    Public ImageFormatBMP As Boolean
    Public ImageOnly As Boolean
    Public ImageWithGraphic As Boolean
    Public WhichImageNeedSave As Int16
    Public AutoCreatDateFolder As Boolean
    Public AutoUseTimeForFileName As Boolean

    Public del_IsneedDeleteImage As Boolean
    Public del_rule_time As Boolean = False
    Public del_rule_disk As Boolean = True
    Public del_disk_all As Double = 0
    Public del_disk_remaining As Double = 0
    Public del_disk_setmin As Double = 0
    Public del_time_oldest As DateTime = DateTime.Now
    Public del_time_holdtime As Long = 0
    Public image_allimagenum As Long
    Public image_ramainingImagenum As Long
    Public image_today_save As Long
    Public image_today_del As Long
    Public del_time_holdtime_CBindex As Integer
    Public del_disk_setmin_CBindex As Integer
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveIniParameter()
        SaveDelImageIniParameter()
        RaiseEvent ImageSaveOK()
    End Sub

    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        RaiseEvent ImageSaveCancal()
    End Sub

    Private Sub CC_ImageSaveUI_Load(sender As Object, e As EventArgs) Handles Me.Load
        IsBeUsed = True
        CK_AutoCreateDatePath.Checked = False
        CK_AutoCreateDatePath.Visible = False
        CK_AutoCreateTimeImageName.Checked = False
        CK_AutoCreateTimeImageName.Visible = False
        CK_UseMicroSoftWay.Checked = False
        CK_UseMicroSoftWay.Visible = False

        GetIniParameter()
    End Sub
    Private Sub GetDelImageIniParameter()
        del_IsneedDeleteImage = MyIni.Read(INISection, "del_IsneedDeleteImage", mytype.CC_Boolean)
        del_rule_time = MyIni.Read(INISection, "del_rule_time", mytype.CC_Boolean)
        del_rule_disk = MyIni.Read(INISection, "del_rule_disk", mytype.CC_Boolean)
        del_disk_setmin = MyIni.Read(INISection, "del_disk_setmin", mytype.CC_Double)
        del_time_holdtime = MyIni.Read(INISection, "del_time_holdtime", mytype.CC_Integer)
        del_time_holdtime_CBindex = MyIni.Read(INISection, "del_time_holdtime_CBindex", mytype.CC_Integer)
        del_disk_setmin_CBindex = MyIni.Read(INISection, "del_disk_setmin_CBindex", mytype.CC_Integer)

        CKBox_AutoDel_Enable.Checked = del_IsneedDeleteImage
        CkBox_AutoDel_Time.Checked = del_rule_time
        CB_del_remainingtime.SelectedIndex = del_time_holdtime_CBindex
        CB_disk_min.SelectedIndex = del_disk_setmin_CBindex
    End Sub
    Private Sub SaveDelImageIniParameter()
        del_IsneedDeleteImage = CKBox_AutoDel_Enable.Checked
        del_rule_time = CkBox_AutoDel_Time.Checked
        del_rule_disk = True
        del_disk_setmin = GetDiskMin()
        del_time_holdtime = GetRemainTiem()
        del_time_holdtime_CBindex = CB_del_remainingtime.SelectedIndex
        del_disk_setmin_CBindex = CB_disk_min.SelectedIndex

        MyIni.Write(INISection, "del_IsneedDeleteImage", del_IsneedDeleteImage)
        MyIni.Write(INISection, "del_rule_time", del_rule_time)
        MyIni.Write(INISection, "del_rule_disk", del_rule_disk)
        MyIni.Write(INISection, "del_disk_setmin", del_disk_setmin)
        MyIni.Write(INISection, "del_time_holdtime", del_time_holdtime)
        MyIni.Write(INISection, "del_time_holdtime_CBindex", del_time_holdtime_CBindex)
        MyIni.Write(INISection, "del_disk_setmin_CBindex", del_disk_setmin_CBindex)

    End Sub
    Private Function GetRemainTiem() As Long
        '0   6小时
        '1   12小时
        '2   1天
        '3   3天
        '4   5天
        '5   7天
        '6   15天
        '7   30天
        '8   60天
        '9   90天
        '10  180天
        '11  365天
        '12  2年
        '13  5年
        Select Case CB_del_remainingtime.SelectedIndex
            Case 0
                Return 60 * 60 * 6
            Case 1
                Return 60 * 60 * 12
            Case 2
                Return 60 * 60 * 24
            Case 3
                Return 60 * 60 * 24 * 3
            Case 4
                Return 60 * 60 * 24 * 5
            Case 5
                Return 60 * 60 * 24 * 7
            Case 6
                Return 60 * 60 * 24 * 15
            Case 7
                Return 60 * 60 * 24 * 30
            Case 8
                Return 60 * 60 * 24 * 60
            Case 9
                Return 60 * 60 * 24 * 90
            Case 10
                Return 60 * 60 * 24 * 180
            Case 11
                Return 60 * 60 * 24 * 365
            Case 12
                Return 60 * 60 * 24 * 365 * 2
            Case 13
                Return 60 * 60 * 24 * 365 * 5
            Case Else
                Return 60 * 60 * 24 * 365 * 5
        End Select
    End Function
    Private Function GetDiskMin() As Double
        '1GB
        '5GB
        '10GB
        '20GB
        '50GB
        '100GB
        Select Case CB_disk_min.SelectedIndex
            Case 0
                Return 1
            Case 1
                Return 5
            Case 2
                Return 10
            Case 3
                Return 20
            Case 4
                Return 50
            Case 5
                Return 100
            Case Else
                Return 100
        End Select
    End Function
    Private Sub SaveIniParameter()
        ImageOnly = CK_ImageOnly.Checked
        ImageWithGraphic = CK_ImageWithGraphic.Checked
        ImageFormatJPG = CK_JPG.Checked
        ImageFormatBMP = CK_BMP.Checked
        AutoCreatDateFolder = CK_AutoCreateDatePath.Checked
        AutoUseTimeForFileName = CK_AutoCreateTimeImageName.Checked
        ImageSavePathEdit = TxtBox_ImageSavePath.Text
        If RB_SaveAllImage.Checked Then
            WhichImageNeedSave = 0
        End If
        If RB_SaveCorrectImage.Checked Then
            WhichImageNeedSave = 1
        End If
        If RB_SaveErrorImage.Checked Then
            WhichImageNeedSave = 2
        End If

        MyIni.Write(INISection, "ImageFormatJPG", ImageFormatJPG)
        MyIni.Write(INISection, "ImageFormatBMP", ImageFormatBMP)
        MyIni.Write(INISection, "ImageOnly", ImageOnly)
        MyIni.Write(INISection, "ImageWithGraphic", ImageWithGraphic)
        MyIni.Write(INISection, "AutoCreatDateFolder", AutoCreatDateFolder)
        MyIni.Write(INISection, "AutoUseTimeForFileName", AutoUseTimeForFileName)
        MyIni.Write(INISection, "WhichImageNeedSave", WhichImageNeedSave)
        MyIni.Write(INISection, "ImageSavePathEdit ", ImageSavePathEdit)
    End Sub
    Private Sub GetIniParameter()
        ImageFormatJPG = MyIni.Read(INISection, "ImageFormatJPG", mytype.CC_Boolean)
        ImageFormatBMP = MyIni.Read(INISection, "ImageFormatBMP", mytype.CC_Boolean)
        ImageOnly = MyIni.Read(INISection, "ImageOnly", mytype.CC_Boolean)
        ImageWithGraphic = MyIni.Read(INISection, "ImageWithGraphic", mytype.CC_Boolean)
        AutoCreatDateFolder = MyIni.Read(INISection, "AutoCreatDateFolder", mytype.CC_Boolean)
        AutoUseTimeForFileName = MyIni.Read(INISection, "AutoUseTimeForFileName", mytype.CC_Boolean)
        WhichImageNeedSave = MyIni.Read(INISection, "WhichImageNeedSave", mytype.CC_Integer)
        ImageSavePathEdit = MyIni.Read(INISection, "ImageSavePathEdit ", mytype.CC_String)

        CK_ImageOnly.Checked = ImageOnly
        CK_ImageWithGraphic.Checked = ImageWithGraphic
        CK_JPG.Checked = ImageFormatJPG
        CK_BMP.Checked = ImageFormatBMP
        CK_AutoCreateDatePath.Checked = AutoCreatDateFolder
        CK_AutoCreateTimeImageName.Checked = AutoUseTimeForFileName
        TxtBox_ImageSavePath.Text = ImageSavePathEdit
        RB_SaveAllImage.Checked = False
        RB_SaveCorrectImage.Checked = False
        RB_SaveErrorImage.Checked = False
        Select Case WhichImageNeedSave
            Case 0
                RB_SaveAllImage.Checked = True
            Case 1
                RB_SaveCorrectImage.Checked = True
            Case 2
                RB_SaveErrorImage.Checked = True
        End Select
    End Sub

    Private Sub bt_PathView_Click(sender As Object, e As EventArgs) Handles bt_PathView.Click
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ImageSavePathEdit = FolderBrowserDialog1.SelectedPath
            TxtBox_ImageSavePath.Text = ImageSavePathEdit
        End If
    End Sub

    ''' <summary>
    ''' 修改界面参数在ini文件中保存的段落
    ''' </summary>
    ''' <value>保存的段落名，字符串格式</value>
    ''' <returns>返回保存的段落名，字符串格式</returns>
    ''' <remarks></remarks>
    Public Property ParameterInINISection() As String
        Get
            Return INISection
        End Get
        Set(ByVal value As String)
            INISection = value
        End Set
    End Property


End Class
