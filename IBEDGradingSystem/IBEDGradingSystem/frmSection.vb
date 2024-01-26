Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmSection

    Dim strSearch As String

    Public Sub LoadSection()
        Try
            sqL = "SELECT SectionNo, GradeLevel, SectionName FROM SECTION Where SectionName LIKE '" & strSearch & "%' ORDER By SectionNo"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            ListView1.Items.Clear()
            Dim x As ListViewItem

            Do While dr.Read = True
                x = New ListViewItem(dr(0).ToString())
                x.SubItems.Add(dr(1).ToString)
                x.SubItems.Add(dr(2).ToString)

                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub frmSection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Dock = Windows.Forms.DockStyle.Fill
        LoadSection()
    End Sub


    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        strSearch = InputBox("Enter section name : ", "Search Section")
        LoadSection()
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
            frmAddEditSection.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        adding = True
        editing = False
        frmAddEditSection.ShowDialog()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        If MsgBox("Are you sure you want to delete the selected section?", MsgBoxStyle.YesNo, "Warning") = MsgBoxResult.Yes Then
            Try
                sqL = "DELETE FROM Section WHERE SectionNo = '" & ListView1.FocusedItem.Text & "'"
                ConnDB()
                cmd = New MySqlCommand(sqL, conn)
                Dim i As Integer = cmd.ExecuteNonQuery

                If i > 0 Then
                    MsgBox("Section Deleted Successfully.", MsgBoxStyle.Information, "Delete Section")
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                cmd.Dispose()
                conn.Close()
            End Try

            LoadSection()
        End If
    End Sub
End Class