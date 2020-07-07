Imports System.IO

Namespace Classes

    Public Class LeitorDeArquivo
        Implements IDisposable

#Region "Propriedades"

        Public Property Status As String
        Public ReadOnly Property NomeArquivo As String
        Public Property ConteudoArquivo As String

#End Region

#Region "Construtores"

        Sub New(_Arquivo As String)
            NomeArquivo = _Arquivo

            'Throw New FileNotFoundException

            Console.WriteLine("Abrindo arquivo...")
            Status = "ABERTO"
            ConteudoArquivo = ""
        End Sub

#End Region

#Region "Métodos"

        Public Sub LerLinha()
            'Throw New IOException

            Console.WriteLine("Lendo linha...")
            ConteudoArquivo += "Leitura de linha..." + vbCrLf
            Status = "ABERTO"
        End Sub

        Private Sub FecharArquivo()
            Console.WriteLine("Fechando arquivo...")
            Status = "FECHADO"
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            FecharArquivo()
        End Sub

#End Region

    End Class

End Namespace
