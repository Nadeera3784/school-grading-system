Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmStudent
    Dim strSearch As String
    Public isStudentFilter As Boolean
    Public grade As String = ""
    Public section As String = ""

    Private Sub frmStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Dock = Windows.Forms.DockStyle.Fill
        lblSection.Text = ""
        lblGrade.Text = ""
       
        txtSection.Text = frmMain.lblSection.Text
        If frmMain.lblRole.Text.ToUpper() = "ADMIN" Then
            btnSelect.Enabled = True
            cmbGrading.Enabled = True
            ToolStripButton2.Visible = True
            ToolStripButton3.Visible = True
            ToolStripButton4.Visible = True
            ToolStripButton6.Visible = True

        Else
            btnSelect.Enabled = False
            cmbGrading.Text = frmMain.lblSY.Text
            cmbGrading.Enabled = False
            ToolStripButton2.Visible = False
            ToolStripButton3.Visible = False
            ToolStripButton4.Visible = False
            ToolStripButton6.Visible = False
            LoadStudent()
        End If

    End Sub

    Public Sub LoadStudent()
        Try
            If frmMain.lblRole.Text.ToUpper() = "ADMIN" Then
                sqL = "SELECT StudentNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as StudName, Gender, CONCAT(GradeLevel, ' - ', SectionName) as Section FROM Student s LEFT JOIN Section sec ON s.SectionNo = sec.SectionNo WHERE Lastname LIKE '" & strSearch & "%' AND SY LIKE '" & cmbGrading.Text & "%' AND s.SectionNo LIKE '" & lblSection.Tag & "%' AND GradeLevel LIKE '" & lblGrade.Text & "%'  ORDER BY Lastname,Firstname"
            Else
                sqL = "SELECT StudentNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as StudName, Gender, CONCAT(GradeLevel, ' - ', SectionName) as Section FROM Student s LEFT JOIN Section sec ON s.SectionNo = sec.SectionNo WHERE Lastname LIKE '" & strSearch & "%' AND SY LIKE '" & frmMain.lblSY.Text & "%' AND s.SectionNo = '" & frmMain.lblSection.Tag & "' AND GradeLevel LIKE '" & lblGrade.Text & "%'  ORDER BY Lastname,Firstname"
            End If

            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            ListView1.Items.Clear()
            ListView1.Items.Add("")
            Dim x As ListViewItem
            Do While dr.Read = True
                x = New ListViewItem(dr(0).ToString)
                x.SubItems.Add(dr(1).ToString)
                x.SubItems.Add(dr(2).ToString)
                x.SubItems.Add(dr(3).ToString)

                ListView1.Items.Add(x)

            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

      
    End Sub

    Private Sub DeleteStudent()
        Try
            sqL = "DELETE FROM Student WHERE StudentNo = '" & ListView1.FocusedItem.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                MsgBox("Student Successfully Deleted", MsgBoxStyle.Information, "Delete Student")
            End If



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
                MsgBox("No Student to Update", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            If ListView1.FocusedItem.Text = "" Then
                MsgBox("Please Select Student to Update", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            adding = False
            editing = True
            frmAddEditStudent.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        adding = True
        editing = False
        frmAddEditStudent.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        strSearch = InputBox("Enter student last name : ", "Search Student")
        LoadStudent()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        isStudentFilter = True
        frmLoadSection.ShowDialog()
    End Sub

    Private Sub txtSection_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSection.TextChanged
        'LoadStudent()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        If MsgBox("Are you sure you want to delete?", MsgBoxStyle.YesNo, "Delete Student") = MsgBoxResult.Yes Then
            DeleteStudent()
            LoadStudent()
        End If
    End Sub

    Private Sub cmbGrading_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrading.SelectedIndexChanged
        'LoadStudent()
    End Sub
End Class