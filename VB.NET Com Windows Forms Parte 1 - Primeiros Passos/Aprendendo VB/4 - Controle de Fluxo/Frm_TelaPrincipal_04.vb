Public Class Frm_TelaPrincipal_04
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Lbl_NomeProjeto.Text = "4 - Controle de Fluxo"
        Btm_Principal.Text = "Checagem da permissão de entrada"
        Me.Text = "4 - Controle de Fluxo"

        ' Inicialização dos componentes da aplicação
        Lbl_Idade.Text = "Idade"
        Lbl_Resultado.Text = "Resultado"
        Grp_Pais.Text = "Acompanhado dos pais?"
        Rdb_Sim.Text = "Sim"
        Rdb_Nao.Text = "Não"

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click

        Txt_Resultado.Text = ""
        Dim Idade As Integer = Txt_Idade.Text

        Dim AcompanhadoPais As String
        If Rdb_Sim.Checked Then
            AcompanhadoPais = "S"
        Else
            AcompanhadoPais = "N"
        End If

        Dim PodeEntrar As Boolean = ((Idade >= 18) Or (AcompanhadoPais = "S" And Idade >= 16))
        Dim NaoPodeEntrar As Boolean = ((AcompanhadoPais = "N" And Idade >= 16) Or (Idade < 16))

        Dim MensagemAdicional As String
        If AcompanhadoPais = "S" Then
            MensagemAdicional = "Está acompanhado"
        Else
            MensagemAdicional = "Não está acompanhnado"
        End If

        If PodeEntrar Then
            Txt_Resultado.ForeColor = Color.Green
            Txt_Resultado.Text = "Pode entrar. " + MensagemAdicional
        ElseIf NaoPodeEntrar Then
            Txt_Resultado.ForeColor = Color.Red
            Txt_Resultado.Text = "Não pode entrar. " + MensagemAdicional
        End If

    End Sub
End Class
