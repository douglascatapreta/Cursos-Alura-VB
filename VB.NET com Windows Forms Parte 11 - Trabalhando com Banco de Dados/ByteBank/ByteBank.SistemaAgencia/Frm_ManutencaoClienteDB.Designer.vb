<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ManutencaoClienteDB
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ManutencaoClienteDB))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NovoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Grp_Lista = New System.Windows.Forms.GroupBox()
        Me.Lvw_Clientes = New System.Windows.Forms.ListView()
        Me.Txt_CPF = New System.Windows.Forms.TextBox()
        Me.Txt_Nome = New System.Windows.Forms.TextBox()
        Me.txt_Profissao = New System.Windows.Forms.TextBox()
        Me.Lbl_CPF = New System.Windows.Forms.Label()
        Me.Lbl_Nome = New System.Windows.Forms.Label()
        Me.Lbl_Profissao = New System.Windows.Forms.Label()
        Me.Lbl_Database = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.Grp_Lista.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripButton, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(421, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NovoToolStripButton
        '
        Me.NovoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NovoToolStripButton.Image = CType(resources.GetObject("NovoToolStripButton.Image"), System.Drawing.Image)
        Me.NovoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoToolStripButton.Name = "NovoToolStripButton"
        Me.NovoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NovoToolStripButton.Text = "&Novo"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Apagar"
        '
        'Grp_Lista
        '
        Me.Grp_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grp_Lista.Controls.Add(Me.Lvw_Clientes)
        Me.Grp_Lista.Location = New System.Drawing.Point(12, 139)
        Me.Grp_Lista.Name = "Grp_Lista"
        Me.Grp_Lista.Size = New System.Drawing.Size(396, 192)
        Me.Grp_Lista.TabIndex = 3
        Me.Grp_Lista.TabStop = False
        Me.Grp_Lista.Text = "GroupBox1"
        '
        'Lvw_Clientes
        '
        Me.Lvw_Clientes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lvw_Clientes.Location = New System.Drawing.Point(3, 16)
        Me.Lvw_Clientes.Name = "Lvw_Clientes"
        Me.Lvw_Clientes.Size = New System.Drawing.Size(390, 173)
        Me.Lvw_Clientes.TabIndex = 0
        Me.Lvw_Clientes.UseCompatibleStateImageBehavior = False
        '
        'Txt_CPF
        '
        Me.Txt_CPF.Location = New System.Drawing.Point(87, 56)
        Me.Txt_CPF.Name = "Txt_CPF"
        Me.Txt_CPF.Size = New System.Drawing.Size(177, 20)
        Me.Txt_CPF.TabIndex = 4
        '
        'Txt_Nome
        '
        Me.Txt_Nome.Location = New System.Drawing.Point(87, 82)
        Me.Txt_Nome.Name = "Txt_Nome"
        Me.Txt_Nome.Size = New System.Drawing.Size(177, 20)
        Me.Txt_Nome.TabIndex = 5
        '
        'txt_Profissao
        '
        Me.txt_Profissao.Location = New System.Drawing.Point(87, 108)
        Me.txt_Profissao.Name = "txt_Profissao"
        Me.txt_Profissao.Size = New System.Drawing.Size(177, 20)
        Me.txt_Profissao.TabIndex = 6
        '
        'Lbl_CPF
        '
        Me.Lbl_CPF.AutoSize = True
        Me.Lbl_CPF.Location = New System.Drawing.Point(17, 59)
        Me.Lbl_CPF.Name = "Lbl_CPF"
        Me.Lbl_CPF.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_CPF.TabIndex = 7
        Me.Lbl_CPF.Text = "Label1"
        '
        'Lbl_Nome
        '
        Me.Lbl_Nome.AutoSize = True
        Me.Lbl_Nome.Location = New System.Drawing.Point(17, 85)
        Me.Lbl_Nome.Name = "Lbl_Nome"
        Me.Lbl_Nome.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Nome.TabIndex = 8
        Me.Lbl_Nome.Text = "Label2"
        '
        'Lbl_Profissao
        '
        Me.Lbl_Profissao.AutoSize = True
        Me.Lbl_Profissao.Location = New System.Drawing.Point(17, 111)
        Me.Lbl_Profissao.Name = "Lbl_Profissao"
        Me.Lbl_Profissao.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Profissao.TabIndex = 9
        Me.Lbl_Profissao.Text = "Label3"
        '
        'Lbl_Database
        '
        Me.Lbl_Database.AutoSize = True
        Me.Lbl_Database.Location = New System.Drawing.Point(17, 35)
        Me.Lbl_Database.Name = "Lbl_Database"
        Me.Lbl_Database.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Database.TabIndex = 10
        Me.Lbl_Database.Text = "Label1"
        '
        'Frm_ManutencaoClienteDB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 341)
        Me.Controls.Add(Me.Lbl_Database)
        Me.Controls.Add(Me.Lbl_Profissao)
        Me.Controls.Add(Me.Lbl_Nome)
        Me.Controls.Add(Me.Lbl_CPF)
        Me.Controls.Add(Me.txt_Profissao)
        Me.Controls.Add(Me.Txt_Nome)
        Me.Controls.Add(Me.Txt_CPF)
        Me.Controls.Add(Me.Grp_Lista)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ManutencaoClienteDB"
        Me.Text = "Frm_ManutencaoClienteDB"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Grp_Lista.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NovoToolStripButton As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Grp_Lista As GroupBox
    Friend WithEvents Lvw_Clientes As ListView
    Friend WithEvents Txt_CPF As TextBox
    Friend WithEvents Txt_Nome As TextBox
    Friend WithEvents txt_Profissao As TextBox
    Friend WithEvents Lbl_CPF As Label
    Friend WithEvents Lbl_Nome As Label
    Friend WithEvents Lbl_Profissao As Label
    Friend WithEvents Lbl_Database As Label
End Class
