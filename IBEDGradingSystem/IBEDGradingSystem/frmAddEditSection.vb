Public Class frmAddEditSection

    Dim strSQL As String

    Private Sub frmAddEditSection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If adding = True Then
            lblTitle.Text = "Adding Section"
            cmbGradeLevel.Text = ""
            txtSection.Text = ""
            txtSection.Tag = ""
        Else
            lblTitle.Text = "Updating Section"
            cmbGradeLevel.Text = frmSection.ListView1.FocusedItem.SubItems(2).Text
            txtSection.Text = frmSection.ListView1.FocusedItem.SubItems(1).Text
            txtSection.Tag = frmSection.ListView1.FocusedItem.Text
        End If
    End Sub

   

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtSection.Text = "" Then
            MsgBox("Please fill-in section field.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        ElseIf cmbGradeLevel.Text = "" Then
            MsgBox("Please select Grade level.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        If ValidateTableData("SELECT * FROM Section WHERE SectionName = '" & txtSection.Text & "'") = True Then
            MsgBox("Section name already exist.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        If adding = True Then
           
            strSQL = "INSERT INTO Section(SectionName, GradeLevel) VALUES('" & txtSection.Text & "', '" & cmbGradeLevel.Text & "')"
            If AddEditData(strSQL) = True Then
                MsgBox("Section added successfully.", MsgBoxStyle.Information, "Add Section")
            End If
        Else
            strSQL = "UPDATE Section SET SectionName = '" & txtSection.Text & "', GradeLevel = '" & cmbGradeLevel.Text & "' WHERE SectionNo = '" & txtSection.Tag & "'"
            If AddEditData(strSQL) = True Then
                MsgBox("Section updated successfully.", MsgBoxStyle.Information, "Update Section")
            End If
        End If

        frmSection.LoadSection()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class