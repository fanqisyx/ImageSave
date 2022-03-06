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
        Me.CK_UseMicroSoftWay = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
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
        'CK_UseMicroSoftWay
        '
        Me.CK_UseMicroSoftWay.AutoSize = True
        Me.CK_UseMicroSoftWay.Location = New System.Drawing.Point(414, 46)
        Me.CK_UseMicroSoftWay.Name = "CK_UseMicroSoftWay"
        Me.CK_UseMicroSoftWay.Size = New System.Drawing.Size(120, 16)
        Me.CK_UseMicroSoftWay.TabIndex = 7
        Me.CK_UseMicroSoftWay.Text = "使用微软内部方法"
        Me.CK_UseMicroSoftWay.UseVisualStyleBackColor = True
        '
        'CC_ImageSaveUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CC_ImageSaveUI"
        Me.Size = New System.Drawing.Size(585, 182)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents CK_UseMicroSoftWay As System.Windows.Forms.CheckBox

End Class
