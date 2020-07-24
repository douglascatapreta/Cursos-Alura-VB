Imports ByteBank.Bibliotecas.Classes.Clientes

Namespace Classes.Criterios

    Public Class CriterioContaCorrenteSaldo
        Implements IComparer(Of ContaCorrente)

        Public Function Compare(x As ContaCorrente, y As ContaCorrente) As Integer Implements IComparer(Of ContaCorrente).Compare

            ' SE X < Y ---> -1
            ' SE X = Y ---> 0
            ' SE X > Y ---> 1

            If x.saldo < y.saldo Then
                Return -1
            End If
            If x.saldo = y.saldo Then
                Return 0
            End If
            Return 1

            ' Return x.saldo.CompareTo(y.saldo)

        End Function
    End Class

End Namespace
