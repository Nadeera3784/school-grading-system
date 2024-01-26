

Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmLogin

    Private Sub Login()
        Try
            sqL = "SELECT * FROM USERS s LEFT JOIN Teacher t ON s.TeacherNo = t.TeacherNo LEFT JOIN SECTION sec ON t.SectionNO = sec.SectionNo WHERE Username = '" & txtUsername.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader()

            If dr.Read = True Then
              
                If Decrypt(dr("Pwd")) = txtPassword.Text Then
                    '  MsgBox("Welcome to ABC - EDC Permanent Record and Grade Slip System.", MsgBoxStyle.Information, "Login")
                    frmMain.lblUser.Text = dr("Username").ToString.ToUpper()
                    frmMain.lblSection.Text = dr("GradeLevel") & " - " & dr("SectionName").ToString
                    frmMain.lblSection.Tag = dr("SectionNo").ToString
                    frmMain.lblRole.Text = dr("Role").ToString
                    frmMain.lblSY.Text = dr("SY").ToString
                    frmMain.lblGrade.Text = dr("GradeLevel").ToString
                    frmMain.MainFunctionsDisEn()
                    frmMain.Show()
                    Me.Hide()
                    ' Me.Close()

                Else
                    MsgBox("Incorrect username or password.", MsgBoxStyle.Critical, "Login")
                    txtUsername.SelectAll()
                    txtPassword.SelectAll()
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub LoginSubjectTeacher()
        Try
            sqL = "SELECT * FROM USERS s LEFT JOIN Teacher t ON s.TeacherNo = t.TeacherNo LEFT JOIN SECTION sec ON t.SectionNO = sec.SectionNo WHERE Username = '" & txtUsername.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader()

            If dr.Read = True Then
                If dr("Role").ToString.ToUpper() = "ADMIN" Then
                    MsgBox("Admin or Adviser Role cant use this form.", MsgBoxStyle.Exclamation, "Warning")
                    Exit Sub
                End If

                If Decrypt(dr("Pwd")) = txtPassword.Text Then
                   
                    frmComputeSubjectGrade.txtLogTeacher.Tag = dr("TeacherNo")
                    frmComputeSubjectGrade.cmbSY.Text = dr("SY").ToString
                    frmComputeSubjectGrade.txtLogTeacher.Text = dr("LastName") & ", " & dr("Firstname") & " " & dr("MI")
                    frmComputeSubjectGrade.Show()
                    Me.Hide()
                    'Me.Close()

                Else
                    MsgBox("Incorrect username or password.", MsgBoxStyle.Critical, "Login")
                    txtUsername.SelectAll()
                    txtPassword.SelectAll()
                End If


            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub


    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUsername.GotFocus
        AcceptButton = Button1
    End Sub

    Private Sub TextBox2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPassword.GotFocus
        AcceptButton = Button1
        If txtUserName.Text = "" Then
            txtUserName.Focus()

        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If ComboBox1.Text = "" Then
            MsgBox("Please select option.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        If ComboBox1.Text = "Subject Teacher" Then
            LoginSubjectTeacher()
        Else
            Login()
        End If


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MsgBox("Are you sure you want to close?", MsgBoxStyle.YesNo, "Close Window") = MsgBoxResult.Yes Then
            End
        End If
    End Sub

    Private Sub frmLogin_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F4 And e.Modifiers = Keys.Alt Then
            e.Handled = True
        End If

        If e.KeyCode = Keys.F12 Then
            frmDatabase.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        For Each selProcess As Process In Process.GetProcesses
            If selProcess.ProcessName = "taskmgr" Then
                selProcess.Kill()
                Exit For
            End If
        Next
    End Sub

    Private Sub frmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        getData()
        txtPassword.Text = ""
        txtUsername.Text = ""
        txtUsername.Focus()
       
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ComboBox1.KeyPress
        e.Handled = True
    End Sub
End Class