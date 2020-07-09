Namespace Classes.Bibliotecas

    Friend Class AutenticacaoHelper

        Public Function Autenticar(senhaTentativa As String, senhaUsuario As String) As Boolean
            If senhaUsuario = senhaTentativa Then
                Return True
            End If
            Return False

        End Function

    End Class

End Namespace
