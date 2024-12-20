Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.IO
Imports System.Net.Mail
Imports MySql.Data
Imports MySql.Data.MySqlClient
Public Class Functions
    Public connString As String = "server=localhost,userid=root,password=,database=Bestfood;"
    Public conn As MySqlConnection
    Public Sub connection()
        conn = New MySqlConnection
        Try
            conn.ConnectionString = connString
            conn.Open()



        Catch ex As Exception

        End Try
    End Sub
End Class
