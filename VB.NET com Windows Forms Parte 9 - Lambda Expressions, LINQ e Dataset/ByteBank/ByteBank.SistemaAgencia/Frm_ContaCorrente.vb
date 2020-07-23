Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class Frm_ContaCorrente

#Region "PROPRIEDADES"

    Public Property Conta As ContaCorrente
    Public Property Retorno As Boolean

#End Region

#Region "CONSTRUTORES"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Conta Corrente"
        Lbl_ContaCorrente.Text = "Nova Conta Corrente"
        Retorno = False

    End Sub

#End Region

#Region "MÉTODOS"

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click

        Retorno = True
        Conta = New ContaCorrente(Txt_Agencia.Text, Txt_Conta.Text, Txt_Nome.Text)
        Me.Close()

    End Sub

#End Region

End Class