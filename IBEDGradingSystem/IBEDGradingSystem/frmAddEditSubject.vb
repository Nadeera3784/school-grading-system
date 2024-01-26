Public Class frmAddEditSubject

    Dim strSQL As String

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmAddEditSubject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If adding = True Then
            lblTitle.Text = "Adding Subject"
            txtSubject.Text = ""
            txtSubject.Tag = ""
        Else
            lblTitle.Text = "Updating Subject"
            txtSubject.Text = frmSubject.ListView1.FocusedItem.SubItems(1).Text
            txtSubject.Tag = frmSubject.ListView1.FocusedItem.Text
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If adding = True Then
            strSQL = "INSERT INTO SUBJECT(SubjectName) VALUES('" & txtSubject.Text.Trim & "')"
            If AddEditData(strSQL) = True Then
                MsgBox("Subject added successfully.", MsgBoxStyle.Information, "Add Subject")
            End If
        Else
            strSQL = "UPDATE SUBJECT Set SubjectName = '" & txtSubject.Text.Trim & "' WHERE SubjectNo = '" & txtSubject.Tag & "'"
            If AddEditData(strSQL) = True Then
                MsgBox("Subject updated successfully.", MsgBoxStyle.Information, "Update Subject")
            End If
        End If

        frmSubject.LoadSubject()
        Me.Close()
    End Sub
End Class