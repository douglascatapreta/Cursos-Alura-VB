Imports System.Data
Imports System.Data.Common

Public Class Frm_TesteProviders
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Dt As DataTable = DbProviderFactories.GetFactoryClasses()
        DataGridView1.DataSource = Dt

    End Sub
End Class