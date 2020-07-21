Imports System.Collections.ObjectModel

Namespace Classes.Clientes

    Public Class AgenciaDic

#Region "PROPRIEDADES"

        Public ReadOnly Property Agencia As Integer

        Private _contasCorrentes As IDictionary(Of Integer, ContaCorrente)

        Public ReadOnly Property ContasCorrentes As IDictionary(Of Integer, ContaCorrente)
            Get
                Return _contasCorrentes
            End Get
        End Property

#End Region

#Region "CONSTRUTORES"

        Public Sub New(codigo As Integer)

            Agencia = codigo
            _contasCorrentes = New Dictionary(Of Integer, ContaCorrente)

        End Sub

#End Region

#Region "MÉTODOS"

        Public Sub AbrirContaCorrente(Numero As Integer, Nome As String)

            _contasCorrentes.Add(Numero, New ContaCorrente(Agencia, Numero, Nome))

        End Sub

        Public Sub FecharContaCorrente(Numero As Integer)

            _contasCorrentes.Remove(Numero)

        End Sub

        Public Function BuscarContaCorrente(Numero As Integer) As ContaCorrente

            Return _contasCorrentes(Numero)

        End Function

        Public Sub AlterarContaCorrente(Numero As Integer, Nome As String)

            _contasCorrentes(Numero).titular.nome = Nome

        End Sub

#End Region

    End Class

End Namespace
