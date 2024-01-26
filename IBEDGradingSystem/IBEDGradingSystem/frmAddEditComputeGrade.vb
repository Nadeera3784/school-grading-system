Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmAddEditComputeGrade

    Public isComputingGrade As Boolean

    Private Sub LoadStudentsAdding()
        Try

            sqL = "SELECT s.StudentNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as StudName FROM Student s INNER JOIN SECTION sec ON s.SectionNo = sec.SectionNo WHERE sec.SectionNo = '" & frmComputeSubjectGrade.txtSection.Tag & "'  GROUP BY StudentNo ORDER BY Lastname, Firstname"

            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                x = New ListViewItem(dr(0).ToString)
                x.SubItems.Add(dr(1).ToString)
                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try


    End Sub

    Private Sub LoadStudentsUpdating()
        Try
        
            sqL = "SELECT s.StudentNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as StudName, SGId FROM Student s INNER JOIN SECTION sec ON s.SectionNo = sec.SectionNo LEFT OUTER JOIN SubjectGrade g ON s.StudentNo = g.StudentNo WHERE g.SY = '" & frmComputeSubjectGrade.cmbSY.Text & "' AND g.GradingPeriod= '" & frmComputeSubjectGrade.cmbGrading.Text & "' AND g.Subject = '" & frmComputeSubjectGrade.cmbSubject.Text & "' AND g.SectionNo = '" & frmComputeSubjectGrade.txtSection.Tag & "' GROUP BY StudentNo ORDER BY Lastname, Firstname"
        
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
                '  If dr(2).ToString <> "First" And dr(2).ToString <> "Second" Then ' Or dr(2).ToString <> "Third" Or dr(2).ToString <> "Fourth" Then
                x = New ListViewItem(dr(0).ToString)
                x.SubItems.Add(dr(1).ToString)
                x.SubItems.Add(dr(2).ToString)

                ListView1.Items.Add(x)
                '   End If

            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If ValidaFields() = False Then
            Exit Sub
        End If

        If txtName.Text = "" Then
            MsgBox("Please select student from the List.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        'Validate Knowledge Total
        If Val(KTotal.Text) > Val(lblKTotal.Text) Then
            MsgBox("Invalid Knowledge Total Value. Total is greater than Max Total", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        'Validate Process/skills total
        If Val(PTotal.Text) > Val(lblPTotal.Text) Then
            MsgBox("Invalid Process/Skills Total Value. Total is greater than Max Total", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        'Validate Understanding total
        If Val(UTotal.Text) > Val(lblUTotal.Text) Then
            MsgBox("Invalid Understanding Total Value. Total is greater than Max Total", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        'Validate Performance total
        If Val(PPPP.Text) > Val(lblPPTotal.Text) Then
            MsgBox("Invalid Performance Total Value. Total is greater than Max Total", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If


        Dim strSQL As String

        If adding = True Then

            strSQL = "INSERT INTO SubjectGrade(KQuiz, KExam, KTotal, KEquivalent, KPercent, PQuiz, PExam, PTotal, PEquivalent, PPercent, UQuiz, UExam, UTotal, UEquivalent, UPercent, PPPP, PPEquivalent, PPPercent, FG, LG, TIQuiz, TIExam, TeacherNo, StudentNo, SY, SectionNo, Subject, GradingPeriod) "
            strSQL = strSQL & " VALUES('" & KQuiz.Text & "', '" & KExam.Text & "', '" & KTotal.Text & "', '" & KEquivalent.Text & "', '" & KPercent.Text & "','" & PQuiz.Text & "', '" & PExam.Text & "', '" & PTotal.Text & "', '" & PEquivalent.Text & "', '" & PPercent.Text & "','" & UQuiz.Text & "', '" & UExam.Text & "', '" & UTotal.Text & "', '" & UEquivalent.Text & "', '" & UPercent.Text & "', '" & PPPP.Text & "', '" & PPEquivalent.Text & "', '" & PPPercent.Text & "','" & FG.Text & "', '" & LG.Text & "', '" & TotalQuiz.Text & "', '" & TotalExam.Text & "' , '" & frmComputeSubjectGrade.txtLogTeacher.Tag & "', '" & txtName.Tag & "', '" & frmComputeSubjectGrade.cmbSY.Text & "', '" & frmComputeSubjectGrade.txtSection.Tag & "', '" & frmComputeSubjectGrade.cmbSubject.Text & "', '" & frmComputeSubjectGrade.cmbGrading.Text & "')"
            If AddEditData(strSQL) = True Then
                AddFinalGrade(frmComputeSubjectGrade.cmbSubject.Text)
                MsgBox("Added Successfully", MsgBoxStyle.Information, "Add Grade")
                ListView1.Items.Remove(ListView1.FocusedItem)
                ClearFields()
            End If
        Else
            strSQL = "UPDATE SubjectGrade SET kQuiz = '" & KQuiz.Text & "', kExam = '" & KExam.Text & "', KTotal = '" & KTotal.Text & "', KEquivalent = '" & KEquivalent.Text & "', KPercent = '" & KPercent.Text & "', "
            strSQL = strSQL & " pQuiz = '" & PQuiz.Text & "', pExam = '" & PExam.Text & "', pTotal = '" & PTotal.Text & "', pEquivalent = '" & PEquivalent.Text & "', pPercent = '" & PPercent.Text & "', "
            strSQL = strSQL & " uQuiz = '" & UQuiz.Text & "', uExam = '" & UExam.Text & "', uTotal = '" & PTotal.Text & "', uEquivalent = '" & UEquivalent.Text & "', uPercent = '" & UPercent.Text & "', "
            strSQL = strSQL & " PPPP = '" & PPPP.Text & "', PPEquivalent = '" & PPEquivalent.Text & "', PPPercent = '" & PPPercent.Text & "', FG = '" & FG.Text & "', LG = '" & LG.Text & "', "
            strSQL = strSQL & " TIQuiz = '" & TotalQuiz.Text & "', TIExam = '" & TotalExam.Text & "', TeacherNo = '" & frmComputeSubjectGrade.txtLogTeacher.Tag & "', StudentNo = '" & txtName.Tag & "', SY = '" & frmComputeSubjectGrade.cmbSY.Text & "', "
            strSQL = strSQL & " SectionNo = '" & frmComputeSubjectGrade.txtSection.Tag & "', Subject = '" & frmComputeSubjectGrade.cmbSubject.Text & "', GradingPeriod = '" & frmComputeSubjectGrade.cmbGrading.Text & "' WHERE SGID = '" & KQuiz.Tag & "' "

            If AddEditData(strSQL) = True Then
                AddFinalGrade(frmComputeSubjectGrade.cmbSubject.Text)
                MsgBox("Updated Successfully", MsgBoxStyle.Information, "Update Grade")
                ClearFields()
            End If
        End If

        frmComputeSubjectGrade.loadRecordGrades()
    End Sub

    Private Sub AddFinalGrade(ByVal strSubject As String)
       

        'Homeroom
        If strSubject = "Homeroom" Then
            If ValidateTableData("SELECT * FROM Grade WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'") = False Then
                AddEditData("INSERT INTO Grade(StudentNo, GradingPeriod, Homeroom) VALUES('" & txtName.Tag & "', '" & frmComputeSubjectGrade.cmbGrading.Text & "', '" & FG.Text & "')")
            Else
                AddEditData("UPDATE Grade SET Homeroom = '" & FG.Text & "' WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'")

            End If

            'Filipino
        ElseIf strSubject = "Filipino" Then
            If ValidateTableData("SELECT * FROM Grade WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'") = False Then
                AddEditData("INSERT INTO Grade(StudentNo, GradingPeriod, Filipino) VALUES('" & txtName.Tag & "', '" & frmComputeSubjectGrade.cmbGrading.Text & "', '" & FG.Text & "')")
            Else
                AddEditData("UPDATE Grade SET Filipino = '" & FG.Text & "' WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'")

            End If

            'English
        ElseIf strSubject = "English" Then
            If ValidateTableData("SELECT * FROM Grade WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'") = False Then
                AddEditData("INSERT INTO Grade(StudentNo, GradingPeriod, English) VALUES('" & txtName.Tag & "', '" & frmComputeSubjectGrade.cmbGrading.Text & "', '" & FG.Text & "')")
            Else
                AddEditData("UPDATE Grade SET English = '" & FG.Text & "' WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'")

            End If

            'Math
        ElseIf strSubject = "Mathematics" Then
            If ValidateTableData("SELECT * FROM Grade WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'") = False Then
                AddEditData("INSERT INTO Grade(StudentNo, GradingPeriod, Math) VALUES('" & txtName.Tag & "', '" & frmComputeSubjectGrade.cmbGrading.Text & "', '" & FG.Text & "')")
            Else
                AddEditData("UPDATE Grade SET Math = '" & FG.Text & "' WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'")

            End If

            'Science
        ElseIf strSubject = "Science" Then
            If ValidateTableData("SELECT * FROM Grade WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'") = False Then
                AddEditData("INSERT INTO Grade(StudentNo, GradingPeriod, Science) VALUES('" & txtName.Tag & "', '" & frmComputeSubjectGrade.cmbGrading.Text & "', '" & FG.Text & "')")
            Else
                AddEditData("UPDATE Grade SET Science = '" & FG.Text & "' WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'")

            End If

            'AP
        ElseIf strSubject = "AP" Then
            If ValidateTableData("SELECT * FROM Grade WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'") = False Then
                AddEditData("INSERT INTO Grade(StudentNo, GradingPeriod, AP) VALUES('" & txtName.Tag & "', '" & frmComputeSubjectGrade.cmbGrading.Text & "', '" & FG.Text & "')")
            Else
                AddEditData("UPDATE Grade SET AP = '" & FG.Text & "' WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'")

            End If

            'MAPEH
        ElseIf strSubject = "MAPEH" Then
            If ValidateTableData("SELECT * FROM Grade WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'") = False Then
                AddEditData("INSERT INTO Grade(StudentNo, GradingPeriod, MAPEH) VALUES('" & txtName.Tag & "', '" & frmComputeSubjectGrade.cmbGrading.Text & "', '" & FG.Text & "')")
            Else
                AddEditData("UPDATE Grade SET MAPEH = '" & FG.Text & "' WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'")

            End If

            'RR
        ElseIf strSubject = "Research" Or strSubject = "Reading/Speech" Then
            If ValidateTableData("SELECT * FROM Grade WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'") = False Then
                AddEditData("INSERT INTO Grade(StudentNo, GradingPeriod, RR) VALUES('" & txtName.Tag & "', '" & frmComputeSubjectGrade.cmbGrading.Text & "', '" & FG.Text & "')")
            Else
                AddEditData("UPDATE Grade SET RR = '" & FG.Text & "' WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'")

            End If

            'EP
        ElseIf strSubject = "Edukasyon sa Pagpapakatao" Then
            If ValidateTableData("SELECT * FROM Grade WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'") = False Then
                AddEditData("INSERT INTO Grade(StudentNo, GradingPeriod, EP) VALUES('" & txtName.Tag & "', '" & frmComputeSubjectGrade.cmbGrading.Text & "', '" & FG.Text & "')")
            Else
                AddEditData("UPDATE Grade SET EP = '" & FG.Text & "' WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'")

            End If

            'CCBA
        ElseIf strSubject = "Conduct/Char. Build. Act" Then
            If ValidateTableData("SELECT * FROM Grade WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'") = False Then
                AddEditData("INSERT INTO Grade(StudentNo, GradingPeriod, CCBA) VALUES('" & txtName.Tag & "', '" & frmComputeSubjectGrade.cmbGrading.Text & "', '" & FG.Text & "')")
            Else
                AddEditData("UPDATE Grade SET CCBA = '" & FG.Text & "' WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'")

            End If

            'CIG
        ElseIf strSubject = "Current Issues/Geography" Then
            If ValidateTableData("SELECT * FROM Grade WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'") = False Then
                AddEditData("INSERT INTO Grade(StudentNo, GradingPeriod, CIG) VALUES('" & txtName.Tag & "', '" & frmComputeSubjectGrade.cmbGrading.Text & "', '" & FG.Text & "')")
            Else
                AddEditData("UPDATE Grade SET CIG = '" & FG.Text & "' WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'")

            End If

            'Computer
        ElseIf strSubject = "Comp./Tech and Livelihood Educ." Then
            If ValidateTableData("SELECT * FROM Grade WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'") = False Then
                AddEditData("INSERT INTO Grade(StudentNo, GradingPeriod, Computer) VALUES('" & txtName.Tag & "', '" & frmComputeSubjectGrade.cmbGrading.Text & "', '" & FG.Text & "')")
            Else
                AddEditData("UPDATE Grade SET Computer = '" & FG.Text & "' WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'")

            End If

            'Language
        ElseIf strSubject = "Foreign Language" Or strSubject = "Mother Tongue" Then
            If ValidateTableData("SELECT * FROM Grade WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'") = False Then
                AddEditData("INSERT INTO Grade(StudentNo, GradingPeriod, Language) VALUES('" & txtName.Tag & "', '" & frmComputeSubjectGrade.cmbGrading.Text & "', '" & FG.Text & "')")
            Else
                AddEditData("UPDATE Grade SET Language = '" & FG.Text & "' WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmComputeSubjectGrade.cmbGrading.Text & "'")

            End If

        End If
    End Sub

    Private Sub frmAddEditComputeGrade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GetSubMaxScore()

        If adding = True Then
            lblTitle.Text = "Adding Grade"
            ClearFields()
            LoadStudentsAdding()


            Dim x As String
            Dim iCtr As Integer = ListView1.Items.Count
            Dim ctr As Integer = ListView1.Items.Count


            Try
                For i As Integer = 0 To ListView1.Items.Count - 1

                    iCtr = iCtr - 1
                    x = ListView1.Items(iCtr).Text
                    If ValidateTableData("SELECT * FROM SubjectGrade WHERE StudentNo = '" & x & "' AND GradingPeriod= '" & frmComputeSubjectGrade.cmbGrading.Text & "' AND Subject = '" & frmComputeSubjectGrade.cmbSubject.Text & "'") = True Then

                        ListView1.Items.Remove(ListView1.Items(iCtr))
                    End If
                    '  iCtr = iCtr + 1
                Next

            Catch ex As Exception

            End Try
        Else
            lblTitle.Text = "Updating Grade"
            LoadStudentsUpdating()
            GetSubjectGradeInfoK()
            GetSubjectGradeInfoP()
            GetSubjectGradeInfoU()
            GetSubjectGradeInfoPP()
        End If


    End Sub

    Private Sub ListView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.Click
        If adding = True Then
            txtName.Tag = ListView1.FocusedItem.Text
            txtName.Text = ListView1.FocusedItem.SubItems(1).Text
        Else
            txtName.Tag = ListView1.FocusedItem.Text
            txtName.Text = ListView1.FocusedItem.SubItems(1).Text
            BindGradeInforToTextK()
            BindGradeInforToTextP()
            BindGradeInforToTextU()
            BindGradeInforToTextPP()
        End If
    End Sub

    Private Sub ClearFields()
        txtName.Tag = ""
        txtName.Text = ""

        KQuiz.Text = ""
        KExam.Text = ""
        KTotal.Text = ""
        KEquivalent.Text = ""
        KPercent.Text = ""

        PQuiz.Text = ""
        PExam.Text = ""
        PTotal.Text = ""
        PEquivalent.Text = ""
        PPercent.Text = ""

        UQuiz.Text = ""
        UExam.Text = ""
        UTotal.Text = ""
        UEquivalent.Text = ""
        UPercent.Text = ""

        PPPP.Text = ""
        PPEquivalent.Text = ""
        PPPercent.Text = ""

        FG.Text = ""
        LG.Text = ""
        TotalQuiz.Text = ""
        TotalExam.Text = ""
    End Sub

    Private Sub BindGradeInforToTextK()
        Try
            sqL = "SELECT KQuiz, KExam, PQuiz, PExam, UQuiz, UExam, PPPP, SGId FROM SubjectGrade WHERE SGId = '" & ListView1.FocusedItem.SubItems(2).Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                KQuiz.Tag = dr(7).ToString
                KQuiz.Text = dr(0).ToString
                KExam.Text = dr(1).ToString
                ' PQuiz.Text = dr(2).ToString
                '  PExam.Text = dr(3).ToString
                ' UQuiz.Text = dr(4).ToString
                ' UExam.Text = dr(5).ToString
                ' PPPP.Text = dr(6).ToString

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub BindGradeInforToTextP()
        Try
            sqL = "SELECT KQuiz, KExam, PQuiz, PExam, UQuiz, UExam, PPPP, SGId FROM SubjectGrade WHERE SGId = '" & ListView1.FocusedItem.SubItems(2).Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                ' KQuiz.Tag = dr(7).ToString
                '  KQuiz.Text = dr(0).ToString
                '  KExam.Text = dr(1).ToString
                PQuiz.Text = dr(2).ToString
                PExam.Text = dr(3).ToString
                '  UQuiz.Text = dr(4).ToString
                ' UExam.Text = dr(5).ToString
                ' PPPP.Text = dr(6).ToString

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub BindGradeInforToTextU()
        Try
            sqL = "SELECT KQuiz, KExam, PQuiz, PExam, UQuiz, UExam, PPPP, SGId FROM SubjectGrade WHERE SGId = '" & ListView1.FocusedItem.SubItems(2).Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                '  KQuiz.Tag = dr(7).ToString
                '  KQuiz.Text = dr(0).ToString
                '   KExam.Text = dr(1).ToString
                '  PQuiz.Text = dr(2).ToString
                '  PExam.Text = dr(3).ToString
                UQuiz.Text = dr(4).ToString
                UExam.Text = dr(5).ToString
                ' PPPP.Text = dr(6).ToString

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub BindGradeInforToTextPP()
        Try
            sqL = "SELECT KQuiz, KExam, PQuiz, PExam, UQuiz, UExam, PPPP, SGId FROM SubjectGrade WHERE SGId = '" & ListView1.FocusedItem.SubItems(2).Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                '  KQuiz.Tag = dr(7).ToString
                '  KQuiz.Text = dr(0).ToString
                '  KExam.Text = dr(1).ToString
                '  PQuiz.Text = dr(2).ToString
                '  PExam.Text = dr(3).ToString
                ' UQuiz.Text = dr(4).ToString
                ' UExam.Text = dr(5).ToString
                PPPP.Text = dr(6).ToString

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub KTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KTotal.TextChanged
        If Val(KTotal.Text) > Val(lblKTotal.Text) Then
            MsgBox("Invalid Knowledge Total Value. Total is greater than Max Total", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        Try
            KEquivalent.Text = GetTotalEquivalent(KTotal.Text, lblKTotal.Text)
            KPercent.Text = Format(Val(KEquivalent.Text) * 0.15, "#,##0.00")
        Catch ex As Exception

        End Try

        'Computing Result
        Try
            FG.Text = Format(Val(KPercent.Text) + Val(PPercent.Text) + Val(UPercent.Text) + Val(PPPercent.Text), "#,##0.00")
            LG.Text = equivalentLetterCompute(FG.Text)
            TotalQuiz.Text = Val(KQuiz.Text) + Val(PQuiz.Text) + Val(UQuiz.Text)
            TotalExam.Text = Val(KExam.Text) + Val(PExam.Text) + Val(UExam.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub KExam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KExam.TextChanged
        If KExam.Text = "" Then
            Exit Sub
        End If

        If IsNumeric(KExam.Text) = True Then
            'Do nothing
        Else
            MsgBox("Numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            KExam.Clear()
        End If

        If Val(KExam.Text) > Val(lblKExam.Text) Then
            MsgBox("Invalid Exam value, greater than max value.", MsgBoxStyle.Exclamation, "Warning")
            KExam.Text = ""
            KTotal.Text = ""
            KEquivalent.Text = ""
            KPercent.Text = ""
            clearResultField()
            Exit Sub
        End If

        Try
            KTotal.Text = Val(KQuiz.Text) + Val(KExam.Text)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub clearResultField()
        FG.Text = ""
        LG.Text = ""
        TotalExam.Text = ""
        TotalQuiz.Text = ""
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub PTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PTotal.TextChanged
        If Val(PTotal.Text) > Val(lblPTotal.Text) Then
            MsgBox("Invalid Process/Skills Total Value. Total is greater than Max Total", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        Try
            PEquivalent.Text = GetTotalEquivalent(PTotal.Text, lblPTotal.Text)
            PPercent.Text = Format(Val(PEquivalent.Text) * 0.25, "#,##0.00")
        Catch ex As Exception

        End Try

        'Computing Result
        Try
            FG.Text = Format(Val(KPercent.Text) + Val(PPercent.Text) + Val(UPercent.Text) + Val(PPPercent.Text), "#,##0.00")
            LG.Text = equivalentLetterCompute(FG.Text)
            TotalQuiz.Text = Val(KQuiz.Text) + Val(PQuiz.Text) + Val(UQuiz.Text)
            TotalExam.Text = Val(KExam.Text) + Val(PExam.Text) + Val(UExam.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PExam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PExam.TextChanged

        If PExam.Text = "" Then
            Exit Sub
        End If

        If IsNumeric(PExam.Text) = True Then
            'Do nothing
        Else
            MsgBox("Numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            PExam.Clear()
        End If

        If Val(PExam.Text) > Val(lblPExam.Text) Then
            MsgBox("Invalid Exam value, greater than max value.", MsgBoxStyle.Exclamation, "Warning")
            PExam.Text = ""
            PTotal.Text = ""
            PEquivalent.Text = ""
            PPercent.Text = ""
            clearResultField()
            Exit Sub
        End If

        Try
            PTotal.Text = Val(PQuiz.Text) + Val(PExam.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UTotal.TextChanged
        If Val(UTotal.Text) > Val(lblUTotal.Text) Then
            MsgBox("Invalid Understanding Total Value. Total is greater than Max Total", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        Try
            UEquivalent.Text = GetTotalEquivalent(UTotal.Text, lblUTotal.Text)
            UPercent.Text = Format(Val(UEquivalent.Text) * 0.3, "#,##0.00")
        Catch ex As Exception

        End Try

        'Computing Result
        Try
            FG.Text = Format(Val(KPercent.Text) + Val(PPercent.Text) + Val(UPercent.Text) + Val(PPPercent.Text), "#,##0.00")
            LG.Text = equivalentLetterCompute(FG.Text)
            TotalQuiz.Text = Val(KQuiz.Text) + Val(PQuiz.Text) + Val(UQuiz.Text)
            TotalExam.Text = Val(KExam.Text) + Val(PExam.Text) + Val(UExam.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub UExam_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UExam.TextChanged
        If UExam.Text = "" Then
            Exit Sub
        End If

        If IsNumeric(UExam.Text) = True Then
            'Do nothing
        Else
            MsgBox("Numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            UExam.Clear()
        End If

        If Val(UExam.Text) > Val(lblUExam.Text) Then
            MsgBox("Invalid Exam value, greater than max value.", MsgBoxStyle.Exclamation, "Warning")
            UExam.Text = ""
            UTotal.Text = ""
            UEquivalent.Text = ""
            UPercent.Text = ""
            clearResultField()
            Exit Sub
        End If

        Try
            UTotal.Text = Val(UQuiz.Text) + Val(UExam.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub PPPP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPPP.TextChanged
        If PPPP.Text = "" Then
            Exit Sub
        End If

        If Val(PPPP.Text) > Val(lblPPTotal.Text) Then
            MsgBox("Invalid Performance Total Value. Total is greater than Max Total", MsgBoxStyle.Exclamation, "Warning")
            PPPP.Text = ""
            PPEquivalent.Text = ""
            PPPercent.Text = ""
            clearResultField()
            Exit Sub
        End If

        If IsNumeric(PPPP.Text) = True Then
            'Do nothing
        Else
            MsgBox("Numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            PPPP.Clear()
        End If

        Try
            PPEquivalent.Text = GetTotalEquivalent(PPPP.Text, lblPPTotal.Text)
            PPPercent.Text = Format(Val(PPEquivalent.Text) * 0.3, "#,##0.00")
        Catch ex As Exception

        End Try

        'Computing Result
        Try
            FG.Text = Format(Val(KPercent.Text) + Val(PPercent.Text) + Val(UPercent.Text) + Val(PPPercent.Text), "#,##0.00")
            LG.Text = equivalentLetterCompute(FG.Text)
            TotalQuiz.Text = Val(KQuiz.Text) + Val(PQuiz.Text) + Val(UQuiz.Text)
            TotalExam.Text = Val(KExam.Text) + Val(PExam.Text) + Val(UExam.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GetSubjectGradeInfoK()

        txtName.Text = frmComputeSubjectGrade.ListView1.FocusedItem.SubItems(1).Text
        Try
            sqL = "SELECT SGID, KQuiz, KExam, PQuiz, PExam, UQuiz, UExam, PPPP, StudentNo FROM SubjectGrade WHERE SGID = '" & frmComputeSubjectGrade.ListView1.FocusedItem.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                txtName.Tag = dr(8).ToString
                KQuiz.Tag = dr(0).ToString
                KQuiz.Text = dr(1).ToString
                KExam.Text = dr(2).ToString
                ' PQuiz.Text = dr(3).ToString
                ' PExam.Text = dr(4).ToString
                ' UQuiz.Text = dr(5).ToString
                ' UExam.Text = dr(6).ToString
                ' PPPP.Text = dr(7).ToString

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub GetSubjectGradeInfoP()


        Try
            sqL = "SELECT SGID, KQuiz, KExam, PQuiz, PExam, UQuiz, UExam, PPPP, StudentNo FROM SubjectGrade WHERE SGID = '" & frmComputeSubjectGrade.ListView1.FocusedItem.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                '  KQuiz.Tag = dr(0).ToString
                ' KQuiz.Text = dr(1).ToString
                ' KExam.Text = dr(2).ToString
                PQuiz.Text = dr(3).ToString
                PExam.Text = dr(4).ToString
                'UQuiz.Text = dr(5).ToString
                ' UExam.Text = dr(6).ToString
                'PPPP.Text = dr(7).ToString
                ' txtName.Tag = dr(8).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub GetSubjectGradeInfoU()


        Try
            sqL = "SELECT SGID, KQuiz, KExam, PQuiz, PExam, UQuiz, UExam, PPPP, StudentNo FROM SubjectGrade WHERE SGID = '" & frmComputeSubjectGrade.ListView1.FocusedItem.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                ' KQuiz.Tag = dr(0).ToString
                ' KQuiz.Text = dr(1).ToString
                ' KExam.Text = dr(2).ToString
                ' PQuiz.Text = dr(3).ToString
                '  PExam.Text = dr(4).ToString
                UQuiz.Text = dr(5).ToString
                UExam.Text = dr(6).ToString
                ' PPPP.Text = dr(7).ToString
                'txtName.Tag = dr(8).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub GetSubjectGradeInfoPP()


        Try
            sqL = "SELECT SGID, KQuiz, KExam, PQuiz, PExam, UQuiz, UExam, PPPP, StudentNo FROM SubjectGrade WHERE SGID = '" & frmComputeSubjectGrade.ListView1.FocusedItem.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                ' KQuiz.Tag = dr(0).ToString
                ' KQuiz.Text = dr(1).ToString
                ' KExam.Text = dr(2).ToString
                ' PQuiz.Text = dr(3).ToString
                ' PExam.Text = dr(4).ToString
                '  UQuiz.Text = dr(5).ToString
                ' UExam.Text = dr(6).ToString
                PPPP.Text = dr(7).ToString
                ' txtName.Tag = dr(8).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub


    Private Sub GetSubMaxScore()
        Try
            sqL = "SELECT kTotal, pTotal, uTotal, PPTotal, KQuiz, KExam, PQuiz, PExam, UQuiz, UExam FROM SubjectMaxScore WHERE TeacherNo = '" & frmComputeSubjectGrade.txtLogTeacher.Tag & "' AND SY = '" & frmComputeSubjectGrade.cmbSY.Text & "' AND GradeLevel = '" & frmComputeSubjectGrade.lblGrade.Text & "' AND Subject  =  '" & frmComputeSubjectGrade.cmbSubject.Text & "' AND GradingPeriod = '" & frmComputeSubjectGrade.cmbGrading.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                lblKTotal.Text = dr(0)
                lblPTotal.Text = dr(1)
                lblUTotal.Text = dr(2)
                lblPPTotal.Text = dr(3)
                lblKQuiz.Text = dr(4)
                lblKExam.Text = dr(5)
                lblPQuiz.Text = dr(6)
                lblPExam.Text = dr(7)
                lblUQuiz.Text = dr(8)
                lblUExam.Text = dr(9)
            Else
                lblKTotal.Text = ""
                lblPTotal.Text = ""
                lblUTotal.Text = ""
                lblPPTotal.Text = ""
                lblKQuiz.Text = ""
                lblKExam.Text = ""
                lblPQuiz.Text = ""
                lblPExam.Text = ""
                lblUQuiz.Text = ""
                lblUExam.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Function ValidaFields()
        Dim ret As Boolean = False

        If KQuiz.Text = "" Then
            MsgBox("Please fill-in knowledege quiz field.", MsgBoxStyle.Exclamation, "Warning")
            KQuiz.Focus()
        ElseIf KExam.Text = "" Then
            MsgBox("Please fill-in knowledege exam field.", MsgBoxStyle.Exclamation, "Warning")
            KExam.Focus()
        ElseIf PExam.Text = "" Then
            MsgBox("Please fill-in Process/skills exam field.", MsgBoxStyle.Exclamation, "Warning")
            PExam.Focus()
        ElseIf PQuiz.Text = "" Then
            MsgBox("Please fill-in Process/skills quiz field.", MsgBoxStyle.Exclamation, "Warning")
            PQuiz.Focus()
        ElseIf UExam.Text = "" Then
            MsgBox("Please fill-in Understanding exam field.", MsgBoxStyle.Exclamation, "Warning")
            PExam.Focus()
        ElseIf UQuiz.Text = "" Then
            MsgBox("Please fill-in Understanding quiz field.", MsgBoxStyle.Exclamation, "Warning")
            PQuiz.Focus()
        ElseIf PPPP.Text = "" Then
            MsgBox("Please fill-in Performance field.", MsgBoxStyle.Exclamation, "Warning")
            PPPP.Focus()
        Else
            ret = True
        End If

        Return ret
    End Function

    Private Sub KQuiz_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KQuiz.TextChanged
        If KQuiz.Text = "" Then
            Exit Sub
        End If

      

        If IsNumeric(KQuiz.Text) = True Then
            'Do nothing
        Else
            MsgBox("Numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            KQuiz.Clear()
        End If

        If Val(KQuiz.Text) > Val(lblKQuiz.Text) Then
            MsgBox("Invalid Quiz value, greater than max value.", MsgBoxStyle.Exclamation, "Warning")
            KQuiz.Text = ""
            Exit Sub
        End If

        'Try
        '    KTotal.Text = Val(KQuiz.Text) + Val(KExam.Text)
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub PQuiz_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PQuiz.TextChanged
        If PQuiz.Text = "" Then
            Exit Sub
        End If

        If IsNumeric(PQuiz.Text) = True Then
            'Do nothing
        Else
            MsgBox("Numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            PQuiz.Clear()
        End If

        If Val(PQuiz.Text) > Val(lblPQuiz.Text) Then
            MsgBox("Invalid Quiz value, greater than max value.", MsgBoxStyle.Exclamation, "Warning")
            PQuiz.Text = ""
            Exit Sub
        End If

        'Try
        '    PTotal.Text = Val(PQuiz.Text) + Val(PExam.Text)
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub UQuiz_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UQuiz.TextChanged
        If UQuiz.Text = "" Then
            Exit Sub
        End If

        If IsNumeric(UQuiz.Text) = True Then
            'Do nothing
        Else
            MsgBox("Numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            UQuiz.Clear()
        End If

        If Val(UQuiz.Text) > Val(lblUQuiz.Text) Then
            MsgBox("Invalid Quiz value, greater than max value.", MsgBoxStyle.Exclamation, "Warning")
            UQuiz.Text = ""
            Exit Sub
        End If

        'Try
        '    UTotal.Text = Val(UQuiz.Text) + Val(UExam.Text)
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub LG_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LG.TextChanged

    End Sub

    Private Sub PPEquivalent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPEquivalent.TextChanged

    End Sub

    Private Sub PPPercent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PPPercent.TextChanged

    End Sub
End Class