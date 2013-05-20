Imports System.Data.SqlClient
Imports System.Data.Sql

Public Class Conector


    Private Sub OpenSqlConnection()
        Dim connectionString As String = GetConnectionString()

        Using connection As New SqlConnection(connectionString)

            connection.Open()

            Console.WriteLine("State: {0}", connection.State)
            Console.WriteLine("ConnectionString: {0}", _
                connection.ConnectionString)
        End Using
    End Sub

    Private Function GetConnectionString() As String
        ' To avoid storing the connection string in your code,   
        ' you can retrieve it from a configuration file, using the 
        ' System.Configuration.ConfigurationSettings.AppSettings property 
        Return "Data Source=(local);Database=BDJaguar;" _
          & "Integrated Security=SSPI;"
    End Function



    Public Sub ejecutarSQL(ByVal slq As String)

        Dim connection As New SqlConnection(GetConnectionString())
        OpenSqlConnection()
        Try
            Dim cmd As New SqlCommand(slq, connection)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try



    End Sub



End Class
