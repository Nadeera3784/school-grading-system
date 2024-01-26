<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradeReport
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
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgw = New System.Windows.Forms.DataGridView()
        Me.Clients = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContractNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ORNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.isLate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sci = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MAPEH = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Elec = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DSGradingReport = New IBEDGradingSystem.DSGradingReport()
        Me.tempgradingreportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tempgradingreportTableAdapter = New IBEDGradingSystem.DSGradingReportTableAdapters.tempgradingreportTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSGradingReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tempgradingreportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.Location = New System.Drawing.Point(124, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(562, 403)
        Me.Panel1.TabIndex = 1
        Me.Panel1.UseWaitCursor = True
        '
        'dgw
        '
        Me.dgw.AllowUserToAddRows = False
        Me.dgw.AllowUserToDeleteRows = False
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.White
        Me.dgw.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle20
        Me.dgw.BackgroundColor = System.Drawing.Color.White
        Me.dgw.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgw.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.dgw.ColumnHeadersHeight = 24
        Me.dgw.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Clients, Me.ContractNo, Me.ORNo, Me.isLate, Me.Sci, Me.AP, Me.TLE, Me.MAPEH, Me.CLE, Me.Elec, Me.Late, Me.Absent, Me.TMAL, Me.Total, Me.Average, Me.Honor})
        Me.dgw.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.dgw.EnableHeadersVisualStyles = False
        Me.dgw.GridColor = System.Drawing.Color.White
        Me.dgw.Location = New System.Drawing.Point(7, 135)
        Me.dgw.MultiSelect = False
        Me.dgw.Name = "dgw"
        Me.dgw.ReadOnly = True
        Me.dgw.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle37.SelectionBackColor = System.Drawing.Color.Teal
        DataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgw.RowHeadersDefaultCellStyle = DataGridViewCellStyle37
        Me.dgw.RowHeadersVisible = False
        Me.dgw.RowHeadersWidth = 25
        Me.dgw.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle38.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle38.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle38.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.Black
        Me.dgw.RowsDefaultCellStyle = DataGridViewCellStyle38
        Me.dgw.RowTemplate.Height = 18
        Me.dgw.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgw.Size = New System.Drawing.Size(455, 245)
        Me.dgw.TabIndex = 49
        Me.dgw.UseWaitCursor = True
        '
        'Clients
        '
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Clients.DefaultCellStyle = DataGridViewCellStyle22
        Me.Clients.HeaderText = "NAME"
        Me.Clients.Name = "Clients"
        Me.Clients.ReadOnly = True
        Me.Clients.Width = 200
        '
        'ContractNo
        '
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        Me.ContractNo.DefaultCellStyle = DataGridViewCellStyle23
        Me.ContractNo.HeaderText = "Fil."
        Me.ContractNo.Name = "ContractNo"
        Me.ContractNo.ReadOnly = True
        Me.ContractNo.Width = 35
        '
        'ORNo
        '
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.ORNo.DefaultCellStyle = DataGridViewCellStyle24
        Me.ORNo.HeaderText = "Eng."
        Me.ORNo.Name = "ORNo"
        Me.ORNo.ReadOnly = True
        Me.ORNo.Width = 35
        '
        'isLate
        '
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.isLate.DefaultCellStyle = DataGridViewCellStyle25
        Me.isLate.HeaderText = "Math"
        Me.isLate.Name = "isLate"
        Me.isLate.ReadOnly = True
        Me.isLate.Width = 40
        '
        'Sci
        '
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Sci.DefaultCellStyle = DataGridViewCellStyle26
        Me.Sci.HeaderText = "Sci."
        Me.Sci.Name = "Sci"
        Me.Sci.ReadOnly = True
        Me.Sci.Width = 35
        '
        'AP
        '
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.AP.DefaultCellStyle = DataGridViewCellStyle27
        Me.AP.HeaderText = "AP"
        Me.AP.Name = "AP"
        Me.AP.ReadOnly = True
        Me.AP.Width = 35
        '
        'TLE
        '
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.TLE.DefaultCellStyle = DataGridViewCellStyle28
        Me.TLE.HeaderText = "TLE"
        Me.TLE.Name = "TLE"
        Me.TLE.ReadOnly = True
        Me.TLE.Width = 35
        '
        'MAPEH
        '
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.MAPEH.DefaultCellStyle = DataGridViewCellStyle29
        Me.MAPEH.HeaderText = "MAPEH"
        Me.MAPEH.Name = "MAPEH"
        Me.MAPEH.ReadOnly = True
        Me.MAPEH.Width = 50
        '
        'CLE
        '
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.CLE.DefaultCellStyle = DataGridViewCellStyle30
        Me.CLE.HeaderText = "CLE"
        Me.CLE.Name = "CLE"
        Me.CLE.ReadOnly = True
        Me.CLE.Width = 35
        '
        'Elec
        '
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Elec.DefaultCellStyle = DataGridViewCellStyle31
        Me.Elec.HeaderText = "Elec."
        Me.Elec.Name = "Elec"
        Me.Elec.ReadOnly = True
        Me.Elec.Width = 35
        '
        'Late
        '
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Late.DefaultCellStyle = DataGridViewCellStyle32
        Me.Late.HeaderText = "FMAL"
        Me.Late.Name = "Late"
        Me.Late.ReadOnly = True
        '
        'Absent
        '
        DataGridViewCellStyle33.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Absent.DefaultCellStyle = DataGridViewCellStyle33
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
        DataGridViewCellStyle34.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Total.DefaultCellStyle = DataGridViewCellStyle34
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        Me.Total.Width = 50
        '
        'Average
        '
        DataGridViewCellStyle35.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Average.DefaultCellStyle = DataGridViewCellStyle35
        Me.Average.HeaderText = "Ave."
        Me.Average.Name = "Average"
        Me.Average.ReadOnly = True
        Me.Average.Width = 45
        '
        'Honor
        '
        DataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Honor.DefaultCellStyle = DataGridViewCellStyle36
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
        Me.Label1.Location = New System.Drawing.Point(57, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(808, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "JMJ Marist Brothers"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Label1.UseWaitCursor = True
        '
        'PrintDocument1
        '
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(1017, 696)
        Me.ReportViewer1.TabIndex = 2
        '
        'DSGradingReport
        '
        Me.DSGradingReport.DataSetName = "DSGradingReport"
        Me.DSGradingReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tempgradingreportBindingSource
        '
        Me.tempgradingreportBindingSource.DataMember = "tempgradingreport"
        Me.tempgradingreportBindingSource.DataSource = Me.DSGradingReport
        '
        'tempgradingreportTableAdapter
        '
        Me.tempgradingreportTableAdapter.ClearBeforeFill = True
        '
        'frmGradeReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1017, 696)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmGradeReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grading Report Grade"
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgw, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSGradingReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tempgradingreportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblGrading As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblSection As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgw As System.Windows.Forms.DataGridView
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents Clients As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContractNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ORNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents isLate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sci As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AP As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MAPEH As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLE As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Elec As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Late As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Absent As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TMAL As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Average As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Honor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DSGradingReport As IBEDGradingSystem.DSGradingReport
    Friend WithEvents tempgradingreportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tempgradingreportTableAdapter As IBEDGradingSystem.DSGradingReportTableAdapters.tempgradingreportTableAdapter
End Class
