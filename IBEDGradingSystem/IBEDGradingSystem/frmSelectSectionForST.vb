Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Public Class frmSelectSectionForST


    Private Sub LoadSection()
        Try
            If frmComputeSubjectGrade.isComputingGrade = True Then
                sqL = "SELECT st.SectionNo,  GradeLevel, SectionName FROM TeacherSubject st INNER JOIN Section s ON st.SectionNo = s.SectionNo WHERE st.TeacherNo = '" & frmComputeSubjectGrade.txtLogTeacher.Tag & "' GROUP BY st.SectionNo ORDER BY GradeLevel, SectionName"
            Else
                sqL = "SELECT st.SectionNo,  GradeLevel, SectionName FROM TeacherSubject st INNER JOIN Section s ON st.SectionNo = s.SectionNo WHERE st.TeacherNo = '" & frmComputeSubjectGradeMain.txtLogTeacher.Tag & "' GROUP BY st.SectionNo ORDER BY GradeLevel, SectionName"
            End If

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

    Private Sub frmSelectSectionForST_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSection()
    End Sub

    Private Sub cmbGradeLevel_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadSection()
    End Sub

    Private Sub ListView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.DoubleClick

        If frmComputeSubjectGrade.isComputingGrade = True Then
            frmComputeSubjectGrade.txtSection.Tag = ListView1.FocusedItem.Text
            frmComputeSubjectGrade.txtSection.Text = ListView1.FocusedItem.SubItems(1).Text & " - " & ListView1.FocusedItem.SubItems(2).Text
            frmComputeSubjectGrade.lblGrade.Text = ListView1.FocusedItem.SubItems(1).Text
            frmComputeSubjectGrade.isComputingGrade = False
            Me.Close()
        End If

        If frmComputeSubjectGradeMain.isComputingGradeMain = True Then
            frmComputeSubjectGradeMain.txtSection.Tag = ListView1.FocusedItem.Text
            frmComputeSubjectGradeMain.txtSection.Text = ListView1.FocusedItem.SubItems(1).Text & " - " & ListView1.FocusedItem.SubItems(2).Text
            frmComputeSubjectGradeMain.lblGrade.Text = ListView1.FocusedItem.SubItems(1).Text
            frmComputeSubjectGradeMain.isComputingGradeMain = False
            Me.Close()
        End If
       
    End Sub
End Class