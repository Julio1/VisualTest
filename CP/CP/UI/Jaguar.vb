Public Class Jaguar

    Private Sub IngresarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IngresarToolStripMenuItem.Click

        Dim form As New Agregar
        form.MdiParent = Me
        form.Show()

    End Sub

    Private Sub VerAmigosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerAmigosToolStripMenuItem.Click

        Dim form As New Ver
        form.MdiParent = Me
        form.Show()

    End Sub
End Class
