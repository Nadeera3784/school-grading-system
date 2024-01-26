Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class frmAddEditAbsentLate

    Dim strsSQL As String

    Private Sub GetALInfo()
        Try
            sqL = "SELECT FMA, FML, SMA, SML, TMA, TML, ALNo, s.StudentNO FROM AbsentLate al INNER JOIN Student s ON al.StudentNo =s.StudentNo WHERE ALNO = '" & frmAbsenLate.ListView1.FocusedItem.Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            txtName.Text = frmAbsenLate.ListView1.FocusedItem.SubItems(1).Text
            If dr.Read = True Then
                txtName.Tag = dr(7).ToString
                txtFMA.Tag = dr(6).ToString
                txtFMA.Text = dr(0).ToString
                txtFMA1.Text = dr(1).ToString
                txtSMA.Text = dr(2).ToString
                txtSML.Text = dr(3).ToString
                txtTMA.Text = dr(4).ToString
                txtTML.Text = dr(5).ToString
            End If
        Catch ex As Exception
            ' MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub BindToText()
        Try
            sqL = "SELECT FMA, FML, SMA, SML, TMA, TML, ALNo, s.StudentNO, CONCAT(Lastname, ', ', Firstname, ' ', MI) as SName FROM AbsentLate al INNER JOIN Student s ON al.StudentNo =s.StudentNo WHERE ALNO = '" & ListView1.FocusedItem.SubItems(2).Text & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            txtName.Text = frmAbsenLate.ListView1.FocusedItem.SubItems(1).Text
            If dr.Read = True Then
                txtName.Tag = dr(7).ToString
                txtFMA.Tag = dr(6).ToString
                txtFMA.Text = dr(0).ToString
                txtFMA1.Text = dr(1).ToString
                txtSMA.Text = dr(2).ToString
                txtSML.Text = dr(3).ToString
                txtTMA.Text = dr(4).ToString
                txtTML.Text = dr(5).ToString
                txtName.Text = dr("SName").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub


    Private Sub LoadStudentsUpdating()
        Try
            If frmMain.lblRole.Text.ToUpper() = "ADMIN" Then
                sqL = "SELECT s.StudentNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as StudName, ALNo FROM Student s INNER JOIN SECTION sec ON s.SectionNo = sec.SectionNo LEFT OUTER JOIN Absentlate al ON s.StudentNo = al.StudentNo WHERE sec.SectionNo = '" & frmAbsenLate.txtSection.Tag & "' AND GradingPeriod = '" & frmAbsenLate.cmbGrading.Text & "' GROUP BY StudentNo ORDER BY Lastname, Firstname"
            Else
                sqL = "SELECT s.StudentNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as StudName, ALNo FROM Student s INNER JOIN SECTION sec ON s.SectionNo = sec.SectionNo LEFT OUTER JOIN Absentlate al ON s.StudentNo = al.StudentNo WHERE SectionName = '" & frmAbsenLate.txtSection.Text & "' AND GradingPeriod = '" & frmAbsenLate.cmbGrading.Text & "' GROUP BY StudentNo ORDER BY Lastname, Firstname"
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
                sqL = "SELECT s.StudentNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as StudName FROM Student s INNER JOIN SECTION sec ON s.SectionNo = sec.SectionNo WHERE sec.SectionNo = '" & frmAbsenLate.txtSection.Tag & "'  GROUP BY StudentNo ORDER BY Lastname, Firstname"
            Else
                sqL = "SELECT s.StudentNo, CONCAT(Lastname, ', ', Firstname, ' ', MI) as StudName FROM Student s INNER JOIN SECTION sec ON s.SectionNo = sec.SectionNo WHERE SectionName = '" & frmAbsenLate.txtSection.Text & "'  GROUP BY StudentNo ORDER BY Lastname, Firstname"
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

    Private Sub frmAddEditAbsentLate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnSave.Enabled = False
        Me.loadstud()
       


    End Sub

    Sub loadstud()
        If frmAbsenLate.cmbGrading.Text = "First" Then
            lblFM.Text = "June"
            lblSM.Text = "July"
            lblTM.Text = "August"
            lblTM.Visible = True
            txtTMA.Visible = True
            txtTML.Visible = True
        ElseIf frmAbsenLate.cmbGrading.Text = "Second" Then
            lblFM.Text = "September"
            lblSM.Text = "October"
            lblTM.Text = "November"
            lblTM.Visible = True
            txtTMA.Visible = True
            txtTML.Visible = True
        ElseIf frmAbsenLate.cmbGrading.Text = "Third" Then
            lblFM.Text = "December"
            lblSM.Text = "January"
            lblTM.Text = ""
            lblTM.Visible = False
            txtTMA.Visible = False
            txtTML.Visible = False
        ElseIf frmAbsenLate.cmbGrading.Text = "Fourth" Then
            lblFM.Text = "February"
            lblSM.Text = "March"
            lblTM.Text = ""
            lblTM.Visible = False
            txtTMA.Visible = False
            txtTML.Visible = False
        End If

        If adding = True Then
            lblTitle.Text = "Adding Absent/Late"
            txtFMA.Text = ""
            txtFMA1.Text = ""
            txtSMA.Text = ""
            txtSML.Text = ""
            txtTMA.Text = ""
            txtTML.Text = ""
            txtName.Text = ""
            LoadStudentsAdding()

            Dim x As String
            Dim iCtr As Integer = ListView1.Items.Count
            Dim ctr As Integer = ListView1.Items.Count


            Try
                For i As Integer = 0 To ListView1.Items.Count - 1

                    iCtr = iCtr - 1
                    x = ListView1.Items(iCtr).Text
                    If ValidateTableData("SELECT * FROM AbsentLate WHERE StudentNo = '" & x & "' AND GradingPeriod= '" & frmAbsenLate.cmbGrading.Text & "'") = True Then

                        ListView1.Items.Remove(ListView1.Items(iCtr))
                    End If
                    '  iCtr = iCtr + 1
                Next

            Catch ex As Exception

            End Try
        Else
            lblTitle.Text = "Updating Absent/Late"
            GetALInfo()
            LoadStudentsUpdating()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmLoadStudent.ShowDialog()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtName.Text = "" Then
            MsgBox("Please select student.", MsgBoxStyle.Exclamation, "Warning")
            Exit Sub
        End If

        If adding = True Then

            strsSQL = "INSERT INTO AbsentLate(StudentNo, FMA, FML, SMA, SML, TMA, TML, GradingPeriod) VALUES('" & txtName.Tag & "', '" & txtFMA.Text & "', '" & txtFMA1.Text & "', '" & txtSMA.Text & "', '" & txtSML.Text & "', '" & txtTMA.Text & "', '" & txtTML.Text & "', '" & frmAbsenLate.cmbGrading.Text & "')"
            If AddEditData(strsSQL) = True Then
                MsgBox("Absent/Late added successfully.", MsgBoxStyle.Information, "Adding")
            End If
        Else
            strsSQL = "UPDATE AbsentLate SET StudentNo = '" & txtName.Tag & "',  FMA = '" & txtFMA.Text & "', FML = '" & txtFMA1.Text & "', SMA = '" & txtSMA.Text & "', SML = '" & txtSML.Text & "', TMA = '" & txtTMA.Text & "', TML = '" & txtTML.Text & "', GradingPeriod = '" & frmAbsenLate.cmbGrading.Text & "' WHERE ALNo = '" & txtFMA.Tag & "'"
            If AddEditData(strsSQL) = True Then
                MsgBox("Absent/Late updated successfully.", MsgBoxStyle.Information, "Updating")
            End If
        End If
        frmAbsenLate.LoadAL()
        loadstud()
    End Sub

    Private Function isFieldHasData()
        isFieldHasData = False
        If txtFMA.Text <> "" Or txtFMA1.Text <> "" Or txtSMA.Text <> "" Or txtSML.Text <> "" Or txtTMA.Text <> "" Or txtTML.Text <> "" Then
            isFieldHasData = True
        End If
    End Function

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub ListView1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.Click
        If editing = True Then
            BindToText()
        End If

        If adding = True Then
            txtName.Text = ListView1.FocusedItem.SubItems(1).Text
            txtName.Tag = ListView1.FocusedItem.Text
        End If
    End Sub

    Private Sub txtFMA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFMA.TextChanged

        If isFieldHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If

        If txtFMA.Text = "" Then
            Exit Sub
        End If


        If IsNumeric(txtFMA.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtFMA.Clear()
        End If

    End Sub

    Private Sub txtFMA1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFMA1.TextChanged


        If isFieldHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If

        If txtFMA1.Text = "" Then
            Exit Sub
        End If


        If IsNumeric(txtFMA1.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtFMA1.Clear()
        End If

    End Sub

    Private Sub txtSMA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSMA.TextChanged
        If isFieldHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If

        If txtSMA.Text = "" Then
            Exit Sub
        End If


        If IsNumeric(txtSMA.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtSMA.Clear()
        End If

      
    End Sub

    Private Sub txtSML_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSML.TextChanged
        If isFieldHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If

        If txtSML.Text = "" Then
            Exit Sub
        End If


        If IsNumeric(txtSML.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtSML.Clear()
        End If

      
    End Sub

    Private Sub txtTMA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTMA.TextChanged
        If isFieldHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If

        If txtTMA.Text = "" Then
            Exit Sub
        End If


        If IsNumeric(txtTMA.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtTMA.Clear()
        End If

     
    End Sub

    Private Sub txtTML_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTML.TextChanged


        If isFieldHasData() = True Then
            btnSave.Enabled = True
        Else
            btnSave.Enabled = False
        End If

        If txtTML.Text = "" Then
            Exit Sub
        End If


        If IsNumeric(txtTML.Text) = True Then
            'do nothing
        Else
            MsgBox("Please enter numeric data only.", MsgBoxStyle.Exclamation, "Warning")
            txtTML.Clear()
        End If

    End Sub
End Class