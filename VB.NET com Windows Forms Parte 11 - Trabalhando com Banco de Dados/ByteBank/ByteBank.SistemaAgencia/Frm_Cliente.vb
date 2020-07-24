Public Class Frm_Cliente
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Cadastro de Clientes"

    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ByteBankDBDataSet)

    End Sub

    Private Sub Frm_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'ByteBankDBDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
        Me.ClienteTableAdapter.Fill(Me.ByteBankDBDataSet.Cliente)

    End Sub
End Class