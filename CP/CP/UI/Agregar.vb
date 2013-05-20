

Public Class Agregar

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub Agregar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Registrar.Click

        Dim nombre As String = nombreTxt.Text
        Dim fechaNasc As Date = fechaNascTdp.Value

        Dim miGestor As Gestor = New Gestor()

        Try
            miGestor.registrar(nombre, fechaNasc)
        Catch ex As Exception

        End Try

        nombreTxt.Text() = String.Empty




    End Sub
End Class