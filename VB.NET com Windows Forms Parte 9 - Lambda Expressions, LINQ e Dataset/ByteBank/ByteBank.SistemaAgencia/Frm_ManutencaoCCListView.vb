Imports ByteBank.Bibliotecas.Classes.Clientes

Public Class Frm_ManutencaoCCListView

    Dim ListaContas As New List(Of ContaCorrente)

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
        AtualizarListView()

    End Sub

    Sub InicializarContas()
        ' Previamente configurar algumas contas
        ListaContas.Add(New ContaCorrente(277, 144323, "João da Silva"))
        ListaContas.Add(New ContaCorrente(277, 155532, "Pedro Alcântara"))
        ListaContas.Add(New ContaCorrente(277, 233224, "Julia Matos"))
        ListaContas.Add(New ContaCorrente(277, 983323, "Cláudia Organa"))
        ListaContas.Add(New ContaCorrente(277, 788233, "José Firmino"))
        ListaContas.Add(New ContaCorrente(277, 322352, "Julio de Castilho"))
    End Sub

    Sub FormatarListView()
        ' Formatar o ListView
        Lvw_Contas.View = View.Details
        Lvw_Contas.LabelEdit = False
        Lvw_Contas.AllowColumnReorder = False
        Lvw_Contas.FullRowSelect = True
        Lvw_Contas.GridLines = True
    End Sub

    Sub CriarColunas()
        ' Configurar colunas
        Lvw_Contas.Columns.Add("Conta Corrente", 100, HorizontalAlignment.Center)
        Lvw_Contas.Columns.Add("Correntista", 150, HorizontalAlignment.Center)
        Lvw_Contas.Columns.Add("Saldo R$", 100, HorizontalAlignment.Center)
    End Sub

    Sub AtualizarListView()
        ' Inclusão elementos
        Lvw_Contas.Items.Clear()
        For i As Integer = 0 To ListaContas.Count - 1
            Dim vContaNumero As String = $"{ListaContas(i).agencia}-{ListaContas(i).numero}"
            Dim Linha As New ListViewItem()
            Linha.Name = vContaNumero
            Linha.Text = vContaNumero
            Linha.SubItems.Add(ListaContas(i).titular.nome)
            Linha.SubItems.Add(ListaContas(i).saldo.ToString)
            Lvw_Contas.Items.Add(Linha)
        Next
    End Sub

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        Dim F As New Frm_ContaCorrente()
        F.ShowDialog()

        If F.Retorno Then
            ListaContas.Add(F.Conta)
            AtualizarListView()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim ListaContasExcluir As New List(Of ContaCorrente)

        For i As Integer = 0 To Lvw_Contas.Items.Count - 1
            If Lvw_Contas.Items(i).Selected Then
                ListaContasExcluir.Add(ListaContas(i))
            End If
        Next

        If ListaContasExcluir.Count > 0 Then
            For i As Integer = 0 To ListaContasExcluir.Count - 1
                ListaContas.Remove(ListaContasExcluir(i))
            Next
        End If

        AtualizarListView()
    End Sub

    Private Sub Rb_Conta_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Conta.CheckedChanged
        Dim ListaAuxiliar As IEnumerable(Of ContaCorrente) = ListaContas _
            .OrderBy(Function(conta As ContaCorrente) conta.agencia) _
            .OrderBy(Function(conta As ContaCorrente) conta.numero)

        ListaContas = New List(Of ContaCorrente)(ListaAuxiliar)
        AtualizarListView()
    End Sub

    Private Sub Rb_Nome_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Nome.CheckedChanged
        Dim ListaAuxiliar As IEnumerable(Of ContaCorrente) = ListaContas _
            .OrderBy(Function(conta As ContaCorrente) conta.titular.nome)

        ListaContas = New List(Of ContaCorrente)(ListaAuxiliar)
        AtualizarListView()
    End Sub

    Private Sub Rb_Saldo_CheckedChanged(sender As Object, e As EventArgs) Handles Rb_Saldo.CheckedChanged
        Dim ListaAuxiliar As IEnumerable(Of ContaCorrente) = ListaContas _
            .OrderBy(Function(conta As ContaCorrente) conta.saldo)

        ListaContas = New List(Of ContaCorrente)(ListaAuxiliar)
        AtualizarListView()
    End Sub
End Class