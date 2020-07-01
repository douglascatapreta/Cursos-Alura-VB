Imports ByteBank.Classes.Bibliotecas
Imports ByteBank.Classes.Funcionarios

Public Class Frm_Principal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Principal"
        Lbl_Principal.Text = "Principal"
        Btm_Click.Text = "Clique aqui"
        Btm_TesteHeranca.Text = "Clique aqui para testar herança"
        Btm_ClasseBase.Text = "Executa exemplo classe base"
        Btm_Aumento.Text = "Aumento salarial"

    End Sub

    Private Sub Btm_Click_Click(sender As Object, e As EventArgs) Handles Btm_Click.Click

        Dim GerenciadorBonificacao As New GerenciadorBonificacao

        Dim Carlos As New Gerente("543.445.434-00", 10000)
        Carlos.Nome = "Carlos Antônio"

        GerenciadorBonificacao.Registrar(Carlos)

        Dim Bia As New Diretor("543.445.434-00", 20000)
        Bia.Nome = "Beatriz Regina"

        GerenciadorBonificacao.Registrar(Bia)

        MsgBox("O salário do " + Carlos.Nome + " é " + Carlos.Salario.ToString)
        MsgBox("A bonificação de " + Carlos.Nome + " será de " + Carlos.GetBonificacao().ToString)

        MsgBox("O salário da " + Bia.Nome + " é " + Bia.Salario.ToString)
        MsgBox("A bonificação da " + Bia.Nome + " será de " + Bia.GetBonificacao().ToString)

        MsgBox("O valor total de bonificação a ser pago será de " + GerenciadorBonificacao.GetBonificacao().ToString)


    End Sub

    Private Sub Btm_TesteHeranca_Click(sender As Object, e As EventArgs) Handles Btm_TesteHeranca.Click

        'Dim vFuncionario As New Funcionario("111.111.111-01", 21550)
        'Dim vDiretorFuncionario As New Funcionario("111.111.111-02", 10000)
        MsgBox("O número de funcionários atualmente instanciados é de " + Funcionario.TotalDeFuncionarios.ToString)

        Dim vDiretor As New Diretor("111.111.111-03", 50000)
        MsgBox("O número de funcionários e diretores atualmente instanciados é de " + Funcionario.TotalDeFuncionarios.ToString)

        Dim vGerente As New Gerente("111.111.111-04", 25000)
        MsgBox("O número de funcionários, diretores e gerentes atualmente instanciados é de " + Funcionario.TotalDeFuncionarios.ToString)

        Dim vTexto As String
        'vTexto = "Os CPFs dos funcionários são " + vFuncionario.CPF + " e " + vDiretorFuncionario.CPF + vbCrLf
        vTexto += "O CPF do diretor é " + vDiretor.CPF + vbCrLf
        vTexto += "O CPF do gerente é " + vGerente.CPF + vbCrLf

        MsgBox(vTexto)

        'vDiretorFuncionario = vDiretor

        Dim vSaida As String = ""

        vSaida += "A bonificação de vDiretor é " + vDiretor.GetBonificacao().ToString + vbCrLf
        'vSaida += "A bonificação de vFuncionario é " + vFuncionario.GetBonificacao().ToString + vbCrLf
        'vSaida += "A bonificação de vDiretorFuncionario é " + vDiretorFuncionario.GetBonificacao().ToString + vbCrLf

        MsgBox(vSaida)

    End Sub

    Private Sub Btm_ClasseBase_Click(sender As Object, e As EventArgs) Handles Btm_ClasseBase.Click

        Dim vDiretor As New Diretor("111.111.111-05", 10000)

        MsgBox("A bonificação do diretor é: R$" + vDiretor.GetBonificacao().ToString)

    End Sub

    Private Sub Btm_Aumento_Click(sender As Object, e As EventArgs) Handles Btm_Aumento.Click

        'Dim vFuncionario As New Funcionario("123.456.789-00", 1000)
        Dim vGerente As New Gerente("123.456.789-22", 2000)
        Dim vDiretor As New Diretor("123.456.789-11", 3000)

        Dim vTexto As String = ""
        'vTexto = "O salário do funcionário é: " + vFuncionario.Salario.ToString + vbCrLf
        vTexto += "O salário do gerente é: " + vGerente.Salario.ToString + vbCrLf
        vTexto += "O salário do diretor é: " + vDiretor.Salario.ToString + vbCrLf

        MsgBox(vTexto)

        'vFuncionario.AumentarSalario()
        vGerente.AumentarSalario()
        vDiretor.AumentarSalario()

        'vTexto = "O salário do funcionário é: " + vFuncionario.Salario.ToString + vbCrLf
        vTexto += "O salário do gerente é: " + vGerente.Salario.ToString + vbCrLf
        vTexto += "O salário do diretor é: " + vDiretor.Salario.ToString + vbCrLf

        MsgBox(vTexto)

    End Sub
End Class
