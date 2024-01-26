Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmSubject

    Dim strSearch As String

    Private Sub frmSubject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Dock = Windows.Forms.DockStyle.Fill
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        adding = True
        editing = False
        frmAddEditSubject.ShowDialog()
    End Sub

    Public Sub LoadSubject()
        Try
            sqL = "SELECT SubjectNo, SubjectName FROM Subject WHERE SubjectName LIKE '" & strSearch & "%' ORDER BY SubjectName"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            ListView1.Items.Clear()
            Dim x As ListViewItem
            Do While dr.Read = True
                x = New ListViewItem(dr(0).ToString())
                x.SubItems.Add(dr(1).ToString())

                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        strSearch = InputBox("Enter subject name : ", "Search Subject")
        LoadSubject()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Try

            If ListView1.Items.Count <= 0 Then
                MsgBox("Please Subject to Update", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            If ListView1.FocusedItem.Text = "" Then
                MsgBox("Please Subject to Update", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            adding = False
            editing = True
            frmAddEditSubject.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class