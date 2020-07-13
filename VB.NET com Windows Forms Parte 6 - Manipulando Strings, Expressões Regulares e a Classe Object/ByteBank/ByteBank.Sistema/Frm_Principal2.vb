Imports ByteBank.Bibliotecas.Classes

Public Class Frm_Principal2
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Formulário Principal 2"
        Lbl_Principal2.Text = "Formulário Principal 2"
        Lbl_URL.Text = "URL"
        Lbl_Argumento.Text = "Argumento"
        Txt_Argumento.ReadOnly = True
        Btm_Processar.Text = "Processar"
        Lbl_Propriedade.Text = "Propriedade"

        ' Inicializando o TextBox
        Txt_URL.Text = "https://www.bytebank.com.br/cambio?moedaOrigem=dolar&moedaDestino=real&valor=1500"
        Txt_Propriedade.Text = "moedaDestino"

    End Sub

    Private Sub Btm_Processar_Click(sender As Object, e As EventArgs) Handles Btm_Processar.Click

        Dim vUrl As New ExtrairValorDeArgumentosUrl(Txt_URL.Text)

        If Not vUrl.IsByteBank Then
            MsgBox("URL não é do domínio do banco ByteBank")
        Else
            Txt_Argumento.Text = vUrl.argumento
            Dim vPropriedade As String = Txt_Propriedade.Text
            MsgBox(vUrl.GetValor(vPropriedade))
        End If

    End Sub
End Class