<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGradingSheetReport
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ibedgrading_dbDataSet = New IBEDGradingSystem.ibedgrading_dbDataSet()
        Me.tempsubjectgradeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tempsubjectgradeTableAdapter = New IBEDGradingSystem.ibedgrading_dbDataSetTableAdapters.tempsubjectgradeTableAdapter()
        CType(Me.ibedgrading_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tempsubjectgradeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tempsubjectgradeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "IBEDGradingSystem.rptGradingSheet.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(775, 488)
        Me.ReportViewer1.TabIndex = 0
        '
        'ibedgrading_dbDataSet
        '
        Me.ibedgrading_dbDataSet.DataSetName = "ibedgrading_dbDataSet"
        Me.ibedgrading_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tempsubjectgradeBindingSource
        '
        Me.tempsubjectgradeBindingSource.DataMember = "tempsubjectgrade"
        Me.tempsubjectgradeBindingSource.DataSource = Me.ibedgrading_dbDataSet
        '
        'tempsubjectgradeTableAdapter
        '
        Me.tempsubjectgradeTableAdapter.ClearBeforeFill = True
        '
        'frmGradingSheetReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(775, 488)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmGradingSheetReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ibedgrading_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tempsubjectgradeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tempsubjectgradeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ibedgrading_dbDataSet As IBEDGradingSystem.ibedgrading_dbDataSet
    Friend WithEvents tempsubjectgradeTableAdapter As IBEDGradingSystem.ibedgrading_dbDataSetTableAdapters.tempsubjectgradeTableAdapter
End Class
