Imports MySql.Data.MySqlClient
Imports System.Windows.Forms


Public Class frmAddingGrade


    Public isAddingGrade As Boolean
    Dim strSQL As String


    Private Sub LoadStudentsUpdating()
        Try
            If frmMain.lblRole.Text.ToUpper() = "ADMIN" Then
                sqL = "SELECT s.StudentNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as StudName, GradeNo FROM Student s INNER JOIN SECTION sec ON s.SectionNo = sec.SectionNo LEFT OUTER JOIN Grade g ON s.StudentNo = g.StudentNo WHERE sec.SectionNo = '" & frmGrades.txtSection.Tag & "' AND GradingPeriod = '" & frmGrades.cmbGrading.Text & "' GROUP BY StudentNo ORDER BY Lastname, Firstname"
            Else
                sqL = "SELECT s.StudentNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as StudName, GradeNo FROM Student s INNER JOIN SECTION sec ON s.SectionNo = sec.SectionNo LEFT OUTER JOIN Grade g ON s.StudentNo = g.StudentNo WHERE SectionName = '" & frmGrades.txtSection.Text & "' AND GradingPeriod = '" & frmGrades.cmbGrading.Text & "' GROUP BY StudentNo ORDER BY Lastname, Firstname"
            End If

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

    Private Sub LoadStudentsAdding()
        Try
            If frmMain.lblRole.Text.ToUpper() = "ADMIN" Then
                sqL = "SELECT s.StudentNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as StudName FROM Student s INNER JOIN SECTION sec ON s.SectionNo = sec.SectionNo WHERE sec.SectionNo = '" & frmGrades.txtSection.Tag & "'  GROUP BY StudentNo ORDER BY Lastname, Firstname"
            Else
                sqL = "SELECT s.StudentNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as StudName FROM Student s INNER JOIN SECTION sec ON s.SectionNo = sec.SectionNo WHERE SectionName = '" & frmGrades.txtSection.Text & "'  GROUP BY StudentNo ORDER BY Lastname, Firstname"
            End If

            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            Dim x As ListViewItem
            ListView1.Items.Clear()

            Do While dr.Read = True
              
              
                    x = New ListViewItem(dr(0).ToString)
                    x.SubItems.Add(dr(1).ToString)


                    ListView1.Items.Add(x)
                '  End If

               
             
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try


    End Sub




    Private Sub GetGradeInfo()
        Try
            sqL = "SELECT GradeNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as StudName,  Filipino, English, Math, Science, AP, TLE, MAPEH, CLE, Elective FROM Student s INNER JOIN Section sec ON s.SectionNo = sec.SectionNo LEFT JOIN Grade g ON g.StudentNo = s.StudentNo WHERE s.StudentNO = '" & ListView1.FocusedItem.Text & "' AND GradeNo = '" & ListView1.FocusedItem.SubItems(2).Text & "' AND GradingPeriod = '" & frmGrades.cmbGrading.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                '  txtName.Tag = dr(0).ToString
                txtName.Text = dr(1).ToString
                txtFilipino.Text = dr(2).ToString
                txtFilipino.Tag = dr(0).ToString
                txtEnglish.Text = dr(3).ToString
                txtMath.Text = dr(4).ToString
                txtScience.Text = dr(5).ToString
                txtAP.Text = dr(6).ToString
                txtHomeroom.Text = dr(7).ToString
                txtMAPEH.Text = dr(8).ToString
                txtRR.Text = dr(9).ToString
                txtEP.Text = dr(10).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub GetGradeInfoForUpdate()
        Try
            sqL = "SELECT GradeNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as StudName,  Filipino, English, Math, Science, AP, Homeroom, MAPEH, RR, EP, CCBA, Computer, Language, CIG FROM Student s INNER JOIN Section sec ON s.SectionNo = sec.SectionNo LEFT JOIN Grade g ON g.StudentNo = s.StudentNo WHERE s.StudentNO = '" & frmGrades.ListView1.FocusedItem.Text & "' AND GradingPeriod = '" & frmGrades.cmbGrading.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                '  txtName.Tag = dr(0).ToString
                txtName.Text = dr(1).ToString
                txtFilipino.Text = dr(2).ToString
                txtFilipino.Tag = dr(0).ToString
                txtEnglish.Text = dr(3).ToString
                txtMath.Text = dr(4).ToString
                txtScience.Text = dr(5).ToString
                txtAP.Text = dr(6).ToString
                txtHomeroom.Text = dr(7).ToString
                txtMAPEH.Text = dr(8).ToString
                txtRR.Text = dr(9).ToString
                txtEP.Text = dr(10).ToString
                txtCCBA.Text = dr(11).ToString
                txtComputer.Text = dr(12).ToString
                txtLanguage.Text = dr(13).ToString
                txtCIG.Text = dr(14).ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub



    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtName.Text = "" Then
            MsgBox("Please select student.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        If adding = True Then

            If ValidateTableData("SELECT * FROM Grade WHERE STUDENTNO = '" & txtName.Tag & "' AND GradingPeriod ='" & frmGrades.cmbGrading.Text & "'") = True Then
                MsgBox("The selected student had already grade for " & frmGrades.cmbGrading.Text & " grading period.", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            strSQL = "INSERT INTO Grade(StudentNo, GradingPeriod, Filipino, English, Math, Science, AP, MAPEH, Homeroom, RR, EP, CCBA, Computer, Language, CIG) "
            strSQL = strSQL & " VALUES('" & txtName.Tag & "', '" & frmGrades.cmbGrading.Text & "', '" & txtFilipino.Text & "', '" & txtEnglish.Text & "', '" & txtMath.Text & "', '" & txtScience.Text & "', '" & txtAP.Text & "','" & txtMAPEH.Text & "', '" & txtHomeroom.Text & "',  '" & txtRR.Text & "', '" & txtEP.Text & "', '" & txtCCBA.Text & "', '" & txtComputer.Text & "', '" & txtLanguage.Text & "', '" & txtCIG.Text & "')"
            If AddEditData(strSQL) = True Then
                MsgBox("Grade(s) Added Successfully.", MsgBoxStyle.Information, "Adding Grade")
                ListView1.Items.Remove(ListView1.FocusedItem)
                ClearFields()
                frmGrades.LoadGrades()
            End If
        Else
            strSQL = "UPDATE GRADE SET Filipino = '" & txtFilipino.Text & "', English = '" & txtEnglish.Text & "', Math = '" & txtMath.Text & "', Science = '" & txtScience.Text & "', AP = '" & txtAP.Text & "', Homeroom = '" & txtHomeroom.Text & "', MAPEH = '" & txtMAPEH.Text & "', RR = '" & txtRR.Text & "', EP = '" & txtEP.Text & "', CCBA = '" & txtCCBA.Text & "', Computer = '" & txtComputer.Text & "', Language = '" & txtLanguage.Text & "', CIG = '" & txtCIG.Text & "' WHERE GradeNo = '" & txtFilipino.Tag & "'"

            If AddEditData(strSQL) = True Then
                MsgBox("Grades Successfully Updated", MsgBoxStyle.Information, "Editing Grade")
                frmGrades.LoadGrades()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub ClearFields()
        txtName.Text = ""
        txtName.Tag = ""
        txtFilipino.Text = ""
        txtEnglish.Text = ""
        txtMath.Text = ""
        txtScience.Text = ""
        txtAP.Text = ""
        txtHomeroom.Text = ""
        txtMAPEH.Text = ""
        txtRR.Text = ""
        txtEP.Text = ""
        txtCCBA.Text = ""
        txtComputer.Text = ""
        txtLanguage.Text = ""
        txtCIG.Text = ""
    End Sub

    Private Function isFieldsHasData()
        isFieldsHasData = False
        If txtFilipino.Text <> "" Or txtEnglish.Text <> "" Or txtMath.Text <> "" Or txtScience.Text <> "" Or txtAP.Text <> "" Or txtHomeroom.Text <> "" Or txtMAPEH.Text <> "" Or txtRR.Text <> "" Or txtEP.Text <> "" Or txtCCBA.Text <> "" Or txtComputer.Text <> "" Or txtLanguage.Text <> "" Or txtCIG.Text <> "" Then
            isFieldsHasData = True
        End If
    End Function

    Private Sub cmbGradeLevel_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub frmAddingGrade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim strGrade As String

        If frmMain.lblRole.Text.ToUpper() = "ADMIN" Then
            strGrade = frmGrades.gradesGrade
        Else
            strGrade = frmMain.lblGrade.Text
        End If

        If isHighSchool(strGrade) = True Then
            lblRR.Text = "Research : "
            lblLanguage.Text = "Foreign Language : "
        Else
            lblRR.Text = "Reading/Speech : "
            lblLanguage.Text = "Mother Tongue : "
        End If

        btnSave.Enabled = False


        If adding = True Then
            lblTitle.Text = "Adding Grades"
            ClearFields()
            LoadStudentsAdding()
            Dim x As String
            Dim iCtr As Integer = ListView1.Items.Count
            Dim ctr As Integer = ListView1.Items.Count


            Try
                For i As Integer = 0 To ListView1.Items.Count - 1

                    iCtr = iCtr - 1
                    x = ListView1.Items(iCtr).Text
                    If ValidateTableData("SELECT * FROM Grade WHERE StudentNo = '" & x & "' AND GradingPeriod= '" & frmGrades.cmbGrading.Text & "'") = True Then

                        ListView1.Items.Remove(ListView1.Items(iCtr))
                    End If
                    '  iCtr = iCtr + 1
                Next

            Catch ex As Exception

            End Try


            '   MsgBox(ListView1.Items(0).Text)
        Else
            lblTitle.Text = "Updating Grades"
            LoadStudentsUpdating()
            GetGradeInfoForUpdate()

        End If

    End Sub

    Private Sub cmbGradeLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If frmGrades.txtSection.Tag <> "" Then
            '  LoadStudents()
        End If
    End Sub

    Private Sub ListView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.Click
        If editing = True Then
            GetGradeInfo()
        End If
        txtName.Text = ListView1.FocusedItem.SubItems(1).Text
        txtName.Tag = ListView1.FocusedItem.Text
    End Sub

    Private Sub txtFilipino_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFilipino.TextChanged
        If isFieldsHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If


        If Val(txtFilipino.Text) > 100 Then
            MsgBox("Invalid Grade", MsgBoxStyle.Exclamation, "Warning")
            txtFilipino.Clear()
        End If

        If txtFilipino.Text = "" Then
            Exit Sub
        End If


        If IsNumeric(txtFilipino.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtFilipino.Clear()
        End If
    End Sub

    Private Sub txtEnglish_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEnglish.TextChanged
        If isFieldsHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If


        If Val(txtEnglish.Text) > 100 Then
            MsgBox("Invalid Grade", MsgBoxStyle.Exclamation, "Warning")
            txtEnglish.Clear()
        End If

        If txtEnglish.Text = "" Then
            Exit Sub
        End If


        If IsNumeric(txtEnglish.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtEnglish.Clear()
        End If
    End Sub

    Private Sub txtMath_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMath.TextChanged
        If isFieldsHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If



        If Val(txtMath.Text) > 100 Then
            MsgBox("Invalid Grade", MsgBoxStyle.Exclamation, "Warning")
            txtMath.Clear()
        End If

        If txtMath.Text = "" Then
            Exit Sub
        End If


        If IsNumeric(txtMath.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtMath.Clear()
        End If
    End Sub

    Private Sub txtScience_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtScience.TextChanged
        If isFieldsHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If



        If Val(txtScience.Text) > 100 Then
            MsgBox("Invalid Grade", MsgBoxStyle.Exclamation, "Warning")
            txtScience.Clear()
        End If

        If txtScience.Text = "" Then
            Exit Sub
        End If

        If IsNumeric(txtScience.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtScience.Clear()
        End If
    End Sub

    Private Sub txtAP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAP.TextChanged
        If isFieldsHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If


        If Val(txtAP.Text) > 100 Then
            MsgBox("Invalid Grade", MsgBoxStyle.Exclamation, "Warning")
            txtAP.Clear()
        End If


        If txtAP.Text = "" Then
            Exit Sub
        End If


        If IsNumeric(txtAP.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtAP.Clear()
        End If
    End Sub

    Private Sub txtTLE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHomeroom.TextChanged
        If isFieldsHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If



        If Val(txtHomeroom.Text) > 100 Then
            MsgBox("Invalid Grade", MsgBoxStyle.Exclamation, "Warning")
            txtHomeroom.Clear()
        End If

        If txtHomeroom.Text = "" Then
            Exit Sub
        End If

        If IsNumeric(txtHomeroom.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtHomeroom.Clear()
        End If
    End Sub

    Private Sub txtMAPEH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMAPEH.TextChanged
        If isFieldsHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If



        If Val(txtMAPEH.Text) > 100 Then
            MsgBox("Invalid Grade", MsgBoxStyle.Exclamation, "Warning")
            txtMAPEH.Clear()
        End If

        If txtMAPEH.Text = "" Then
            Exit Sub
        End If

        If IsNumeric(txtMAPEH.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtMAPEH.Clear()
        End If
    End Sub

    Private Sub txtCLE_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRR.TextChanged
        If isFieldsHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If



        If Val(txtRR.Text) > 100 Then
            MsgBox("Invalid Grade", MsgBoxStyle.Exclamation, "Warning")
            txtRR.Clear()
        End If

        If txtRR.Text = "" Then
            Exit Sub
        End If

        If IsNumeric(txtRR.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtRR.Clear()
        End If
    End Sub

    Private Sub txtElective_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEP.TextChanged
        If isFieldsHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If


        If Val(txtEP.Text) > 100 Then
            MsgBox("Invalid Grade", MsgBoxStyle.Exclamation, "Warning")
            txtEP.Clear()
        End If

        If txtEP.Text = "" Then
            Exit Sub
        End If


        If IsNumeric(txtEP.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtEP.Clear()
        End If
    End Sub

    Private Sub txtCCBA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCCBA.TextChanged
        If isFieldsHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If


        If Val(txtCCBA.Text) > 100 Then
            MsgBox("Invalid Grade", MsgBoxStyle.Exclamation, "Warning")
            txtCCBA.Clear()
        End If

        If txtCCBA.Text = "" Then
            Exit Sub
        End If


        If IsNumeric(txtCCBA.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtCCBA.Clear()
        End If
    End Sub

    Private Sub txtComputer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtComputer.TextChanged
        If isFieldsHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If


        If Val(txtComputer.Text) > 100 Then
            MsgBox("Invalid Grade", MsgBoxStyle.Exclamation, "Warning")
            txtComputer.Clear()
        End If

        If txtComputer.Text = "" Then
            Exit Sub
        End If


        If IsNumeric(txtComputer.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtComputer.Clear()
        End If
    End Sub

    Private Sub txtLanguage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLanguage.TextChanged
        If isFieldsHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If


        If Val(txtLanguage.Text) > 100 Then
            MsgBox("Invalid Grade", MsgBoxStyle.Exclamation, "Warning")
            txtLanguage.Clear()
        End If

        If txtLanguage.Text = "" Then
            Exit Sub
        End If


        If IsNumeric(txtLanguage.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtLanguage.Clear()
        End If
    End Sub

    Private Sub txtCIG_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCIG.TextChanged
        If isFieldsHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If


        If Val(txtCIG.Text) > 100 Then
            MsgBox("Invalid Grade", MsgBoxStyle.Exclamation, "Warning")
            txtCIG.Clear()
        End If

        If txtCIG.Text = "" Then
            Exit Sub
        End If


        If IsNumeric(txtCIG.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtCIG.Clear()
        End If
    End Sub
End Class