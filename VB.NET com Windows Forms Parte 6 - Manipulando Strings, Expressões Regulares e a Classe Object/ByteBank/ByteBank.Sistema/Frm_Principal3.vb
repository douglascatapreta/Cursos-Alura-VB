Imports System.Text.RegularExpressions
Imports ByteBank.Bibliotecas.Classes
Imports ByteBank.Bibliotecas.Classes.Clientes
Imports ByteBank.Bibliotecas.Classes.Funcionarios

Public Class Frm_Principal3
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Formulário Principal 3"
        Lbl_Principal3.Text = "Formulário Principal 3"
        Btm_Principal3.Text = "Clique Aqui"
        Btm_Principal3A.Text = "Clique Aqui"
        Btm_Principal03B.Text = "Clique Aqui"

    End Sub

    Private Sub Btm_Principal3_Click(sender As Object, e As EventArgs) Handles Btm_Principal3.Click

        Dim vFrase As String = "O telefone é 2334-4332"
        'Dim vExpressaoRegular As String = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]"
        'Dim vExpressaoRegular As String = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]"
        'Dim vExpressaoRegular As String = "[0-9]{4}[-][0-9]{4}"
        'Dim vExpressaoRegular As String = "[0-9]{4,5}[-][0-9]{4}"
        'Dim vExpressaoRegular As String = "[0-9]{4,5}[-]{0,1}[0-9]{4}"
        'Dim vExpressaoRegular As String = "[0-9]{4,5}[-]?[0-9]{4}"
        Dim vExpressaoRegular As String = "[0-9]{4,5}-?[0-9]{4}"

        Dim x As Boolean = Regex.IsMatch(vFrase, vExpressaoRegular)
        MsgBox(x)

        Dim y As Match = Regex.Match(vFrase, vExpressaoRegular)
        MsgBox(y.Value)

    End Sub

    Private Sub Btm_Principal3A_Click(sender As Object, e As EventArgs) Handles Btm_Principal3A.Click

        'Dim x As String = "texto"
        'Dim y As Integer = 123
        'Dim z As Boolean = True

        'Dim x As Object = "texto"
        'Dim y As Object = 123
        'Dim z As Object = True
        'MsgBox(x)
        'MsgBox(y)
        'MsgBox(z)

        'Dim Conta As New ContaCorrente(234, 159356)
        'MsgBox(Conta.ToString)

        Dim Cliente_1 As New Cliente()
        Dim Cliente_2 As New Cliente()

        Cliente_1.nome = "Carlos"
        Cliente_1.cpf = "123.123.123-23"
        Cliente_1.profissao = "Analista de Sistemas"

        Cliente_2.nome = "Carlos"
        Cliente_2.cpf = "123.123.123-23"
        Cliente_2.profissao = "Analista de Sistemas"

        If (Cliente_1.Equals(Cliente_2)) Then
            MsgBox("SÃO IGUAIS")
        Else
            MsgBox("SÃO DIFERENTES")
        End If

        Dim Ger As New Gerente("123.456.789-00")

        If (Cliente_1.Equals(Ger)) Then
            MsgBox("SÃO IGUAIS")
        Else
            MsgBox("SÃO DIFERENTES")
        End If

        Dim Str As String = "String"

        If (Cliente_1.Equals(Str)) Then
            MsgBox("SÃO IGUAIS")
        Else
            MsgBox("SÃO DIFERENTES")
        End If


    End Sub

    Private Sub Btm_Principal03B_Click(sender As Object, e As EventArgs) Handles Btm_Principal03B.Click

        Dim url As String = "https://www.bytebank.com.br/cambio?moedaOrigem=dolar&moedaDestino=real&valor=1500"
        Dim x As New ExtrairValorDeArgumentosUrl(url)
        Dim y As String = x.GetTodosArgumentos()

        MsgBox(y)

    End Sub
End Class