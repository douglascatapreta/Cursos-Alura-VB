Namespace Classes.Funcionarios

    Public MustInherit Class Funcionario

#Region "PROPRIEDADES"
        Public Property Nome As String

        Private m_CPF As String
        Public ReadOnly Property CPF As String
            Get
                Return m_CPF
            End Get
        End Property

        Private m_Salario As Double
        Public Property Salario As Double
            Get
                Return m_Salario
            End Get
            Protected Set(value As Double)
                m_Salario = value
            End Set
        End Property

        Private Shared m_TotalDeFuncionarios As Integer
        Public Shared ReadOnly Property TotalDeFuncionarios As Integer
            Get
                Return m_TotalDeFuncionarios
            End Get
        End Property
#End Region

#Region "CONSTRUTORES"
        Public Sub New(_CPF As String, _Salario As Double)
            m_CPF = _CPF
            m_Salario = _Salario
            m_TotalDeFuncionarios += 1
        End Sub
#End Region

#Region "MÉTODOS"
        Public MustOverride Function GetBonificacao() As Double

        Public MustOverride Sub AumentarSalario()
#End Region

    End Class

End Namespace