Imports ByteBank.Classes

Public Class Frm_Video05
    Dim Conta As New ContaCorrente(237, 144422)
    Dim Conta2 As New ContaCorrente(237, 1663347)

    Dim vStack As String = ""
    Dim vControle As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Fomulário do Vídeo 05"
        Lbl_Video05.Text = "Fomulário do Vídeo 05"
        Btm_Fechar.Text = "Fechar"
        Grp_Movimentacao.Text = "Movimentação da Conta"
        Lbl_Movimentacao.Text = "Digite o valor"
        Btm_Saque.Text = "Sacar"
        Lbl_ContaCorrente.Text = "Conta: " + Conta.Agencia.ToString + " - " + Conta.Numero.ToString
        Lbl_Saldo.Text = "Saldo: " + Conta.Saldo.ToString
        Btm_Transfere.Text = "Transferir"
        Lbl_ContaCorrente2.Text = "Conta: " + Conta2.Agencia.ToString + " - " + Conta2.Numero.ToString
        Lbl_Saldo2.Text = "Saldo: " + Conta2.Saldo.ToString
        Btm_Stack.Text = "Ver último StackTrace"
        Txt_Stack.Visible = vControle
        Lbl_SaquesErrados.Text = "Num. saques errados: " + Conta.NumeroSaquesErrados.ToString
        Lbl_TransferenciasErradas.Text = "Num. transferências erradas: " + Conta.NumeroTransferenciasErrados.ToString

    End Sub

    Private Sub Btm_Fechar_Click(sender As Object, e As EventArgs) Handles Btm_Fechar.Click

        Me.Close()

    End Sub

    Private Sub Btm_Saque_Click(sender As Object, e As EventArgs) Handles Btm_Saque.Click

        Try
            Dim valorSaque As Double = Val(Txt_Valor.Text)
            Conta.Sacar(valorSaque, "do saque")
            Lbl_Saldo.Text = "Saldo: " + Conta.Saldo.ToString
        Catch ex As SaldoInsuficienteException
            vStack = ex.StackTrace
            MsgBox("Ocorreu um erro SaldoInsuficienteException: " + ex.Message +
                   ". Valor saque de " + ex.ValorSacado.ToString + ". Saldo de " + ex.Saldo.ToString + ".")
        Catch ex As ArgumentException
            vStack = ex.StackTrace
            MsgBox("Ocorreu um erro ArgumentException: " + ex.Message)
        Catch ex As Exception
            vStack = ex.StackTrace
            MsgBox("Ocorreu um erro Exception: " + ex.Message)
        End Try

        Lbl_SaquesErrados.Text = "Num. saques errados: " + Conta.NumeroSaquesErrados.ToString
        Lbl_TransferenciasErradas.Text = "Num. transferências erradas: " + Conta.NumeroTransferenciasErrados.ToString

    End Sub

    Private Sub Btm_Transfere_Click(sender As Object, e As EventArgs) Handles Btm_Transfere.Click

        Try
            Dim valorTransferencia As Double = Val(Txt_Valor.Text)
            Conta.Transferir(valorTransferencia, Conta2)
            Lbl_Saldo.Text = "Saldo: " + Conta.Saldo.ToString
            Lbl_Saldo2.Text = "Saldo: " + Conta2.Saldo.ToString
        Catch ex As OperacaoFinanceiraException
            vStack = ex.StackTrace
            MsgBox("Ocorreu um erro OperacaoFinanceiraException: " + ex.Message)
        Catch ex As SaldoInsuficienteException
            vStack = ex.StackTrace
            MsgBox("Ocorreu um erro SaldoInsuficienteException: " + ex.Message +
                   ". Valor da transferência de " + ex.ValorSacado.ToString + ". Saldo de " + ex.Saldo.ToString + ".")
        Catch ex As ArgumentException
            vStack = ex.StackTrace
            MsgBox("Ocorreu um erro ArgumentException: " + ex.Message)
        Catch ex As Exception
            vStack = ex.StackTrace + vbCrLf + ex.InnerException.StackTrace
            MsgBox("Ocorreu um erro Exception: " + ex.Message)
        End Try

        Lbl_SaquesErrados.Text = "Num. saques errados: " + Conta.NumeroSaquesErrados.ToString
        Lbl_TransferenciasErradas.Text = "Num. transferências erradas: " + Conta.NumeroTransferenciasErrados.ToString

    End Sub

    Private Sub Btm_Stack_Click(sender As Object, e As EventArgs) Handles Btm_Stack.Click

        If vControle = False Then
            vControle = True
        Else
            vControle = False
        End If
        Txt_Stack.Text = vStack
        Txt_Stack.Visible = vControle

    End Sub
End Class