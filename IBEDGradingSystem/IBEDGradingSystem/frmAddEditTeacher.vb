
Imports MySql.Data.MySqlClient

Public Class frmAddEditTeacher

    Public isAddEditTeacher As Boolean

    Private Function ValidateFields()
        ValidateFields = False

        If txtLastname.Text = "" Then
            MsgBox("Please fill-in lastname field.", MsgBoxStyle.Exclamation, "Warning")
            txtLastname.Focus()
        ElseIf txtFirstname.Text = "" Then
            MsgBox("Please fill-in firstname field.", MsgBoxStyle.Exclamation, "Warning")
            txtFirstname.Focus()
        ElseIf txtSection.Text = "" Then
            MsgBox("Please fill-in section field.", MsgBoxStyle.Exclamation, "Warning")

       
        ElseIf cmbSY.Text = "" Then
            MsgBox("Please fill-in school year field.", MsgBoxStyle.Exclamation, "Warning")
            cmbSY.Focus()
        Else
            Return True
        End If
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strSQL As String

        If ValidateFields() = False Then
            Exit Sub

        End If

        If adding = True Then
            If ValidateTableData("SELECT * FROM Teacher WHERE Lastname ='" & txtLastname.Text & "' AND Firstname = '" & txtFirstname.Text & "'") Then
                MsgBox("Teacher already added.", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            If ValidateTableData("SELECT * FROM Teacher WHERE SectionNo = '" & txtSection.Tag & "' AND SY = '" & cmbSY.Text & "'") Then
                MsgBox("Section alread assigned to a teacher.", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            strSQL = "INSERT INTO TEacher(Lastname, Firstname, MI, SectionNo, SY) VALUES('" & txtLastname.Text & "', '" & txtFirstname.Text & "', '" & txtMI.Text & "', '" & txtSection.Tag & "', '" & cmbSY.Text & "')"
            AddEditData(strSQL)
            MsgBox("Teacher Info Added Successfully", MsgBoxStyle.Information, "Adding Teacher")
        Else
            strSQL = "UPDATE TEACHER SET Lastname = '" & txtLastname.Text & "', Firstname = '" & txtFirstname.Text & "', MI = '" & txtMI.Text & "', SectionNo = '" & txtSection.Tag & "', SY = '" & cmbSY.Text & "' WHERE TeacherNo = '" & txtLastname.Tag & "'"
            AddEditData(strSQL)
            MsgBox("Teacher Info Updated Successfully", MsgBoxStyle.Information, "Adding Teacher")
        End If
        frmTeacher.LoadTeacher()
        Me.Close()
    End Sub

    Private Sub GetTeacherInfo()
        Try
            sqL = "SELECT TeacherNo, Lastname, Firstname, MI, s.SectionNo, CONCAT(GradeLevel, ' - ', SectionName) as Section, SY FROM Teacher t LEFT JOIN Section s ON t.SectionNo = s.SectionNo WHERE TeacherNo = '" & frmTeacher.ListView1.FocusedItem.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtLastname.Tag = dr(0).ToString
                txtLastname.Text = dr(1).ToString
                txtFirstname.Text = dr(2).ToString
                txtMI.Text = dr(3).ToString
                txtSection.Tag = dr(4).ToString
                txtSection.Text = dr(5).ToString
                cmbSY.Text = dr(6).ToString

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
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

    Private Sub frmAddEditTeacher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSY()

        If adding = True Then
            lblTitle.Text = "Adding Teacher Info"
            txtLastname.Text = ""
            txtFirstname.Text = ""
            txtMI.Text = ""
            txtSection.Text = ""
            txtSection.Tag = ""
            cmbSY.Text = ""
        Else
            lblTitle.Text = "Updating Teacher Info"
            GetTeacherInfo()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        isAddEditTeacher = True
        frmLoadSection.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class