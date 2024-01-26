Imports System
Imports System.IO
Imports System.Threading
Imports System.Management
Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Module modFunction
  

    Public Function AddEditData(ByVal strSQL As String)
        Dim ret As Boolean = False
        Try
            ConnDB()
            cmd = New MySqlCommand(strSQL, conn)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If i > 0 Then
                ret = True
            End If

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
        Return ret
    End Function

    Public Function GetNumberData(ByVal strSQL As String)
        GetNumberData = ""
        Try
            ConnDB()
            cmd = New MySqlCommand(strSQL, conn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                Dim x As Integer = dr(0).ToString
                Return dr(0).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function

    Public Function GetStringData(ByVal strSQL As String)
        GetStringData = ""
        Try
            ConnDB()
            cmd = New MySqlCommand(strSQL, conn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                Return dr(0).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function

    Public Function ValidateTableData(ByVal strSQL As String)
        ValidateTableData = False
        Try
            ConnDB()
            cmd = New MySqlCommand(strSQL, conn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Function

    Public Function ValidateTableData2(ByVal strSQL As String)
        ValidateTableData2 = False
        Try
            ConnDB()
            cmd = New MySqlCommand(strSQL, conn)
            dr = cmd.ExecuteReader
            If dr.Read = True Then
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
           
        End Try
    End Function

    Public Function isHighSchool(ByVal grade As String)
        Dim ret As Boolean = False
       
        If grade.ToUpper() = "GRADE 7" Or grade.ToUpper() = "GRADE 8" Or grade.ToUpper() = "GRADE 9" Or grade.ToUpper() = "GRADE 10" Or grade.ToUpper() = "GRADE 11" Or grade.ToUpper() = "GRADE 12" Then
            ret = True
        End If

        Return ret
    End Function

    Public Function equivalentLetter(ByVal grade As String)
        Dim ret As String = ""
        Dim intGrade As Integer
        If grade <> "" Then
            intGrade = CInt(grade)
        Else
            intGrade = 0
        End If
        If intGrade < 74 Then
            ret = intGrade.ToString() & " B"
        ElseIf intGrade >= 75 And intGrade <= 79 Then
            ret = intGrade.ToString() & " D"
        ElseIf intGrade >= 80 And intGrade <= 84 Then
            ret = intGrade.ToString() & " AP"
        ElseIf intGrade >= 85 And intGrade <= 89 Then
            ret = intGrade.ToString() & " P"
        ElseIf intGrade >= 90 Then
            ret = intGrade.ToString() & " A"
        End If

        If intGrade <= 0 Then
            ret = ""
        End If

        Return ret
    End Function

    Public Function equivalentLetterCompute(ByVal grade As String)
        Dim ret As String = ""
        Dim intGrade As Integer
        If grade <> "" Then
            intGrade = CInt(grade)
        Else
            intGrade = 0
        End If
        If intGrade < 74 Then
            ret = "B"
        ElseIf intGrade >= 75 And intGrade <= 79 Then
            ret = "D"
        ElseIf intGrade >= 80 And intGrade <= 84 Then
            ret = "AP"
        ElseIf intGrade >= 85 And intGrade <= 89 Then
            ret = "P"
        ElseIf intGrade >= 90 Then
            ret = "A"
        End If

        If intGrade <= 0 Then
            ret = ""
        End If

        Return ret
    End Function


    Public Function GetTotalEquivalent(ByVal score As Integer, ByVal max As Integer)
        Dim ret As Integer

        Try
            sqL = "Select Equivalent FROM Transmutation WHERE Score = '" & score & "' AND Max = '" & max & "'"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader

            If dr.Read = True Then
                ret = dr(0)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try

        Return ret
    End Function

End Module
