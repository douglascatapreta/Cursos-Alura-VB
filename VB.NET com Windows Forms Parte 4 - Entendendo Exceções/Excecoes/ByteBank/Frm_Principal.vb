Imports System.IO
Imports ByteBank.Classes

Public Class Frm_Principal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Projeto ByteBank"
        Lbl_Principal.Text = "Projeto ByteBank"
        Lbl_Denominador.Text = "Denominador"

        Lbl_Agencia.Text = "Agência"
        Lbl_Conta.Text = "Conta"

    End Sub

    Private Sub Video01ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Video01ToolStripMenuItem.Click

        Dim conta As New ContaCorrente(237, 117333)
        MsgBox("O número de contas criadas é de " + ContaCorrente.TotalContasCriadas.ToString())
        MsgBox("O valor da taxa de operações está em " + ContaCorrente.TaxaOperacao.ToString())

    End Sub

    Private Sub Video02ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Video02ToolStripMenuItem.Click

        Dim denominador As Integer = Val(Txt_Denominador.Text)

        Dim resposta As Integer = TestarDivisao(denominador)

        If resposta = -1 Then
            MsgBox("Não é possível fazer a divisão pois o denominador é igual a zero")
        ElseIf resposta = -2 Then
            MsgBox("Não é possível fazer a divisão pois o denominador é maior que o numerador")
        Else
            MsgBox("O valor da divisão entre 10 e " + denominador.ToString() + " é de " + resposta.ToString())
        End If

    End Sub

    Private Function TestarDivisao(valor As Integer) As Integer

        Dim resultado As Integer = Dividir(10, valor)

        If resultado = -1 Then
            Return -1
        ElseIf resultado = -2 Then
            Return -2
        End If

        Return resultado

    End Function

    Private Function Dividir(numerador As Integer, denominador As Integer) As Integer

        If denominador = 0 Then
            Return -1
        End If

        If denominador > numerador Then
            Return -2
        End If

        Return numerador / denominador

    End Function

    Private Sub Video03ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Video03ToolStripMenuItem.Click

        Dim denominador As Integer = Val(Txt_Denominador.Text)
        Try
            TestarDivisao2(denominador)
        Catch ex As InvalidCastException
            MsgBox(ex.Message)
            MsgBox(ex.StackTrace)
            MsgBox("Houve um erro de conversão de um Double para um String em algum MsgBox.")
        Catch ex As OverflowException
            MsgBox(ex.Message)
            MsgBox(ex.StackTrace)
            MsgBox("Houve um erro de divisão por zero.")
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox(ex.StackTrace)
            MsgBox("Houve um erro genérico. Observe a mensagem de retorno da exceção    .")
        End Try

    End Sub

    Private Sub TestarDivisao2(valor As Integer)

        'Forçando um erro de outro tipo para testar o Catch genérico
        If valor = 5 Then
            Dim conta As New ContaCorrente(277, 344445)
            MsgBox(conta.Titular.Nome)
        End If

        Dim resultado As Integer = Dividir2(10, valor)
        MsgBox("O valor da divisão entre 10 e " + valor.ToString + " é de " + resultado + ".")

    End Sub

    Private Function Dividir2(numerador As Integer, denominador As Integer) As Integer

        Try
            Return numerador / denominador
        Catch ex As OverflowException
            MsgBox("Tentamos dividir o número " + numerador.ToString + " por " + denominador.ToString)
            Throw
        End Try

    End Function

    Private Sub Video04ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Video04ToolStripMenuItem.Click

        Dim vAgencia As Integer = Val(Txt_Agencia.Text)
        Dim vNumero As Integer = Val(Txt_Conta.Text)

        Try
            Dim conta As New ContaCorrente(vAgencia, vNumero)
            MsgBox("O número da agência e conta são " + conta.Agencia.ToString + " e " + conta.Numero.ToString)

        Catch ex As ArgumentException
            MsgBox("Ocorreu um erro de ArgumentException: " + ex.Message)

        Catch ex As Exception
            MsgBox("Ocorreu um erro de Exception: " + ex.Message)
        End Try


    End Sub

    Private Sub Video05ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Video05ToolStripMenuItem.Click

        Dim f As New Frm_Video05
        f.ShowDialog()

    End Sub

    Private Sub Video06ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Video06ToolStripMenuItem.Click

        Try
            LeituraArquivo()

        Catch ex As Exception
            Console.WriteLine("Erro no arquivo")

        End Try

    End Sub

    Private Sub LeituraArquivo()

        Using x As New LeitorDeArquivo("ContaCorrente.txt")
            x.LerLinha()
            x.LerLinha()
            x.LerLinha()
            x.LerLinha()
            x.LerLinha()
        End Using

        'Dim x As LeitorDeArquivo

        'Try
        '    x = New LeitorDeArquivo("ContaCorrente.txt")
        '    x.LerLinha()
        '    x.LerLinha()
        '    x.LerLinha()
        '    x.LerLinha()
        '    x.LerLinha()

        'Finally
        '    If Not (x Is Nothing) Then
        '        x.FecharArquivo()
        '    End If

        'End Try

    End Sub
End Class
