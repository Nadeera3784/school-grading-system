
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms


Public Class frmTeacherSubjects

    Public isTeacherSubjects As Boolean
    Public tsGrade As String

    Private Sub frmTeacherSubjects_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtTeacherName.Text = frmTeacher.ListView1.FocusedItem.SubItems(1).Text
        txtTeacherName.Tag = frmTeacher.ListView1.FocusedItem.Text
        LoadTeacherSubjects()
        LockField()
        EnabledButton()
        CLearFields()
    End Sub

    Private Sub LockField()
        TextBox1.Enabled = False
        cmbSubjects.Enabled = False
    End Sub

    Private Sub UnlockField()
        TextBox1.Enabled = True
        cmbSubjects.Enabled = True
    End Sub

    Private Sub CLearFields()
        TextBox1.Text = ""
        cmbSubjects.Text = ""
    End Sub

    Private Sub EnabledButton()
        btnAdd.Enabled = True
        btnUpdate.Enabled = True
        btnDelete.Enabled = True
        ListView1.Enabled = True

        btnSection.Enabled = False
        btnSave.Enabled = False
        btnCancel.Enabled = False
    End Sub

    Private Sub DisabledButton()
        btnAdd.Enabled = False
        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        ListView1.Enabled = False


        btnSection.Enabled = True
        btnSave.Enabled = True
        btnCancel.Enabled = True
    End Sub


    Private Sub LoadTeacherSubjects()
        Try
            sqL = "SELECT TSId, Subject, CONCAT(GradeLevel, ' - ', SectionName) section FROM TeacherSubject ts INNER JOIN Section s ON ts.SectionNo = s.SectionNo Where TeacherNo = '" & frmTeacher.ListView1.FocusedItem.Text & "' ORDER BY Subject, GradeLevel"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader()

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr(0).ToString)
                x.SubItems.Add(dr(1))
                x.SubItems.Add(dr(2))

                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub



    Public Sub LoadSubjects(ByVal gradeLevel As String)
        cmbSubjects.Items.Clear()
        If gradeLevel = "Grade 7" Or gradeLevel = "Grade 8" Or gradeLevel = "Grade 9" Or gradeLevel = "Grade 10" Or gradeLevel = "Grade 11" Or gradeLevel = "Grade 12" Then
            cmbSubjects.Items.Add("Homeroom")
            cmbSubjects.Items.Add("Filipino")
            cmbSubjects.Items.Add("English")
            cmbSubjects.Items.Add("Mathematics")
            cmbSubjects.Items.Add("Science")
            cmbSubjects.Items.Add("AP")
            cmbSubjects.Items.Add("MAPEH")
            cmbSubjects.Items.Add("Research")
            cmbSubjects.Items.Add("Edukasyon sa Pagpapakatao")
            cmbSubjects.Items.Add("Conduct/Char. Build. Act")
            cmbSubjects.Items.Add("Current Issues/Geography")
            cmbSubjects.Items.Add("Comp./Tech and Livelihood Educ.")
            cmbSubjects.Items.Add("Foreign Language")
            ' cmbSubjects.Items.Add("General Average")
        Else
            cmbSubjects.Items.Add("Homeroom")
            cmbSubjects.Items.Add("Filipino")
            cmbSubjects.Items.Add("English")
            cmbSubjects.Items.Add("Mathematics")
            cmbSubjects.Items.Add("Science")
            cmbSubjects.Items.Add("AP")
            cmbSubjects.Items.Add("MAPEH")
            cmbSubjects.Items.Add("Reading/Speech")
            cmbSubjects.Items.Add("Edukasyon sa Pagpapakatao")
            cmbSubjects.Items.Add("Conduct/Char. Build. Act")
            cmbSubjects.Items.Add("Current Issues/Geography")
            cmbSubjects.Items.Add("Comp./Tech and Livelihood Educ.")
            cmbSubjects.Items.Add("Mother Tongue")
            ' cmbSubjects.Items.Add("General Average")

        End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        UnlockField()
        CLearFields()
        DisabledButton()
        adding = True
        editing = False

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If cmbSubjects.Text = "" Then
            MsgBox("Please select subject to update.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        UnlockField()
        DisabledButton()
        adding = False
        editing = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim strSQL As String

        If adding = True Then

            If ValidateTableData("SELECT * FROM TeacherSubject WHERE Subject = '" & cmbSubjects.Text & "' AND TeacherNo = '" & txtTeacherName.Tag & "' AND SectionNo = '" & TextBox1.Tag & "'") = True Then
                MsgBox("Subject already added to teacher.", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            If ValidateTableData("SELECT * FROM TeacherSubject WHERE Subject = '" & cmbSubjects.Text & "'  AND SectionNo = '" & TextBox1.Tag & "'") = True Then
                MsgBox("Subject already added to teacher.", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            ' Add TEacher Subject
            strSQL = "INSERT INTO TeacherSubject(Subject, SectionNo, TeacherNo) VALUES('" & cmbSubjects.Text & "', '" & TextBox1.Tag & "', '" & txtTeacherName.Tag & "')"
            If AddEditData(strSQL) = True Then
                MsgBox("Subject Added to Teacher Successfully", MsgBoxStyle.Information, "Add Subject to Teacher")
            End If

            CLearFields()
            LockField()
            LoadTeacherSubjects()
            EnabledButton()
        Else

            ' Update Teacher Subject
            strSQL = "UPDATE TeacherSubject SET Subject = '" & cmbSubjects.Text & "', SectionNo = '" & TextBox1.Tag & "' WHERE TSId = '" & cmbSubjects.Tag & "'"
            If AddEditData(strSQL) = True Then
                MsgBox("Teacher's Subject Updated Successfully", MsgBoxStyle.Information, "Update Subject Teacher")
            End If
            CLearFields()
            LockField()
            EnabledButton()
            LoadTeacherSubjects()


        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged
        cmbSubjects.Tag = ListView1.FocusedItem.Text
        cmbSubjects.Text = ListView1.FocusedItem.SubItems(1).Text
        TextBox1.Text = ListView1.FocusedItem.SubItems(2).Text
    End Sub

    Private Sub cmbGradeLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadSubjects(TextBox1.Text)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        CLearFields()
        LockField()
        LoadTeacherSubjects()
        EnabledButton()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If ListView1.FocusedItem.Text = "" Then
            MsgBox("Please select subject to delete.", MsgBoxStyle.Exclamation, "Delete")
            Exit Sub
        End If



        If MsgBox("Are you sure you want to delete", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Try
                sqL = "DELETE FROM TeacherSubject WHERE TSID = '" & ListView1.FocusedItem.Text & "'"
                ConnDB()
                cmd = New MySqlCommand(sqL, conn)
                Dim i As Integer = cmd.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Selected teacher subject successfully deleted.", MsgBoxStyle.Information, "Delete teacher subject")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                cmd.Dispose()
                conn.Close()
            End Try
            LoadTeacherSubjects()
            CLearFields()
        End If
    End Sub

    Private Sub btnSection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSection.Click
        isTeacherSubjects = True
        frmLoadSection.ShowDialog()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        'LoadSubjects(lblGrade.Text)
    End Sub
End Class