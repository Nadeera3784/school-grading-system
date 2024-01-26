<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradingReport
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tempgradingreportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSGradingReport = New IBEDGradingSystem.DSGradingReport()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Clients = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isLate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sci = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MAPEH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Homeroom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCBA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Comp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Lang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CIG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Late = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Absent = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TMAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Average = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Honor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblGrading = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblSection = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tempgradingreportTableAdapter = New IBEDGradingSystem.DSGradingReportTableAdapters.tempgradingreportTableAdapter()
        CType(Me.tempgradingreportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSGradingReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tempgradingreportBindingSource
        '
        Me.tempgradingreportBindingSource.DataMember = "tempgradingreport"
        Me.tempgradingreportBindingSource.DataSource = Me.DSGradingReport
        '
        'DSGradingReport
        '
        Me.DSGradingReport.DataSetName = "DSGradingReport"
        Me.DSGradingReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tempgradingreportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "IBEDGradingSystem.rptGradingReport1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1132, 424)
        Me.ReportViewer1.TabIndex = 0
        Me.ReportViewer1.ZoomPercent = 80
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.dgw)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblGrading)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.lblSection)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(434, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(185, 403)
        Me.Panel1.TabIndex = 2
        Me.Panel1.UseWaitCursor = True
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Clients, Me.ContractNo, Me.ORNo, Me.isLate, Me.Sci, Me.AP, Me.MAPEH, Me.Homeroom, Me.RR, Me.EP, Me.CCBA, Me.Comp, Me.Lang, Me.CIG, Me.Late, Me.Absent, Me.TMAL, Me.Total, Me.Average, Me.Honor})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.White
        Me.dgw.Location = New System.Drawing.Point(7, 135)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgw.RowHeadersVisible = False
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle19
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(238, 245)
        Me.dgw.TabIndex = 49
        Me.dgw.UseWaitCursor = True
        '
        'Clients
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Clients.DefaultCellStyle = DataGridViewCellStyle3
        Me.Clients.HeaderText = "NAME"
        Me.Clients.Name = "Clients"
        Me.Clients.ReadOnly = True
        Me.Clients.Width = 200
        '
        'ContractNo
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.ContractNo.DefaultCellStyle = DataGridViewCellStyle4
        Me.ContractNo.HeaderText = "Fil."
        Me.ContractNo.Name = "ContractNo"
        Me.ContractNo.ReadOnly = True
        Me.ContractNo.Width = 35
        '
        'ORNo
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ORNo.DefaultCellStyle = DataGridViewCellStyle5
        Me.ORNo.HeaderText = "Eng."
        Me.ORNo.Name = "ORNo"
        Me.ORNo.ReadOnly = True
        Me.ORNo.Width = 35
        '
        'isLate
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.isLate.DefaultCellStyle = DataGridViewCellStyle6
        Me.isLate.HeaderText = "Math"
        Me.isLate.Name = "isLate"
        Me.isLate.ReadOnly = True
        Me.isLate.Width = 40
        '
        'Sci
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Sci.DefaultCellStyle = DataGridViewCellStyle7
        Me.Sci.HeaderText = "Sci."
        Me.Sci.Name = "Sci"
        Me.Sci.ReadOnly = True
        Me.Sci.Width = 35
        '
        'AP
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.AP.DefaultCellStyle = DataGridViewCellStyle8
        Me.AP.HeaderText = "AP"
        Me.AP.Name = "AP"
        Me.AP.ReadOnly = True
        Me.AP.Width = 35
        '
        'MAPEH
        '
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.MAPEH.DefaultCellStyle = DataGridViewCellStyle9
        Me.MAPEH.HeaderText = "MAPEH"
        Me.MAPEH.Name = "MAPEH"
        Me.MAPEH.ReadOnly = True
        Me.MAPEH.Width = 50
        '
        'Homeroom
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Homeroom.DefaultCellStyle = DataGridViewCellStyle10
        Me.Homeroom.HeaderText = "Homeroom"
        Me.Homeroom.Name = "Homeroom"
        Me.Homeroom.ReadOnly = True
        Me.Homeroom.Width = 35
        '
        'RR
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.RR.DefaultCellStyle = DataGridViewCellStyle11
        Me.RR.HeaderText = "RR"
        Me.RR.Name = "RR"
        Me.RR.ReadOnly = True
        Me.RR.Width = 35
        '
        'EP
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.EP.DefaultCellStyle = DataGridViewCellStyle12
        Me.EP.HeaderText = "EP"
        Me.EP.Name = "EP"
        Me.EP.ReadOnly = True
        Me.EP.Width = 35
        '
        'CCBA
        '
        Me.CCBA.HeaderText = "CCBA"
        Me.CCBA.Name = "CCBA"
        Me.CCBA.ReadOnly = True
        '
        'Comp
        '
        Me.Comp.HeaderText = "Comp"
        Me.Comp.Name = "Comp"
        Me.Comp.ReadOnly = True
        '
        'Lang
        '
        Me.Lang.HeaderText = "Lang"
        Me.Lang.Name = "Lang"
        Me.Lang.ReadOnly = True
        '
        'CIG
        '
        Me.CIG.HeaderText = "CIG"
        Me.CIG.Name = "CIG"
        Me.CIG.ReadOnly = True
        '
        'Late
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Late.DefaultCellStyle = DataGridViewCellStyle13
        Me.Late.HeaderText = "FMAL"
        Me.Late.Name = "Late"
        Me.Late.ReadOnly = True
        '
        'Absent
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Absent.DefaultCellStyle = DataGridViewCellStyle14
        Me.Absent.HeaderText = "SMAL"
        Me.Absent.Name = "Absent"
        Me.Absent.ReadOnly = True
        '
        'TMAL
        '
        Me.TMAL.HeaderText = "TMAL"
        Me.TMAL.Name = "TMAL"
        Me.TMAL.ReadOnly = True
        '
        'Total
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Total.DefaultCellStyle = DataGridViewCellStyle15
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 50
        '
        'Average
        '
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Average.DefaultCellStyle = DataGridViewCellStyle16
        Me.Average.HeaderText = "Ave."
        Me.Average.Name = "Average"
        Me.Average.ReadOnly = True
        Me.Average.Width = 45
        '
        'Honor
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Honor.DefaultCellStyle = DataGridViewCellStyle17
        Me.Honor.HeaderText = "Honor"
        Me.Honor.Name = "Honor"
        Me.Honor.ReadOnly = True
        Me.Honor.Width = 45
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(808, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Notre Dame of Kidapawan College"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label2.UseWaitCursor = True
        '
        'lblGrading
        '
        Me.lblGrading.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrading.Location = New System.Drawing.Point(579, 91)
        Me.lblGrading.Name = "lblGrading"
        Me.lblGrading.Size = New System.Drawing.Size(202, 16)
        Me.lblGrading.TabIndex = 0
        Me.lblGrading.Text = "Second Grading Period"
        Me.lblGrading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblGrading.UseWaitCursor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(221, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "MASTER GRADING SHEET"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label5.UseWaitCursor = True
        '
        'lblSection
        '
        Me.lblSection.Font = New System.Drawing.Font("Verdana", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSection.Location = New System.Drawing.Point(2, 107)
        Me.lblSection.Name = "lblSection"
        Me.lblSection.Size = New System.Drawing.Size(806, 16)
        Me.lblSection.TabIndex = 0
        Me.lblSection.Text = "Grade 8 - St. Francis"
        Me.lblSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblSection.UseWaitCursor = True
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(808, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Kidapawan City"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label4.UseWaitCursor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(808, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "IBEd High School Department"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label3.UseWaitCursor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(808, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "JMJ Marist Brothers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.UseWaitCursor = True
        '
        'tempgradingreportTableAdapter
        '
        Me.tempgradingreportTableAdapter.ClearBeforeFill = True
        '
        'frmGradingReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1132, 424)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGradingReport"
        Me.Text = "Grading Report"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tempgradingreportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSGradingReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tempgradingreportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSGradingReport As IBEDGradingSystem.DSGradingReport
    Friend WithEvents tempgradingreportTableAdapter As IBEDGradingSystem.DSGradingReportTableAdapters.tempgradingreportTableAdapter
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblGrading As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Clients As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContractNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ORNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents isLate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sci As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MAPEH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Homeroom As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RR As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CCBA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Comp As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lang As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CIG As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Late As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Absent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Average As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Honor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
