Public Class Ver

    Private Sub Ver_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BDJaguarDataSet.TAmigo' table. You can move, or remove it, as needed.
        Me.TAmigoTableAdapter.Fill(Me.BDJaguarDataSet.TAmigo)
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class