Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmSubjectMaxScore

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If validateFields() = False Then
            MsgBox("Please Complete all total fields.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        If validateTotalValue(KTotal.Text) = False Then
            MsgBox("Knowledge total is invalid.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        ElseIf validateTotalValue(PTotal.Text) = False Then
            MsgBox("Process/skills total is invalid.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        ElseIf validateTotalValue(UTotal.Text) = False Then
            MsgBox("Understanding total is invalid.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        ElseIf validateTotalValue(PPTotal.Text) = False Then
            MsgBox("Performance total is invalid.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        Dim strSQL As String
        Dim strSQLVal As String = "SELECT SMSID, Subject, KQuiz, KExam, PQuiz, PExam, UQuiz, UExam, PPTotal FROM SubjectMaxScore WHERE TeacherNo = '" & frmComputeSubjectGrade.txtLogTeacher.Tag & "' AND SY = '" & frmComputeSubjectGrade.cmbSY.Text & "' AND GradeLevel = '" & frmComputeSubjectGrade.lblGrade.Text & "' AND Subject  =  '" & frmComputeSubjectGrade.cmbSubject.Text & "' AND GradingPeriod = '" & frmComputeSubjectGrade.cmbGrading.Text & "'"
        If ValidateTableData(strSQLVal) = False Then
            'add subject max score
            strSQL = "INSERT INTO SubjectMaxScore(KQuiz, KExam, KTotal, PQuiz, PExam, PTotal, UQuiz, UExam, UTotal, PPTotal, TeacherNo, SY, GradeLevel, Subject, GradingPeriod) "
            strSQL = strSQL & " VALUES('" & KQuiz.Text & "', '" & KExam.Text & "', '" & KTotal.Text & "','" & PQuiz.Text & "', '" & PExam.Text & "', '" & PTotal.Text & "','" & UQuiz.Text & "', '" & UExam.Text & "', '" & UTotal.Text & "', '" & PPTotal.Text & "', '" & frmComputeSubjectGrade.txtLogTeacher.Tag & "', '" & frmComputeSubjectGrade.cmbSY.Text & "', '" & frmComputeSubjectGrade.lblGrade.Text & "', '" & frmComputeSubjectGrade.cmbSubject.Text & "', '" & frmComputeSubjectGrade.cmbGrading.Text & "')"
            If AddEditData(strSQL) = True Then
                MsgBox("Subject Max Score Added Successfully.", MsgBoxStyle.Information, "Adding Data")

            End If
        Else
            'edit subject max score
            strSQL = "UPDATE SubjectMaxScore SET kQuiz = '" & KQuiz.Text & "', KExam = '" & KExam.Text & "', kTotal = '" & KTotal.Text & "', PQuiz = '" & PQuiz.Text & "', PExam = '" & PExam.Text & "', PTotal = '" & PTotal.Text & "', uQuiz = '" & UQuiz.Text & "', uExam = '" & UExam.Text & "', uTotal = '" & UTotal.Text & "', PPTotal = '" & PPTotal.Text & "' WHERE SMSID = '" & txtSubject.Tag & "'"
            If AddEditData(strSQL) = True Then
                MsgBox("Subject Max Score Updated Successfully.", MsgBoxStyle.Information, "Updating Data")

            End If
        End If
        Me.Close()
    End Sub

    Private Sub GetSubMaxScore()
        Try
            sqL = "SELECT SMSID, Subject, KQuiz, KExam, PQuiz, PExam, UQuiz, UExam, PPTotal FROM SubjectMaxScore WHERE TeacherNo = '" & frmComputeSubjectGrade.txtLogTeacher.Tag & "' AND SY = '" & frmComputeSubjectGrade.cmbSY.Text & "' AND GradeLevel = '" & frmComputeSubjectGrade.lblGrade.Text & "' AND Subject  =  '" & frmComputeSubjectGrade.cmbSubject.Text & "' AND GradingPeriod = '" & frmComputeSubjectGrade.cmbGrading.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtSubject.Tag = dr(0).ToString
                txtSubject.Text = dr(1).ToString
                KQuiz.Text = dr(2).ToString
                KExam.Text = dr(3).ToString
                PQuiz.Text = dr(4).ToString
                PExam.Text = dr(5).ToString
                UQuiz.Text = dr(6).ToString
                UExam.Text = dr(7).ToString
                PPTotal.Text = dr(8).ToString
            Else
                txtSubject.Tag = ""
                txtSubject.Text = ""
                KQuiz.Text = ""
                KExam.Text = ""
                PQuiz.Text = ""
                PExam.Text = ""
                UQuiz.Text = ""
                UExam.Text = ""
                PPTotal.Text = ""
                txtSubject.Text = frmComputeSubjectGrade.cmbSubject.Text
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Function validateTotalValue(ByVal maxScore As String)
        Dim ret As Boolean

        If maxScore = "35" Or maxScore = "40" Or maxScore = "45" Or maxScore = "50" Or maxScore = "55" Or maxScore = "60" Or maxScore = "65" Or maxScore = "70" Or maxScore = "75" Or maxScore = "80" Then
            ret = True
        Else
            ret = False
        End If


        Return ret
    End Function

    Private Sub frmSubjectMaxScore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ValidateTableData("SELECT * FROM SubjectGrade sg INNER JOIN Student s ON sg.StudentNo = s.StudentNo WHERE sg.SY = '" & frmComputeSubjectGrade.cmbSY.Text & "' AND Subject = '" & frmComputeSubjectGrade.cmbSubject.Text & "' AND sg.SectionNo = '" & frmComputeSubjectGrade.txtSection.Tag & "' AND sg.GradingPeriod = '" & frmComputeSubjectGrade.cmbGrading.Text & "'") = True Then
            KQuiz.Enabled = False
            KExam.Enabled = False
            PQuiz.Enabled = False
            PExam.Enabled = False
            UQuiz.Enabled = False
            UExam.Enabled = False
            PPTotal.Enabled = False
        Else
            KQuiz.Enabled = True
            KExam.Enabled = True
            PQuiz.Enabled = True
            PExam.Enabled = True
            UQuiz.Enabled = True
            UExam.Enabled = True
            PPTotal.Enabled = True
        End If
        GetSubMaxScore()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

   
    Private Sub KExam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KExam.TextChanged
        KTotal.Text = Val(KQuiz.Text) + Val(KExam.Text)
    End Sub

   

    Private Sub PExam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PExam.TextChanged
        PTotal.Text = Val(PQuiz.Text) + Val(PExam.Text)
    End Sub

    
    Private Sub UExam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UExam.TextChanged
        UTotal.Text = Val(UQuiz.Text) + Val(UExam.Text)
    End Sub

   

    Private Sub KQuiz_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KQuiz.TextChanged
        KTotal.Text = Val(KQuiz.Text) + Val(KExam.Text)
    End Sub


    Private Sub PQuiz_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PQuiz.TextChanged
        PTotal.Text = Val(PQuiz.Text) + Val(PExam.Text)
    End Sub

    Private Sub UQuiz_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UQuiz.TextChanged
        UTotal.Text = Val(UQuiz.Text) + Val(UExam.Text)
       
    End Sub

    Private Function validateFields()
        Dim ret As Boolean

        If KTotal.Text = "" Or KTotal.Text = "0" Then
            ret = False
        ElseIf PTotal.Text = "" Or PTotal.Text = "0" Then
            ret = False
        ElseIf UTotal.Text = "" Or UTotal.Text = "0" Then
            ret = False
        ElseIf PPTotal.Text = "" Or PPTotal.Text = "0" Then
            ret = False
        Else
            ret = True
        End If

        Return ret
    End Function

   
End Class