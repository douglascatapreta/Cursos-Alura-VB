﻿Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class Frm_ContasCorrentesAgenciaDic

    Dim agencia As AgenciaDic

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        agencia = New AgenciaDic(277)

        Me.Text = "Contas Correntes Agências Usando Dicionário"
        Grp_Conta.Text = "Conta Corrente"
        Lbl_Agencia.Text = $"Agência: {agencia.Agencia}"
        Btm_Adicionar.Text = "Adicionar"
        Btm_Remover.Text = "Remover"

        Grp_Busca.Text = "Buscar"
        Btm_CCBusca.Text = "Buscar"

        Grp_AlterarCC.Text = "Alterar Nome"
        Btm_AlterarCC.Text = "Alterar"

    End Sub

    Private Sub Btm_Adicionar_Click(sender As Object, e As EventArgs) Handles Btm_Adicionar.Click

        If Txt_Conta.Text <> "" And Txt_Nome.Text <> "" Then
            Try
                agencia.AbrirContaCorrente(Txt_Conta.Text, Txt_Nome.Text)
                Txt_Array.Text = EscreverElementosArrayIndexador()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub Btm_Remover_Click(sender As Object, e As EventArgs) Handles Btm_Remover.Click

        If Txt_Conta.Text <> "" Then
            agencia.FecharContaCorrente(Txt_Conta.Text)
            Txt_Array.Text = EscreverElementosArrayIndexador()
        End If

    End Sub

    Public Function EscreverElementosArrayIndexador() As String

        Dim elementos As String = String.Empty
        For i As Integer = 0 To agencia.ContasCorrentes.Count - 1
            elementos += agencia.ContasCorrentes.Values(i).ToString + vbCrLf
        Next
        Return elementos

    End Function

    Private Sub Btm_CCBusca_Click(sender As Object, e As EventArgs) Handles Btm_CCBusca.Click

        Try
            Dim numero As Integer = Val(Txt_CCBusca.Text)
            Dim Conta As ContaCorrente = agencia.BuscarContaCorrente(numero)
            Txt_ResultadoBusca.Text = Conta.ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Btm_AlterarCC_Click(sender As Object, e As EventArgs) Handles Btm_AlterarCC.Click

        Try
            agencia.AlterarContaCorrente(Txt_CCAlterar.Text, Txt_NomeAlterar.Text)
            Txt_Array.Text = EscreverElementosArrayIndexador()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class