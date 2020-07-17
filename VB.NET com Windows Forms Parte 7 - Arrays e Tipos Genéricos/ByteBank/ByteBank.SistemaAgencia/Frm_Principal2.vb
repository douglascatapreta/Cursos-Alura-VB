Imports ByteBank.Bibliotecas.Classes.Clientes
Imports ByteBank.SistemaAgencia.Classes

Public Class Frm_Principal2
    Dim Lista As New ListaDeContasCorrentes()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Array Contas Correntes"
        Lbl_Agencia.Text = "Agência"
        Lbl_Conta.Text = "Conta"
        Btm_Adicionar.Text = "Adicionar"
        Btm_Remover.Text = "Remover"
        Grp_AdicionarVarios.Text = "Adicionar Vários"

        Btm_AdiconaVarios.Text = "Adicionar"
        Lbl_Agencia1.Text = "Agência 1"
        Lbl_Conta1.Text = "Conta 1"
        Lbl_Agencia2.Text = "Agência 2"
        Lbl_Conta2.Text = "Conta 2"
        Lbl_Agencia3.Text = "Agência 3"
        Lbl_Conta3.Text = "Conta 3"
        Lbl_Agencia4.Text = "Agência 4"
        Lbl_Conta4.Text = "Conta 4"

    End Sub

    Private Sub Btm_Adicionar_Click(sender As Object, e As EventArgs) Handles Btm_Adicionar.Click

        If Txt_Agencia.Text <> "" And Txt_Conta.Text <> "" Then
            Dim conta As New ContaCorrente(Txt_Agencia.Text, Txt_Conta.Text)
            Lista.Adicionar(conta)
            'Txt_Array.Text = Lista.EscreverElementosArray()
            'Txt_Array.Text = EscreverElementosArray()
            Txt_Array.Text = EscreverElementosArrayIndexador()
        End If

    End Sub

    Private Sub Btm_Remover_Click(sender As Object, e As EventArgs) Handles Btm_Remover.Click

        If Txt_Agencia.Text <> "" And Txt_Conta.Text <> "" Then
            Dim conta As New ContaCorrente(Txt_Agencia.Text, Txt_Conta.Text)
            Lista.Remover(conta)
            'Txt_Array.Text = Lista.EscreverElementosArray()
            'Txt_Array.Text = EscreverElementosArray()
            Txt_Array.Text = EscreverElementosArrayIndexador()
        End If

    End Sub

    Public Function EscreverElementosArray() As String

        Dim elementos As String = String.Empty
        For i As Integer = 0 To Lista.Tamanho - 1
            elementos += Lista.GetContaCorrente(i).agencia.ToString + " - " + Lista.GetContaCorrente(i).numero.ToString + vbCrLf
        Next
        Return elementos

    End Function

    Public Function EscreverElementosArrayIndexador() As String

        Dim elementos As String = String.Empty
        For i As Integer = 0 To Lista.Tamanho - 1
            elementos += Lista(i).agencia.ToString + " - " + Lista(i).numero.ToString + vbCrLf
        Next
        Return elementos

    End Function

    Private Sub Btm_AdiconaVarios_Click(sender As Object, e As EventArgs) Handles Btm_AdiconaVarios.Click

        'Dim conta1 As New ContaCorrente(Txt_Agencia1.Text, Txt_Conta1.Text)
        'Dim conta2 As New ContaCorrente(Txt_Agencia2.Text, Txt_Conta2.Text)
        'Dim conta3 As New ContaCorrente(Txt_Agencia3.Text, Txt_Conta3.Text)
        'Dim conta4 As New ContaCorrente(Txt_Agencia4.Text, Txt_Conta4.Text)
        'Dim contas() As ContaCorrente = {conta1, conta2, conta3, conta4}
        'Lista.AdicionarVarios(contas)
        'Txt_Array.Text = EscreverElementosArrayIndexador()

        If Txt_Agencia1.Text <> "" And Txt_Conta1.Text <> "" Then
            Dim conta1 As New ContaCorrente(Txt_Agencia1.Text, Txt_Conta1.Text)
            If Txt_Agencia2.Text <> "" And Txt_Conta2.Text <> "" Then
                Dim conta2 As New ContaCorrente(Txt_Agencia2.Text, Txt_Conta2.Text)
                If Txt_Agencia3.Text <> "" And Txt_Conta3.Text <> "" Then
                    Dim conta3 As New ContaCorrente(Txt_Agencia3.Text, Txt_Conta3.Text)
                    If Txt_Agencia4.Text <> "" And Txt_Conta4.Text <> "" Then
                        Dim conta4 As New ContaCorrente(Txt_Agencia4.Text, Txt_Conta4.Text)
                        Lista.AdicionarVariosUmAUm(conta1, conta2, conta3, conta4)
                    Else
                        Lista.AdicionarVariosUmAUm(conta1, conta2, conta3)
                    End If
                Else
                    Lista.AdicionarVariosUmAUm(conta1, conta2)
                End If
            Else
                Lista.AdicionarVariosUmAUm(conta1)
            End If
        End If

        Txt_Array.Text = EscreverElementosArrayIndexador()

    End Sub
End Class