Public Class Frm_ContaCorrenteDataTable
#Region "PROPRIEDADES"

    Public Property Agencia As Integer
    Public Property Conta As Integer
    Public Property CPF As String
    Public Property Retorno As Boolean

#End Region

#Region "CONSTRUTORES"

    Public Sub New(DtClientes As DataTable)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Conta Corrente"
        Lbl_ContaCorrente.Text = "Nova Conta Corrente"
        Txt_CPF.ReadOnly = True
        Retorno = False
        Cmb_CPF.Items.Clear()
        For i As Integer = 0 To DtClientes.Rows.Count - 1
            Cmb_CPF.Items.Add(DtClientes.Rows(i)("CPF"))
        Next

    End Sub

#End Region

#Region "MÉTODOS"

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click

        Retorno = True
        Agencia = Txt_Agencia.Text
        Conta = Txt_Conta.Text
        CPF = Txt_CPF.Text
        Me.Close()

    End Sub

    Private Sub Cmb_CPF_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_CPF.SelectedIndexChanged

        Txt_CPF.Text = Cmb_CPF.Text

    End Sub

#End Region
End Class