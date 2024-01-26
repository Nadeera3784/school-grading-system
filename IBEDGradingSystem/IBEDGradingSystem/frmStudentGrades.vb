Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class frmStudentGrades

    Private Sub frmtest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DSGradingReport.tempgradingreport' table. You can move, or remove it, as needed.

        AddEditData("Delete  FROM TempGradingReport")
        AddTempReport()


        Me.tempgradingreportTableAdapter.Fill(Me.DSGradingReport.tempgradingreport)

        Me.ReportViewer1.RefreshReport()
    End Sub


    Public Sub AddTempReport()
        Try
            sqL = "INSERT INTO TempGradingReport(StudentName, Filipino, English, Math, Science, AP, MAPEH, Homeroom, RR, EP, CCBA, Computer, Language, CIG, Section, GradingPeriod) "
            sqL = sqL & " VALUES(@StudentName, @Filipino, @English, @Math, @Science, @AP,  @MAPEH, @Homeroom, @RR, @EP, @CCBA, @Computer, @Language, @CIG,  @Section, @GradingPeriod)"
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
            cmd.Parameters.Add("Section", MySql.Data.MySqlClient.MySqlDbType.VarChar)
            cmd.Parameters.Add("GradingPeriod", MySql.Data.MySqlClient.MySqlDbType.VarChar)


            With frmGrades.ListView1
                For i As Integer = 0 To .Items.Count - 1
                    cmd.Parameters("StudentName").Value = .Items(i).SubItems(1).Text
                    cmd.Parameters("Filipino").Value = equivalentLetter(.Items(i).SubItems(4).Text)
                    cmd.Parameters("English").Value = equivalentLetter(.Items(i).SubItems(5).Text)
                    cmd.Parameters("Math").Value = equivalentLetter(.Items(i).SubItems(6).Text)
                    cmd.Parameters("Science").Value = equivalentLetter(.Items(i).SubItems(7).Text)
                    cmd.Parameters("AP").Value = equivalentLetter(.Items(i).SubItems(8).Text)
                    cmd.Parameters("MAPEH").Value = equivalentLetter(.Items(i).SubItems(10).Text)
                    cmd.Parameters("Homeroom").Value = equivalentLetter(.Items(i).SubItems(9).Text)
                    cmd.Parameters("RR").Value = equivalentLetter(.Items(i).SubItems(11).Text)
                    cmd.Parameters("EP").Value = equivalentLetter(.Items(i).SubItems(12).Text)
                    cmd.Parameters("CCBA").Value = equivalentLetter(.Items(i).SubItems(13).Text)
                    cmd.Parameters("Computer").Value = equivalentLetter(.Items(i).SubItems(14).Text)
                    cmd.Parameters("Language").Value = equivalentLetter(.Items(i).SubItems(15).Text)
                    cmd.Parameters("CIG").Value = equivalentLetter(.Items(i).SubItems(16).Text)
                    cmd.Parameters("Section").Value = frmGrades.txtSection.Text
                    cmd.Parameters("GradingPeriod").Value = .Items(i).SubItems(3).Text
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

    Private Sub tempgradingreportBindingSource_CurrentChanged(sender As System.Object, e As System.EventArgs) Handles tempgradingreportBindingSource.CurrentChanged

    End Sub
End Class