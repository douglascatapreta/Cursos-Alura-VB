Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class Frm_Principal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Sistema Interno"
        Btm_Principal.Text = "Clique Aqui"

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click

        Dim Conta As New ContaCorrente(273, 374996)
        MsgBox(Conta.saldo)

        Dim Conta2 As ContaCorrente = New ContaCorrente(123, 75648897)
        Conta2.Sacar(100, "sacado")

    End Sub
End Class
