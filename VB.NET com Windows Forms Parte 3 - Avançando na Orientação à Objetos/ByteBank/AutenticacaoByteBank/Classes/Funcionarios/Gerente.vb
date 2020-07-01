Namespace Classes.Funcionarios
    Public Class Gerente
        Inherits FuncionarioAutenticavel

#Region "PROPRIEDADES"

#End Region

#Region "CONSTRUTORES"
        Public Sub New(_CPF As String, _Salario As Double)
            MyBase.New(_CPF, _Salario)
        End Sub
#End Region

#Region "MÉTODOS"
        Public Overrides Function GetBonificacao() As Double
            Return Salario * 0.25
        End Function

        Public Overrides Sub AumentarSalario()
            Salario *= 1.03
        End Sub
#End Region

    End Class
End Namespace
