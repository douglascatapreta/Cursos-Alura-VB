Imports ByteBank.Classes.Funcionarios

Namespace Classes.Bibliotecas

    Public Class GerenciadorBonificacao

        Private _totalBonificacao As Double

        Public Sub Registrar(Funcionario As Funcionario)
            _totalBonificacao += Funcionario.GetBonificacao()
        End Sub

        Public Function GetBonificacao() As Double
            Return _totalBonificacao
        End Function

    End Class

End Namespace
