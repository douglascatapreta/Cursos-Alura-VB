Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class Frm_ManutencaoCCDataTable

    Dim DS As New DataSet()
    Dim DtListView As New DataTable()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Manutenção Conta Corrente"
        Grp_Lista.Text = "Lista de Contas Correntes"
        Grp_CriterioOrdenacao.Text = "Critério de Ordenação"

        Rb_Conta.Text = "Conta"
        Rb_Nome.Text = "Nome"
        Rb_Saldo.Text = "Saldo"

        InicializarContas()
        FormatarListView()
        CriarColunas()
        CriarDataTableListView()
        'AtualizarListView()
        AtualizarListView1()
        AtualizarListView2()

    End Sub

    Sub InicializarContas()
        Dim Clientes As New List(Of Cliente) From {
            New Cliente() With {.cpf = "11111111111", .nome = "João da Silva", .profissao = "Engenheiro"},
            New Cliente() With {.cpf = "22222222222", .nome = "Alberto Navarro", .profissao = "Programador"},
            New Cliente() With {.cpf = "33333333333", .nome = "Zoraide Margrelha", .profissao = "Médica"},
            New Cliente() With {.cpf = "44444444444", .nome = "Verônica Mars", .profissao = "Agente Secreta"},
            New Cliente() With {.cpf = "55555555555", .nome = "Coulson Springs", .profissao = "Lixeiro"},
            New Cliente() With {.cpf = "66666666666", .nome = "Maricota Miranda", .profissao = "Dona de Casa"}
        }

        Dim Contas As New List(Of ContaCorrente) From {
            New ContaCorrente(277, 123221) With {.titular = Clientes(0)},
            New ContaCorrente(277, 344789) With {.titular = Clientes(0)},
            New ContaCorrente(277, 556441) With {.titular = Clientes(1)},
            New ContaCorrente(277, 113499) With {.titular = Clientes(1)},
            New ContaCorrente(277, 456477) With {.titular = Clientes(2)},
            New ContaCorrente(277, 123697) With {.titular = Clientes(3)},
            New ContaCorrente(277, 661377) With {.titular = Clientes(4)},
            New ContaCorrente(277, 999447) With {.titular = Clientes(5)}
        }

        Dim vDepositar As Double = 1000
        For Each conta As ContaCorrente In Contas
            conta.Depositar(vDepositar)
            vDepositar -= 100
        Next

        Dim Dt As New DataTable With {
            .TableName = "Contas Correntes"
        }
        Dt.Columns.Add(New DataColumn With {.ColumnName = "Agência", .DataType = Type.GetType("System.Int32"), .AllowDBNull = False})
        Dt.Columns.Add(New DataColumn With {.ColumnName = "Conta", .DataType = Type.GetType("System.Int32"), .AllowDBNull = False})
        Dt.Columns.Add(New DataColumn With {.ColumnName = "CPF", .DataType = Type.GetType("System.String")})
        Dt.Columns.Add(New DataColumn With {.ColumnName = "Saldo", .DataType = Type.GetType("System.Double")})
        Dt.PrimaryKey = New DataColumn(1) {Dt.Columns("Agência"), Dt.Columns("Conta")}

        Dim Dt2 As New DataTable With {
            .TableName = "Clientes"
        }
        Dt2.Columns.Add(New DataColumn With {.ColumnName = "CPF", .DataType = Type.GetType("System.String")})
        Dt2.Columns.Add(New DataColumn With {.ColumnName = "Nome", .DataType = Type.GetType("System.String")})
        Dt2.Columns.Add(New DataColumn With {.ColumnName = "Profissão", .DataType = Type.GetType("System.String")})
        Dt2.PrimaryKey = New DataColumn(0) {Dt2.Columns("CPF")}

        DS.Tables.Add(Dt)
        DS.Tables.Add(Dt2)
        DS.Tables("Contas Correntes").Constraints.Add(New ForeignKeyConstraint("FKClientesCC", DS.Tables("Clientes").Columns("CPF"), DS.Tables("Contas Correntes").Columns("CPF")) With {.DeleteRule = Rule.None})

        For i As Integer = 0 To Clientes.Count - 1
            Dim Dr As DataRow = DS.Tables("Clientes").NewRow
            Dr(0) = Clientes(i).cpf
            Dr(1) = Clientes(i).nome
            Dr(2) = Clientes(i).profissao
            DS.Tables("Clientes").Rows.Add(Dr)
        Next

        For i As Integer = 0 To Contas.Count - 1
            Dim Dr As DataRow = DS.Tables("Contas Correntes").NewRow
            Dr(0) = Contas(i).agencia
            Dr(1) = Contas(i).numero
            Dr(2) = Contas(i).titular.cpf
            Dr(3) = Contas(i).saldo
            DS.Tables("Contas Correntes").Rows.Add(Dr)
        Next
    End Sub

    Sub FormatarListView()
        Lvw_Contas.View = View.Details
        Lvw_Contas.LabelEdit = False
        Lvw_Contas.AllowColumnReorder = False
        Lvw_Contas.FullRowSelect = True
        Lvw_Contas.GridLines = True
    End Sub

    Sub CriarColunas()
        Lvw_Contas.Columns.Add("Conta Corrente", 100, HorizontalAlignment.Center)
        Lvw_Contas.Columns.Add("Correntista", 150, HorizontalAlignment.Center)
        Lvw_Contas.Columns.Add("Saldo R$", 100, HorizontalAlignment.Center)
    End Sub

    Sub CriarDataTableListView()
        DtListView.Columns.Add(New DataColumn With {.ColumnName = "Conta Corrente", .DataType = Type.GetType("System.String")})
        DtListView.Columns.Add(New DataColumn With {.ColumnName = "Correntista", .DataType = Type.GetType("System.String")})
        DtListView.Columns.Add(New DataColumn With {.ColumnName = "Saldo em R$", .DataType = Type.GetType("System.Double")})
    End Sub

    'Sub AtualizarListView()
    '    Lvw_Contas.Items.Clear()

    '    For i As Integer = 0 To DS.Tables("Contas Correntes").Rows.Count - 1
    '        Dim vContaNumero As String = DS.Tables("Contas Correntes").Rows(i)("Agência").ToString + "-" + DS.Tables("Contas Correntes").Rows(i)("Conta").ToString

    '        Dim Linha As New ListViewItem With {
    '            .Name = vContaNumero,
    '            .Text = vContaNumero
    '        }

    '        Linha.SubItems.Add(BuscaCliente(DS.Tables("Contas Correntes").Rows(i)("CPF").ToString))
    '        Linha.SubItems.Add(DS.Tables("Contas Correntes").Rows(i)("Saldo").ToString)

    '        Lvw_Contas.Items.Add(Linha)
    '    Next
    'End Sub

    Sub AtualizarListView1()
        DtListView.Rows.Clear()

        For i As Integer = 0 To DS.Tables("Contas Correntes").Rows.Count - 1
            Dim vContaNumero As String = DS.Tables("Contas Correntes").Rows(i)("Agência").ToString + "-" + DS.Tables("Contas Correntes").Rows(i)("Conta").ToString

            Dim Linha As DataRow = DtListView.NewRow
            Linha(0) = vContaNumero
            Linha(1) = BuscaCliente(DS.Tables("Contas Correntes").Rows(i)("CPF").ToString)
            Linha(2) = DS.Tables("Contas Correntes").Rows(i)("Saldo").ToString

            DtListView.Rows.Add(Linha)
        Next
        AtualizarListView2()
    End Sub

    Sub AtualizarListView2()
        Lvw_Contas.Items.Clear()

        For i As Integer = 0 To DtListView.Rows.Count - 1
            Dim Linha As New ListViewItem With {
                .Name = DtListView.Rows(i)(0).ToString,
                .Text = DtListView.Rows(i)(0).ToString
            }

            Linha.SubItems.Add(DtListView.Rows(i)(1).ToString)
            Linha.SubItems.Add(DtListView.Rows(i)(2))

            Lvw_Contas.Items.Add(Linha)
        Next
    End Sub

    Function BuscaCliente(cpf As String) As String
        Dim result As DataRow() = DS.Tables("Clientes").Select($"CPF = '{cpf}'")

        If result.Count > 0 Then
            Return result(0)("Nome")
        End If

        Return ""

    End Function

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        Dim F As New Frm_ContaCorrenteDataTable(DS.Tables("Clientes"))
        F.ShowDialog()

        If F.Retorno Then
            Dim Dr As DataRow = DS.Tables("Contas Correntes").NewRow
            Dr(0) = F.Agencia
            Dr(1) = F.Conta
            Dr(2) = F.CPF
            Dr(3) = 100
            DS.Tables("Contas Correntes").Rows.Add(Dr)
            AtualizarListView1()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        For i As Integer = 0 To Lvw_Contas.Items.Count - 1
            If Lvw_Contas.Items(i).Selected Then
                Dim vAgenciaConta As String = Lvw_Contas.Items(i).SubItems(0).Text

                Dim vPos As Integer = InStr(vAgenciaConta, "-")
                Dim vAgencia As Integer = Val(Mid(vAgenciaConta, 1, vPos))
                Dim vConta As Integer = Val(Mid(vAgenciaConta, vPos + 1))

                Dim DrLinhas As DataRow() = DS.Tables("Contas Correntes").Select($"Agência = {vAgencia} AND Conta = {vConta}")
                For Each row As DataRow In DrLinhas
                    DS.Tables("Contas Correntes").Rows.Remove(row)
                Next
            End If
        Next

        AtualizarListView1()
    End Sub

    Private Sub Rb_Conta_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Conta.CheckedChanged
        Dim DtView As DataView
        DtView = DtListView.DefaultView
        DtView.Sort = "Conta Corrente"
        DtListView = DtView.ToTable()
        AtualizarListView2()
    End Sub

    Private Sub Rb_Nome_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Nome.CheckedChanged
        Dim DtView As DataView
        DtView = DtListView.DefaultView
        DtView.Sort = "Correntista"
        DtListView = DtView.ToTable()
        AtualizarListView2()
    End Sub

    Private Sub Rb_Saldo_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Saldo.CheckedChanged
        Dim DtView As DataView
        DtView = DtListView.DefaultView
        DtView.Sort = "Saldo em R$"
        DtListView = DtView.ToTable()
        AtualizarListView2()
    End Sub
End Class