
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Drawing

Public Class frmGrades

    Public isGradeSection As Boolean
    Public gradesGrade As String

    Dim strSearch As String

    Private Function CreateSubQuery()
        Dim query As String = ""
        Dim subQuery As String = ""
        Dim i As Integer = 1
        Dim subject As String = "sub"


        subQuery = subQuery & "(Select gradeRate from ibedgrading_db.grade where subjectNo = '1' and gradingperiod ='" & cmbGrading.Text & "') as Fil, "
        subQuery = subQuery & "(Select gradeRate from ibedgrading_db.grade where subjectNo = '2' and gradingperiod ='" & cmbGrading.Text & "') as Eng, "
        subQuery = subQuery & "(Select gradeRate from ibedgrading_db.grade where subjectNo = '3' and gradingperiod ='" & cmbGrading.Text & "') as Mat, "
        subQuery = subQuery & "(Select gradeRate from ibedgrading_db.grade where subjectNo = '4' and gradingperiod ='" & cmbGrading.Text & "') as ST, "
        subQuery = subQuery & "(Select gradeRate from ibedgrading_db.grade where subjectNo = '5' and gradingperiod ='" & cmbGrading.Text & "') as AP, "
        subQuery = subQuery & "(Select gradeRate from ibedgrading_db.grade where subjectNo = '6' and gradingperiod ='" & cmbGrading.Text & "') as TLE, "
        subQuery = subQuery & "(Select gradeRate from ibedgrading_db.grade where subjectNo = '7' and gradingperiod ='" & cmbGrading.Text & "') as MAP, "
        subQuery = subQuery & "(Select gradeRate from ibedgrading_db.grade where subjectNo = '8' and gradingperiod ='" & cmbGrading.Text & "') as CLE, "
        subQuery = subQuery & "(Select gradeRate from ibedgrading_db.grade where subjectNo = '9' and gradingperiod ='" & cmbGrading.Text & "') as ELE, "


        Return subQuery
    End Function


    Public Sub LoadGrades()

        Try

            If frmMain.lblRole.Text.ToUpper() = "ADMIN" Then
                sqL = "SELECT s.StudentNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as StudName, CONCAT(GradeLevel, ' - ', SectionName) as Section, GradingPeriod, Filipino, English, Math, Science, AP,  MAPEH, Homeroom, RR, EP, CCBA, Computer, Language, CIG FROM Student s LEFT JOIN Section sec ON s.SectionNo = sec.SectionNo LEFT JOIN Grade g ON g.StudentNo = s.StudentNo WHERE sec.SectionNo = '" & txtSection.Tag & "' AND GradingPeriod LIKE '" & cmbGrading.Text & "' AND Lastname LIKE '" & strSearch & "%' ORDER BY Lastname, Firstname"
            Else
                sqL = "SELECT s.StudentNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as StudName, CONCAT(GradeLevel, ' - ', SectionName) as Section, GradingPeriod, Filipino, English, Math, Science, AP,  MAPEH, Homeroom, RR, EP, CCBA, Computer, Language, CIG FROM Student s LEFT JOIN Section sec ON s.SectionNo = sec.SectionNo LEFT JOIN Grade g ON g.StudentNo = s.StudentNo WHERE s.SectionNo = '" & frmMain.lblSection.Tag & "' AND GradingPeriod LIKE '" & cmbGrading.Text & "' AND Lastname LIKE '" & strSearch & "%' ORDER BY Lastname, Firstname"
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
                x.SubItems.Add(dr(3).ToString)
                x.SubItems.Add(dr(4).ToString)
                x.SubItems.Add(dr(5).ToString)
                x.SubItems.Add(dr(6).ToString)
                x.SubItems.Add(dr(7).ToString)
                x.SubItems.Add(dr(8).ToString)
                x.SubItems.Add(dr(9).ToString)
                x.SubItems.Add(dr(10).ToString)
                x.SubItems.Add(dr(11).ToString)
                x.SubItems.Add(dr(12).ToString)
                x.SubItems.Add(dr(13).ToString)
                x.SubItems.Add(dr(14).ToString)
                x.SubItems.Add(dr(15).ToString)
                x.SubItems.Add(dr(16).ToString)

                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub frmGrades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Dock = DockStyle.Fill
        txtSection.Text = frmMain.lblSection.Text
        If frmMain.lblRole.Text.ToUpper() = "ADMIN" Then
            btnSelect.Enabled = True
        Else
            btnSelect.Enabled = False
        End If
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click
        isGradeSection = True
        frmLoadSection.ShowDialog()
    End Sub


    Private Sub txtSection_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSection.TextChanged
        LoadGrades()
    End Sub

    Private Sub cmbGrading_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrading.SelectedIndexChanged
        LoadGrades()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click


        If txtSection.Text = "" Then
            MsgBox("Please select section.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        ElseIf cmbGrading.Text = "" Then
            MsgBox("Please select grading period.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        adding = True
        editing = False
        frmAddingGrade.ShowDialog()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick
        'frmEditingGrade.ShowDialog()
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
            frmAddingGrade.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        strSearch = InputBox("Enter Student Lastname : ", "Search By Lastname")
        LoadGrades()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        strSearch = ""
        LoadGrades()

        If txtSection.Text = "" Then
            MsgBox("Please select section.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        ElseIf cmbGrading.Text = "" Then
            MsgBox("Please select grading period.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        frmGradingReport.ShowDialog()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        Try

            If ListView1.Items.Count <= 0 Then

                Exit Sub
            End If



            frmStudentGrades.Show()
        Catch ex As Exception

        End Try
    End Sub



    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGradePerStudent.Show()
    End Sub


    Private Sub ListView1_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDown
        Try
            If IsNothing(ListView1.FocusedItem) Then Exit Sub
            If e.Button = MouseButtons.Right Then
                If ListView1.SelectedItems.Count > 0 Then
                    ContextMenuStrip1.Show(ListView1, New Point(e.X, e.Y))
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        If ListView1.FocusedItem.Text <> "" Then
            frmGradePerStudent.Show()
        Else
            MsgBox("Please select student grade to print.", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub
End Class