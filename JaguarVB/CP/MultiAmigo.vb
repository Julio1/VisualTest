Imports Microsoft.VisualBasic

Public Class MultiAmigo


    Public Sub registro(ByVal pnombre As String, ByVal pfechaNascimiento)

        Dim sql As String = "INSERT INTO [TAmigo] ([Nombre],[fechaNascimiento])  VALUES  ('" + pnombre + "',' " + pfechaNascimientoSql + "')"

        Dim miConector As New Conector

        Try
            miConector.ejecutarSQL(sql)

        Catch ex As Exception

        End Try



    End Sub








End Class
