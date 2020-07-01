Namespace Classes.Externos

    Public Class Representante
        Implements IAutentica

#Region "PROPRIEDADES"
        Public Property Senha As String
#End Region

#Region "CONSTRUTORES"

#End Region

#Region "MÉTODOS"
        Public Function Autenticar(senhaTentativa As String) As Boolean Implements IAutentica.Autenticar
            If senhaTentativa.Length < 10 Then
                Return False
            End If
            Return senhaTentativa = Senha
        End Function
#End Region

    End Class

End Namespace
