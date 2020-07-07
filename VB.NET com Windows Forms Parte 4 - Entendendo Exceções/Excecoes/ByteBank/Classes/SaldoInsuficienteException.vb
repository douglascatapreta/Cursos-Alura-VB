Namespace Classes

    Public Class SaldoInsuficienteException
        Inherits OperacaoFinanceiraException

#Region "PROPRIEDADES"

        Public ReadOnly Property ValorSacado As Double
        Public ReadOnly Property Saldo As Double

#End Region

#Region "CONSTRUTORES"

        Sub New()

        End Sub

        Sub New(mensagem As String)
            MyBase.New(mensagem)
        End Sub

        Sub New(_valorSacado As Double, _saldo As Double, _mensagem As String)
            Me.New(_mensagem)
            ValorSacado = _valorSacado
            Saldo = _saldo
        End Sub

        Sub New(message As String, innerException As Exception)
            MyBase.New(message, innerException)
        End Sub

#End Region

    End Class

End Namespace
