﻿Imports _1___Primeiro_Projeto
Imports _2___Criando_Variáveis
Imports _3___Manipulando_Textos
Imports _4___Controle_de_Fluxo
Imports _5___Laços_de_Repetição

Public Class Frm_Principal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Projeto Principal"
        Btm_01.Text = "1 - Primeiro Projeto"
        Btm_02.Text = "2 - Criando Variáveis"
        Btm_03.Text = "3 - Manipulando Textos"
        Btm_04.Text = "4 - Controle de Fluxo"
        Btm_05.Text = "5 - Laços de Repetição"

    End Sub

    Private Sub Btm_01_Click(sender As Object, e As EventArgs) Handles Btm_01.Click
        Dim f As New Frm_TelaPrincipal_01
        f.ShowDialog()
    End Sub

    Private Sub Btm_02_Click(sender As Object, e As EventArgs) Handles Btm_02.Click
        Dim f As New Frm_TelaPrincipal_02
        f.ShowDialog()
    End Sub

    Private Sub Btm_03_Click(sender As Object, e As EventArgs) Handles Btm_03.Click
        Dim f As New Frm_TelaPrincipal_03
        f.ShowDialog()
    End Sub

    Private Sub Btm_04_Click(sender As Object, e As EventArgs) Handles Btm_04.Click
        Dim f As New Frm_TelaPrincipal_04
        f.ShowDialog()
    End Sub

    Private Sub Btm_05_Click(sender As Object, e As EventArgs) Handles Btm_05.Click
        Dim f As New Frm_TelaPrincipal_05
        f.ShowDialog()
    End Sub
End Class
