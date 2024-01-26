Imports MySql.Data.MySqlClient
Imports System.Windows.Forms



Public Class frmTeacher

    Dim strSearch As String

    Public Sub LoadTeacher()
        Try
            sqL = "SELECT TeacherNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as TName, CONCAT(GradeLevel, ' - ',SectionName) as Section, SY FROM Teacher t LEFT JOIN Section s ON t.SectionNo = s.SectionNo WHERE Lastname LIKE '" & strSearch & "%' ORDER BY Lastname, Firstname"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr(0).ToString)
                x.SubItems.Add(dr(1).ToString)
                x.SubItems.Add(dr(2).ToString)
                x.SubItems.Add(dr(3).ToString)

                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Try

            If ListView1.Items.Count <= 0 Then
                MsgBox("No teacher to Update", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            If ListView1.FocusedItem.Text = "" Then
                MsgBox("Please Select teacher to Update", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            adding = False
            editing = True
            frmAddEditTeacher.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        adding = True
        editing = False
        frmAddEditTeacher.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        strSearch = InputBox("Enter Teacher Lastname : ", "Search Teacher")
        LoadTeacher()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        If MsgBox("Are you sure you want to delete the selected teacher?", MsgBoxStyle.YesNo, "Delete teacher") = MsgBoxResult.Yes Then
            AddEditData("DELETE FROM Teacher WHERE TeacherNo = '" & ListView1.FocusedItem.Text & "'")
            MsgBox("Teacher Deleted Successfully.", MsgBoxStyle.Information, "Delete")
            LoadTeacher()
        End If
    End Sub

    Private Sub frmTeacher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        LoadTeacher()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If ListView1.FocusedItem.Text <> "" Then
            frmTeacherSubjects.ShowDialog()
        End If
    End Sub
End Class