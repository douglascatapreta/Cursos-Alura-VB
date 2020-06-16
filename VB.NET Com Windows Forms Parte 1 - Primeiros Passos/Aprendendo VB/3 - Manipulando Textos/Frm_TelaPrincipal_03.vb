Public Class Frm_TelaPrincipal_03

    Dim ListaCurso As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        Lbl_NomeProjeto.Text = "3 - Manipulando Textos"
        Btm_Principal.Text = "Clique para ver os resultados"
        Me.Text = "3 - Manipulando Textos"
        Btm_Char.Text = "Clique para obter o char"
        Lbl_Curso.Text = "Digite o seu curso preferido"
        Btm_Adicionar.Text = "Adicione a sua lista"
        Btm_MostraLista.Text = "Mostra a lista atual"
        Btm_GuardarVariavel.Text = "Clique aqui"

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click

        Dim PrimeiraLetra As Char = "a"
        MsgBox("O caracter da variável PrimeriraLetra é " + PrimeiraLetra)

        Dim SegundaLetra As Char = Chr(65)
        MsgBox("O caracter número 65 é " + SegundaLetra)

        Dim NumeroChar As Integer
        NumeroChar = 65
        Dim TerceiraLetra As Char = Chr(NumeroChar)

        NumeroChar = NumeroChar + 1
        Dim QuartaLetra As Char = Chr(NumeroChar)

        MsgBox("O caracter número 65 é " + TerceiraLetra + " e o 66 é " + QuartaLetra)

    End Sub

    Private Sub Btm_Char_Click(sender As Object, e As EventArgs) Handles Btm_Char.Click

        Dim ValorChar As Integer = Val(Txb_NumeroChar.Text)
        Dim QuintaLetra As Char = Chr(ValorChar)

        MsgBox("O caracter para o número " + ValorChar.ToString + " é " + QuintaLetra)

    End Sub

    Private Sub Btm_Adicionar_Click(sender As Object, e As EventArgs) Handles Btm_Adicionar.Click

        Dim CursoDigitado As String = Txt_Curso.Text
        ListaCurso = ListaCurso + CursoDigitado + vbCrLf
        Txt_Lista.Text = ListaCurso

    End Sub

    Private Sub Btm_MostraLista_Click(sender As Object, e As EventArgs) Handles Btm_MostraLista.Click

        MsgBox(ListaCurso)

    End Sub

    Private Sub Btm_GuardarVariavel_Click(sender As Object, e As EventArgs) Handles Btm_GuardarVariavel.Click

        Dim idade As Integer = 32
        Dim idadeGustavo As Integer

        idadeGustavo = idade

        MsgBox("Idade é igual a " + idade.ToString + " enquanto a idadeGustavo é " + idadeGustavo.ToString)

        idade = 20

        MsgBox("Idade é igual a " + idade.ToString + " enquanto a idadeGustavo é " + idadeGustavo.ToString)

    End Sub
End Class
