<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal))
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.Mnu_Principal = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalvarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopiarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecortarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArquivoTextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanilhaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SobreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Location = New System.Drawing.Point(12, 52)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(51, 17)
        Me.Lbl_Principal.TabIndex = 0
        Me.Lbl_Principal.Text = "Label1"
        '
        'Mnu_Principal
        '
        Me.Mnu_Principal.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Mnu_Principal.Location = New System.Drawing.Point(0, 28)
        Me.Mnu_Principal.Name = "Mnu_Principal"
        Me.Mnu_Principal.Size = New System.Drawing.Size(800, 24)
        Me.Mnu_Principal.TabIndex = 1
        Me.Mnu_Principal.Text = "MenuStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem, Me.EditarToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripMenuItem, Me.AbrirToolStripMenuItem, Me.SalvarToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(75, 24)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'NovoToolStripMenuItem
        '
        Me.NovoToolStripMenuItem.Name = "NovoToolStripMenuItem"
        Me.NovoToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NovoToolStripMenuItem.Text = "Novo"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoTextoToolStripMenuItem, Me.PlanilhaToolStripMenuItem})
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'SalvarToolStripMenuItem
        '
        Me.SalvarToolStripMenuItem.Name = "SalvarToolStripMenuItem"
        Me.SalvarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SalvarToolStripMenuItem.Text = "Salvar"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarToolStripMenuItem, Me.CopiarToolStripMenuItem, Me.RecortarToolStripMenuItem, Me.ColarToolStripMenuItem})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'BuscarToolStripMenuItem
        '
        Me.BuscarToolStripMenuItem.Name = "BuscarToolStripMenuItem"
        Me.BuscarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.BuscarToolStripMenuItem.Text = "Buscar"
        '
        'CopiarToolStripMenuItem
        '
        Me.CopiarToolStripMenuItem.Image = CType(resources.GetObject("CopiarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        Me.CopiarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopiarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.CopiarToolStripMenuItem.Text = "Copiar"
        '
        'RecortarToolStripMenuItem
        '
        Me.RecortarToolStripMenuItem.Name = "RecortarToolStripMenuItem"
        Me.RecortarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.RecortarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RecortarToolStripMenuItem.Text = "Recortar"
        '
        'ColarToolStripMenuItem
        '
        Me.ColarToolStripMenuItem.Name = "ColarToolStripMenuItem"
        Me.ColarToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ColarToolStripMenuItem.Text = "Colar"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnlineToolStripMenuItem, Me.SobreToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'OnlineToolStripMenuItem
        '
        Me.OnlineToolStripMenuItem.Name = "OnlineToolStripMenuItem"
        Me.OnlineToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.OnlineToolStripMenuItem.Text = "Online"
        '
        'ArquivoTextoToolStripMenuItem
        '
        Me.ArquivoTextoToolStripMenuItem.Name = "ArquivoTextoToolStripMenuItem"
        Me.ArquivoTextoToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ArquivoTextoToolStripMenuItem.Text = "Arquivo Texto"
        '
        'PlanilhaToolStripMenuItem
        '
        Me.PlanilhaToolStripMenuItem.Name = "PlanilhaToolStripMenuItem"
        Me.PlanilhaToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.PlanilhaToolStripMenuItem.Text = "Planilha"
        '
        'SobreToolStripMenuItem
        '
        Me.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem"
        Me.SobreToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.SobreToolStripMenuItem.Text = "Sobre"
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Controls.Add(Me.Mnu_Principal)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.Mnu_Principal
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Mnu_Principal As MenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NovoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AbrirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArquivoTextoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlanilhaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalvarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RecortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnlineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SobreToolStripMenuItem As ToolStripMenuItem
End Class
