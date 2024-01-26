
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports System.Drawing


Public Class frmGradePerStudent

    Private Sub frmGradePerStudent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim strGrade As String

        If frmMain.lblRole.Text.ToUpper() = "ADMIN" Then
            strGrade = frmGrades.gradesGrade
        Else
            strGrade = frmMain.lblGrade.Text
        End If

        If isHighSchool(strGrade) = True Then
            lblRR.Text = "Research  "
            lblLanguage.Text = "Foreign Language : "
        Else
            lblRR.Text = "Reading/Speech  "
            lblLanguage.Text = "Mother Tongue : "
        End If
        ClearLabels()
        LoadGrade()
    End Sub

    Private Sub LoadGrade()
        Try
            With frmGrades.ListView1
                lblName.Text = .FocusedItem.SubItems(1).Text
                lblSection.Text = .FocusedItem.SubItems(2).Text
                lblGradingPeriod.Text = .FocusedItem.SubItems(3).Text

                lblFilipino.Text = equivalentLetter(CInt(.FocusedItem.SubItems(4).Text))
                lblEnglish.Text = equivalentLetter(CInt(.FocusedItem.SubItems(5).Text))
                lblMath.Text = equivalentLetter(CInt(.FocusedItem.SubItems(6).Text))
                lblScience.Text = equivalentLetter(CInt(.FocusedItem.SubItems(7).Text))
                lblAP.Text = equivalentLetter(CInt(.FocusedItem.SubItems(8).Text))
                lblMAPEH.Text = equivalentLetter(CInt(.FocusedItem.SubItems(9).Text))
                lblHomeroom.Text = equivalentLetter(CInt(.FocusedItem.SubItems(10).Text))
                lblRRValue.Text = equivalentLetter(CInt(.FocusedItem.SubItems(11).Text))
                lblEP.Text = equivalentLetter(CInt(.FocusedItem.SubItems(12).Text))
                lblCCBA.Text = equivalentLetter(CInt(.FocusedItem.SubItems(13).Text))
                lblComputer.Text = equivalentLetter(CInt(.FocusedItem.SubItems(14).Text))
                lblLanguageValue.Text = equivalentLetter(CInt(.FocusedItem.SubItems(15).Text))
                lblCIG.Text = equivalentLetter(CInt(.FocusedItem.SubItems(16).Text))


            End With
        Catch ex As Exception

        End Try

      


    End Sub

    Private Sub ClearLabels()
        lblName.Text = ""
        lblSection.Text = ""
        lblGradingPeriod.Text = ""

        lblFilipino.Text = ""
        lblEnglish.Text = ""
        lblMath.Text = ""
        lblScience.Text = ""
        lblAP.Text = ""
        lblMAPEH.Text = ""
        lblHomeroom.Text = ""
        lblRRValue.Text = ""
        lblEP.Text = ""
        lblCCBA.Text = ""
        lblComputer.Text = ""
        lblLanguageValue.Text = ""
        lblCIG.Text = ""
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.Panel1.Width, Me.Panel1.Height)

        Panel1.DrawToBitmap(bm, New Rectangle(0, 0, Me.Panel1.Width, Me.Panel1.Height))

        e.Graphics.DrawImage(bm, 50, 60)
        Dim aPS As New PageSetupDialog

        aPS.Document = PrintDocument1
    End Sub


    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        PrintDialog1.Document = Me.PrintDocument1

        Dim ButtonPressed As DialogResult = PrintDialog1.ShowDialog()
        If (ButtonPressed = DialogResult.OK) Then
            PrintDocument1.Print()
            Me.Close()
        End If
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class