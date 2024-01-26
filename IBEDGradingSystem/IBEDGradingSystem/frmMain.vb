
Imports System.Windows.Forms


Public Class frmMain

    Private Sub CloseChildForms()
        For Each frm As Form In Me.MdiChildren
            If frm.Name <> "frmHome" Then
                frm.Close()
            End If
        Next

        'frmHome.MdiParent = Me
        'frmHome.Show()
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Application.Exit()
        frmLogin.txtUsername.Text = ""
        frmLogin.txtPassword.Text = ""
        frmLogin.ComboBox1.Text = ""
        frmLogin.Show()
        frmLogin.txtUsername.Focus()
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        getData()
        frmHome.MdiParent = Me
        frmHome.Show()
        lblDate.Text = Date.Now.ToString("MMMM dd, yyyy")
        ' frmLogin.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CloseChildForms()
        frmSubject.MdiParent = Me
        frmSubject.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTIme.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Windows.Forms.Keys.F1 Then
            frmDatabase.ShowDialog()
        End If
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSection.Click
        CloseChildForms()
        frmSection.MdiParent = Me
        frmSection.Show()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStudent.Click
        CloseChildForms()
        frmStudent.MdiParent = Me
        frmStudent.Show()
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUser.Click
        frmUser.ShowDialog()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetting.Click

        CloseChildForms()
    
        frmComputeSubjectGradeMain.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGrades.Click
        CloseChildForms()
        frmGrades.MdiParent = Me
        frmGrades.Show()
    End Sub

    Private Sub ToolStripButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
       
        Me.Close()

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbsentLate.Click
        CloseChildForms()
        frmAbsenLate.MdiParent = Me
        frmAbsenLate.Show()
    End Sub

    Public Sub MainFunctionsDisEn()
        If lblRole.Text.ToUpper() = "ADMIN" Then
            btnSection.Enabled = True
            btnStudent.Enabled = True
            btnAbsentLate.Enabled = True
            btnGrades.Enabled = True
            btnSetting.Enabled = True
            btnUser.Enabled = True
            btnTeacher.Enabled = True
            btnSYSetting.Enabled = True
        Else
            btnSection.Enabled = False
            btnStudent.Enabled = True
            btnAbsentLate.Enabled = True
            btnGrades.Enabled = True
            btnSetting.Enabled = False
            btnUser.Enabled = False
            btnTeacher.Enabled = False
            btnSYSetting.Enabled = False
        End If
    End Sub


    Private Sub btnTeacher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeacher.Click
        CloseChildForms()
        frmTeacher.MdiParent = Me
        frmTeacher.Show()
    End Sub

    Private Sub btnSYSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSYSetting.Click
        frmSYSetting.ShowDialog()
    End Sub
End Class