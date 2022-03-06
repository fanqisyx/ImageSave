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

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveIniParameter()
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
