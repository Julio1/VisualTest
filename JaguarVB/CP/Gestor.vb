Imports Microsoft.VisualBasic

Public Class Gestor


#Region "Registro"


    Public Sub registrarAmigo(ByVal pnombre As String, ByVal pfechaNascimiento As Date)

        Dim objMultiAmigo As New MultiAmigo()

        Try

            objMultiAmigo.registro(pnombre, pfechaNascimiento)

        Catch ex As Exception

        End Try


    End Sub

#End Region










End Class
