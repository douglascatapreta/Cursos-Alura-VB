Imports System.IO
Imports System.Text
Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class Frm_EntradaSaida
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        TextBox1.Text = ""
        TextBox2.Text = ""

        Dim EnderecoDoArquivo As String = "temp.txt"

        Using FluxoDoArquivo As New FileStream(EnderecoDoArquivo, FileMode.Open)
            Dim Buffer = New Byte(1024) {}
            Dim NumeroBytesLidos As Integer = -1

            While NumeroBytesLidos <> 0
                NumeroBytesLidos = FluxoDoArquivo.Read(Buffer, 0, 1024)
                If NumeroBytesLidos <> 0 Then
                    TextBox1.AppendText(EscreverBuffer(Buffer, NumeroBytesLidos))
                    TextBox2.AppendText(EscreverBufferUTF(Buffer, NumeroBytesLidos))
                End If
            End While
        End Using
    End Sub

    Function EscreverBuffer(Buffer As Byte(), NumeroBytesLidos As Integer) As String

        Dim vRetorno As String = ""
        For i As Integer = 0 To NumeroBytesLidos - 1
            vRetorno += Buffer(i).ToString + " "
        Next

        Return vRetorno

    End Function

    Function EscreverBufferUTF(Buffer As Byte(), NumeroBytesLidos As Integer) As String

        Dim vRetorno As String
        Dim UTF As New UTF8Encoding()
        vRetorno = UTF.GetString(Buffer, 0, NumeroBytesLidos)

        Return vRetorno

    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        TextBox1.Text = ""
        TextBox2.Text = ""

        Using FluxoDoArquivo As New FileStream("temp.csv", FileMode.Open)
            Using Leitor As New StreamReader(FluxoDoArquivo, Encoding.UTF8)
                While Not Leitor.EndOfStream()
                    Dim Linha As String = Leitor.ReadLine()
                    Dim CC As ContaCorrente = CriarContaCorrente(Linha)
                    TextBox1.AppendText(Linha + vbCrLf)
                    TextBox2.AppendText(CC.ToString + vbCrLf)
                End While
            End Using
        End Using

    End Sub

    Function CriarContaCorrente(Linha As String) As ContaCorrente

        Dim VetorLinha() As String = Linha.Split(";")

        Dim Cliente As New Cliente() With {
            .cpf = VetorLinha(3),
            .nome = VetorLinha(4)
        }

        Dim Conta As New ContaCorrente(VetorLinha(0), VetorLinha(1)) With {
            .titular = Cliente
        }
        Conta.Depositar(Double.Parse(VetorLinha(2)) - 100)

        Return Conta

    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Using FLuxoDeArquivo As New FileStream("ContasExternas.csv", FileMode.Create)
            Dim ContaString As String = "456;78945;4785,9;221122323;Gustavo Santos"
            Dim UTF As New UTF8Encoding()
            Dim Bytes = UTF.GetBytes(ContaString)
            FLuxoDeArquivo.Write(Bytes, 0, Bytes.Count)
        End Using

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Using FLuxoDeArquivo As New FileStream("ContasExternas.csv", FileMode.Create)
            Using Escritor As New StreamWriter(FLuxoDeArquivo, Encoding.UTF8)
                Escritor.WriteLine("456;78945;4785,9;221122323;José da Silva")
            End Using
        End Using

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        TextBox2.Text = ""
        Using FLuxoDeArquivo As New FileStream("Teste.txt", FileMode.Create)
            Using Escritor As New StreamWriter(FLuxoDeArquivo, Encoding.UTF8)
                For i As Integer = 0 To 1000
                    TextBox2.AppendText($"Linha {i}{vbCrLf}")
                    Escritor.WriteLine($"Linha {i}")
                    Escritor.Flush()
                Next
            End Using
        End Using

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Using FLuxoDeArquivo As New FileStream("ContaCorrenteBinario.bin", FileMode.Create)
            Using Escritor As New BinaryWriter(FLuxoDeArquivo)
                Dim agencia As Integer = 234
                Dim conta As Integer = 122221
                Dim saldo As Double = 4323.23
                Dim cpf As String = "12222111122"
                Dim nome As String = "João da Silva"

                Escritor.Write(agencia)
                Escritor.Write(conta)
                Escritor.Write(saldo)
                Escritor.Write(cpf)
                Escritor.Write(nome)
            End Using
        End Using

        Using FLuxoDeArquivo As New FileStream("ContaCorrenteBinario.bin", FileMode.Open)
            Using Leitor As New BinaryReader(FLuxoDeArquivo)
                Dim agencia As Integer = Leitor.ReadInt32()
                Dim conta As Integer = Leitor.ReadInt32()
                Dim saldo As Double = Leitor.ReadDouble()
                Dim cpf As String = Leitor.ReadString()
                Dim nome As String = Leitor.ReadString()

                MsgBox($"Agência: {agencia}, Conta: {conta}, Saldo: {saldo}, CPF: {cpf}, None: {nome}")
            End Using
        End Using

    End Sub
End Class