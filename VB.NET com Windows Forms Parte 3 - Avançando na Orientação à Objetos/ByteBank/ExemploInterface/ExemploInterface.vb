Public Class ExemploInterface
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Exemplo Interface"
        Lbl_ExemploInterface.Text = "Exemplo Interface"
        Btm_ExemploInterface.Text = "Clique aqui"

    End Sub

    Private Sub Btm_ExemploInterface_Click(sender As Object, e As EventArgs) Handles Btm_ExemploInterface.Click

        Dim vX As New Imovel()

        MsgBox(vX.AbrirPorta(New Casa()))
        MsgBox(vX.AbrirPorta(New Predio()))
        MsgBox(vX.AbrirPorta(New Sobrado()))

    End Sub
End Class
