'Imports CL.Gestor

Public Class Agregar

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
    Private Sub Agregar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nombreTxt.TextChanged

    End Sub

    Private Sub Registrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Registrar.Click

        Dim nombre As String = nombreTxt.Text
        Dim fechaNascimiento = fechaNascimientoDtp.Value




    End Sub
End Class