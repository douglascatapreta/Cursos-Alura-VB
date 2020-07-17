Imports ByteBank.Bibliotecas.Classes.Clientes
Imports ByteBank.SistemaAgencia.Classes

Public Class Frm_Principal
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Lbl_Principal.Text = "Principal"
        Me.Text = "Principal"
        Btm_Principal.Text = "Clique Aqui"
        Btm_Principal2.Text = "Clique Aqui"
        Btm_Principal3.Text = "Clique Aqui"
        Btm_Principal4.Text = "Clique Aqui"

    End Sub

    Private Sub Btm_Principal_Click(sender As Object, e As EventArgs) Handles Btm_Principal.Click

        Dim idade_1 As Integer = 30
        Dim idade_2 As Integer = 20
        Dim idade_3 As Integer = 25
        Dim idade_4 As Integer = 45
        Dim idade_5 As Integer = 32

        Dim media_1 As Double = (idade_1 + idade_2 + idade_3 + idade_4 + idade_5) / 5
        MsgBox(media_1)

        Dim idades(4) As Integer
        idades(0) = 30
        idades(1) = 20
        idades(2) = 25
        idades(3) = 45
        idades(4) = 32

        Dim media_2 As Double = 0
        For i As Integer = 0 To idades.Length - 1
            media_2 += idades(i)
        Next
        media_2 /= idades.Length
        MsgBox(media_2)

        Dim media_3 As Double = idades.Sum / idades.Length
        MsgBox(media_3)

        Dim media_4 As Double = idades.Average
        MsgBox(media_4)

    End Sub

    Private Sub Btm_Principal2_Click(sender As Object, e As EventArgs) Handles Btm_Principal2.Click

        Dim contas(5) As ContaCorrente
        contas(0) = New ContaCorrente(123, 456789)
        contas(1) = New ContaCorrente(123, 654315)
        contas(2) = New ContaCorrente(123, 737444)
        contas(3) = New ContaCorrente(123, 604654)
        contas(4) = New ContaCorrente(123, 375894)
        contas(5) = New ContaCorrente(123, 159077)

        For i As Integer = 0 To contas.Length - 1
            Dim vNumero As Integer = contas(i).numero
            MsgBox($"Contas na posição {i}: {vNumero}")
        Next

        Dim contas2() As ContaCorrente
        contas2 = {New ContaCorrente(123, 456789),
        New ContaCorrente(123, 654315),
        New ContaCorrente(123, 737444),
        New ContaCorrente(123, 604654),
        New ContaCorrente(123, 375894),
        New ContaCorrente(123, 159077)}

        For i As Integer = 0 To contas2.Length - 1
            Dim vNumero As Integer = contas2(i).numero
            MsgBox($"Contas2 na posição {i}: {vNumero}")
        Next

    End Sub

    Private Sub Btm_Principal3_Click(sender As Object, e As EventArgs) Handles Btm_Principal3.Click

        Dim Lista As New ListaDeContasCorrentes(10)

        Lista.Adicionar(New ContaCorrente(111, 111111))
        Lista.Adicionar(New ContaCorrente(222, 222222))
        Lista.Adicionar(New ContaCorrente(333, 222222))
        Lista.Adicionar(New ContaCorrente(444, 222222))
        Lista.Adicionar(New ContaCorrente(555, 222222))
        Lista.Adicionar(New ContaCorrente(666, 222222))
        Lista.Adicionar(New ContaCorrente(777, 222222))

    End Sub

    Private Sub Btm_Principal4_Click(sender As Object, e As EventArgs) Handles Btm_Principal4.Click

        Dim Lista1 As New ListaDeObjects()

        Lista1.Adicionar(12)
        Lista1.Adicionar(13)
        Lista1.Adicionar(15)
        Lista1.AdicionarVariosUmAUm(12, 15, 14, 13, 18, 20)

        Dim soma As Integer
        For i As Integer = 0 To Lista1.Tamanho - 1
            soma += Lista1(i)
        Next

        MsgBox(soma)

        Dim Lista2 As New ListaDeObjects()

        Lista2.Adicionar("a1")
        Lista2.Adicionar("a2")
        Lista2.Adicionar("a3")
        Lista2.AdicionarVariosUmAUm("a4", "a5", "a6", "a7")

        Dim somaStr As String = ""
        For i As Integer = 0 To Lista2.Tamanho - 1
            somaStr += Lista2(i)
        Next

        MsgBox(somaStr)

        Dim Lista3 As New ListaDeObjects()

        Lista3.Adicionar(New ContaCorrente(1, 1))
        Lista3.Adicionar(New ContaCorrente(2, 2))
        Lista3.Adicionar(New ContaCorrente(3, 3))
        Lista3.AdicionarVariosUmAUm(New ContaCorrente(4, 4), New ContaCorrente(5, 5), New ContaCorrente(6, 6), New ContaCorrente(7, 7))

        Dim somaStr2 As String = ""
        For i As Integer = 0 To Lista3.Tamanho - 1
            Dim contaAtual As ContaCorrente = TryCast(Lista3(i), ContaCorrente)
            somaStr2 += contaAtual.agencia.ToString + " - " + contaAtual.numero.ToString + " ; "
        Next

        MsgBox(somaStr2)

        Dim Lista4 As New ListaDeContasCorrentes
        Lista4.Adicionar(New ContaCorrente(1, 1))
        Lista4.Adicionar(New ContaCorrente(2, 2))
        'Lista4.Adicionar("string")

        Dim Lista5 As New ListaDeObjects
        Lista5.Adicionar(New ContaCorrente(1, 1))
        Lista5.Adicionar(New ContaCorrente(2, 2))
        Lista5.Adicionar("string")

        Dim Lista6 As New Lista(Of ContaCorrente)
        Lista6.Adicionar(New ContaCorrente(1, 1))
        Lista6.Adicionar(New ContaCorrente(2, 2))
        'Lista6.Adicionar("string")

    End Sub
End Class