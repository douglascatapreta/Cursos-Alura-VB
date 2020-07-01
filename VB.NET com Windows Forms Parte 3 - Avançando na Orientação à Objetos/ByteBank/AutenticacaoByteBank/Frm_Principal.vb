Imports AutenticacaoByteBank.Classes.Bibliotecas
Imports AutenticacaoByteBank.Classes.Externos
Imports AutenticacaoByteBank.Classes.Funcionarios

Public Class Frm_Principal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Autenticação ByteBank"
        Lbl_Principal.Text = "Autenticação ByteBank"
        Btm_Autentica.Text = "Autenticar"
        Btm_Autentica2.Text = "Autenticar como representante"

    End Sub

    Private Sub Btm_Autentica_Click(sender As Object, e As EventArgs) Handles Btm_Autentica.Click

        Dim Pedro As New Diretor("123.123.123-00", 2000)
        Pedro.Senha = "abc"

        Dim Alberto As New Gerente("123.123.123-00", 2000)
        Alberto.Senha = "999"

        Dim vLoga As Boolean
        Dim SistemaInterno As New SistemaInterno()
        vLoga = SistemaInterno.Logar(Pedro, "123")
        MsgBox("A tentativa de logar no sistema como Diretor resultou em " + vLoga.ToString)

        vLoga = SistemaInterno.Logar(Pedro, "abc")
        MsgBox("A tentativa de logar no sistema como Diretor resultou em " + vLoga.ToString)

        vLoga = SistemaInterno.Logar(Alberto, "999")
        MsgBox("A tentativa de logar no sistema como Gerente resultou em " + vLoga.ToString)

    End Sub

    Private Sub Btm_Autentica2_Click(sender As Object, e As EventArgs) Handles Btm_Autentica2.Click

        Dim Pedro As New Diretor("123.123.123-00", 2000)
        Pedro.Senha = "abcdefg"

        Dim Gilberto As New Representante()
        Gilberto.Senha = "99999999999"

        Dim vLoga As Boolean
        Dim SistemaInterno As New SistemaInterno()

        vLoga = SistemaInterno.Logar(Pedro, "abcdefg")
        MsgBox("A tentativa de logar no sistema como Diretor resultou em " + vLoga.ToString)

        vLoga = SistemaInterno.Logar(Gilberto, "99999999999")
        MsgBox("A tentativa de logar no sistema como Representante resultou em " + vLoga.ToString)

    End Sub
End Class
