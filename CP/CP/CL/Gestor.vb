Imports System.Data.SqlClient

Public Class Gestor



    Public Sub registrar(ByVal pnombre As String, ByVal pfechaNasc As Date)

        Dim sql As String = "INSERT INTO [TAmigo] ([Nombre],[fechaNascimiento])  VALUES  ('" + pnombre + "',' " + pfechaNasc + "')"

        Dim miConector As Conector = New Conector()

        Try


            miConector.ejecutarSQL(sql)
        Catch ex As Exception

        End Try


    End Sub






End Class
