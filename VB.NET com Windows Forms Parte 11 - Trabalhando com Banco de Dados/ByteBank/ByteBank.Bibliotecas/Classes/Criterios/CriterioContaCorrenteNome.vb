
Imports ByteBank.Bibliotecas.Classes.Clientes

Namespace Classes.Criterios

    Public Class CriterioContaCorrenteNome
        Implements IComparer(Of ContaCorrente)

        Public Function Compare(x As ContaCorrente, y As ContaCorrente) As Integer Implements IComparer(Of ContaCorrente).Compare


            ' SE X < Y ---> -1
            ' SE X = Y ---> 0
            ' SE X > Y ---> 1

            If x.titular.nome < y.titular.nome Then
                Return -1
            End If
            If x.titular.nome = y.titular.nome Then
                Return 0
            End If
            Return 1

            'Return x.titular.nome.CompareTo(y.titular.nome)

        End Function
    End Class

End Namespace


