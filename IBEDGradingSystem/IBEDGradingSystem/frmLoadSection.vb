
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmLoadSection


    Private Sub LoadSection()
        Try
            sqL = "SELECT SectionNo, GradeLevel, SectionName FROM Section  ORDER BY GradeLevel, SectionName"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            ListView1.Items.Clear()
            Dim x As ListViewItem

            Do While dr.Read = True
                x = New ListViewItem(dr(0).ToString)
                x.SubItems.Add(dr(1).ToString)
                x.SubItems.Add(dr(2).ToString)

                ListView1.Items.Add(x)
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub cmbGradeLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadSection()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick

       



        If frmAddEditStudent.isStudentSection = True Then
            frmAddEditStudent.txtSection.Tag = ListView1.FocusedItem.Text
            ' frmAddEditStudent.txtSection.Text = ListView1.FocusedItem.SubItems(2).Text & " - " & ListView1.FocusedItem.SubItems(1).Text
            frmAddEditStudent.txtSection.Text = ListView1.FocusedItem.SubItems(1).Text & " - " & ListView1.FocusedItem.SubItems(2).Text
            frmAddEditStudent.isStudentSection = False

        End If

        If frmGrades.isGradeSection = True Then
            frmGrades.txtSection.Tag = ListView1.FocusedItem.Text
            ' frmGrades.txtSection.Text = ListView1.FocusedItem.SubItems(2).Text & " - " & ListView1.FocusedItem.SubItems(1).Text
            frmGrades.txtSection.Text = ListView1.FocusedItem.SubItems(1).Text & " - " & ListView1.FocusedItem.SubItems(2).Text
            frmGrades.gradesGrade = ListView1.FocusedItem.SubItems(1).Text
            frmGrades.lblGrade.Text = ListView1.FocusedItem.SubItems(1).Text
            frmGrades.isGradeSection = False
        End If

        If frmTeacherSubjects.isTeacherSubjects = True Then
            frmTeacherSubjects.TextBox1.Tag = ListView1.FocusedItem.Text
            frmTeacherSubjects.TextBox1.Text = ListView1.FocusedItem.SubItems(1).Text & " - " & ListView1.FocusedItem.SubItems(2).Text
            frmTeacherSubjects.LoadSubjects(ListView1.FocusedItem.SubItems(1).Text)

            frmTeacherSubjects.isTeacherSubjects = False
        End If

       

        If frmStudent.isStudentFilter = True Then
            frmStudent.txtSection.Tag = ListView1.FocusedItem.Text
            frmStudent.txtSection.Text = ListView1.FocusedItem.SubItems(1).Text & " - " & ListView1.FocusedItem.SubItems(2).Text
            frmStudent.lblGrade.Text = ListView1.FocusedItem.SubItems(1).Text
            frmStudent.lblSection.Text = ListView1.FocusedItem.SubItems(2).Text
            frmStudent.LoadStudent()
            frmStudent.isStudentFilter = False
        End If

        If frmAbsenLate.isAbsentLate = True Then
            frmAbsenLate.txtSection.Tag = ListView1.FocusedItem.Text
            frmAbsenLate.txtSection.Text = ListView1.FocusedItem.SubItems(1).Text & " - " & ListView1.FocusedItem.SubItems(2).Text
            frmAbsenLate.lblGrade.Text = ListView1.FocusedItem.SubItems(1).Text
            frmAbsenLate.lblSection.Text = ListView1.FocusedItem.SubItems(2).Text
            frmAbsenLate.LoadAL()
            frmAbsenLate.isAbsentLate = False
        End If

        If frmLoadStudent.isLoadStudent = True Then
            frmLoadStudent.txtSection.Tag = ListView1.FocusedItem.Text
            frmLoadStudent.txtSection.Text = ListView1.FocusedItem.SubItems(2).Text & " - " & ListView1.FocusedItem.SubItems(1).Text
            frmLoadStudent.isLoadStudent = False
        End If

        If frmComputeSubjectGrade.isComputingGrade = True Then
            frmComputeSubjectGrade.txtSection.Tag = ListView1.FocusedItem.Text
            frmComputeSubjectGrade.txtSection.Text = ListView1.FocusedItem.SubItems(2).Text & " - " & ListView1.FocusedItem.SubItems(1).Text
            frmComputeSubjectGrade.lblGrade.Text = ListView1.FocusedItem.SubItems(2).Text
            frmComputeSubjectGrade.LoadSubjects()
            frmComputeSubjectGrade.isComputingGrade = False
        End If

        If frmComputeSubjectGradeMain.isComputingGradeMain = True Then
            frmComputeSubjectGradeMain.txtSection.Tag = ListView1.FocusedItem.Text
            frmComputeSubjectGradeMain.txtSection.Text = ListView1.FocusedItem.SubItems(1).Text & " - " & ListView1.FocusedItem.SubItems(2).Text
            frmComputeSubjectGradeMain.lblGrade.Text = ListView1.FocusedItem.SubItems(1).Text
            frmComputeSubjectGradeMain.LoadSubjects()
            frmComputeSubjectGradeMain.isComputingGradeMain = False
        End If

        If frmUser.isAddingUser = True Then


            If frmMain.lblSection.Text <> ListView1.FocusedItem.SubItems(1).Text And frmMain.lblRole.Text.ToUpper() <> "ADMIN" Then
                MsgBox("You are not allowed to view record of the selected section.", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            If ValidateTableData("SELECT * FROM Users WHERE Section = '" & ListView1.FocusedItem.SubItems(1).Text & "'") = True Then
                MsgBox("Section already assigned.", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If
            frmUser.txtTeacher.Text = ListView1.FocusedItem.SubItems(2).Text
            frmUser.isAddingUser = False
        End If

        If frmAddEditTeacher.isAddEditTeacher = True Then
            frmAddEditTeacher.txtSection.Tag = ListView1.FocusedItem.Text
            frmAddEditTeacher.txtSection.Text = ListView1.FocusedItem.SubItems(1).Text & " - " & ListView1.FocusedItem.SubItems(2).Text
            frmAddEditTeacher.isAddEditTeacher = False

        End If

        Me.Close()
    End Sub

    Private Sub frmLoadSection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSection()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If frmAddEditStudent.isStudentSection = True Then
            frmAddEditStudent.txtSection.Tag = ListView1.FocusedItem.Text
            ' frmAddEditStudent.txtSection.Text = ListView1.FocusedItem.SubItems(2).Text & " - " & ListView1.FocusedItem.SubItems(1).Text
            frmAddEditStudent.txtSection.Text = ListView1.FocusedItem.SubItems(1).Text & " - " & ListView1.FocusedItem.SubItems(2).Text
            frmAddEditStudent.isStudentSection = False

        End If

        If frmGrades.isGradeSection = True Then
            frmGrades.txtSection.Tag = ListView1.FocusedItem.Text
            ' frmGrades.txtSection.Text = ListView1.FocusedItem.SubItems(2).Text & " - " & ListView1.FocusedItem.SubItems(1).Text
            frmGrades.txtSection.Text = ListView1.FocusedItem.SubItems(1).Text & " - " & ListView1.FocusedItem.SubItems(2).Text
            frmGrades.gradesGrade = ListView1.FocusedItem.SubItems(1).Text
            frmGrades.lblGrade.Text = ListView1.FocusedItem.SubItems(1).Text
            frmGrades.isGradeSection = False
        End If

        If frmTeacherSubjects.isTeacherSubjects = True Then
            frmTeacherSubjects.TextBox1.Tag = ListView1.FocusedItem.Text
            frmTeacherSubjects.TextBox1.Text = ListView1.FocusedItem.SubItems(1).Text & " - " & ListView1.FocusedItem.SubItems(2).Text
            frmTeacherSubjects.LoadSubjects(ListView1.FocusedItem.SubItems(1).Text)
         
            frmTeacherSubjects.isTeacherSubjects = False
        End If



        If frmStudent.isStudentFilter = True Then
            frmStudent.txtSection.Tag = ListView1.FocusedItem.Text
            frmStudent.txtSection.Text = ListView1.FocusedItem.SubItems(1).Text & " - " & ListView1.FocusedItem.SubItems(2).Text
            frmStudent.lblGrade.Text = ListView1.FocusedItem.SubItems(1).Text
            frmStudent.lblSection.Text = ListView1.FocusedItem.SubItems(2).Text
            frmStudent.LoadStudent()
            frmStudent.isStudentFilter = False
        End If

        If frmAbsenLate.isAbsentLate = True Then
            frmAbsenLate.txtSection.Tag = ListView1.FocusedItem.Text
            frmAbsenLate.txtSection.Text = ListView1.FocusedItem.SubItems(1).Text & " - " & ListView1.FocusedItem.SubItems(2).Text
            frmAbsenLate.lblGrade.Text = ListView1.FocusedItem.SubItems(1).Text
            frmAbsenLate.lblSection.Text = ListView1.FocusedItem.SubItems(2).Text
            frmAbsenLate.LoadAL()
            frmAbsenLate.isAbsentLate = False
        End If

        If frmLoadStudent.isLoadStudent = True Then
            frmLoadStudent.txtSection.Tag = ListView1.FocusedItem.Text
            frmLoadStudent.txtSection.Text = ListView1.FocusedItem.SubItems(2).Text & " - " & ListView1.FocusedItem.SubItems(1).Text
            frmLoadStudent.isLoadStudent = False
        End If

        If frmComputeSubjectGrade.isComputingGrade = True Then
            frmComputeSubjectGrade.txtSection.Tag = ListView1.FocusedItem.Text
            frmComputeSubjectGrade.txtSection.Text = ListView1.FocusedItem.SubItems(2).Text & " - " & ListView1.FocusedItem.SubItems(1).Text
            frmComputeSubjectGrade.lblGrade.Text = ListView1.FocusedItem.SubItems(2).Text
            frmComputeSubjectGrade.LoadSubjects()
            frmComputeSubjectGrade.isComputingGrade = False
        End If

        If frmComputeSubjectGradeMain.isComputingGradeMain = True Then
            frmComputeSubjectGradeMain.txtSection.Tag = ListView1.FocusedItem.Text
            frmComputeSubjectGradeMain.txtSection.Text = ListView1.FocusedItem.SubItems(1).Text & " - " & ListView1.FocusedItem.SubItems(2).Text
            frmComputeSubjectGradeMain.lblGrade.Text = ListView1.FocusedItem.SubItems(1).Text
            frmComputeSubjectGradeMain.LoadSubjects()
            frmComputeSubjectGradeMain.isComputingGradeMain = False
        End If

        If frmUser.isAddingUser = True Then


            If frmMain.lblSection.Text <> ListView1.FocusedItem.SubItems(1).Text And frmMain.lblRole.Text.ToUpper() <> "ADMIN" Then
                MsgBox("You are not allowed to view record of the selected section.", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If

            If ValidateTableData("SELECT * FROM Users WHERE Section = '" & ListView1.FocusedItem.SubItems(1).Text & "'") = True Then
                MsgBox("Section already assigned.", MsgBoxStyle.Exclamation, "Warning")
                Exit Sub
            End If
            frmUser.txtTeacher.Text = ListView1.FocusedItem.SubItems(2).Text
            frmUser.isAddingUser = False
        End If

        If frmAddEditTeacher.isAddEditTeacher = True Then
            frmAddEditTeacher.txtSection.Tag = ListView1.FocusedItem.Text
            frmAddEditTeacher.txtSection.Text = ListView1.FocusedItem.SubItems(1).Text & " - " & ListView1.FocusedItem.SubItems(2).Text
            frmAddEditTeacher.isAddEditTeacher = False

        End If

        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class