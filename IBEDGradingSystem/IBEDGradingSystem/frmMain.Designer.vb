<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTIme = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblUser = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSection = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblRole = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSY = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblGrade = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.btnSection = New System.Windows.Forms.ToolStripButton()
        Me.btnTeacher = New System.Windows.Forms.ToolStripButton()
        Me.btnStudent = New System.Windows.Forms.ToolStripButton()
        Me.btnAbsentLate = New System.Windows.Forms.ToolStripButton()
        Me.btnSetting = New System.Windows.Forms.ToolStripButton()
        Me.btnGrades = New System.Windows.Forms.ToolStripButton()
        Me.btnSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.btnUser = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.btnSYSetting = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Teal
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1122, 42)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Teal
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lblDate, Me.ToolStripStatusLabel3, Me.lblTIme, Me.ToolStripStatusLabel2, Me.lblUser, Me.lblSection, Me.lblRole, Me.lblSY, Me.lblGrade})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 727)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1122, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(43, 17)
        Me.ToolStripStatusLabel1.Text = "Date :"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = False
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(140, 17)
        Me.lblDate.Text = " "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(44, 17)
        Me.ToolStripStatusLabel3.Text = "Time :"
        '
        'lblTIme
        '
        Me.lblTIme.AutoSize = False
        Me.lblTIme.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTIme.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTIme.Name = "lblTIme"
        Me.lblTIme.Size = New System.Drawing.Size(121, 17)
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.Gainsboro
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(36, 17)
        Me.ToolStripStatusLabel2.Text = "User :"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = False
        Me.lblUser.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(121, 17)
        '
        'lblSection
        '
        Me.lblSection.AutoSize = False
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(121, 17)
        Me.lblSection.Visible = False
        '
        'lblRole
        '
        Me.lblRole.AutoSize = False
        Me.lblRole.Name = "lblRole"
        Me.lblRole.Size = New System.Drawing.Size(121, 17)
        Me.lblRole.Visible = False
        '
        'lblSY
        '
        Me.lblSY.AutoSize = False
        Me.lblSY.Name = "lblSY"
        Me.lblSY.Size = New System.Drawing.Size(121, 17)
        Me.lblSY.Visible = False
        '
        'lblGrade
        '
        Me.lblGrade.AutoSize = False
        Me.lblGrade.Name = "lblGrade"
        Me.lblGrade.Size = New System.Drawing.Size(121, 17)
        Me.lblGrade.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Teal
        Me.Label2.Font = New System.Drawing.Font("Broadway", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(409, 2)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(733, 40)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ABC Educational Development Center"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.btnSection, Me.btnTeacher, Me.btnStudent, Me.btnAbsentLate, Me.btnSetting, Me.btnGrades, Me.btnSeparator, Me.btnSYSetting, Me.btnUser, Me.ToolStripSeparator2, Me.ToolStripButton3})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 42)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(111, 685)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(70, 10)
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnSection
        '
        Me.btnSection.AutoSize = False
        Me.btnSection.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSection.ForeColor = System.Drawing.Color.White
        Me.btnSection.Image = CType(resources.GetObject("btnSection.Image"), System.Drawing.Image)
        Me.btnSection.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSection.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSection.Name = "btnSection"
        Me.btnSection.Size = New System.Drawing.Size(70, 65)
        Me.btnSection.Text = "Sections"
        Me.btnSection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnTeacher
        '
        Me.btnTeacher.AutoSize = False
        Me.btnTeacher.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTeacher.ForeColor = System.Drawing.Color.White
        Me.btnTeacher.Image = CType(resources.GetObject("btnTeacher.Image"), System.Drawing.Image)
        Me.btnTeacher.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnTeacher.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTeacher.Name = "btnTeacher"
        Me.btnTeacher.Size = New System.Drawing.Size(70, 65)
        Me.btnTeacher.Text = "Teacher"
        Me.btnTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnStudent
        '
        Me.btnStudent.AutoSize = False
        Me.btnStudent.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStudent.ForeColor = System.Drawing.Color.White
        Me.btnStudent.Image = CType(resources.GetObject("btnStudent.Image"), System.Drawing.Image)
        Me.btnStudent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnStudent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStudent.Name = "btnStudent"
        Me.btnStudent.Size = New System.Drawing.Size(70, 65)
        Me.btnStudent.Text = "Students"
        Me.btnStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnStudent.ToolTipText = "Home Logo"
        '
        'btnAbsentLate
        '
        Me.btnAbsentLate.AutoSize = False
        Me.btnAbsentLate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbsentLate.ForeColor = System.Drawing.Color.White
        Me.btnAbsentLate.Image = CType(resources.GetObject("btnAbsentLate.Image"), System.Drawing.Image)
        Me.btnAbsentLate.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAbsentLate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbsentLate.Name = "btnAbsentLate"
        Me.btnAbsentLate.Size = New System.Drawing.Size(70, 65)
        Me.btnAbsentLate.Text = "DoS/DP"
        Me.btnAbsentLate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnSetting
        '
        Me.btnSetting.AutoSize = False
        Me.btnSetting.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSetting.ForeColor = System.Drawing.Color.White
        Me.btnSetting.Image = CType(resources.GetObject("btnSetting.Image"), System.Drawing.Image)
        Me.btnSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSetting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSetting.Name = "btnSetting"
        Me.btnSetting.Size = New System.Drawing.Size(70, 65)
        Me.btnSetting.Text = "Sub Grade"
        Me.btnSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnGrades
        '
        Me.btnGrades.AutoSize = False
        Me.btnGrades.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrades.ForeColor = System.Drawing.Color.White
        Me.btnGrades.Image = CType(resources.GetObject("btnGrades.Image"), System.Drawing.Image)
        Me.btnGrades.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnGrades.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGrades.Name = "btnGrades"
        Me.btnGrades.Size = New System.Drawing.Size(70, 65)
        Me.btnGrades.Text = "Grades"
        Me.btnGrades.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnSeparator
        '
        Me.btnSeparator.Name = "btnSeparator"
        Me.btnSeparator.Size = New System.Drawing.Size(109, 6)
        '
        'btnUser
        '
        Me.btnUser.AutoSize = False
        Me.btnUser.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.White
        Me.btnUser.Image = CType(resources.GetObject("btnUser.Image"), System.Drawing.Image)
        Me.btnUser.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnUser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(70, 65)
        Me.btnUser.Text = "Users"
        Me.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(109, 6)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.AutoSize = False
        Me.ToolStripButton3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(70, 65)
        Me.ToolStripButton3.Text = "Exit"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ToolStripButton3.ToolTipText = "System Flow"
        '
        'btnSYSetting
        '
        Me.btnSYSetting.AutoSize = False
        Me.btnSYSetting.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSYSetting.ForeColor = System.Drawing.Color.White
        Me.btnSYSetting.Image = CType(resources.GetObject("btnSYSetting.Image"), System.Drawing.Image)
        Me.btnSYSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSYSetting.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSYSetting.Name = "btnSYSetting"
        Me.btnSYSetting.Size = New System.Drawing.Size(70, 65)
        Me.btnSYSetting.Text = "SY Setting"
        Me.btnSYSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1122, 749)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ABC - EDC Permanent Record and Grade Slip System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTIme As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSection As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnStudent As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGrades As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAbsentLate As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnSetting As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblUser As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblSection As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblRole As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnTeacher As System.Windows.Forms.ToolStripButton
    Friend WithEvents lblSY As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblGrade As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnSYSetting As System.Windows.Forms.ToolStripButton
End Class
