Imports System.Data.SqlClient

Public Class Gestor



    Public Sub registrar(ByVal pnombre, ByVal pfechaNasc)

        Dim fechaSQL As String = Convert.ToString(pfechaNasc, Threading.Thread.CurrentThread.CurrentCulture)
        ' Console.WriteLine(pfechaNasc)
        'MessageBox.Show(pfechaNasc)
        'MessageBox.Show(fechaSQL)

        'Dim FechaBrava = pfechaNasc.ToString("dd-mm-yyyy")


        Dim Julio = pfechaNasc.ToShortDateString()


        MessageBox.Show(Julio)

        ' Dim fechaSQL As DateTime = pfechaNasc
        'Dim sql As String = "INSERT INTO [TAmigo] ([Nombre],[fechaNascimiento])  VALUES  ('" & pnombre & "','" & pfechaNasc & "')"
        'Dim sql As String = "INSERT INTO [TAmigo] ([Nombre],[fechaNascimiento])  VALUES  ('" & pnombre & "','10-5-1982')"
        'Dim sql As String = "INSERT INTO [TAmigo] ([Nombre],[fechaNascimiento])  VALUES  ('" & pnombre & "',' Convert(VARCHAR, " & pfechaNasc & ", 101) ')AS DateOnly"
        Dim sql As String = "INSERT INTO [TAmigo] ([Nombre],[FechaNascimiento])  VALUES  ('" & pnombre & "','" & Julio & "')"
        Dim miConector As Conector = New Conector()

        Try


            miConector.ejecutarSQL(sql)
        Catch ex As Exception

        End Try


    End Sub






End Class
