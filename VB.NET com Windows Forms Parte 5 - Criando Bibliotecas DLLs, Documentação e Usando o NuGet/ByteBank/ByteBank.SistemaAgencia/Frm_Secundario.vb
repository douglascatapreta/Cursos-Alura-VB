Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class Frm_Secundario
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Formulário Secundário"
        Grp_ContaCorrente.Text = "Conta Corrente"
        Lbl_Agencia.Text = "Agência"
        Lbl_Conta.Text = "Conta"
        Btm_Criar.Text = "Criar"
        Lbl_ContaCorrenteCriada.Text = ""

    End Sub

    Private Sub Btm_Criar_Click(sender As Object, e As EventArgs) Handles Btm_Criar.Click

        Dim vAgencia As Double = Val(Txt_Agencia.Text)
        Dim vConta As Double = Val(Txt_Conta.Text)

        Dim Conta As ContaCorrente = New ContaCorrente(vAgencia, vConta)

        Lbl_ContaCorrenteCriada.Text = "Agência: " + Conta.agencia.ToString + " - Conta: " + Conta.numero.ToString

    End Sub
End Class