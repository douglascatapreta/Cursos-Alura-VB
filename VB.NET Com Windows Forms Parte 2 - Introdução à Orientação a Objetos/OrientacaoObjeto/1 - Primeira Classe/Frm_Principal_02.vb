Public Class Frm_Principal_02
    Dim ContaDaGabriela As New ContaCorrente
    Dim ContaDoBruno As New ContaCorrente

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "1 - Primeira Classe - Formulário 02"
        Lbl_Principal_02.Text = "1 - Primeira Classe - Formulário 02"

        ' Inicialização dos textos para Gabriela
        Lbl_SaldoAtual_Gabriela.Text = "Saldo atual"
        Lbl_Valor_Gabriela.Text = "Valor a ser depositado ou sacado"
        Btm_Depositar_Gabriela.Text = "Efetuar Depósito"
        Btm_Sacar_Gabriela.Text = "Efetuar Saque"
        Btm_Transferir_Gabriela.Text = "Efetuar Transferência"
        Lbl_NovoSaldo_Gabriela.Text = "Novo saldo"
        Lbl_Resultado_Gabriela.Text = "Resultado da operação"
        Grp_Gabriela.Text = "Gabriela"

        Txt_SaldoAtual_Gabriela.ReadOnly = True
        Txt_NovoSaldo_Gabriela.ReadOnly = True
        Txt_Resultado_Gabriela.ReadOnly = True
        Txt_Extrato_Gabriela.ReadOnly = True

        ' Inicializar os dados da classe
        ContaDaGabriela.Titular = "Gabriela"
        ContaDaGabriela.Agencia = 863
        ContaDaGabriela.Conta = 863141

        Lbl_BemVindo_Gabriela.Text = "Bem Vindo " + ContaDaGabriela.Titular + " Agência: " + ContaDaGabriela.Agencia.ToString + " Conta Corrente: " + ContaDaGabriela.Conta.ToString
        Txt_SaldoAtual_Gabriela.Text = ContaDaGabriela.Saldo.ToString

        ' Inicialização dos textos para Bruno
        Lbl_SaldoAtual_Bruno.Text = "Saldo atual"
        Lbl_Valor_Bruno.Text = "Valor a ser depositado ou sacado"
        Btm_Depositar_Bruno.Text = "Efetuar Depósito"
        Btm_Sacar_Bruno.Text = "Efetuar Saque"
        Btm_Transferir_Bruno.Text = "Efetuar Transferência"
        Lbl_NovoSaldo_Bruno.Text = "Novo saldo"
        Lbl_Resultado_Bruno.Text = "Resultado da operação"
        Grp_Bruno.Text = "Bruno"

        Txt_SaldoAtual_Bruno.ReadOnly = True
        Txt_NovoSaldo_Bruno.ReadOnly = True
        Txt_Resultado_Bruno.ReadOnly = True
        Txt_Extrato_Bruno.ReadOnly = True

        ' Inicializar os dados da classe
        ContaDoBruno.Titular = "Bruno"
        ContaDoBruno.Agencia = 863
        ContaDoBruno.Conta = 863141

        Lbl_BemVindo_Bruno.Text = "Bem Vindo " + ContaDoBruno.Titular + " Agência: " + ContaDoBruno.Agencia.ToString + " Conta Corrente: " + ContaDoBruno.Conta.ToString
        Txt_SaldoAtual_Bruno.Text = ContaDoBruno.Saldo.ToString

    End Sub

    Private Sub Btm_Sacar_Click(sender As Object, e As EventArgs) Handles Btm_Sacar_Gabriela.Click

        Txt_Resultado_Gabriela.Text = ""
        Txt_NovoSaldo_Gabriela.Text = ""

        Dim ValorSacar As Double = Val(Txt_Valor_Gabriela.Text)

        Dim RetornoSaque As Boolean = ContaDaGabriela.Sacar(ValorSacar)

        If RetornoSaque Then
            Txt_Resultado_Gabriela.Text = "Saque efetuado com sucesso"
            Txt_NovoSaldo_Gabriela.Text = ContaDaGabriela.Saldo.ToString
            Txt_SaldoAtual_Gabriela.Text = ContaDaGabriela.Saldo.ToString
            ContaDaGabriela.Extrato += Now.ToString + " Saque de " + ValorSacar.ToString + " Saldo " + ContaDaGabriela.Saldo.ToString + vbCrLf
            Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato
        Else
            Txt_Resultado_Gabriela.Text = "Saque não é possível ser feito"
        End If

    End Sub

    Private Sub Btm_Depositar_Click(sender As Object, e As EventArgs) Handles Btm_Depositar_Gabriela.Click

        Txt_Resultado_Gabriela.Text = ""
        Txt_NovoSaldo_Gabriela.Text = ""

        Dim ValorDepositar As Double = Val(Txt_Valor_Gabriela.Text)

        ContaDaGabriela.Depositar(ValorDepositar)

        Txt_Resultado_Gabriela.Text = "Depósito efetuado com sucesso"
        Txt_NovoSaldo_Gabriela.Text = ContaDaGabriela.Saldo.ToString
        Txt_SaldoAtual_Gabriela.Text = ContaDaGabriela.Saldo.ToString
        ContaDaGabriela.Extrato += Now.ToString + " Depósito de " + ValorDepositar.ToString + " Saldo " + ContaDaGabriela.Saldo.ToString + vbCrLf
        Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato

    End Sub

    Private Sub Btm_Depositar_Bruno_Click(sender As Object, e As EventArgs) Handles Btm_Depositar_Bruno.Click

        Txt_Resultado_Bruno.Text = ""
        Txt_NovoSaldo_Bruno.Text = ""

        Dim ValorDepositar As Double = Val(Txt_Valor_Bruno.Text)

        ContaDoBruno.Depositar(ValorDepositar)

        Txt_Resultado_Bruno.Text = "Depósito efetuado com sucesso"
        Txt_NovoSaldo_Bruno.Text = ContaDoBruno.Saldo.ToString
        Txt_SaldoAtual_Bruno.Text = ContaDoBruno.Saldo.ToString
        ContaDoBruno.Extrato += Now.ToString + " Depósito de " + ValorDepositar.ToString + " Saldo " + ContaDoBruno.Saldo.ToString + vbCrLf
        Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato

    End Sub

    Private Sub Btm_Sacar_Bruno_Click(sender As Object, e As EventArgs) Handles Btm_Sacar_Bruno.Click

        Txt_Resultado_Bruno.Text = ""
        Txt_NovoSaldo_Bruno.Text = ""

        Dim ValorSacar As Double = Val(Txt_Valor_Bruno.Text)

        Dim RetornoSaque As Boolean = ContaDoBruno.Sacar(ValorSacar)

        If RetornoSaque Then
            Txt_Resultado_Bruno.Text = "Saque efetuado com sucesso"
            Txt_NovoSaldo_Bruno.Text = ContaDoBruno.Saldo.ToString
            Txt_SaldoAtual_Bruno.Text = ContaDoBruno.Saldo.ToString
            ContaDoBruno.Extrato += Now.ToString + " Saque de " + ValorSacar.ToString + " Saldo " + ContaDoBruno.Saldo.ToString + vbCrLf
            Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato
        Else
            Txt_Resultado_Bruno.Text = "Saque não é possível ser feito"
        End If

    End Sub

    Private Sub Btm_Transferir_Gabriela_Click(sender As Object, e As EventArgs) Handles Btm_Transferir_Gabriela.Click

        Txt_Resultado_Gabriela.Text = ""
        Txt_NovoSaldo_Gabriela.Text = ""

        Dim ValorTransferir As Double = Val(Txt_Valor_Gabriela.Text)
        Dim RetornoTransferencia As Boolean = ContaDaGabriela.Transferir(ValorTransferir, ContaDoBruno)

        If RetornoTransferencia Then
            Txt_NovoSaldo_Gabriela.Text = ContaDaGabriela.Saldo.ToString
            Txt_NovoSaldo_Bruno.Text = ContaDoBruno.Saldo.ToString

            Txt_Resultado_Gabriela.Text = "Transferência efetuada com sucesso"
            Txt_SaldoAtual_Gabriela.Text = ContaDaGabriela.Saldo.ToString
            Txt_SaldoAtual_Bruno.Text = ContaDoBruno.Saldo.ToString

            ContaDaGabriela.Extrato += Now.ToString + " Trasnferência de " + ValorTransferir.ToString + " Saldo " + ContaDaGabriela.Saldo.ToString + vbCrLf
            ContaDoBruno.Extrato += Now.ToString + " Transferência de " + ValorTransferir.ToString + " Saldo " + ContaDoBruno.Saldo.ToString + vbCrLf

            Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato
            Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato
        Else
            Txt_Resultado_Gabriela.Text = "Transferência não é possível ser feita"
        End If

    End Sub

    Private Sub Btm_Transferir_Bruno_Click(sender As Object, e As EventArgs) Handles Btm_Transferir_Bruno.Click

        Txt_Resultado_Bruno.Text = ""
        Txt_NovoSaldo_Bruno.Text = ""

        Dim ValorTransferir As Double = Val(Txt_Valor_Bruno.Text)
        Dim RetornoTransferencia As Boolean = ContaDoBruno.Transferir(ValorTransferir, ContaDaGabriela)

        If RetornoTransferencia Then
            Txt_NovoSaldo_Bruno.Text = ContaDoBruno.Saldo.ToString
            Txt_NovoSaldo_Gabriela.Text = ContaDaGabriela.Saldo.ToString

            Txt_Resultado_Bruno.Text = "Transferência efetuada com sucesso"
            Txt_SaldoAtual_Bruno.Text = ContaDoBruno.Saldo.ToString
            Txt_SaldoAtual_Gabriela.Text = ContaDaGabriela.Saldo.ToString

            ContaDoBruno.Extrato += Now.ToString + " Transferência de " + ValorTransferir.ToString + " Saldo " + ContaDoBruno.Saldo.ToString + vbCrLf
            ContaDaGabriela.Extrato += Now.ToString + " Trasnferência de " + ValorTransferir.ToString + " Saldo " + ContaDaGabriela.Saldo.ToString + vbCrLf

            Txt_Extrato_Bruno.Text = ContaDoBruno.Extrato
            Txt_Extrato_Gabriela.Text = ContaDaGabriela.Extrato
        Else
            Txt_Resultado_Bruno.Text = "Transferência não é possível ser feita"
        End If

    End Sub
End Class