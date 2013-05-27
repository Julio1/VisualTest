Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Data.SqlTypes

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
        connection.Open()
        Try
            Dim cmd As New SqlCommand(slq, connection)
            cmd.ExecuteNonQuery()
        Catch ex As Exception

        End Try

    End Sub


    'Function ejecutarSQLListar(ByVal sql As String) As SqlDataReader

    '    Dim reader As SqlDataReader
    '    Dim connection As New SqlConnection(GetConnectionString())
    '    connection.Open()
    '    Dim cmd As New SqlCommand()
    '    cmd.CommandText = sql
    '    Try


    '        If cmd.Connection.State = ConnectionState.Closed Then
    '            cmd.Connection.Open()
    '        End If

    '        reader = cmd.ExecuteReader
    '    Catch ex As Exception

    '    End Try

    '    Return reader
    'End Function

    Public Function ejecutarSQLListar(ByVal pSQL As String) As IDataReader
        Dim cmd As SqlCommand
        Dim connection As New SqlConnection(GetConnectionString())

        'se crea el comando
        cmd = New SqlCommand
        cmd.Connection = connection
        'se sacan los parámetros

        cmd.CommandText = pSQL

        'si la conexión no está abierta, se abre
        If cmd.Connection.State = ConnectionState.Closed Then
            cmd.Connection.Open()
        End If

        Dim miReader As SqlDataReader = cmd.ExecuteReader()


        Return miReader
        'Cierra la conexion
        cmd.Connection.Close()
    End Function


End Class
