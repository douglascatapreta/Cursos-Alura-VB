Namespace Classes

    Public Class ExtrairValorDeArgumentosUrl

#Region "PROPRIEDADES"

        Public ReadOnly Property url As String
        Public ReadOnly Property argumento As String
        Private ReadOnly Property dominio As String

#End Region

#Region "CONSTRUTORES"

        Sub New(urlString As String)

            dominio = "https://www.bytebank.com.br"

            If String.IsNullOrEmpty(urlString) Then
                Throw New ArgumentException("URL nula ou vazia", NameOf(urlString))
            End If

            url = urlString

            Dim posicaoSeparador As Integer = urlString.IndexOf("?")

            If posicaoSeparador = -1 Then
                argumento = ""
            Else
                argumento = urlString.Substring(posicaoSeparador + 1)
            End If

        End Sub

#End Region

#Region "MÉTODOS"

        'Public Function GetValorComSubstring(propriedade As String) As String

        '    Dim vPropriedade As String = propriedade + "="
        '    Dim vIndex As Integer = argumento.IndexOf(vPropriedade)
        '    Dim vValor As String
        '    If vIndex = -1 Then
        '        vValor = ""
        '    Else
        '        vIndex += vPropriedade.Length()
        '        Dim vArgumentoParcial As String = argumento.Substring(vIndex)
        '        Dim vIndex2 As Integer = vArgumentoParcial.IndexOf("&")
        '        If vIndex2 = -1 Then
        '            vValor = vArgumentoParcial
        '        Else
        '            vValor = vArgumentoParcial.Substring(0, vIndex2)
        '        End If
        '    End If
        '    Return vValor

        'End Function

        Public Function GetValor(propriedade As String) As String

            Dim vPropriedade As String = propriedade + "="
            Dim vIndex As Integer = argumento.ToUpper.IndexOf(vPropriedade.ToUpper)
            Dim vValor As String
            If vIndex = -1 Then
                vValor = ""
            Else
                vIndex += vPropriedade.Length()
                Dim vArgumentoParcial As String = argumento.Substring(vIndex)
                Dim vIndex2 As Integer = vArgumentoParcial.IndexOf("&")
                If vIndex2 = -1 Then
                    vValor = vArgumentoParcial
                Else
                    vValor = vArgumentoParcial.Remove(vIndex2)
                End If
            End If
            Return vValor

        End Function

        Public Function IsByteBank() As Boolean

            Return url.ToLower.StartsWith(dominio.ToLower)

        End Function

        Public Function GetTodosArgumentos() As String

            If argumento = "" Then
                Return ""
            End If
            Dim vIndex As Integer = argumento.IndexOf("&")
            If vIndex = -1 Then
                Return argumento
            Else
                Dim vListaArgumentos As String
                vListaArgumentos = argumento.Substring(0, vIndex)
                Dim vArgumentosRestos As String = argumento.Remove(0, vIndex + 1)
                While vIndex <> -1
                    vIndex = vArgumentosRestos.IndexOf("&")
                    If vIndex = -1 Then
                        vListaArgumentos += vbCrLf + vArgumentosRestos
                    Else
                        vListaArgumentos += vbCrLf + vArgumentosRestos.Substring(0, vIndex)
                        vArgumentosRestos = vArgumentosRestos.Remove(0, vIndex + 1)
                    End If
                End While
                Return vListaArgumentos
            End If

        End Function

#End Region

    End Class

End Namespace
