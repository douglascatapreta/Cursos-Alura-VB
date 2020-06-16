Public Class Frm_TelaPrincipal_02
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btn_NumerosInteiros.Click

        Dim idade As Integer
        idade = 12
        MsgBox("O valor da idade é " + idade.ToString, MsgBoxStyle.Critical)

        idade = 12 * 5
        MsgBox("O valor da idade multiplicado por 5 é " + idade.ToString, MsgBoxStyle.Critical)

        idade = (12 * 5) + 10
        MsgBox("O valor da idade multiplicado por 5 e somado a 10 é " + idade.ToString, MsgBoxStyle.Critical)

    End Sub

    Private Sub Btn_NumerosFlutuantes_Click(sender As Object, e As EventArgs) Handles Btn_NumerosFlutuantes.Click

        Dim valor As Double
        valor = 9.5
        MsgBox("A variável valor é igual à " + valor.ToString, MsgBoxStyle.Critical)

        valor = 5 / 2
        MsgBox("O valor de 5/2 é " + valor.ToString, MsgBoxStyle.Critical)

        Dim numerador As Integer = 5
        Dim denominador As Integer = 2

        valor = numerador / denominador

        MsgBox("O valor de 5/2 é " + valor.ToString, MsgBoxStyle.Critical)

    End Sub

    Private Sub Btn_ConversaoNumeros_Click(sender As Object, e As EventArgs) Handles Btn_ConversaoNumeros.Click

        Dim salario As Double
        salario = 1300.45

        Dim salarioInteiro As Integer
        salarioInteiro = salario

        MsgBox("O valor do salário é " + salario.ToString + " e do salário inteiro é " + salarioInteiro.ToString, MsgBoxStyle.Critical)

        Dim salarioGrande As Long
        salarioGrande = 1000000000000000000
        MsgBox("O valor do salário longo é " + salarioGrande.ToString, MsgBoxStyle.Critical)

        Dim salarioPequeno As Short
        salarioPequeno = 10000
        MsgBox("O valor do salário curto é " + salarioPequeno.ToString, MsgBoxStyle.Critical)

        Dim salarioMinusculo As SByte
        salarioMinusculo = 100
        MsgBox("O valor do salário minúsculo é " + salarioMinusculo.ToString, MsgBoxStyle.Critical)

        Dim valorDouble As Double
        valorDouble = 9.238748234798
        MsgBox("O valor do double é " + valorDouble.ToString, MsgBoxStyle.Critical)

        Dim valorDecimal As Decimal
        valorDecimal = 9.238748234798
        MsgBox("O valor do decimal é " + valorDecimal.ToString, MsgBoxStyle.Critical)

        'Decimal tem maior precisão que o Double

    End Sub

    Private Sub Btn_Resultado_Click(sender As Object, e As EventArgs) Handles Btn_Resultado.Click

        Dim numerador As Decimal
        Dim denominador As Decimal

        numerador = Txt_Numerador.Text
        denominador = Txt_Denominador.Text

        Dim resultadoDouble As Double
        resultadoDouble = numerador / denominador

        Txt_ResultadoDouble.Text = resultadoDouble

        MsgBox("O resultado (Double) da divisão de " + numerador.ToString + " por " + denominador.ToString + " é " + resultadoDouble.ToString, MsgBoxStyle.Critical)

        Dim resultadoDecimal As Decimal
        resultadoDecimal = numerador / denominador

        Txt_ResultadoDecimal.Text = resultadoDecimal

        MsgBox("O resultado (Decimal) da divisão de " + numerador.ToString + " por " + denominador.ToString + " é " + resultadoDecimal.ToString, MsgBoxStyle.Critical)

    End Sub
End Class
