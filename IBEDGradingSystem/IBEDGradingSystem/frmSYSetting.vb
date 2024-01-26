
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmSYSetting



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please input school year.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        If TextBox1.Tag <> "" Then
            If AddEditData("UPDATE SY Set SYValue = '" & TextBox1.Text & "' WHERE SYId = '" & TextBox1.Tag & "'") = True Then
                MsgBox("Updated.", MsgBoxStyle.Information, "Update")
            End If
        Else
            If AddEditData("INSERT INTO SY(SYValue) VALUES('" & TextBox1.Text & "')") = True Then
                MsgBox("Added.", MsgBoxStyle.Information, "Add")
            End If

        End If

        LoadSY()
        TextBox1.Text = ""
        TextBox1.Tag = ""
        TextBox1.Focus()
    End Sub


    Private Sub LoadSY()
        Try
            sqL = "SELECT SYValue, SYId FROM SY ORDER BY SYValue"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr(0).ToString)
                x.SubItems.Add(dr(1))

                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If TextBox1.Tag = "" Then
            MsgBox("Please select School Year.", MsgBoxStyle.Exclamation, "Delete")
            Exit Sub
        End If

        If MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo, "Delete") = MsgBoxResult.Yes Then
            If AddEditData("DELETE FROM SY Where SYId = '" & TextBox1.Tag & "'") = True Then
                MsgBox("Deleted.", MsgBoxStyle.Information, "Delete")
            End If
            LoadSY()
            TextBox1.Text = ""
            TextBox1.Tag = ""
            TextBox1.Focus()
        End If
    End Sub

    Private Sub frmSYSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSY()
        TextBox1.Text = ""
        TextBox1.Tag = ""
        TextBox1.Focus()
    End Sub

    Private Sub ListView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.Click
        TextBox1.Text = ListView1.FocusedItem.Text
        TextBox1.Tag = ListView1.FocusedItem.SubItems(1).Text
    End Sub
End Class