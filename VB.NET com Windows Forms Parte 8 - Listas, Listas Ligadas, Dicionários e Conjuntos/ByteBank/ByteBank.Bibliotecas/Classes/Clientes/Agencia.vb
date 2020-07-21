Imports System.Collections.ObjectModel

Namespace Classes.Clientes

    Public Class Agencia

#Region "PROPRIEDADES"

        Public ReadOnly Property Agencia As Integer

        Private _contasCorrentes As ISet(Of ContaCorrente)

        Public ReadOnly Property ContasCorrentes As IList(Of ContaCorrente)
            Get
                Dim contasCorrentesLista As New List(Of ContaCorrente)(_contasCorrentes)
                Return New ReadOnlyCollection(Of ContaCorrente)(contasCorrentesLista)
            End Get
        End Property

        '*********************** SIMULAÇÂO ***********************
        Private Shared _NumeroClienteFila As Integer
        Public Shared ReadOnly Property NumeroClienteFila As Integer
            Get
                Return _NumeroClienteFila
            End Get
        End Property

        Private Shared _TempoTotalFila As Integer
        Public Shared ReadOnly Property TempoTotalFila As Integer
            Get
                Return _TempoTotalFila
            End Get
        End Property

        Public Property Caixas As List(Of Caixa)
        Public Property Fila As Queue(Of ClienteAgencia)
        Public Property NumeroCliente As Integer
        '*********************************************************

#End Region

#Region "CONSTRUTORES"

        Public Sub New(codigo As Integer)

            Agencia = codigo
            _contasCorrentes = New HashSet(Of ContaCorrente)

            '*********************** SIMULAÇÂO ***********************
            Caixas = New List(Of Caixa)
            Fila = New Queue(Of ClienteAgencia)
            _NumeroClienteFila = 0
            _TempoTotalFila = 0
            NumeroCliente = 0
            '*********************************************************

        End Sub

#End Region

#Region "MÉTODOS"

        Public Sub AbrirContaCorrente(Numero As Integer, Nome As String)

            _contasCorrentes.Add(New ContaCorrente(Agencia, Numero, Nome))

        End Sub

        Public Sub FecharContaCorrente(Numero As Integer, Nome As String)

            _contasCorrentes.Remove(New ContaCorrente(Agencia, Numero, Nome))

        End Sub

        Public Function BuscarContaCorrente(Numero As Integer) As ContaCorrente

            Dim contaBuscar As New ContaCorrente(Agencia, Numero)
            For Each conta As ContaCorrente In _contasCorrentes
                If conta.Equals(contaBuscar) Then
                    Return conta
                End If
            Next
            Throw New Exception("Conta não existente")

        End Function

        Public Sub AlterarContaCorrente(Numero As Integer, Nome As String)

            For Each conta As ContaCorrente In _contasCorrentes
                If conta.numero = Numero Then
                    conta.titular.nome = Nome
                    Exit For
                End If
            Next

        End Sub

        '*********************** SIMULAÇÂO ***********************
        Public Sub EntrarNaFila(_TempoServico As Integer)
            NumeroCliente += 1
            Dim Cliente As New ClienteAgencia(_TempoServico, NumeroCliente)
            Fila.Enqueue(Cliente)
        End Sub

        Public Sub ExercutarAtendimento(_TempoIncremento As Integer)
            For i As Integer = 0 To Caixas.Count - 1
                If Caixas(i).Ocupado Then
                    Caixas(i).EfetuarAtendimento(_TempoIncremento)
                Else
                    If Caixas(i).Ativo Then
                        Caixas(i).AumentarTempoOcioso(_TempoIncremento)
                    End If
                End If
            Next
            For i As Integer = 0 To Fila.Count - 1
                Fila(i).AdicionarTempoEspera(_TempoIncremento)
            Next
        End Sub

        Public Sub SairDaFila()
            If Fila.Count > 0 Then
                For i As Integer = 0 To Caixas.Count - 1
                    If Not Caixas(i).Ocupado Then
                        If Fila.Count > 0 Then
                            Dim Cliente As ClienteAgencia = Fila.Dequeue()
                            _NumeroClienteFila += 1
                            _TempoTotalFila += Cliente.TempoEspera
                            Caixas(i).IniciarAtendimento(Cliente.TempoServico)
                            Caixas(i).ZerarTempoOcioso()
                        End If
                    End If
                Next
            End If
        End Sub

        Public Function TamanhoFIla() As Integer
            Return Fila.Count()
        End Function

        Public Sub DesativarCaixa()
            For i As Integer = 0 To Caixas.Count - 1
                If Not Caixas(i).Ocupado And Not Caixas(i).Ativo Then
                    If Caixas(i).TempoOcioso >= 300 Then
                        Caixas(i).TempoOcioso = 0
                        Caixas(i).Ativo = False
                    End If
                End If
            Next
        End Sub
        '*********************************************************

#End Region

    End Class

End Namespace
