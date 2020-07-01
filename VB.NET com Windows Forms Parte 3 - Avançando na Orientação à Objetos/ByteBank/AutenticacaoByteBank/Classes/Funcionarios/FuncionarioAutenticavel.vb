Namespace Classes.Funcionarios

    Public MustInherit Class FuncionarioAutenticavel
        Inherits Funcionario
        Implements IAutentica

#Region "PROPRIEDADES"
        Public Property Senha As String
#End Region

#Region "CONSTRUTORES"
        Public Sub New(_CPF As String, _Salario As Double)
            MyBase.New(_CPF, _Salario)
        End Sub
#End Region

#Region "MÉTODOS"
        Public Function Autenticar(senhaTentativa As String) As Boolean Implements IAutentica.Autenticar
            If senhaTentativa.Length < 5 Then
                Return False
            End If
            Return senhaTentativa = Senha
        End Function
#End Region

    End Class

End Namespace
