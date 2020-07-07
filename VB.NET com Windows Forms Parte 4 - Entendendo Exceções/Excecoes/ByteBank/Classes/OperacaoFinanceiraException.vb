Namespace Classes

    Public Class OperacaoFinanceiraException
        Inherits Exception

#Region "CONSTRUTORES"

        Sub New()

        End Sub

        Sub New(message As String)
            MyBase.New(message)
        End Sub

        Sub New(message As String, innerException As Exception)
            MyBase.New(message, innerException)
        End Sub

#End Region

    End Class

End Namespace
