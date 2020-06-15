Public Class Frm_TelaPrincipal_05
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Lbl_NomeProjeto.Text = "5 - Laços de Repetição"
        Me.Text = "5 - Laços de Repetição"

        Lbl_Principal.Text = "Valor investido"
        Lbl_Rendimento.Text = "Juros (%)"
        Lbl_Periodos.Text = "Período"
        Btm_While.Text = "Calcular valor usando WHILE"
        Btm_For.Text = "Calcular valor usando FOR"
        Grp_Grupo1.Text = "Cálculo do investimento por WHILE e por FOR"

        Grp_Grupo2.Text = "Cálculo do investimento anual"
        Lbl_Principal2.Text = "Valor investido"
        Lbl_Rendimento2.Text = "Juros mensais (%)"
        Lbl_Anos.Text = "Anos aplicados"
        Lbl_AcrescimoRendimento.Text = "Acréscimo juros (%)"
        Lbl_Limite.Text = "Limite"
        Btm_Calcula.Text = "Efetua cálculo"

    End Sub

    Private Sub Btm_While_Click(sender As Object, e As EventArgs) Handles Btm_While.Click

        Dim Investimento As Double = Val(Txt_Principal.Text)
        Dim Rendimento As Double = Val(Txt_Rendimento.Text)
        Dim Periodos As Integer = Val(Txt_Periodos.Text)
        Dim Extrato As String = ""

        Dim Contador As Integer = 1

        While Contador <= Periodos

            Investimento += (Investimento * (Rendimento / 100))
            Extrato += "O saldo do invenstimento no mês " + Contador.ToString + " é: " + Investimento.ToString + vbCrLf
            Contador += 1

        End While

        Txt_Extrato_While.Text = Extrato

    End Sub

    Private Sub Btm_For_Click(sender As Object, e As EventArgs) Handles Btm_For.Click

        Dim Investimento As Double = Val(Txt_Principal.Text)
        Dim Rendimento As Double = Val(Txt_Rendimento.Text)
        Dim Periodos As Integer = Val(Txt_Periodos.Text)
        Dim Extrato As String = ""

        For i As Integer = 1 To Periodos

            Investimento += (Investimento * (Rendimento / 100))
            Extrato += "O saldo do invenstimento no mês " + i.ToString + " é: " + Investimento.ToString + vbCrLf

        Next

        Txt_Extrato_For.Text = Extrato

    End Sub

    Private Sub Btm_Calcula_Click(sender As Object, e As EventArgs) Handles Btm_Calcula.Click

        Dim investimento As Double = Val(Txt_Principal2.Text)
        Dim rendimento As Double = Val(Txt_Rendimento2.Text)
        Dim anos As Integer = Val(Txt_Anos.Text)
        Dim acrescimoJuros As Double = Val(Txt_AcrescimoRendimento.Text)
        Dim limite As Double = Val(Txt_Limite.Text)
        Dim extrato As String = ""
        Dim contador As Integer = 1

        Dim executouExitFor As Boolean = False

        For i As Integer = 1 To anos

            For j As Integer = 1 To 12
                investimento += investimento * (rendimento / 100)
                extrato += "O saldo do invenstimento no mês " + contador.ToString + " é " + investimento.ToString + " usando a taxa " + rendimento.ToString + " % mês " + vbCrLf

                If investimento >= limite Then
                    extrato += "O investimento atingiu o limite" + vbCrLf
                    executouExitFor = True
                    Exit For
                End If

                contador += 1
            Next

            If executouExitFor Then
                Exit For
            End If

            rendimento += rendimento * (acrescimoJuros / 100)

        Next

        Txt_Resultado.Text = extrato

    End Sub
End Class
