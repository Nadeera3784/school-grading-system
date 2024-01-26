
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmUser

    Dim adding As Boolean
    Dim updating As Boolean
    Public isAddingUser As Boolean


    Private Sub LoadUsers()
        Try
            sqL = "SELECT Username FROM USERS ORDER BY Username"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader()

            Dim x As New ListViewItem
            ListView1.Items.Clear()
            ListView1.Items.Add("")
            Do While dr.Read = True
                x = New ListViewItem(dr("Username").ToString)

                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub BindToText()
        Try
            sqL = "SELECT *, CONCAT(Lastname, ', ', Firstname, ' ', MI) as TName FROM USERS s LEFT JOIN Teacher t ON s.TeacherNo = t.TeacherNo LEFT JOIN SECTION sec ON t.SectionNO = sec.SectionNo WHERE Username ='" & ListView1.FocusedItem.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader()

            If dr.Read = True Then
                txtUsername.Text = dr("Username").ToString
                txtPassword.Text = Decrypt(dr("Pwd"))
                txtConfirmPass.Text = Decrypt(dr("Pwd"))
                cmbRole.Text = dr("Role").ToString
                txtTeacher.Text = dr("TName").ToString
                txtTeacher.Tag = dr("TeacherNo").ToString
                If dr("Role").ToString.ToUpper <> "ADMIN" Then
                    lblTeacher.Visible = True
                    txtTeacher.Visible = True
                    btnSection.Visible = True
                Else
                    lblTeacher.Visible = False
                    txtTeacher.Visible = False
                    btnSection.Visible = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Function ValidateOldPassword() As Boolean
        Dim isValid As Boolean = False
        Try
            sqL = "SELECT * FROM Users WHERE Username ='" & txtUsername.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader()

            If dr.Read = True Then

                If Decrypt(dr("Pwd")) = txtPassword.Text Then
                    isValid = True
                End If
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

        Return isValid
    End Function

    Private Sub AddUsers()
        Dim strPassword As String = Encrypt(txtPassword.Text)
        Try
            sqL = "INSERT INTO USERS(Username, Pwd, Role, TeacherNo) VALUES('" & txtUsername.Text & "', '" & strPassword & "', '" & cmbRole.Text & "', '" & txtTeacher.Tag & "')"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("New user successfully saved.", MsgBoxStyle.Information, "User")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub UpdateUser()
        Dim strPassword As String = Encrypt(txtPassword.Text)
        Try
            sqL = "UPDATE Users SET pwd = '" & strPassword & "', Role = '" & cmbRole.Text & "', TeacherNo = '" & txtTeacher.Tag & "' WHERE Username = '" & txtUsername.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            Dim i As Integer
            i = cmd.ExecuteNonQuery
            If i > 0 Then
                MsgBox("User successfully updated.", MsgBoxStyle.Information, "User")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub LockField()
        txtUsername.Enabled = False
        txtPassword.Enabled = False
        txtConfirmPass.Enabled = False
        cmbRole.Enabled = False

    End Sub

    Private Sub UnlockField()

        txtUsername.Enabled = True
        txtPassword.Enabled = True
        txtConfirmPass.Enabled = True
        cmbRole.Enabled = True

    End Sub

    Private Sub CLearFields()
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtConfirmPass.Text = ""
        cmbRole.Text = ""

        txtTeacher.Text = ""
    End Sub

    Private Sub EnabledButton()
        btnAdd.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True


        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnSection.Enabled = False
    End Sub

    Private Sub DisabledButton()
        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False


        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnSection.Enabled = True
    End Sub

    Private Sub frmUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadUsers()
        LockField()
        EnabledButton()
        lblOldPassword.Visible = False
        txtOldPassword.Visible = False

        lblTeacher.Visible = False
        txtTeacher.Visible = False
        btnSection.Visible = False
        lblPassword.Text = "Password : "

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        UnlockField()
        CLearFields()
        DisabledButton()
        adding = True
        updating = False
        txtUsername.Focus()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        UnlockField()
        DisabledButton()
        adding = False
        updating = True

        MsgBox("Enter old password.", MsgBoxStyle.Information, "User")
        lblOldPassword.Visible = True
        txtOldPassword.Visible = True
        lblPassword.Text = "New Password :"
        txtPassword.Text = ""
        txtConfirmPass.Text = ""
        txtOldPassword.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtPassword.Text <> txtConfirmPass.Text Then
            MsgBox("Password did not match.", MsgBoxStyle.Critical, "User")
            Exit Sub
        End If

        If adding = True Then
            AddUsers()
            CLearFields()
            LockField()
            LoadUsers()
            EnabledButton()
        Else
            If ValidateOldPassword() = True Then
                UpdateUser()
                CLearFields()
                LockField()
                EnabledButton()
                LoadUsers()
                lblOldPassword.Visible = False
                txtOldPassword.Visible = False
            Else
                MsgBox("Old password entered incorrect.", MsgBoxStyle.Critical, "user")
            End If

        End If
        lblTeacher.Visible = False
        txtTeacher.Visible = False
        btnSection.Visible = False
        lblPassword.Text = "Password :"

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        CLearFields()
        LockField()
        EnabledButton()
        lblOldPassword.Visible = False
        txtOldPassword.Visible = False
        lblTeacher.Visible = False
        txtTeacher.Visible = False
        btnSection.Visible = False

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        BindToText()

    End Sub

    Private Sub cmbRole_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.Text <> "Admin" Then
            lblTeacher.Visible = True
            txtTeacher.Visible = True
            btnSection.Visible = True

        Else
            lblTeacher.Visible = False
            txtTeacher.Visible = False
            btnSection.Visible = False

        End If
    End Sub

    Private Sub btnSection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSection.Click

        frmLoadTeacher.ShowDialog()


    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If ListView1.FocusedItem.Text = "" Then
            MsgBox("Please select user to delete.", MsgBoxStyle.Exclamation, "Delete")
            Exit Sub
        End If

        If cmbRole.Text = "Admin" Then
            MsgBox("Selected user cannot be deleted.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                sqL = "DELETE FROM Users WHERE Username = '" & ListView1.FocusedItem.Text & "'"
                ConnDB()
                cmd = New MySqlCommand(sqL, conn)
                Dim i As Integer = cmd.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Selected user successfully deleted.", MsgBoxStyle.Information, "Delete User")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                cmd.Dispose()
                conn.Close()
            End Try
            LoadUsers()
            CLearFields()
        End If
    End Sub
End Class