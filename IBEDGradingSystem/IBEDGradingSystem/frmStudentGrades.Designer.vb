<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudentGrades
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
        Me.tempgradingreportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSGradingReport = New IBEDGradingSystem.DSGradingReport()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.tempgradingreportTableAdapter = New IBEDGradingSystem.DSGradingReportTableAdapters.tempgradingreportTableAdapter()
        CType(Me.tempgradingreportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSGradingReport, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "IBEDGradingSystem.rptGradePerStudent.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(703, 471)
        Me.ReportViewer1.TabIndex = 0
        '
        'tempgradingreportTableAdapter
        '
        Me.tempgradingreportTableAdapter.ClearBeforeFill = True
        '
        'frmStudentGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(703, 471)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmStudentGrades"
        Me.Text = "Grade Per Student"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.tempgradingreportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSGradingReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tempgradingreportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DSGradingReport As IBEDGradingSystem.DSGradingReport
    Friend WithEvents tempgradingreportTableAdapter As IBEDGradingSystem.DSGradingReportTableAdapters.tempgradingreportTableAdapter
End Class
