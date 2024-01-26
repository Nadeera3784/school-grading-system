
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmLoadStudent

    Public isLoadStudent As Boolean

    Private Sub LoadStudent()
        Try
            If frmMain.lblRole.Text.ToUpper() = "ADMIN" Then
                sqL = "SELECT StudentNo, CONCAT(Lastname, ', ', Firstname, ' ', MI,'.') as SName, Gender FROM Student WHERE SectionNo = '" & txtSection.Tag & "' AND Lastname LIKE '" & txtLastname.Text & "%' ORDER BY Lastname, Firstname"
                btnBrowse.Enabled = True
                txtSection.Text = ""
            Else
                sqL = "SELECT StudentNo, CONCAT(Lastname, ', ', Firstname, ' ', MI,'.') as SName, Gender FROM Student WHERE SectionNo = '" & frmMain.lblSection.Tag & "' AND Lastname LIKE '" & txtLastname.Text & "%' ORDER BY Lastname, Firstname"
                btnBrowse.Enabled = False
                txtSection.Text = frmMain.lblSection.Text
            End If

            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr(0).ToString)
                x.SubItems.Add(dr(1).ToString)
                x.SubItems.Add(dr(2).ToString)
                x.SubItems.Add(txtSection.Text)

                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

   

    Private Sub txtLastname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLastname.TextChanged
        LoadStudent()
    End Sub

    Private Sub txtSection_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSection.TextChanged
        LoadStudent()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click
        isLoadStudent = True
        frmLoadSection.ShowDialog()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        frmAddEditAbsentLate.txtName.Tag = ListView1.FocusedItem.Text
        frmAddEditAbsentLate.txtName.Text = ListView1.FocusedItem.SubItems(1).Text
        Me.Close()
    End Sub

    Private Sub frmLoadStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadStudent()
    End Sub
End Class