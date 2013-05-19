

Public Class Calculadora

    Dim xNum As Decimal
    Dim xoperator As String

    '*********************************************************************************************************************
    Sub calcular(ByVal valor)
        txtPantalla.Text = CStr(((CInt(txtPantalla.Text) * 10) + valor))
    End Sub

    '*********************************************************************************************************************

    Sub operador(ByVal oper)
        xoperator = oper
        xNum = CInt(txtPantalla.Text)
        txtPantalla.Text = 0
    End Sub


    '*********************************************************************************************************************

    Private Sub Calculadora_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    '*********************************************************************************************************************


    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        calcular(1)

    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        calcular(2)
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        calcular(3)
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        calcular(4)
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        calcular(5)
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        calcular(6)
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        calcular(7)
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        calcular(8)
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        calcular(9)
    End Sub

    Private Sub btn0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click
        calcular(0)
    End Sub

    '*********************************************************************************************************************

    Private Sub btnsuma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsuma.Click
        operador("+")
    End Sub

    Private Sub btnresta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnresta.Click
        operador("-")
    End Sub

    Private Sub btnproducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnproducto.Click
        operador("*")
    End Sub

    Private Sub btndivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndivision.Click
        operador("/")
    End Sub


    '*********************************************************************************************************************


    Private Sub btnIgual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIgual.Click

        Select Case xoperator
            Case "+" : txtPantalla.Text = CStr(xNum + CDec(txtPantalla.Text))
            Case "*" : txtPantalla.Text = CStr(xNum * CDec(txtPantalla.Text))
            Case "-" : txtPantalla.Text = CStr(xNum - CDec(txtPantalla.Text))
            Case "/" : txtPantalla.Text = CStr(xNum / CDec(txtPantalla.Text))

        End Select


    End Sub

    Private Sub txtpantalla_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPantalla.TextChanged

    End Sub
End Class
