
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms


Public Class frmEditingGrade

    Dim strSQL As String

    Private Sub GetGradeInfo()
        Try
            sqL = "SELECT GradeNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as StudName,  Filipino, English, Math, Science, AP, TLE, MAPEH, CLE, Elective FROM Student s INNER JOIN Section sec ON s.SectionNo = sec.SectionNo LEFT JOIN Grade g ON g.StudentNo = s.StudentNo WHERE s.StudentNO = '" & frmGrades.ListView1.FocusedItem.Text & "' AND GradingPeriod = '" & frmGrades.cmbGrading.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtName.Tag = dr(0).ToString
                txtName.Text = dr(1).ToString
                txtFilipino.Text = dr(2).ToString
                txtEnglish.Text = dr(3).ToString
                txtMath.Text = dr(4).ToString
                txtScience.Text = dr(5).ToString
                txtAP.Text = dr(6).ToString
                txtTLE.Text = dr(7).ToString
                txtMAPEH.Text = dr(8).ToString
                txtCLE.Text = dr(9).ToString
                txtElective.Text = dr(10).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub frmEditingGrade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetGradeInfo()
        txtFilipino.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        strSQL = "UPDATE GRADE SET Filipino = '" & txtFilipino.Text & "', English = '" & txtEnglish.Text & "', Math = '" & txtMath.Text & "', Science = '" & txtScience.Text & "', AP = '" & txtAP.Text & "', TLE = '" & txtTLE.Text & "', MAPEH = '" & txtMAPEH.Text & "', CLE = '" & txtCLE.Text & "', Elective = '" & txtElective.Text & "' WHERE GradeNo = '" & txtName.Tag & "'"

        If AddEditData(strSQL) = True Then
            MsgBox("Grades Successfully Updated", MsgBoxStyle.Information, "Editing Grade")
            frmGrades.LoadGrades()
            Me.Close()
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class