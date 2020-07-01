﻿Namespace Classes.Funcionarios
    Public Class Auxiliar
        Inherits Funcionario

#Region "PROPRIEDADES"

#End Region


#Region "CONSTRUTORES"
        Public Sub New(_CPF As String, _Salario As Double)
            MyBase.New(_CPF, _Salario)
        End Sub
#End Region

#Region "MÉTODOS"
        Public Overrides Function GetBonificacao() As Double
            Return Salario * 0.2
        End Function

        Public Overrides Sub AumentarSalario()
            Salario *= 1.1
        End Sub
#End Region

    End Class
End Namespace
