Namespace Classes.Bibliotecas

    Public Class ClasseTeste

        Sub Teste()

            Dim X As New ModificadoresTeste()
            X.MetodoPublico()
            'X.MetodoProtegido()
            'X.MetodoPrivado()
            X.MetodoInterno()

        End Sub

    End Class

    Public Class ClasseDerivada
        Inherits ModificadoresTeste

        Sub Testes()
            MetodoPublico()
            MetodoProtegido()
            'MetodoPrivado()
            MetodoInterno()
        End Sub

    End Class

    Public Class ModificadoresTeste

        Sub Teste()

            Dim X As New ModificadoresTeste()
            X.MetodoPublico()
            X.MetodoProtegido()
            X.MetodoPrivado()
            X.MetodoInterno()

        End Sub

        Public Sub MetodoPublico()
            ' Método acessado pela própria classe, por classes do mesmo projeto e por classes de outros projetos.
        End Sub

        Protected Sub MetodoProtegido()
            ' Método acessado pela própria classe e suas derivadas.
        End Sub

        Private Sub MetodoPrivado()
            ' Método acessado somente pela própria classe.
        End Sub

        Friend Sub MetodoInterno()
            ' Método acessado pela própria classe e por classes do mesmo projeto.
        End Sub

    End Class

End Namespace
