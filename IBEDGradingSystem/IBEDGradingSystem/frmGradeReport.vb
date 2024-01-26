Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Drawing


Public Class frmGradeReport

    Dim arrCtr As Integer

    Private Sub LoadGradingReport(ByVal gender As String)
        Try
            sqL = "SELECT CONCAT(Lastname, ', ', Firstname, ' ', MI,'.') as StudName, Filipino, English, Math, Science, AP, TLE, MAPEH, CLE, Elective, FMA, FML, SMA, SML, TMA, TML FROM Student s INNER JOIN Grade g ON s.StudentNo = g.StudentNo LEFT OUTER JOIN AbsentLate al ON al.StudentNo = s.StudentNo WHERE SectionNo = '" & frmGrades.txtSection.Tag & "' AND g.GradingPeriod = '" & frmGrades.cmbGrading.Text & "' AND Gender = '" & gender & "' AND al.GradingPeriod = '" & frmGrades.cmbGrading.Text & "' ORDER BY Lastname, Firstname"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader


            Dim tot As Double = 0.0
            Dim ave As Double = 0.0
            Dim ctr As Integer = 1
            Do While dr.Read = True
                tot = Val(dr(1)) + Val(dr(2)) + Val(dr(3)) + Val(dr(4)) + Val(dr(5)) + Val(dr(6)) + Val(dr(7)) + Val(dr(8)) + Val(dr(9))
                ave = tot / 9
                dgw.Rows.Add("[" & ctr & "] " & dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8), dr(9), dr(10) & "|" & dr(11), dr(12) & "|" & dr(13), dr(14) & "|" & dr(15), tot, Format(ave, "#,##0.00"), "")
                ctr = ctr + 1
            Loop

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub GetHonor()
        Try
            sqL = "SELECT CONCAT(Lastname, ', ', Firstname, ' ', MI, '.') as StudName, (Filipino + English + Math + Science + AP + TLE + MAPEH + CLE + Elective) as TotalGrade FROM Student s INNER JOIN Grade g ON s.StudentNo = g.StudentNo WHERE SectionNo = '" & frmGrades.txtSection.Tag & "' AND GradingPeriod = '" & frmGrades.cmbGrading.Text & "' ORDER BY TotalGrade DESC"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader


            Do While dr.Read = True
                Ranking(dr(1).ToString)
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub Ranking(ByVal studName As Double)
        Dim counter As Integer
        Dim rank() As String = {"1st", "2nd", "3rd", "4th", "5th", "6th", "7th", "8th", "9th", "10th"}

        For counter = 0 To dgw.Rows.Count - 1
            If studName = dgw.Rows(counter).Cells(13).Value Then
                dgw.Rows(counter).Cells(15).Value = rank(arrCtr)
                arrCtr = arrCtr + 1
            End If
        Next
    End Sub

    Public Sub AddTempReport()
        Try
            sqL = "INSERT INTO TempGradingReport(StudentName, Filipino, English, Math, Science, AP, TLE, MAPEH, CLE, Elective, FMAL, SMAL, TMAL, TOTAL, Average, Honor, Section, GradingPeriod) "
            sqL = sqL & " VALUES(@StudentName, @Filipino, @English, @Math, @Science, @AP, @TLE, @MAPEH, @CLE, @Elective, @FMAL, @SMAL, @TMAL, @TOTAL, @Average, @Honor, @Section, @GradingPeriod)"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.Add("StudentName", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("Filipino", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("English", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("Math", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("Science", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("AP", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("TLE", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("MAPEH", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("CLE", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("Elective", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("FMAL", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("SMAL", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("TMAL", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("TOTAL", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("Average", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("Honor", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("Section", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("GradingPeriod", MySql.Data.MySqlClient.MySqlDbType.VarChar)


            For i As Integer = 0 To dgw.Rows.Count - 1
                cmd.Parameters("StudentName").Value = dgw.Rows(i).Cells(0).Value
                cmd.Parameters("Filipino").Value = dgw.Rows(i).Cells(1).Value
                cmd.Parameters("English").Value = dgw.Rows(i).Cells(2).Value
                cmd.Parameters("Math").Value = dgw.Rows(i).Cells(3).Value
                cmd.Parameters("Science").Value = dgw.Rows(i).Cells(4).Value
                cmd.Parameters("AP").Value = dgw.Rows(i).Cells(5).Value
                cmd.Parameters("TLE").Value = dgw.Rows(i).Cells(6).Value
                cmd.Parameters("MAPEH").Value = dgw.Rows(i).Cells(7).Value
                cmd.Parameters("CLE").Value = dgw.Rows(i).Cells(8).Value
                cmd.Parameters("Elective").Value = dgw.Rows(i).Cells(9).Value
                cmd.Parameters("FMAL").Value = dgw.Rows(i).Cells(10).Value
                cmd.Parameters("SMAL").Value = dgw.Rows(i).Cells(11).Value
                cmd.Parameters("TMAL").Value = dgw.Rows(i).Cells(12).Value
                cmd.Parameters("TOTAL").Value = dgw.Rows(i).Cells(13).Value
                cmd.Parameters("Average").Value = dgw.Rows(i).Cells(14).Value
                cmd.Parameters("Honor").Value = dgw.Rows(i).Cells(15).Value
                cmd.Parameters("Section").Value = lblSection.Text
                cmd.Parameters("GradingPeriod").Value = lblGrading.Text
                cmd.ExecuteNonQuery()
            Next
            ' MsgBox("Added Successfully", MsgBoxStyle.Information, "Adding")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub frmGradeReport_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        AddEditData("Delete  FROM TempGradingReport")
    End Sub

    Private Sub frmGradeReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim grading As String = frmGrades.cmbGrading.Text
        arrCtr = 0

        If grading = "First" Then
            lblGrading.Text = "First Grading Period"
        ElseIf grading = "Second" Then
            lblGrading.Text = "Second Grading Period"
        ElseIf grading = "Third" Then
            lblGrading.Text = "Third Grading Period"
        ElseIf grading = "Fourth" Then
            lblGrading.Text = "Fourth Grading Period"
        End If

        lblSection.Text = frmGrades.txtSection.Text
        dgw.Rows.Clear()
        dgw.Rows.Add("BOYS : ", "", "", "", "", "", "", "", "", "", "A|L", "A|L", "A|L")
        LoadGradingReport("Male")
        dgw.Rows.Add("GIRLS : ")
        LoadGradingReport("Female")
        dgw.Rows.Add("SIGNATURE : ")
        GetHonor()
        AddTempReport()
        LoadReport()
    End Sub

    Private Sub LoadReport()
        Try
            sqL = "SELECT * FROM TempGradingReport"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)

            Me.ReportViewer1.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory + "rptGradingReport1.rdlc"

            Me.DSGradingReport.tempgradingreport.Clear()
            da.Fill(Me.DSGradingReport.tempgradingreport)

            Me.ReportViewer1.RefreshReport()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        AddTempReport()
        ' frmGradingReport.Show()
    End Sub

    Private Sub ReportViewer1_Load(sender As System.Object, e As System.EventArgs) Handles ReportViewer1.Load

    End Sub
End Class