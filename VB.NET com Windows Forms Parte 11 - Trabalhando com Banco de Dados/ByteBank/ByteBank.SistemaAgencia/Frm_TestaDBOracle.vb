Imports ByteBank.Bibliotecas.Classes.BancoDeDados

Public Class Frm_TestaDBOracle
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        DtGrid_Resultado.Columns.Clear()
        DtGrid_Resultado.DataSource = Nothing

        Try
            Dim Dt As New DataTable
            Dim DB As New OracleConn("XE", "system", "oracle")
            Dim Retorno As String = DB.SQLQuery("SELECT CPF, NOME, PROFISSAO FROM CLIENTE", Dt)
            DtGrid_Resultado.DataSource = Dt
            DB.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Try
            Dim Comando As String = "INSERT INTO CLIENTE (CPF, nome, profissao) VALUES ('99433454344','Zanir Moreira','Músico')"
            Dim DB As New OracleConn("XE", "system", "oracle")
            Dim Dt As New DataTable
            Dim Retorno As String = DB.SQLQuery("SELECT CPF,nome,profissao FROM Cliente WHERE CPF = '99433454344'", Dt)
            If Dt.Rows.Count > 0 Then
                MsgBox("Cliente não pode ser incluido porque já existe na base")
            Else
                Dim Retorno2 As String = DB.SQLCommand(Comando)
                MsgBox("Cliente incluido com sucesso")
            End If
            DB.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim Comando As String = "DELETE FROM CLIENTE WHERE CPF = '99433454344'"
            Dim DB As New OracleConn("XE", "system", "oracle")
            Dim Retorno As String = DB.SQLCommand(Comando)
            DB.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class