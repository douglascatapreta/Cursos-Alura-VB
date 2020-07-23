Imports ByteBank.Bibliotecas.Classes.Clientes

Namespace Classes.Criterios

    Public Class CriterioContaCorrenteNome
        Implements IComparer(Of ContaCorrente)

        Public Function Compare(x As ContaCorrente, y As ContaCorrente) As Integer Implements IComparer(Of ContaCorrente).Compare
            'If x.titular.nome < y.titular.nome Then
            '    Return -1
            'End If
            'If x.titular.nome = y.titular.nome Then
            '    Return 0
            'End If
            'If x.titular.nome > y.titular.nome Then
            '    Return 1
            'End If

            Return x.titular.nome.CompareTo(y.titular.nome)
        End Function
    End Class

End Namespace
