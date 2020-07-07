Namespace Classes

    Public Class Cliente

#Region "Propriedades"
        Private m_CPF As String
        Public Property CPF As String
            Get
                Return m_CPF
            End Get
            Set(value As String)
                m_CPF = value
            End Set
        End Property

        Public Property Nome As String

        Public Property Profissao As String
#End Region

    End Class

End Namespace
