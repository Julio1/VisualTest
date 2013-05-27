Imports System.Data.SqlClient
Imports CP
Imports CP.Amigo


Public Class Gestor



    Public Sub registrar(ByVal pnombre, ByVal pfechaNasc)

        Dim fechaSQL As String = Convert.ToString(pfechaNasc, Threading.Thread.CurrentThread.CurrentCulture)
        Dim fechaSimple = pfechaNasc.ToShortDateString()
        ' Dim fechaSQL As DateTime = pfechaNasc
        'Dim sql As String = "INSERT INTO [TAmigo] ([Nombre],[fechaNascimiento])  VALUES  ('" & pnombre & "','" & pfechaNasc & "')"
        'Dim sql As String = "INSERT INTO [TAmigo] ([Nombre],[fechaNascimiento])  VALUES  ('" & pnombre & "','10-5-1982')"
        'Dim sql As String = "INSERT INTO [TAmigo] ([Nombre],[fechaNascimiento])  VALUES  ('" & pnombre & "',' Convert(VARCHAR, " & pfechaNasc & ", 101) ')AS DateOnly"
        Dim sql As String = "INSERT INTO [TAmigo] ([Nombre],[FechaNascimiento])  VALUES  ('" & pnombre & "','" & fechaSimple & "')"
        Dim miConector As Conector = New Conector()

        Try


            miConector.ejecutarSQL(sql)
        Catch ex As Exception

        End Try


    End Sub


    Public Function listar()

        Dim listaAmigos As List(Of Amigo) = New List(Of Amigo)
        Dim miConector As Conector = New Conector()
        Dim SQL As String = "SELECT Id, Nombre, FechaNascimiento FROM  dbo.TAmigo"

        Dim reader As SqlDataReader = miConector.ejecutarSQLListar(SQL)
        'Dim NuevoAmigo As New Amigo()
        Try
            Do While reader.Read()

                'Console.WriteLine(reader)
                '   MessageBox.Show("id" & reader.GetInt32(0))
                '  MessageBox.Show("nombre " & reader.GetValue(1).ToString)
                ' MessageBox.Show("Nascimiento " & reader.GetValue(2))
                'Dim NuevoAmigo As New Amigo(reader.GetInt32(0), reader.GetValue(1).ToString, reader.GetValue(2))
                listaAmigos.Add(New Amigo(reader.GetInt32(0), reader.GetValue(1).ToString, reader.GetValue(2)))


            Loop

            reader.Close()

        Catch ex As Exception

        End Try
       

        '       While reader.NextResult
        '            End While

        Return listaAmigos
    End Function

    'Private Function NuevoAmigo(ByVal p1 As Integer, ByVal p2 As String, ByVal p3 As Object) As Amigo
    '    Throw New NotImplementedException
    'End Function
















End Class
