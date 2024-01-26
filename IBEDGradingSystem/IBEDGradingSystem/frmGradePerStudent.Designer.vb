<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradePerStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGradePerStudent))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblLanguageValue = New System.Windows.Forms.Label()
        Me.lblCCBA = New System.Windows.Forms.Label()
        Me.lblRRValue = New System.Windows.Forms.Label()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblRR = New System.Windows.Forms.Label()
        Me.lblHomeroom = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblEnglish = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblCIG = New System.Windows.Forms.Label()
        Me.lblComputer = New System.Windows.Forms.Label()
        Me.lblEP = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblMAPEH = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblMath = New System.Windows.Forms.Label()
        Me.lblAP = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblScience = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblFilipino = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.lblGradingPeriod = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(723, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripButton1.Text = "&Print"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(56, 22)
        Me.ToolStripButton2.Text = "&Close"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.lblLanguageValue)
        Me.Panel1.Controls.Add(Me.lblCCBA)
        Me.Panel1.Controls.Add(Me.lblRRValue)
        Me.Panel1.Controls.Add(Me.lblLanguage)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.lblRR)
        Me.Panel1.Controls.Add(Me.lblHomeroom)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.lblEnglish)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.lblCIG)
        Me.Panel1.Controls.Add(Me.lblComputer)
        Me.Panel1.Controls.Add(Me.lblEP)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.lblMAPEH)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label30)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.lblMath)
        Me.Panel1.Controls.Add(Me.lblAP)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.lblScience)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.lblFilipino)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label27)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.lblSection)
        Me.Panel1.Controls.Add(Me.lblGradingPeriod)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(723, 333)
        Me.Panel1.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(58, 212)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(108, 14)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Math"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLanguageValue
        '
        Me.lblLanguageValue.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguageValue.Location = New System.Drawing.Point(607, 248)
        Me.lblLanguageValue.Name = "lblLanguageValue"
        Me.lblLanguageValue.Size = New System.Drawing.Size(88, 14)
        Me.lblLanguageValue.TabIndex = 22
        Me.lblLanguageValue.Text = "00.00"
        Me.lblLanguageValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCCBA
        '
        Me.lblCCBA.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCCBA.Location = New System.Drawing.Point(607, 208)
        Me.lblCCBA.Name = "lblCCBA"
        Me.lblCCBA.Size = New System.Drawing.Size(88, 14)
        Me.lblCCBA.TabIndex = 22
        Me.lblCCBA.Text = "00.00"
        Me.lblCCBA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRRValue
        '
        Me.lblRRValue.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRRValue.Location = New System.Drawing.Point(607, 170)
        Me.lblRRValue.Name = "lblRRValue"
        Me.lblRRValue.Size = New System.Drawing.Size(88, 14)
        Me.lblRRValue.TabIndex = 22
        Me.lblRRValue.Text = "00.00"
        Me.lblRRValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLanguage
        '
        Me.lblLanguage.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguage.Location = New System.Drawing.Point(356, 248)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(162, 14)
        Me.lblLanguage.TabIndex = 23
        Me.lblLanguage.Text = "Language"
        Me.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(356, 208)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(162, 14)
        Me.Label20.TabIndex = 23
        Me.Label20.Text = "Conduct/Char. Build. Act"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRR
        '
        Me.lblRR.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRR.Location = New System.Drawing.Point(356, 170)
        Me.lblRR.Name = "lblRR"
        Me.lblRR.Size = New System.Drawing.Size(195, 14)
        Me.lblRR.TabIndex = 23
        Me.lblRR.Text = "Research/Reading"
        Me.lblRR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHomeroom
        '
        Me.lblHomeroom.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeroom.Location = New System.Drawing.Point(241, 289)
        Me.lblHomeroom.Name = "lblHomeroom"
        Me.lblHomeroom.Size = New System.Drawing.Size(93, 14)
        Me.lblHomeroom.TabIndex = 20
        Me.lblHomeroom.Text = "00.00"
        Me.lblHomeroom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(58, 289)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(108, 14)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Homeroom"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEnglish
        '
        Me.lblEnglish.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnglish.Location = New System.Drawing.Point(241, 191)
        Me.lblEnglish.Name = "lblEnglish"
        Me.lblEnglish.Size = New System.Drawing.Size(93, 14)
        Me.lblEnglish.TabIndex = 18
        Me.lblEnglish.Text = "00.00"
        Me.lblEnglish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(58, 191)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(108, 14)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "English"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblName
        '
        Me.lblName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(118, 109)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(602, 25)
        Me.lblName.TabIndex = 24
        Me.lblName.Text = "Tiborsho Makatigbas"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCIG
        '
        Me.lblCIG.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCIG.Location = New System.Drawing.Point(607, 269)
        Me.lblCIG.Name = "lblCIG"
        Me.lblCIG.Size = New System.Drawing.Size(88, 14)
        Me.lblCIG.TabIndex = 29
        Me.lblCIG.Text = "00.00"
        Me.lblCIG.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblComputer
        '
        Me.lblComputer.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputer.Location = New System.Drawing.Point(607, 229)
        Me.lblComputer.Name = "lblComputer"
        Me.lblComputer.Size = New System.Drawing.Size(88, 14)
        Me.lblComputer.TabIndex = 29
        Me.lblComputer.Text = "00.00"
        Me.lblComputer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEP
        '
        Me.lblEP.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEP.Location = New System.Drawing.Point(607, 191)
        Me.lblEP.Name = "lblEP"
        Me.lblEP.Size = New System.Drawing.Size(88, 14)
        Me.lblEP.TabIndex = 29
        Me.lblEP.Text = "00.00"
        Me.lblEP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(356, 269)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(195, 14)
        Me.Label22.TabIndex = 31
        Me.Label22.Text = "Current Issues/Geography"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMAPEH
        '
        Me.lblMAPEH.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMAPEH.Location = New System.Drawing.Point(241, 269)
        Me.lblMAPEH.Name = "lblMAPEH"
        Me.lblMAPEH.Size = New System.Drawing.Size(93, 14)
        Me.lblMAPEH.TabIndex = 30
        Me.lblMAPEH.Text = "00.00"
        Me.lblMAPEH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(356, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(162, 14)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Computer"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label30
        '
        Me.Label30.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(356, 191)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(213, 14)
        Me.Label30.TabIndex = 31
        Me.Label30.Text = "Edukasyon sa Pagpapakatao"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(56, 269)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(108, 14)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "MAPEH"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMath
        '
        Me.lblMath.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMath.Location = New System.Drawing.Point(241, 212)
        Me.lblMath.Name = "lblMath"
        Me.lblMath.Size = New System.Drawing.Size(93, 14)
        Me.lblMath.TabIndex = 25
        Me.lblMath.Text = "00.00"
        Me.lblMath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAP
        '
        Me.lblAP.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAP.Location = New System.Drawing.Point(241, 250)
        Me.lblAP.Name = "lblAP"
        Me.lblAP.Size = New System.Drawing.Size(93, 14)
        Me.lblAP.TabIndex = 26
        Me.lblAP.Text = "00.00"
        Me.lblAP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(58, 250)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(108, 14)
        Me.Label16.TabIndex = 27
        Me.Label16.Text = "AP"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblScience
        '
        Me.lblScience.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScience.Location = New System.Drawing.Point(241, 229)
        Me.lblScience.Name = "lblScience"
        Me.lblScience.Size = New System.Drawing.Size(93, 14)
        Me.lblScience.TabIndex = 16
        Me.lblScience.Text = "00.00"
        Me.lblScience.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(58, 229)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(108, 14)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "Science"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFilipino
        '
        Me.lblFilipino.Font = New System.Drawing.Font("Verdana", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFilipino.Location = New System.Drawing.Point(241, 170)
        Me.lblFilipino.Name = "lblFilipino"
        Me.lblFilipino.Size = New System.Drawing.Size(93, 14)
        Me.lblFilipino.TabIndex = 6
        Me.lblFilipino.Text = "00.00"
        Me.lblFilipino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(58, 170)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 14)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Filipino"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 148)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(106, 14)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "Grades"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 363)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(717, 14)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "---------------------------------------------------------------------------------" & _
    "---------------------------------------"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(0, 134)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(717, 14)
        Me.Label27.TabIndex = 1
        Me.Label27.Text = "---------------------------------------------------------------------------------" & _
    "---------------------------------------"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 14)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Student Name :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSection
        '
        Me.lblSection.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.Location = New System.Drawing.Point(524, 109)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(198, 14)
        Me.lblSection.TabIndex = 8
        Me.lblSection.Text = "Courtesy"
        Me.lblSection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGradingPeriod
        '
        Me.lblGradingPeriod.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGradingPeriod.Location = New System.Drawing.Point(119, 86)
        Me.lblGradingPeriod.Name = "lblGradingPeriod"
        Me.lblGradingPeriod.Size = New System.Drawing.Size(198, 14)
        Me.lblGradingPeriod.TabIndex = 13
        Me.lblGradingPeriod.Text = "First Grading"
        Me.lblGradingPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(456, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 14)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Section :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 14)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Grading Period :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(723, 14)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Kidapawan City"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(723, 14)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "IBEd High School Department"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(723, 14)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Notre Dame of Kidapawan College"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(723, 16)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "JMJ Marist Brothers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'frmGradePerStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 358)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGradePerStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Student Grade"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblRRValue As System.Windows.Forms.Label
    Friend WithEvents lblRR As System.Windows.Forms.Label
    Friend WithEvents lblHomeroom As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblEnglish As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblEP As System.Windows.Forms.Label
    Friend WithEvents lblMAPEH As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblMath As System.Windows.Forms.Label
    Friend WithEvents lblAP As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblScience As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblFilipino As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents lblGradingPeriod As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblLanguageValue As System.Windows.Forms.Label
    Friend WithEvents lblCCBA As System.Windows.Forms.Label
    Friend WithEvents lblLanguage As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblCIG As System.Windows.Forms.Label
    Friend WithEvents lblComputer As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
