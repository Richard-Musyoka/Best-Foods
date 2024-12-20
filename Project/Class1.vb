Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Class1
    Public sqlcon As New SqlConnection With {.ConnectionString = "server=localhost;user id=root;password=;database=Bestfood;"}

    Public sqlcmd As SqlCommand

    Public Function hasconnection() As Boolean
        Try
            sqlcon.Open()

            sqlcon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
