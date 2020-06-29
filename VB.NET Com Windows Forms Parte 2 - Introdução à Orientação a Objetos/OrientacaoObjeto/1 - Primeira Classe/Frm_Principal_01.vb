Public Class Frm_Principal_01
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "1 - Primeira Classe"
        Lbl_Principal.Text = "1 - Primeira Classe"
        Btm_Acao.Text = "Conta Gabriela"
        Lbl_Saldo.Text = "Saldo"
        Lbl_Incremento.Text = "Incremento"
        Btm_Acao2.Text = "Conta Bruno"
        Btm_ValRef.Text = "Clique Aqui"

    End Sub

    Private Sub Btm_Acao_Click(sender As Object, e As EventArgs) Handles Btm_Acao.Click

        'Dim Titular As String = "Gabriela"
        'Dim Agencia As Integer = 863
        'Dim Conta As Integer = 863141
        'Dim Saldo As Double = 100

        'Dim Titular As String = "Bruno"
        'Dim Agencia As Integer = 863
        'Dim Conta As Integer = 863142
        'Dim Saldo As Double = 50

        Dim ContaDaGabriela As New ContaCorrente

        ContaDaGabriela.Titular = "Gabriela"
        ContaDaGabriela.Agencia = 863
        ContaDaGabriela.Conta = 863141
        ContaDaGabriela.Saldo = Val(Txt_Saldo.Text)

        MsgBox("O saldo da " + ContaDaGabriela.Titular + " na C/C " + ContaDaGabriela.Agencia.ToString _
               + " - " + ContaDaGabriela.Conta.ToString + " é " + ContaDaGabriela.Saldo.ToString)

        Dim ValIncremento As Double = Val(Txt_Incremento.Text)
        ContaDaGabriela.Saldo += ValIncremento

        MsgBox("O saldo da " + ContaDaGabriela.Titular + " na C/C " + ContaDaGabriela.Agencia.ToString _
               + " - " + ContaDaGabriela.Conta.ToString + " é " + ContaDaGabriela.Saldo.ToString)

    End Sub

    Private Sub Btm_Acao2_Click(sender As Object, e As EventArgs) Handles Btm_Acao2.Click

        Dim ContaDoBruno As New ContaCorrente

        MsgBox(ContaDoBruno.Titular)
        MsgBox(ContaDoBruno.Agencia)
        MsgBox(ContaDoBruno.Conta)
        MsgBox(ContaDoBruno.Saldo)

        ContaDoBruno.Saldo += 100

        MsgBox(ContaDoBruno.Saldo)

    End Sub

    Private Sub Btm_ValRef_Click(sender As Object, e As EventArgs) Handles Btm_ValRef.Click

        Dim idade As Integer = 20
        Dim idade2 As Integer

        idade2 = idade

        MsgBox("Valor da idade " + idade.ToString + " e da idade2 " + idade2.ToString)

        idade = 30

        MsgBox("Valor da idade " + idade.ToString + " e da idade2 " + idade2.ToString)

        Dim ContaDaGabriela As New ContaCorrente()
        Dim ContaDaGabrielaCosta As New ContaCorrente()

        ContaDaGabriela.Titular = "Gabriela"
        ContaDaGabriela.Agencia = 863
        ContaDaGabriela.Conta = 863141

        ContaDaGabrielaCosta = ContaDaGabriela

        MsgBox("Valor da ContaDaGabriela " + ContaDaGabriela.Saldo.ToString + " e da ContaDaGabrielaCosta" + ContaDaGabrielaCosta.Saldo.ToString)

        ContaDaGabriela.Saldo = 300

        MsgBox("Valor da ContaDaGabriela " + ContaDaGabriela.Saldo.ToString + " e da ContaDaGabrielaCosta" + ContaDaGabrielaCosta.Saldo.ToString)

    End Sub
End Class
