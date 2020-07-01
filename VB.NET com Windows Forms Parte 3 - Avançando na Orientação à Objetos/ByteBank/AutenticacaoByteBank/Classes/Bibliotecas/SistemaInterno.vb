Imports AutenticacaoByteBank.Classes.Externos
Imports AutenticacaoByteBank.Classes.Funcionarios

Namespace Classes.Bibliotecas

    Public Class SistemaInterno

        Public Function Logar(entidade As IAutentica, senhaTentativa As String)

            Dim vRetorno As Boolean = entidade.Autenticar(senhaTentativa)
            Return vRetorno

        End Function

    End Class

End Namespace
