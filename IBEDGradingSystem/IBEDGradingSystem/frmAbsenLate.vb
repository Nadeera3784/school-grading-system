Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmAbsenLate

    Public isAbsentLate As Boolean
    Dim strSearch As String

    Public Sub LoadAL()
        DeleteColumns()


        ListView1.Items.Clear()

        If cmbGrading.Text = "First" Then
            ListView1.Columns.Add("June").Width = 100
            ListView1.Columns.Add("July").Width = 100
            ListView1.Columns.Add("August").Width = 100

        ElseIf cmbGrading.Text = "Second" Then
            ListView1.Columns.Add("September").Width = 100
            ListView1.Columns.Add("October").Width = 100
            ListView1.Columns.Add("November").Width = 100



        ElseIf cmbGrading.Text = "Third" Then
            ListView1.Columns.Add("December").Width = 100
            ListView1.Columns.Add("January").Width = 100
            ListView1.Columns.Add("").Width = 0


        ElseIf cmbGrading.Text = "Fourth" Then
            ListView1.Columns.Add("February").Width = 100
            ListView1.Columns.Add("March").Width = 100
            ListView1.Columns.Add("").Width = 0


        End If


        Try
            If frmMain.lblRole.Text.ToUpper() = "ADMIN" Then
                sqL = "SELECT al.ALNo, CONCAT(Lastname, ', ', Firstname, ' ', MI,'.') as Sname, CONCAT(GradeLevel,' - ',SectionName) as Section, GradingPeriod, FMA, FML, SMA, SML, TMA, TML FROM Student s Inner Join Section sec ON s.SectionNo = sec.SectionNo Inner Join AbsentLate al ON s.StudentNo = al.StudentNo WHERE al.GradingPeriod LIKE '" & cmbGrading.Text & "%' AND SectionName LIKE '" & lblSection.Text & "%' AND GradeLevel LIKE '" & lblGrade.Text & "' AND Lastname LIKE '" & strSearch & "%' ORDER BY Lastname, Firstname"
            Else
                sqL = "SELECT al.ALNo, CONCAT(Lastname, ', ', Firstname, ' ', MI,'.') as Sname, CONCAT(GradeLevel,' - ',SectionName) as Section, GradingPeriod, FMA, FML, SMA, SML, TMA, TML FROM Student s Inner Join Section sec ON s.SectionNo = sec.SectionNo Inner Join AbsentLate al ON s.StudentNo = al.StudentNo WHERE al.GradingPeriod LIKE '" & cmbGrading.Text & "%' AND sec.SectionNo LIKE '" & frmMain.lblSection.Tag & "%'  AND Lastname LIKE '" & strSearch & "%' ORDER BY Lastname, Firstname"
            End If

            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            Dim x As ListViewItem = Nothing
            x = New ListViewItem("")
            x.SubItems.Add("")
            x.SubItems.Add("")
            x.SubItems.Add("")
            x.SubItems.Add("Dos|DP")
            x.SubItems.Add("Dos|DP")
            x.SubItems.Add("Dos|DP")
            ListView1.Items.Add(x)

            Dim x2 As ListViewItem
            Do While dr.Read = True
                x2 = New ListViewItem(dr(0).ToString)
                x2.SubItems.Add(dr(1).ToString)
                x2.SubItems.Add(dr(2).ToString)
                x2.SubItems.Add(dr(3).ToString)
                x2.SubItems.Add("   " & dr(4) & "     |   " & dr(5))
                x2.SubItems.Add("   " & dr(6) & "     |   " & dr(7))
                x2.SubItems.Add("   " & dr(8) & "     |   " & dr(9))

                ListView1.Items.Add(x2)
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Dispose()
        End Try

    End Sub


    Private Sub frmAbsenLate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        txtSection.Text = frmMain.lblSection.Text
        If frmMain.lblRole.Text.ToUpper() = "ADMIN" Then
            btnSelect.Enabled = True
        Else
            btnSelect.Enabled = False
        End If
    End Sub

    Private Sub DeleteColumns()
        For Each col As ColumnHeader In Me.ListView1.Columns
            If col.Text = "June" Or col.Text = "July" Or col.Text = "August" Or col.Text = "September" Or col.Text = "October" Or col.Text = "November" Or col.Text = "December" Or col.Text = "January" Or col.Text = "February" Or col.Text = "March" Or col.Text = "" Then
                Me.ListView1.Columns.Remove(col)
            End If
        Next
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click

        If txtSection.Text = "" Then
            MsgBox("Please select section.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        If cmbGrading.Text = "" Then
            MsgBox("Please select Grading Period.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        adding = True
        editing = False
        frmAddEditAbsentLate.ShowDialog()

    End Sub

    Private Sub cmbGrading_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrading.SelectedIndexChanged
        LoadAL()
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        isAbsentLate = True
        frmLoadSection.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        If txtSection.Text = "" Then
            MsgBox("Please select section.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        If cmbGrading.Text = "" Then
            MsgBox("Please select Grading Period.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

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
            frmAddEditAbsentLate.ShowDialog()
        Catch ex As Exception
            MsgBox("Please Select Student to Update", MsgBoxStyle.Exclamation, "Warning")
        End Try
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        strSearch = InputBox("Enter Student Lastname :", "Search Student")
        LoadAL()
    End Sub

    Private Sub txtSection_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSection.TextChanged
        'LoadAL()
    End Sub
End Class