Public Class Ver

    Private Sub Ver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Dim miGestor As Gestor = New Gestor()
        Try
            DataGridView1().DataSource = miGestor.listar
        Catch ex As Exception

        End Try


    End Sub
End Class