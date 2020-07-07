Namespace Classes

    Public Class ContaCorrente

#Region "Propriedades"

        Public Property Titular As Cliente

        Public ReadOnly Property Agencia As Integer

        Public ReadOnly Property Numero As Integer

        Private m_Saldo As Double = 100
        Public Property Saldo As Double
            Get
                Return m_Saldo
            End Get
            Set(value As Double)
                If value <= 0 Then
                    m_Saldo = 0
                Else
                    m_Saldo = value
                End If
            End Set
        End Property

        Private Shared m_TotalContasCriadas As Integer
        Public Shared ReadOnly Property TotalContasCriadas As Integer
            Get
                Return m_TotalContasCriadas
            End Get
        End Property

        Private Shared m_TaxaOperacao As Integer
        Public Shared ReadOnly Property TaxaOperacao As Integer
            Get
                Return m_TaxaOperacao
            End Get
        End Property

        Private m_NumeroSaquesErrados As Integer
        Public Property NumeroSaquesErrados As Integer
            Get
                Return m_NumeroSaquesErrados
            End Get
            Private Set(value As Integer)
                m_NumeroSaquesErrados = value
            End Set
        End Property

        Private m_NumeroTransferenciasErrados As Integer
        Public Property NumeroTransferenciasErrados As Integer
            Get
                Return m_NumeroTransferenciasErrados
            End Get
            Private Set(value As Integer)
                m_NumeroTransferenciasErrados = value
            End Set
        End Property

#End Region

#Region "Construtores"

        Public Sub New(_agencia As Integer, _numero As Integer)
            If _agencia <= 0 Then
                Throw New ArgumentException("Número da agência menor ou igual a zero.", NameOf(_agencia))
            ElseIf _numero <= 0 Then
                Throw New ArgumentException("Número da conta menor ou igual a zero.", NameOf(_numero))
            End If

            Agencia = _agencia
            Numero = _numero
            m_TotalContasCriadas += 1
            m_TaxaOperacao = 30 / m_TotalContasCriadas
        End Sub

#End Region

#Region "Métodos"

        Public Sub Sacar(valorSacar As Double, valorLabel As String)
            If valorSacar < 0 Then
                m_NumeroSaquesErrados += 1
                Throw New ArgumentException("Valor " + valorLabel + " é negativo. " + valorSacar.ToString, NameOf(valorSacar))
            End If

            If m_Saldo < valorSacar Then
                m_NumeroSaquesErrados += 1
                Dim mensagem As String
                mensagem = "Valor " + valorLabel + " é maior que o saldo."
                Throw New SaldoInsuficienteException(valorSacar, m_Saldo, mensagem)
            Else
                m_Saldo -= valorSacar
            End If
        End Sub

        Public Sub Depositar(valorDepositar As Double)
            m_Saldo += valorDepositar
        End Sub

        Public Sub Transferir(valorTransferir As Double, contaDestino As ContaCorrente)
            Try
                Sacar(valorTransferir, "da transferência")
            Catch ex As SaldoInsuficienteException
                m_NumeroTransferenciasErrados += 1
                Throw New OperacaoFinanceiraException("Operação inválida.", ex)
            Catch ex As ArgumentException
                m_NumeroTransferenciasErrados += 1
                Throw
            End Try
            contaDestino.Depositar(valorTransferir)
        End Sub

#End Region

    End Class

End Namespace
