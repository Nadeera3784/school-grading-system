Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing

Public Class frmGradingReport


    Dim arrCtr As Integer
    Dim aaCtr As Integer
    Dim gradeLevel As String

    Private Sub LoadGradingReport(ByVal gender As String)
        Try
            If frmMain.lblRole.Text.ToUpper() = "ADMIN" Then
                sqL = "SELECT CONCAT(Lastname, ', ', Firstname, ' ', MI,'.') as StudName, Filipino, English, Math, Science, AP, MAPEH, Homeroom, RR, EP, CCBA, Computer, Language, CIG FROM Student s INNER JOIN Grade g ON s.StudentNo = g.StudentNo  WHERE SectionNo = '" & frmGrades.txtSection.Tag & "' AND g.GradingPeriod = '" & frmGrades.cmbGrading.Text & "' AND Gender LIKE '" & gender & "%' ORDER BY Lastname, Firstname"
            Else
                sqL = "SELECT CONCAT(Lastname, ', ', Firstname, ' ', MI,'.') as StudName, Filipino, English, Math, Science, AP, MAPEH, Homeroom, RR, EP, CCBA, Computer, Language, CIG FROM Student s INNER JOIN Grade g ON s.StudentNo = g.StudentNo  INNER JOIN Section sec ON s.SectionNo = sec.SectionNo WHERE sec.SectionNo = '" & frmMain.lblSection.Tag & "' AND g.GradingPeriod = '" & frmGrades.cmbGrading.Text & "' AND Gender LIKE '" & gender & "%' ORDER BY Lastname, Firstname"
            End If


            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader


            Dim tot As Double = 0.0
            Dim ave As Double = 0.0
            Dim ctr As Integer = 1
            Do While dr.Read = True
                tot = Val(dr(1)) + Val(dr(2)) + Val(dr(3)) + Val(dr(4)) + Val(dr(5)) + Val(dr(6)) + Val(dr(7)) + Val(dr(8)) + Val(dr(9)) + Val(dr(10)) + Val(dr(11)) + Val(dr(12)) + Val(dr(13))
                ave = tot / 13
                dgw.Rows.Add(dr(0), dr(1), dr(2), dr(3), dr(4), dr(5), dr(6), dr(7), dr(8), dr(9), dr(10), dr(11), dr(12), dr(13), "", "", "", tot, Format(ave, "#,##0.00"), "")
                ctr = ctr + 1
            Loop

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub LoadAbsentLateReport(ByVal gender As String)
        Try
            If frmMain.lblRole.Text.ToUpper() = "ADMIN" Then
                sqL = "SELECT  FMA, FML, SMA, SML, TMA, TML, CONCAT(Lastname, ', ', Firstname, ' ', MI,'.') as Sname FROM Student s LEFT OUTER JOIN AbsentLate al ON al.StudentNo = s.StudentNo WHERE SectionNo = '" & frmGrades.txtSection.Tag & "' AND al.GradingPeriod = '" & frmGrades.cmbGrading.Text & "' AND Gender LIKE '" & gender & "%' ORDER BY Lastname, Firstname"
            Else
                sqL = "SELECT  FMA, FML, SMA, SML, TMA, TML, CONCAT(Lastname, ', ', Firstname, ' ', MI,'.') as Sname FROM Student s LEFT OUTER JOIN AbsentLate al ON al.StudentNo = s.StudentNo INNER JOIN Section sec ON s.SectionNo = sec.SectionNo WHERE sec.SectionNo = '" & frmMain.lblSection.Tag & "' AND al.GradingPeriod = '" & frmGrades.cmbGrading.Text & "' AND Gender LIKE '" & gender & "%' ORDER BY Lastname, Firstname"
            End If

            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader


            Dim i As Integer = 0

            Do While dr.Read = True
                'If dr(6).ToString = dgw.Rows(i).Cells(0).Value Then
                '    dgw.Rows(i).Cells(10).Value = dr(0) & "|" & dr(1)
                '    dgw.Rows(i).Cells(11).Value = dr(2) & "|" & dr(3)
                '    dgw.Rows(i).Cells(12).Value = dr(4) & "|" & dr(5)
                'End If
                AbsentLate(dr(6).ToString, dr(0) & "|" & dr(1), dr(2) & "|" & dr(3), dr(4) & "|" & dr(5))
            Loop

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub AbsentLate(ByVal StudName As String, ByVal FMAL As String, ByVal SMAL As String, ByVal TMAL As String)
        Dim counter As Integer
        For counter = 0 To dgw.Rows.Count - 1
            If StudName = dgw.Rows(counter).Cells(0).Value Then
                dgw.Rows(counter).Cells(14).Value = FMAL
                dgw.Rows(counter).Cells(15).Value = SMAL
                dgw.Rows(counter).Cells(16).Value = TMAL
            End If
        Next

    End Sub

    Private Sub GetHonor()
        Try
            If frmMain.lblRole.Text.ToUpper() = "ADMIN" Then
                sqL = "SELECT CONCAT(Lastname, ', ', Firstname, ' ', MI, '.') as StudName, (Filipino + English + Math + Science + AP + Homeroom + MAPEH + RR + EP + CCBA + Computer + Language + CIG) as TotalGrade FROM Student s INNER JOIN Grade g ON s.StudentNo = g.StudentNo WHERE SectionNo = '" & frmGrades.txtSection.Tag & "' AND GradingPeriod = '" & frmGrades.cmbGrading.Text & "' ORDER BY TotalGrade DESC"
            Else
                sqL = "SELECT CONCAT(Lastname, ', ', Firstname, ' ', MI, '.') as StudName, (Filipino + English + Math + Science + AP + Homeroom + MAPEH + RR + EP + CCBA + Computer + Language + CIG) as TotalGrade FROM Student s INNER JOIN Grade g ON s.StudentNo = g.StudentNo INNER JOIN Section sec ON s.SectionNo =sec.SectionNo WHERE sec.SectionNo = '" & frmMain.lblSection.Tag & "' AND GradingPeriod = '" & frmGrades.cmbGrading.Text & "' ORDER BY TotalGrade DESC"
            End If

            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader


            Do While dr.Read = True
                Ranking(dr(0).ToString)
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub Ranking(ByVal studName As String)
        For counter = 0 To dgw.Rows.Count - 1
            If studName = dgw.Rows(counter).Cells(0).Value Then
                If dgw.Rows(counter).Cells(1).Value >= "83" And dgw.Rows(counter).Cells(2).Value >= "83" And dgw.Rows(counter).Cells(3).Value >= "83" And dgw.Rows(counter).Cells(4).Value >= "83" And dgw.Rows(counter).Cells(5).Value >= "83" And dgw.Rows(counter).Cells(6).Value >= "83" And dgw.Rows(counter).Cells(7).Value >= "83" And dgw.Rows(counter).Cells(8).Value >= "83" And dgw.Rows(counter).Cells(9).Value >= "83" And dgw.Rows(counter).Cells(10).Value >= "83" And dgw.Rows(counter).Cells(11).Value >= "83" And dgw.Rows(counter).Cells(12).Value >= "83" And dgw.Rows(counter).Cells(13).Value >= "83" Then
                    dgw.Rows(counter).Cells(19).Value = "Achiver"
                End If
            End If
        Next
    End Sub

    Public Sub AddTempReport()
        Try
            sqL = "INSERT INTO TempGradingReport(StudentName, Filipino, English, Math, Science, AP,  MAPEH, Homeroom, RR, EP, CCBA, Computer, Language, CIG, FMAL, SMAL, TMAL, TOTAL, Average, Honor, Section, GradingPeriod) "
            sqL = sqL & " VALUES(@StudentName, @Filipino, @English, @Math, @Science, @AP, @MAPEH, @Homeroom, @RR, @EP, @CCBA, @Computer, @Language, @CIG, @FMAL, @SMAL, @TMAL, @TOTAL, @Average, @Honor, @Section, @GradingPeriod)"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.Parameters.Add("StudentName", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("Filipino", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("English", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("Math", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("Science", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("AP", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("MAPEH", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("Homeroom", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("RR", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("EP", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("CCBA", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("Computer", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("Language", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("CIG", MySql.Data.MySqlClient.MySqlDbType.VarChar)
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
                cmd.Parameters("MAPEH").Value = dgw.Rows(i).Cells(6).Value
                cmd.Parameters("Homeroom").Value = dgw.Rows(i).Cells(7).Value
                cmd.Parameters("RR").Value = dgw.Rows(i).Cells(8).Value
                cmd.Parameters("EP").Value = dgw.Rows(i).Cells(9).Value
                cmd.Parameters("CCBA").Value = dgw.Rows(i).Cells(10).Value
                cmd.Parameters("Computer").Value = dgw.Rows(i).Cells(11).Value
                cmd.Parameters("Language").Value = dgw.Rows(i).Cells(12).Value
                cmd.Parameters("CIG").Value = dgw.Rows(i).Cells(13).Value
                cmd.Parameters("FMAL").Value = dgw.Rows(i).Cells(14).Value
                cmd.Parameters("SMAL").Value = dgw.Rows(i).Cells(15).Value
                cmd.Parameters("TMAL").Value = dgw.Rows(i).Cells(16).Value
                cmd.Parameters("TOTAL").Value = dgw.Rows(i).Cells(17).Value
                cmd.Parameters("Average").Value = dgw.Rows(i).Cells(18).Value
                cmd.Parameters("Honor").Value = dgw.Rows(i).Cells(19).Value
                If frmMain.lblRole.Text.ToUpper() = "ADMIN" Then
                    cmd.Parameters("Section").Value = gradeLevel & " - " & lblSection.Text
                Else
                    cmd.Parameters("Section").Value = frmMain.lblGrade.Text & " - " & lblSection.Text
                End If
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

    Private Sub LoadReport()
        Try
            sqL = "SELECT * FROM TempGradingReport"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            da = New MySqlDataAdapter(cmd)

            If frmGrades.cmbGrading.Text = "First" Then
                Me.ReportViewer1.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory + "rptGradingReport1.rdlc"
            ElseIf frmGrades.cmbGrading.Text = "Second" Then
                Me.ReportViewer1.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory + "rptGradingReport2.rdlc"
            ElseIf frmGrades.cmbGrading.Text = "Third" Then
                Me.ReportViewer1.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory + "rptGradingReport3.rdlc"
            ElseIf frmGrades.cmbGrading.Text = "Fourth" Then
                Me.ReportViewer1.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory + "rptGradingReport4.rdlc"
            End If


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

    Private Sub frmGradingReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSGradingReport.tempgradingreport' table. You can move, or remove it, as needed.
        'Me.tempgradingreportTableAdapter.Fill(Me.DSGradingReport.tempgradingreport)
        AddEditData("Delete  FROM TempGradingReport")
        Dim grading As String = frmGrades.cmbGrading.Text
        arrCtr = 0
        aaCtr = 0
        gradeLevel = frmGrades.lblGrade.Text
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
        dgw.Rows.Add("BOYS : ", "", "", "", "", "", "", "", "", "", "", "", "", "", "DoS|DP", "DoS|DP", "DoS|DP")
        LoadGradingReport("Male")
        dgw.Rows.Add("GIRLS : ")
        LoadGradingReport("Female")
        dgw.Rows.Add("SIGNATURE : ")
        LoadAbsentLateReport("Male")
        LoadAbsentLateReport("Female")
        GetHonor()
        AddTempReport()
        LoadReport()

        'Setting paper size
        'Dim pg As New System.Drawing.Printing.PageSettings
        'pg.Margins.Top = 0
        'pg.Margins.Bottom = 0
        'pg.Margins.Left = 0
        'pg.Margins.Right = 0
        'pg.Landscape = True
        'Dim size As New System.Drawing.Printing.PaperSize
        ''  size.RawKind = PaperKind.Legal
        '' pg.PaperSize = size
        'pg.PaperSize.RawKind = PaperKind.Legal
        'pg.PaperSource.RawKind = PaperKind.Legal
        'ReportViewer1.SetPageSettings(pg)
        'Me.ReportViewer1.RefreshReport()
    End Sub
End Class