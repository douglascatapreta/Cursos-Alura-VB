Public Class frm_Cliente_SQLServer
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

        Me.Text = "Cadastro de Cliente pelo SQL Server"

    End Sub

    Private Sub ClienteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ClienteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClienteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BYTEBANKDataSet)

    End Sub

    Private Sub frm_Cliente_SQLServer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'BYTEBANKDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
        Me.ClienteTableAdapter.Fill(Me.BYTEBANKDataSet.Cliente)

    End Sub
End Class