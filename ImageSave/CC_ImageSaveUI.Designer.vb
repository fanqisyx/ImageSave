<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CC_ImageSaveUI
    Inherits System.Windows.Forms.UserControl

    'UserControl 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxtBox_ImageSavePath = New System.Windows.Forms.TextBox()
        Me.bt_PathView = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CK_UseMicroSoftWay = New System.Windows.Forms.CheckBox()
        Me.CK_AutoCreateTimeImageName = New System.Windows.Forms.CheckBox()
        Me.CK_AutoCreateDatePath = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CK_BMP = New System.Windows.Forms.CheckBox()
        Me.CK_JPG = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CK_ImageWithGraphic = New System.Windows.Forms.CheckBox()
        Me.CK_ImageOnly = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.RB_SaveCorrectImage = New System.Windows.Forms.RadioButton()
        Me.RB_SaveErrorImage = New System.Windows.Forms.RadioButton()
        Me.RB_SaveAllImage = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.CKBox_AutoDel_Enable = New System.Windows.Forms.CheckBox()
        Me.GroupBox_AutoDel_SetRule = New System.Windows.Forms.GroupBox()
        Me.CkBox_AutoDel_Disk = New System.Windows.Forms.CheckBox()
        Me.CkBox_AutoDel_Time = New System.Windows.Forms.CheckBox()
        Me.GroupBox_AutoDel_SetDisk = New System.Windows.Forms.GroupBox()
        Me.GroupBox_AutoDel_SetTime = New System.Windows.Forms.GroupBox()
        Me.ProgressBar_QueueSize = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CB_disk_min = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CB_del_remainingtime = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox_AutoDel_SetRule.SuspendLayout()
        Me.GroupBox_AutoDel_SetDisk.SuspendLayout()
        Me.GroupBox_AutoDel_SetTime.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtBox_ImageSavePath
        '
        Me.TxtBox_ImageSavePath.Location = New System.Drawing.Point(6, 20)
        Me.TxtBox_ImageSavePath.Name = "TxtBox_ImageSavePath"
        Me.TxtBox_ImageSavePath.Size = New System.Drawing.Size(500, 21)
        Me.TxtBox_ImageSavePath.TabIndex = 1
        Me.TxtBox_ImageSavePath.Text = "E:\ImageSave\"
        '
        'bt_PathView
        '
        Me.bt_PathView.Location = New System.Drawing.Point(512, 20)
        Me.bt_PathView.Name = "bt_PathView"
        Me.bt_PathView.Size = New System.Drawing.Size(58, 23)
        Me.bt_PathView.TabIndex = 2
        Me.bt_PathView.Text = "浏览..."
        Me.bt_PathView.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CK_UseMicroSoftWay)
        Me.GroupBox1.Controls.Add(Me.CK_AutoCreateTimeImageName)
        Me.GroupBox1.Controls.Add(Me.CK_AutoCreateDatePath)
        Me.GroupBox1.Controls.Add(Me.TxtBox_ImageSavePath)
        Me.GroupBox1.Controls.Add(Me.bt_PathView)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(579, 68)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "图像保存路径"
        '
        'CK_UseMicroSoftWay
        '
        Me.CK_UseMicroSoftWay.AutoSize = True
        Me.CK_UseMicroSoftWay.Enabled = False
        Me.CK_UseMicroSoftWay.Location = New System.Drawing.Point(414, 46)
        Me.CK_UseMicroSoftWay.Name = "CK_UseMicroSoftWay"
        Me.CK_UseMicroSoftWay.Size = New System.Drawing.Size(120, 16)
        Me.CK_UseMicroSoftWay.TabIndex = 7
        Me.CK_UseMicroSoftWay.Text = "使用微软内部方法"
        Me.CK_UseMicroSoftWay.UseVisualStyleBackColor = True
        '
        'CK_AutoCreateTimeImageName
        '
        Me.CK_AutoCreateTimeImageName.AutoSize = True
        Me.CK_AutoCreateTimeImageName.Checked = True
        Me.CK_AutoCreateTimeImageName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CK_AutoCreateTimeImageName.Location = New System.Drawing.Point(186, 47)
        Me.CK_AutoCreateTimeImageName.Name = "CK_AutoCreateTimeImageName"
        Me.CK_AutoCreateTimeImageName.Size = New System.Drawing.Size(204, 16)
        Me.CK_AutoCreateTimeImageName.TabIndex = 6
        Me.CK_AutoCreateTimeImageName.Text = "图片文件的文件名中自动添加时间"
        Me.CK_AutoCreateTimeImageName.UseVisualStyleBackColor = True
        '
        'CK_AutoCreateDatePath
        '
        Me.CK_AutoCreateDatePath.AutoSize = True
        Me.CK_AutoCreateDatePath.Checked = True
        Me.CK_AutoCreateDatePath.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CK_AutoCreateDatePath.Location = New System.Drawing.Point(6, 47)
        Me.CK_AutoCreateDatePath.Name = "CK_AutoCreateDatePath"
        Me.CK_AutoCreateDatePath.Size = New System.Drawing.Size(156, 16)
        Me.CK_AutoCreateDatePath.TabIndex = 5
        Me.CK_AutoCreateDatePath.Text = "目录自动生成日期文件夹"
        Me.CK_AutoCreateDatePath.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CK_BMP)
        Me.GroupBox2.Controls.Add(Me.CK_JPG)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(105, 48)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "图像保存格式"
        '
        'CK_BMP
        '
        Me.CK_BMP.AutoSize = True
        Me.CK_BMP.Checked = True
        Me.CK_BMP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CK_BMP.Location = New System.Drawing.Point(55, 21)
        Me.CK_BMP.Name = "CK_BMP"
        Me.CK_BMP.Size = New System.Drawing.Size(42, 16)
        Me.CK_BMP.TabIndex = 1
        Me.CK_BMP.Text = "BMP"
        Me.CK_BMP.UseVisualStyleBackColor = True
        '
        'CK_JPG
        '
        Me.CK_JPG.AutoSize = True
        Me.CK_JPG.Location = New System.Drawing.Point(7, 21)
        Me.CK_JPG.Name = "CK_JPG"
        Me.CK_JPG.Size = New System.Drawing.Size(42, 16)
        Me.CK_JPG.TabIndex = 0
        Me.CK_JPG.Text = "JPG"
        Me.CK_JPG.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CK_ImageWithGraphic)
        Me.GroupBox3.Controls.Add(Me.CK_ImageOnly)
        Me.GroupBox3.Location = New System.Drawing.Point(129, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(146, 48)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "图像保存内容"
        '
        'CK_ImageWithGraphic
        '
        Me.CK_ImageWithGraphic.AutoSize = True
        Me.CK_ImageWithGraphic.Location = New System.Drawing.Point(61, 20)
        Me.CK_ImageWithGraphic.Name = "CK_ImageWithGraphic"
        Me.CK_ImageWithGraphic.Size = New System.Drawing.Size(84, 16)
        Me.CK_ImageWithGraphic.TabIndex = 1
        Me.CK_ImageWithGraphic.Text = "图片及图形"
        Me.CK_ImageWithGraphic.UseVisualStyleBackColor = True
        '
        'CK_ImageOnly
        '
        Me.CK_ImageOnly.AutoSize = True
        Me.CK_ImageOnly.Checked = True
        Me.CK_ImageOnly.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CK_ImageOnly.Location = New System.Drawing.Point(7, 20)
        Me.CK_ImageOnly.Name = "CK_ImageOnly"
        Me.CK_ImageOnly.Size = New System.Drawing.Size(48, 16)
        Me.CK_ImageOnly.TabIndex = 0
        Me.CK_ImageOnly.Text = "图片"
        Me.CK_ImageOnly.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.RB_SaveCorrectImage)
        Me.GroupBox4.Controls.Add(Me.RB_SaveErrorImage)
        Me.GroupBox4.Controls.Add(Me.RB_SaveAllImage)
        Me.GroupBox4.Location = New System.Drawing.Point(293, 92)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(289, 48)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "需要保存的图片"
        '
        'RB_SaveCorrectImage
        '
        Me.RB_SaveCorrectImage.AutoSize = True
        Me.RB_SaveCorrectImage.Location = New System.Drawing.Point(196, 20)
        Me.RB_SaveCorrectImage.Name = "RB_SaveCorrectImage"
        Me.RB_SaveCorrectImage.Size = New System.Drawing.Size(71, 16)
        Me.RB_SaveCorrectImage.TabIndex = 11
        Me.RB_SaveCorrectImage.Text = "正确图片"
        Me.RB_SaveCorrectImage.UseVisualStyleBackColor = True
        '
        'RB_SaveErrorImage
        '
        Me.RB_SaveErrorImage.AutoSize = True
        Me.RB_SaveErrorImage.Location = New System.Drawing.Point(102, 20)
        Me.RB_SaveErrorImage.Name = "RB_SaveErrorImage"
        Me.RB_SaveErrorImage.Size = New System.Drawing.Size(71, 16)
        Me.RB_SaveErrorImage.TabIndex = 10
        Me.RB_SaveErrorImage.Text = "错误图片"
        Me.RB_SaveErrorImage.UseVisualStyleBackColor = True
        '
        'RB_SaveAllImage
        '
        Me.RB_SaveAllImage.AutoSize = True
        Me.RB_SaveAllImage.Checked = True
        Me.RB_SaveAllImage.Location = New System.Drawing.Point(6, 20)
        Me.RB_SaveAllImage.Name = "RB_SaveAllImage"
        Me.RB_SaveAllImage.Size = New System.Drawing.Size(71, 16)
        Me.RB_SaveAllImage.TabIndex = 9
        Me.RB_SaveAllImage.TabStop = True
        Me.RB_SaveAllImage.Text = "所有图片"
        Me.RB_SaveAllImage.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(417, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "确定"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(498, 149)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "取消"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox6)
        Me.GroupBox5.Controls.Add(Me.GroupBox_AutoDel_SetTime)
        Me.GroupBox5.Controls.Add(Me.GroupBox_AutoDel_SetDisk)
        Me.GroupBox5.Controls.Add(Me.GroupBox_AutoDel_SetRule)
        Me.GroupBox5.Controls.Add(Me.CKBox_AutoDel_Enable)
        Me.GroupBox5.Location = New System.Drawing.Point(3, 178)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(579, 177)
        Me.GroupBox5.TabIndex = 9
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "图像自动删除规则"
        '
        'CKBox_AutoDel_Enable
        '
        Me.CKBox_AutoDel_Enable.AutoSize = True
        Me.CKBox_AutoDel_Enable.Location = New System.Drawing.Point(7, 21)
        Me.CKBox_AutoDel_Enable.Name = "CKBox_AutoDel_Enable"
        Me.CKBox_AutoDel_Enable.Size = New System.Drawing.Size(144, 16)
        Me.CKBox_AutoDel_Enable.TabIndex = 0
        Me.CKBox_AutoDel_Enable.Text = "启用自动删除图片功能"
        Me.CKBox_AutoDel_Enable.UseVisualStyleBackColor = True
        '
        'GroupBox_AutoDel_SetRule
        '
        Me.GroupBox_AutoDel_SetRule.Controls.Add(Me.CkBox_AutoDel_Time)
        Me.GroupBox_AutoDel_SetRule.Controls.Add(Me.CkBox_AutoDel_Disk)
        Me.GroupBox_AutoDel_SetRule.Location = New System.Drawing.Point(7, 44)
        Me.GroupBox_AutoDel_SetRule.Name = "GroupBox_AutoDel_SetRule"
        Me.GroupBox_AutoDel_SetRule.Size = New System.Drawing.Size(165, 65)
        Me.GroupBox_AutoDel_SetRule.TabIndex = 1
        Me.GroupBox_AutoDel_SetRule.TabStop = False
        Me.GroupBox_AutoDel_SetRule.Text = "删除规则"
        '
        'CkBox_AutoDel_Disk
        '
        Me.CkBox_AutoDel_Disk.AutoSize = True
        Me.CkBox_AutoDel_Disk.Checked = True
        Me.CkBox_AutoDel_Disk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CkBox_AutoDel_Disk.Enabled = False
        Me.CkBox_AutoDel_Disk.Location = New System.Drawing.Point(11, 20)
        Me.CkBox_AutoDel_Disk.Name = "CkBox_AutoDel_Disk"
        Me.CkBox_AutoDel_Disk.Size = New System.Drawing.Size(144, 16)
        Me.CkBox_AutoDel_Disk.TabIndex = 2
        Me.CkBox_AutoDel_Disk.Text = "根据磁盘容量删除图片"
        Me.CkBox_AutoDel_Disk.UseVisualStyleBackColor = True
        '
        'CkBox_AutoDel_Time
        '
        Me.CkBox_AutoDel_Time.AutoSize = True
        Me.CkBox_AutoDel_Time.Location = New System.Drawing.Point(11, 42)
        Me.CkBox_AutoDel_Time.Name = "CkBox_AutoDel_Time"
        Me.CkBox_AutoDel_Time.Size = New System.Drawing.Size(144, 16)
        Me.CkBox_AutoDel_Time.TabIndex = 3
        Me.CkBox_AutoDel_Time.Text = "根据时间设定删除图片"
        Me.CkBox_AutoDel_Time.UseVisualStyleBackColor = True
        '
        'GroupBox_AutoDel_SetDisk
        '
        Me.GroupBox_AutoDel_SetDisk.Controls.Add(Me.Label5)
        Me.GroupBox_AutoDel_SetDisk.Controls.Add(Me.Label4)
        Me.GroupBox_AutoDel_SetDisk.Controls.Add(Me.CB_disk_min)
        Me.GroupBox_AutoDel_SetDisk.Controls.Add(Me.Label3)
        Me.GroupBox_AutoDel_SetDisk.Controls.Add(Me.Label2)
        Me.GroupBox_AutoDel_SetDisk.Controls.Add(Me.Label1)
        Me.GroupBox_AutoDel_SetDisk.Location = New System.Drawing.Point(190, 21)
        Me.GroupBox_AutoDel_SetDisk.Name = "GroupBox_AutoDel_SetDisk"
        Me.GroupBox_AutoDel_SetDisk.Size = New System.Drawing.Size(181, 88)
        Me.GroupBox_AutoDel_SetDisk.TabIndex = 2
        Me.GroupBox_AutoDel_SetDisk.TabStop = False
        Me.GroupBox_AutoDel_SetDisk.Text = "磁盘容量设定"
        '
        'GroupBox_AutoDel_SetTime
        '
        Me.GroupBox_AutoDel_SetTime.Controls.Add(Me.CB_del_remainingtime)
        Me.GroupBox_AutoDel_SetTime.Controls.Add(Me.Label7)
        Me.GroupBox_AutoDel_SetTime.Controls.Add(Me.TextBox1)
        Me.GroupBox_AutoDel_SetTime.Controls.Add(Me.Label6)
        Me.GroupBox_AutoDel_SetTime.Location = New System.Drawing.Point(389, 20)
        Me.GroupBox_AutoDel_SetTime.Name = "GroupBox_AutoDel_SetTime"
        Me.GroupBox_AutoDel_SetTime.Size = New System.Drawing.Size(181, 88)
        Me.GroupBox_AutoDel_SetTime.TabIndex = 3
        Me.GroupBox_AutoDel_SetTime.TabStop = False
        Me.GroupBox_AutoDel_SetTime.Text = "时间设定"
        '
        'ProgressBar_QueueSize
        '
        Me.ProgressBar_QueueSize.BackColor = System.Drawing.Color.Lime
        Me.ProgressBar_QueueSize.ForeColor = System.Drawing.Color.Red
        Me.ProgressBar_QueueSize.Location = New System.Drawing.Point(76, 155)
        Me.ProgressBar_QueueSize.Maximum = 15
        Me.ProgressBar_QueueSize.Name = "ProgressBar_QueueSize"
        Me.ProgressBar_QueueSize.Size = New System.Drawing.Size(317, 10)
        Me.ProgressBar_QueueSize.Step = 1
        Me.ProgressBar_QueueSize.TabIndex = 10
        Me.ProgressBar_QueueSize.Value = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "磁盘总容量"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "磁盘剩余容量"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 12)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "磁盘容量下限"
        '
        'CB_disk_min
        '
        Me.CB_disk_min.FormattingEnabled = True
        Me.CB_disk_min.Items.AddRange(New Object() {"1GB", "5GB", "10GB", "20GB", "50GB", "100GB"})
        Me.CB_disk_min.Location = New System.Drawing.Point(90, 60)
        Me.CB_disk_min.Name = "CB_disk_min"
        Me.CB_disk_min.Size = New System.Drawing.Size(74, 20)
        Me.CB_disk_min.TabIndex = 3
        Me.CB_disk_min.Text = "10GB"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(90, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 12)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "100GB"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(90, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "50GB"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 12)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "档案中最早的图片的保存时间"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(9, 39)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(159, 21)
        Me.TextBox1.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 12)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "图像保存天数"
        '
        'CB_del_remainingtime
        '
        Me.CB_del_remainingtime.FormattingEnabled = True
        Me.CB_del_remainingtime.Items.AddRange(New Object() {"6小时", "12小时", "1天", "3天", "5天", "7天", "15天", "30天", "60天", "90天", "180天", "365天", "2年", "5年"})
        Me.CB_del_remainingtime.Location = New System.Drawing.Point(94, 60)
        Me.CB_del_remainingtime.Name = "CB_del_remainingtime"
        Me.CB_del_remainingtime.Size = New System.Drawing.Size(74, 20)
        Me.CB_del_remainingtime.TabIndex = 6
        Me.CB_del_remainingtime.Text = "30天"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 153)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 12)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "缓存 10/15"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox6.Location = New System.Drawing.Point(7, 115)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(547, 60)
        Me.GroupBox6.TabIndex = 4
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "图片数据统计"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox6, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox5, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label12, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label11, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label10, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(541, 40)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 12)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "历史存图总数"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(111, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 12)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "记录中现存图数"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(219, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 12)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "今日存图数量"
        '
        'TextBox2
        '
        Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(3, 15)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(102, 21)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "0"
        '
        'TextBox3
        '
        Me.TextBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(111, 15)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(102, 21)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(327, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 12)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "今日删图数量"
        '
        'TextBox5
        '
        Me.TextBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox5.Enabled = False
        Me.TextBox5.Location = New System.Drawing.Point(219, 15)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(102, 21)
        Me.TextBox5.TabIndex = 7
        Me.TextBox5.Text = "0"
        '
        'TextBox6
        '
        Me.TextBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox6.Enabled = False
        Me.TextBox6.Location = New System.Drawing.Point(327, 15)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(102, 21)
        Me.TextBox6.TabIndex = 8
        Me.TextBox6.Text = "0"
        '
        'CC_ImageSaveUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ProgressBar_QueueSize)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CC_ImageSaveUI"
        Me.Size = New System.Drawing.Size(585, 369)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox_AutoDel_SetRule.ResumeLayout(False)
        Me.GroupBox_AutoDel_SetRule.PerformLayout()
        Me.GroupBox_AutoDel_SetDisk.ResumeLayout(False)
        Me.GroupBox_AutoDel_SetDisk.PerformLayout()
        Me.GroupBox_AutoDel_SetTime.ResumeLayout(False)
        Me.GroupBox_AutoDel_SetTime.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtBox_ImageSavePath As System.Windows.Forms.TextBox
    Friend WithEvents bt_PathView As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CK_BMP As System.Windows.Forms.CheckBox
    Friend WithEvents CK_JPG As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CK_ImageWithGraphic As System.Windows.Forms.CheckBox
    Friend WithEvents CK_ImageOnly As System.Windows.Forms.CheckBox
    Friend WithEvents CK_AutoCreateTimeImageName As System.Windows.Forms.CheckBox
    Friend WithEvents CK_AutoCreateDatePath As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents RB_SaveCorrectImage As System.Windows.Forms.RadioButton
    Friend WithEvents RB_SaveErrorImage As System.Windows.Forms.RadioButton
    Friend WithEvents RB_SaveAllImage As System.Windows.Forms.RadioButton
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents CK_UseMicroSoftWay As System.Windows.Forms.CheckBox
    Public WithEvents Button1 As Windows.Forms.Button
    Public WithEvents Button2 As Windows.Forms.Button
    Friend WithEvents GroupBox5 As Windows.Forms.GroupBox
    Friend WithEvents GroupBox_AutoDel_SetTime As Windows.Forms.GroupBox
    Friend WithEvents CB_del_remainingtime As Windows.Forms.ComboBox
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents TextBox1 As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents GroupBox_AutoDel_SetDisk As Windows.Forms.GroupBox
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents CB_disk_min As Windows.Forms.ComboBox
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents GroupBox_AutoDel_SetRule As Windows.Forms.GroupBox
    Friend WithEvents CkBox_AutoDel_Time As Windows.Forms.CheckBox
    Friend WithEvents CkBox_AutoDel_Disk As Windows.Forms.CheckBox
    Friend WithEvents CKBox_AutoDel_Enable As Windows.Forms.CheckBox
    Friend WithEvents ProgressBar_QueueSize As Windows.Forms.ProgressBar
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents GroupBox6 As Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As Windows.Forms.TableLayoutPanel
    Friend WithEvents TextBox6 As Windows.Forms.TextBox
    Friend WithEvents TextBox5 As Windows.Forms.TextBox
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents TextBox2 As Windows.Forms.TextBox
    Friend WithEvents TextBox3 As Windows.Forms.TextBox
End Class
