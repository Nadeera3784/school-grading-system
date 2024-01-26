
Imports MySql.Data.MySqlClient

Public Class frmAddEditStudent

    Dim strSQL As String
    Public isStudentSection As Boolean

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSection.Click
        isStudentSection = True
        frmLoadSection.ShowDialog()
    End Sub

    Private Sub LoadSY()
        Try
            sqL = "SELECT SYValue FROM SY ORDER BY SYValue "
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            cmbSY.Items.Clear()
            cmbSY.Items.Add("")
            Do While dr.Read = True
                cmbSY.Items.Add(dr(0).ToString)

            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub frmAddEditStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSY()

        If frmMain.lblRole.Text.ToUpper() = "ADMIN" Then
            btnSection.Visible = True
            txtSection.Text = ""
            txtSection.Tag = ""
            cmbSY.Enabled = True
        Else
            btnSection.Visible = False
            txtSection.Text = frmMain.lblSection.Text
            txtSection.Tag = frmMain.lblSection.Tag
            cmbSY.Text = frmMain.lblSY.Text
            cmbSY.Enabled = False
        End If

        If adding = True Then
            lblTitle.Text = "Adding Student"
            txtLastname.Tag = ""
            txtLastname.Text = ""
            txtFirstname.Text = ""
            txtMI.Text = ""
            cmbGender.Text = ""
           
        Else
            lblTitle.Text = "Updating Student"
            GetStudentInfo()
        End If

        cmbSY.Text = frmStudent.cmbGrading.Text
        txtSection.Tag = frmStudent.txtSection.Tag
        txtSection.Text = frmStudent.txtSection.Text
    End Sub

    Private Sub GetStudentInfo()
        Try
            sqL = "SELECT StudentNo, Lastname, Firstname, MI, Gender, CONCAT(GradeLevel, ' - ', SectionName) as Section, sec.SectionNo, SY FROM Student s LEFT JOIN Section sec ON s.SectionNo = sec.SectionNo WHERE StudentNo = '" & frmStudent.ListView1.FocusedItem.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtLastname.Tag = dr(0).ToString
                txtLastname.Text = dr(1).ToString
                txtFirstname.Text = dr(2).ToString
                txtMI.Text = dr(3).ToString
                cmbGender.Text = dr(4).ToString
                txtSection.Text = dr(5).ToString
                txtSection.Tag = dr(6).ToString
                cmbSY.Text = dr(7).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValFields() = False Then
            Exit Sub
        End If

        If adding = True Then
            strSQL = "INSERT INTO Student(Lastname, Firstname, MI, Gender, SectionNo, SY) VALUES('" & txtLastname.Text & "', '" & txtFirstname.Text & "', '" & txtMI.Text & "', '" & cmbGender.Text & "', '" & txtSection.Tag & "', '" & cmbSY.Text & "')"
            If AddEditData(strSQL) = True Then
                MsgBox("Student added successfully.", MsgBoxStyle.Information, "Add Student")
            End If
        Else
            strSQL = "UPDATE Student SET Lastname = '" & txtLastname.Text & "', Firstname = '" & txtFirstname.Text & "', MI = '" & txtMI.Text & "', Gender = '" & cmbGender.Text & "', SectionNo = '" & txtSection.Tag & "', SY = '" & cmbSY.Text & "' WHERE StudentNo = '" & txtLastname.Tag & "'"
            If AddEditData(strSQL) = True Then
                MsgBox("Student updated successfully.", MsgBoxStyle.Information, "Update Student")
            End If
        End If

        frmStudent.LoadStudent()
        Me.Close()
    End Sub

    Private Sub cmbGender_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbGender.KeyPress
        'e.Handled = True
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbSY.KeyPress
        e.Handled = True
    End Sub

    Private Function ValFields()
        ValFields = False
        If txtLastname.Text = "" Then
            MsgBox("Please Fill-in lastname field.", MsgBoxStyle.Exclamation, "Warning")
        ElseIf txtFirstname.Text = "" Then
            MsgBox("Please Fill-in firstname field.", MsgBoxStyle.Exclamation, "Warning")
        ElseIf cmbGender.Text = "" Then
            MsgBox("Please Fill-in gender field.", MsgBoxStyle.Exclamation, "Warning")
        ElseIf txtSection.Text = "" Then
            MsgBox("Please Fill-in section field.", MsgBoxStyle.Exclamation, "Warning")
        ElseIf cmbSY.Text = "" Then
            MsgBox("Please Fill-in school year field.", MsgBoxStyle.Exclamation, "Warning")
        Else
            ValFields = True
        End If
    End Function

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
End Class