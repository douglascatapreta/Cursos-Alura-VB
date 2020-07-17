Namespace Classes

    Public Class Lista(Of T)

#Region "Propriedades"

        Private Property _items() As T()
        Private Property _proximaPosicao As Integer

        Public ReadOnly Property Tamanho As Integer
            Get
                Return _proximaPosicao
            End Get
        End Property

#End Region

#Region "Indexadores"

        Default Public ReadOnly Property Item(indice As Integer)
            Get
                Return GetItem(indice)
            End Get
        End Property

#End Region

#Region "Construtores"

        Public Sub New(Optional tamanhoInicial As Integer = 5)

            _items = New T(tamanhoInicial - 1) {}
            _proximaPosicao = 0

        End Sub

#End Region

#Region "Métodos"

        Public Sub Adicionar(item As T)

            VerificarCapacidadeArrayComCopy(_proximaPosicao + 1)
            _items(_proximaPosicao) = item
            _proximaPosicao += 1

        End Sub

        Private Sub VerificarCapacidadeArrayComFor(tamanhoNecessario As Integer)

            If _items.Length >= tamanhoNecessario Then
                Return
            End If

            Dim novoTamanho As Integer = _items.Length * 2

            If novoTamanho < tamanhoNecessario Then
                novoTamanho = tamanhoNecessario
            End If

            Dim novoArray(novoTamanho) As Object

            For i As Integer = 0 To _items.Length - 1
                novoArray(i) = _items(i)
            Next

            _items = novoArray

        End Sub

        Private Sub VerificarCapacidadeArrayComCopy(tamanhoNecessario As Integer)

            If _items.Length >= tamanhoNecessario Then
                Return
            End If

            Dim novoTamanho As Integer = _items.Length * 2

            If novoTamanho < tamanhoNecessario Then
                novoTamanho = tamanhoNecessario
            End If

            Dim novoArray(novoTamanho) As Object

            Array.Copy(_items, novoArray, _items.Length)

            _items = novoArray

        End Sub

        Public Function PosicaoElemento(item As T) As Integer

            For i As Integer = 0 To _proximaPosicao - 1
                If _items(i).Equals(item) Then
                    Return i
                End If
            Next

            Return -1

        End Function

        Public Sub Remover(item As T)

            Dim indice As Integer = PosicaoElemento(item)
            If indice = -1 Then
                Return
            End If

            _proximaPosicao -= 1

            For i As Integer = indice To _proximaPosicao - 1
                _items(i) = _items(i + 1)
            Next

        End Sub

        Public Function GetItem(indice As Integer) As T

            If indice < 0 Or indice >= _proximaPosicao Then
                Throw New ArgumentOutOfRangeException(NameOf(indice))
            End If

            Return _items(indice)

        End Function

        Public Sub AdicionarVarios(items As T())

            'For i As Integer = 0 To contas.Length - 1
            '    Adicionar(contas(i))
            'Next

            For Each item As T In items
                Adicionar(item)
            Next

        End Sub

        Public Sub AdicionarVariosUmAUm(ParamArray items As T())

            For Each item As T In items
                Adicionar(item)
            Next

        End Sub

#End Region
    End Class

End Namespace
