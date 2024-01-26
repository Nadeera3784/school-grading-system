
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmGradingSheetReport

    Private Sub frmGradingSheetReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ibedgrading_dbDataSet.tempsubjectgrade' table. You can move, or remove it, as needed.
        ' Me.tempsubjectgradeTableAdapter.Fill(Me.ibedgrading_dbDataSet.tempsubjectgrade)
        'Delete Existing Data if any
        AddEditData("Delete  FROM TempSubjectGrade")
        'Adding TempData
        AddTempGradingReport()

        ' Me.ReportViewer1.RefreshReport()
        LoadReport()

    End Sub

    Private Sub LoadReport()
        Try
            sqL = "SELECT * FROM TempSubjectGrade"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)

          


            Me.ibedgrading_dbDataSet.tempsubjectgrade.Clear()
            da.Fill(Me.ibedgrading_dbDataSet.tempsubjectgrade)


            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub


    Public Sub AddTempGradingReport()
        Try
            sqL = "INSERT INTO TempSubjectGrade(KQuiz, KExam, KTotal, KEquivalent, KPercent, PQuiz, PExam, PTotal, PEquivalent, PPercent, UQuiz, UExam, UTotal, UEquivalent, UPercent, PPPP, PPEquivalent, PPPercent, FG, LG, TIQuiz, TIExam, StudentName, TeacherName, SY, GradeSection, GradeSubject, GradingPeriod) "
            sqL = sqL & " VALUES(@KQuiz, @KExam, @KTotal, @KEquivalent, @KPercent, @PQuiz, @PExam, @PTotal, @PEquivalent, @PPercent, @UQuiz, @UExam, @UTotal, @UEquivalent, @UPercent, @PPPP, @PPEquivalent, @PPPercent, @FG, @LG, @TIQuiz, @TIExam, @StudentName, @TeacherName, @SY, @GradeSection, @GradeSubject, @GradingPeriod)"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.Add("KQuiz", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("KExam", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("KTotal", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("KEquivalent", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("KPercent", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("PQuiz", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("PExam", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("PTotal", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("PEquivalent", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("PPercent", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("UQuiz", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("UExam", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("UTotal", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("UEquivalent", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("UPercent", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("PPPP", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("PPEquivalent", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("PPPercent", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("FG", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("LG", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("TIQuiz", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("TIExam", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("StudentName", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("TeacherName", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("SY", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("GradeSection", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("GradeSubject", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("GradingPeriod", MySql.Data.MySqlClient.MySqlDbType.VarChar)
           


            With frmComputeSubjectGrade.ListView1
                For i As Integer = 0 To .Items.Count - 1
                    cmd.Parameters("KQuiz").Value = .Items(i).SubItems(2).Text
                    cmd.Parameters("KExam").Value = .Items(i).SubItems(3).Text
                    cmd.Parameters("KTotal").Value = .Items(i).SubItems(4).Text
                    cmd.Parameters("KEquivalent").Value = .Items(i).SubItems(5).Text
                    cmd.Parameters("KPercent").Value = .Items(i).SubItems(6).Text
                    cmd.Parameters("PQuiz").Value = .Items(i).SubItems(7).Text
                    cmd.Parameters("PExam").Value = .Items(i).SubItems(8).Text
                    cmd.Parameters("PTotal").Value = .Items(i).SubItems(9).Text
                    cmd.Parameters("PEquivalent").Value = .Items(i).SubItems(10).Text
                    cmd.Parameters("PPercent").Value = .Items(i).SubItems(11).Text
                    cmd.Parameters("UQuiz").Value = .Items(i).SubItems(12).Text
                    cmd.Parameters("UExam").Value = .Items(i).SubItems(13).Text
                    cmd.Parameters("UTotal").Value = .Items(i).SubItems(14).Text
                    cmd.Parameters("UEquivalent").Value = .Items(i).SubItems(15).Text
                    cmd.Parameters("UPercent").Value = .Items(i).SubItems(16).Text
                    cmd.Parameters("PPPP").Value = .Items(i).SubItems(17).Text
                    cmd.Parameters("PPEquivalent").Value = .Items(i).SubItems(18).Text
                    cmd.Parameters("PPPercent").Value = .Items(i).SubItems(19).Text
                    cmd.Parameters("FG").Value = .Items(i).SubItems(20).Text
                    cmd.Parameters("LG").Value = .Items(i).SubItems(21).Text
                    cmd.Parameters("TIQuiz").Value = .Items(i).SubItems(22).Text
                    cmd.Parameters("TIExam").Value = .Items(i).SubItems(23).Text
                    cmd.Parameters("StudentName").Value = .Items(i).SubItems(1).Text
                    cmd.Parameters("TeacherName").Value = frmComputeSubjectGrade.txtLogTeacher.Text
                    cmd.Parameters("SY").Value = frmComputeSubjectGrade.cmbSY.Text
                    cmd.Parameters("GradeSection").Value = frmComputeSubjectGrade.lblGrade.Text & " - " & frmComputeSubjectGrade.txtSection.Text
                    cmd.Parameters("GradeSubject").Value = frmComputeSubjectGrade.lblGrade.Text & " " & frmComputeSubjectGrade.cmbSubject.Text
                    If frmComputeSubjectGrade.cmbGrading.Text = "First" Then
                        cmd.Parameters("GradingPeriod").Value = "1st Quarter Grades"
                    ElseIf frmComputeSubjectGrade.cmbGrading.Text = "Second" Then
                        cmd.Parameters("GradingPeriod").Value = "2nd Quarter Grades"
                    ElseIf frmComputeSubjectGrade.cmbGrading.Text = "Third" Then
                        cmd.Parameters("GradingPeriod").Value = "3rd Quarter Grades"
                    ElseIf frmComputeSubjectGrade.cmbGrading.Text = "Fourth" Then
                        cmd.Parameters("GradingPeriod").Value = "4th Quarter Grades"
                    End If
                    cmd.ExecuteNonQuery()
                Next
            End With

            ' MsgBox("Added Successfully", MsgBoxStyle.Information, "Adding")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub
End Class