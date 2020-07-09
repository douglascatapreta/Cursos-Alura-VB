Public Class Frm_Principal
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Text = "Sistema de Agências ByteBank"

    End Sub

    Private Sub Video01ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Video01ToolStripMenuItem.Click

        Dim F As New Frm_Secundario
        F.MdiParent = Me
        F.Show()

    End Sub

    Private Sub JanelasHorizontaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JanelasHorizontaisToolStripMenuItem.Click

        Me.LayoutMdi(MdiLayout.TileHorizontal)

    End Sub

    Private Sub JanelasVerticaisToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JanelasVerticaisToolStripMenuItem.Click

        Me.LayoutMdi(MdiLayout.TileVertical)

    End Sub

    Private Sub JanelasCascataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JanelasCascataToolStripMenuItem.Click

        Me.LayoutMdi(MdiLayout.Cascade)

    End Sub

    Private Sub Video02ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Video02ToolStripMenuItem.Click

        Dim F As New Frm_Login
        F.MdiParent = Me
        F.Show()

    End Sub

    Private Sub Video03ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Video03ToolStripMenuItem.Click

        Dim F As New Frm_CartaoCredito
        F.MdiParent = Me
        F.Show()

    End Sub
End Class
