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

    '用于自动删除图片的变量定义
    Public del_IsneedDeleteImage As Boolean
    Public del_rule_time As Boolean
    Public del_rule_disk As Boolean = True
    Public del_disk_all As Double
    Public del_disk_remaining As Double
    Public del_disk_setmin As Double
    'Public del_time_oldest As DateTime = DateTime.Now
    Public del_time_holdtime As Long
    Public image_allimagenum As Long
    Public image_ramainingImagenum As Long
    Public image_today_save As Long
    Public image_today_del As Long
    Public del_time_holdtime_CBindex As Integer
    Public del_disk_setmin_CBindex As Integer
    Public isStarting As Boolean = True

    Delegate Sub ShowTextBoxDelegate(textbox As System.Windows.Forms.TextBox, str As String)
    Delegate Sub ShowLabelDelegate(label As System.Windows.Forms.Label, str As String)

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
        GetDelImageIniParameter()
        isStarting = False
    End Sub
    Private Sub GetDelImageIniParameter()
        del_IsneedDeleteImage = MyIni.Read(INISection, "del_IsneedDeleteImage", mytype.CC_Boolean)

        del_rule_time = MyIni.Read(INISection, "Del_rule_time", mytype.CC_Boolean)
        del_rule_disk = MyIni.Read(INISection, "Del_rule_disk", mytype.CC_Boolean)
        del_disk_setmin = MyIni.Read(INISection, "Del_disk_setmin", mytype.CC_Double)
        del_time_holdtime = MyIni.Read(INISection, "Del_time_holdtime", mytype.CC_Integer)
        del_time_holdtime_CBindex = MyIni.Read(INISection, "Del_time_holdtime_CBindex", mytype.CC_Integer)
        del_disk_setmin_CBindex = MyIni.Read(INISection, "Del_disk_setmin_CBindex", mytype.CC_Integer)

        CKBox_AutoDel_Enable.Checked = del_IsneedDeleteImage
        CkBox_AutoDel_Time.Checked = del_rule_time



        CB_del_remainingtime.SelectedIndex = del_time_holdtime_CBindex
        CB_disk_min.SelectedIndex = del_disk_setmin_CBindex


    End Sub
    Private Sub SetDelImageControlEnable(isneeddelimage As Boolean, timerule As Boolean)
        If isneeddelimage = False Then
            GroupBox_AutoDel_SetDisk.Enabled = False
            GroupBox_AutoDel_SetRule.Enabled = False
            GroupBox_AutoDel_SetTime.Enabled = False
        Else
            GroupBox_AutoDel_SetDisk.Enabled = True
            GroupBox_AutoDel_SetRule.Enabled = True
            If timerule = True Then
                GroupBox_AutoDel_SetTime.Enabled = timerule
            Else
                GroupBox_AutoDel_SetTime.Enabled = False
            End If
        End If
    End Sub
    Private Sub SaveDelImageIniParameter()
        del_rule_disk = True
        GetDelImageControlValue()

        MyIni.Write(INISection, "del_IsneedDeleteImage", del_IsneedDeleteImage)
        MyIni.Write(INISection, "Del_rule_time", del_rule_time)
        MyIni.Write(INISection, "Del_rule_disk", del_rule_disk)
        MyIni.Write(INISection, "Del_disk_setmin", del_disk_setmin)
        MyIni.Write(INISection, "Del_time_holdtime", del_time_holdtime)
        MyIni.Write(INISection, "Del_time_holdtime_CBindex", del_time_holdtime_CBindex)
        MyIni.Write(INISection, "Del_disk_setmin_CBindex", del_disk_setmin_CBindex)

    End Sub
    Private Function GetRemainTime() As Long
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

    Private Sub CKBox_AutoDel_Enable_CheckedChanged(sender As Object, e As EventArgs) Handles CKBox_AutoDel_Enable.CheckedChanged
        GetDelImageControlValue()
    End Sub

    Private Sub CkBox_AutoDel_Time_CheckedChanged(sender As Object, e As EventArgs) Handles CkBox_AutoDel_Time.CheckedChanged
        GetDelImageControlValue()
    End Sub
    Private Sub GetDelImageControlValue()
        If isStarting = True Then Return
        del_IsneedDeleteImage = CKBox_AutoDel_Enable.Checked
        del_rule_time = CkBox_AutoDel_Time.Checked
        del_disk_setmin = GetDiskMin() * 1024 * 1024 * 1024
        del_time_holdtime = GetRemainTime()
        del_time_holdtime_CBindex = CB_del_remainingtime.SelectedIndex
        del_disk_setmin_CBindex = CB_disk_min.SelectedIndex
        SetDelImageControlEnable(del_IsneedDeleteImage, del_rule_time)
    End Sub

    Private Sub CB_disk_min_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_disk_min.SelectedIndexChanged
        'GetDelImageControlValue()
    End Sub

    Private Sub CB_del_remainingtime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_del_remainingtime.SelectedIndexChanged
        'GetDelImageControlValue()
    End Sub


    Private Show_AllImage As Long
    Public Property Allimage() As Long
        Get
            Return Show_AllImage
        End Get
        Set(ByVal value As Long)
            Show_AllImage = value
            DG_ShowText(txtbox_allImage, Show_AllImage)
        End Set
    End Property

    Private Show_RemainingImage As Long
    Public Property RemainingImage() As Long
        Get
            Return Show_RemainingImage
        End Get
        Set(ByVal value As Long)
            Show_RemainingImage = value
            DG_ShowText(txtbox_allremainingimage, Show_RemainingImage)
        End Set
    End Property


    Private Show_TodaySaveImage As Long
    Public Property TodaySaveImage() As Long
        Get
            Return Show_TodaySaveImage
        End Get
        Set(ByVal value As Long)
            Show_TodaySaveImage = value
            DG_ShowText(txtbox_todaySaveImage, Show_TodaySaveImage)
        End Set
    End Property

    Private Show_TodayDelImage As Long
    Public Property TodayDelImage() As String
        Get
            Return Show_TodayDelImage
        End Get
        Set(ByVal value As String)
            Show_TodayDelImage = value
            DG_ShowText(txtbox_todayDelImage, Show_TodayDelImage)
        End Set
    End Property

    Private Show_Disk_all As Long
    Public Property Disk_All() As Long
        Get
            Return Show_Disk_all
        End Get
        Set(ByVal value As Long)
            Show_Disk_all = value
            DG_ShowText(txtbox_Disk_All, String.Format("{0}GB", (Show_Disk_all / 1024 / 1024 / 1024).ToString("0.00")))
        End Set
    End Property

    Private Show_Disk_Remaining As Long
    Public Property Disk_remaining() As Long
        Get
            Return Show_Disk_Remaining
        End Get
        Set(ByVal value As Long)
            Show_Disk_Remaining = value
            DG_ShowText(txtbox_disk_remaining, String.Format("{0}GB", (Show_Disk_Remaining / 1024 / 1024 / 1024).ToString("0.00")))
        End Set
    End Property

    Private ShowImageCache As Integer = 0
    Public Property ImageCache() As Integer
        Get
            Return ShowImageCache
        End Get
        Set(ByVal value As Integer)
            ShowImageCache = value
            DG_ShowLabel(Label8, String.Format("缓存 {0}/50", value.ToString()))
        End Set
    End Property
    Private ShowOldestImageTime As DateTime
    Public Property del_time_oldest() As DateTime
        Get
            Return ShowOldestImageTime
        End Get
        Set(ByVal value As DateTime)
            ShowOldestImageTime = value
            DG_ShowText(txtbox_del_oldestImageTime, ShowOldestImageTime.ToString("yyyy-MM-dd HH:mm:ss.fff"))
        End Set
    End Property

    Private ShowTableLineNum As Integer
    Public Property TableLineNum() As Integer
        Get
            Return ShowTableLineNum
        End Get
        Set(ByVal value As Integer)
            ShowTableLineNum = value
            DG_ShowText(txtbox_TableLineNum, value.ToString())
        End Set
    End Property

    Private Sub DG_ShowText(textbox As System.Windows.Forms.TextBox, str As String) '//托管程序
        If (textbox.InvokeRequired) Then
            Dim d As New ShowTextBoxDelegate(AddressOf DG_ShowText) '//可选择为txt sub同样效果
            textbox.Invoke(d, textbox, str)
        Else
            textbox.Text = str
        End If
    End Sub

    Private Sub DG_ShowLabel(Label As System.Windows.Forms.Label, str As String) '//托管程序
        If (Label.InvokeRequired) Then
            Dim d As New ShowLabelDelegate(AddressOf DG_ShowLabel) '//可选择为txt sub同样效果
            Label.Invoke(d, Label, str)
        Else
            Label.Text = str
        End If
    End Sub

End Class
