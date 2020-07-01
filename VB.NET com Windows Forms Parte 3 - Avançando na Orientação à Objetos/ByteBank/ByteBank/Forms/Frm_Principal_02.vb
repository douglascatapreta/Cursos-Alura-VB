Imports ByteBank.Classes.Bibliotecas
Imports ByteBank.Classes.Funcionarios

Public Class Frm_Principal_02
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Cálculo Bonificação"
        Lbl_Principal.Text = "Cálculo Bonificação"

        Btm_Bonificacao.Text = "Calcular Bonificação"

    End Sub

    Private Sub Btm_Bonificacao_Click(sender As Object, e As EventArgs) Handles Btm_Bonificacao.Click

        Dim TotalBonificacao As New GerenciadorBonificacao

        Dim Carlos As New Diretor("123.123.123-05", 5000)
        Dim Pedro As New Designer("123.123.123-05", 3000)
        Dim Joao As New Gerente("123.123.123-05", 4000)
        Dim Carla As New Auxiliar("123.123.123-05", 2000)
        Dim Julia As New Desenvolvedor("123.123.123-06", 2000)

        TotalBonificacao.Registrar(Carlos)
        TotalBonificacao.Registrar(Pedro)
        TotalBonificacao.Registrar(Joao)
        TotalBonificacao.Registrar(Carla)
        TotalBonificacao.Registrar(Julia)

        MsgBox("O valor total da bonificação será de " + TotalBonificacao.GetBonificacao().ToString())

    End Sub
End Class