Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmComputeSubjectGrade

    Public isComputingGrade As Boolean

    Public Sub LoadSubjects()
        Try
            sqL = "SELECT Subject FROM TeacherSubject WHERE TeacherNo = '" & txtLogTeacher.Tag & "' AND SectionNo = '" & txtSection.Tag & "' ORDER BY Subject"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            cmbSubject.Text = ""
            cmbSubject.Items.Clear()
            Do While dr.Read = True
                cmbSubject.Items.Add(dr(0).ToString)
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Public Sub LoadSubjectGrade(ByVal gender As String)
        Try
            sqL = "SELECT SGID, CONCAT(Lastname, ', ', Firstname, ' ', MI) as SName,  KQuiz, KExam, KTotal, KEquivalent, KPercent, PQuiz, PExam, PTotal, PEquivalent, UPercent, UQuiz, UExam, UTotal, UEquivalent, UPercent, PPPP, PPEquivalent, PPPercent, FG, LG, TIQuiz, TIExam FROM SubjectGrade sg INNER JOIN Student s ON sg.StudentNo = s.StudentNo WHERE sg.SY = '" & cmbSY.Text & "' AND Subject = '" & cmbSubject.Text & "' AND sg.SectionNo = '" & txtSection.Tag & "' AND sg.GradingPeriod = '" & cmbGrading.Text & "' AND Gender= '" & gender & "' ORDER BY Lastname, Firstname"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader


            Dim x As ListViewItem

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
                x.SubItems.Add(dr(17).ToString)
                x.SubItems.Add(dr(18).ToString)
                x.SubItems.Add(dr(19).ToString)
                x.SubItems.Add(dr(20).ToString)
                x.SubItems.Add(dr(21).ToString)
                x.SubItems.Add(dr(22).ToString)
                x.SubItems.Add(dr(23).ToString)

                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Function validateFields()
        Dim ret As Boolean = False

        If cmbSY.Text = "" Or txtSection.Text = "" Or cmbSubject.Text = "" Or cmbGrading.Text = "" Then
            ret = False
        Else
            ret = True
        End If

        Return ret

    End Function


    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        If validateFields() = False Then
            MsgBox("Please fill in all the fields.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        If ValidateTableData("SELECT  KQuiz, KExam, PQuiz, PExam, UQuiz, UExam, PPTotal FROM SubjectMaxScore WHERE TeacherNo = '" & Me.txtLogTeacher.Tag & "' AND SY = '" & Me.cmbSY.Text & "' AND GradeLevel = '" & Me.lblGrade.Text & "' AND Subject  =  '" & Me.cmbSubject.Text & "' AND GradingPeriod = '" & Me.cmbGrading.Text & "'") = False Then
            MsgBox("Please add Max Score first before adding Computing Grade.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If


        adding = True
        editing = False
        frmAddEditComputeGrade.ShowDialog()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Try

            If ListView1.Items.Count <= 0 Then
                MsgBox("No Student Grade to Update", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            If ListView1.FocusedItem.Text = "" Then
                MsgBox("Please Select Student Grade to Update", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If
            adding = False
            editing = True
            frmAddEditComputeGrade.ShowDialog()
        Catch ex As Exception

        End Try

       
    End Sub

    Private Sub cmbGrading_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGrading.SelectedIndexChanged
       loadRecordGrades
    End Sub

    Private Sub cmbSubject_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubject.SelectedIndexChanged
      loadRecordGrades
    End Sub


    Public Sub loadRecordGrades()
        ListView1.Items.Clear()
        SubjectMaxScore()

        Dim x As ListViewItem
        x = New ListViewItem("")
        x.SubItems.Add("NAME OF STUDENTS")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        x.SubItems.Add("")
        ListView1.Items.Add(x)

        LoadSubjectGrade("Male")

        Dim y As ListViewItem
        y = New ListViewItem("")
        y.SubItems.Add("GIRLS")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        y.SubItems.Add("")
        ListView1.Items.Add(y)

        LoadSubjectGrade("Female")
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        isComputingGrade = True
        frmSelectSectionForST.ShowDialog()
    End Sub

    Private Sub txtSection_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSection.TextChanged
        loadRecordGrades()
        LoadSubjects()
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        If validateFields() = False Then
            MsgBox("Please fill in all the fields.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        frmSubjectMaxScore.ShowDialog()
    End Sub

    Private Sub LoadSY()
        Try
            sqL = "SELECT SYValue FROM SY ORDER BY SYValue "
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader
            cmbSY.Items.Clear()
            cmbSY.Items.Add("")
            Do While dr.Read = True
                cmbSY.Items.Add(dr(0).ToString)

            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub frmComputeSubjectGrade_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        LoadSY()
    End Sub

    Private Sub frmComputeSubjectGrade_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'Application.Exit()
        frmLogin.txtUsername.Text = ""
        frmLogin.txtPassword.Text = ""
        frmLogin.ComboBox1.Text = ""
        frmLogin.Show()
        frmLogin.txtUsername.Focus()
    End Sub


    Private Sub frmComputeSubjectGrade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SubjectMaxScore()
        Try
            sqL = "SELECT  KQuiz, KExam, PQuiz, PExam, UQuiz, UExam, PPTotal FROM SubjectMaxScore WHERE TeacherNo = '" & Me.txtLogTeacher.Tag & "' AND SY = '" & Me.cmbSY.Text & "' AND GradeLevel = '" & Me.lblGrade.Text & "' AND Subject  =  '" & Me.cmbSubject.Text & "' AND GradingPeriod = '" & Me.cmbGrading.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            Dim kTotal, pTotal, Utotal, totalQuiz, totalExam As Integer


            Do While dr.Read = True
                'Knowledege
                totalQuiz = Val(dr(0)) + Val(dr(2)) + Val(dr(4))
                totalExam = Val(dr(1)) + Val(dr(3)) + Val(dr(5))
                x = New ListViewItem("")
                x.SubItems.Add("")
                x.SubItems.Add(dr(0).ToString)
                x.SubItems.Add(dr(1).ToString)
                kTotal = Val(dr(0)) + Val(dr(1))
                x.SubItems.Add(kTotal.ToString)
                x.SubItems.Add("") 'GetTotalEquivalent(kTotal, kTotal).ToString)
                x.SubItems.Add("15%")

                'Process/skills
                x.SubItems.Add(dr(2).ToString)
                x.SubItems.Add(dr(3).ToString)
                pTotal = Val(dr(2)) + Val(dr(3))
                x.SubItems.Add(pTotal.ToString)
                x.SubItems.Add("") 'GetTotalEquivalent(pTotal, pTotal))
                x.SubItems.Add("25%")

                'Understanding
                x.SubItems.Add(dr(4).ToString)
                x.SubItems.Add(dr(5).ToString)
                Utotal = Val(dr(4)) + Val(dr(5))
                x.SubItems.Add(pTotal.ToString)
                x.SubItems.Add("") 'GetTotalEquivalent(Utotal, Utotal))
                x.SubItems.Add("30%")

                'Performance
                x.SubItems.Add(dr(6).ToString)
                x.SubItems.Add("") 'GetTotalEquivalent(dr(6), dr(6)))
                x.SubItems.Add("30%")

                x.SubItems.Add("100%")
                x.SubItems.Add("")
                x.SubItems.Add(totalQuiz)
                x.SubItems.Add(totalExam)

                ListView1.Items.Add(x)
            Loop


        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        If validateFields() = False Then
            MsgBox("Please fill in all the fields.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If
        frmGradingSheetReport.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub
End Class