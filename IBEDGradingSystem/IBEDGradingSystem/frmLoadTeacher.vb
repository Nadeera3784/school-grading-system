Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmLoadTeacher

    Private Sub LoadTeacher()
        Try
            sqL = "SELECT TeacherNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as TName, SectionName FROM Teacher t LEFT JOIN Section s ON t.SectionNo = s.SectionNo WHERE Lastname LIKE '" & TextBox1.Text & "%' ORDER BY Lastname, Firstname"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr(0).ToString)
                x.SubItems.Add(dr(1).ToString)
                x.SubItems.Add(dr(2).ToString)


                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub frmLoadTeacher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadTeacher()
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        LoadTeacher()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        If frmComputeSubjectGradeMain.isComputingGradeTeacher = True Then
            frmComputeSubjectGradeMain.txtLogTeacher.Tag = ListView1.FocusedItem.Text
            frmComputeSubjectGradeMain.txtLogTeacher.Text = ListView1.FocusedItem.SubItems(1).Text
            Me.Close()
        Else
            frmUser.txtTeacher.Tag = ListView1.FocusedItem.Text
            frmUser.txtTeacher.Text = ListView1.FocusedItem.SubItems(1).Text
            Me.Close()
        End If

       
    End Sub
End Class