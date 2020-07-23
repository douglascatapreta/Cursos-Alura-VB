<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ContaCorrente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ContaCorrente))
        Me.Lbl_ContaCorrente = New System.Windows.Forms.Label()
        Me.Txt_Agencia = New System.Windows.Forms.TextBox()
        Me.Txt_Conta = New System.Windows.Forms.TextBox()
        Me.Txt_Nome = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SaveToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_ContaCorrente
        '
        Me.Lbl_ContaCorrente.AutoSize = True
        Me.Lbl_ContaCorrente.Location = New System.Drawing.Point(12, 44)
        Me.Lbl_ContaCorrente.Name = "Lbl_ContaCorrente"
        Me.Lbl_ContaCorrente.Size = New System.Drawing.Size(51, 17)
        Me.Lbl_ContaCorrente.TabIndex = 0
        Me.Lbl_ContaCorrente.Text = "Label1"
        '
        'Txt_Agencia
        '
        Me.Txt_Agencia.Location = New System.Drawing.Point(15, 64)
        Me.Txt_Agencia.Name = "Txt_Agencia"
        Me.Txt_Agencia.Size = New System.Drawing.Size(262, 22)
        Me.Txt_Agencia.TabIndex = 1
        '
        'Txt_Conta
        '
        Me.Txt_Conta.Location = New System.Drawing.Point(15, 92)
        Me.Txt_Conta.Name = "Txt_Conta"
        Me.Txt_Conta.Size = New System.Drawing.Size(262, 22)
        Me.Txt_Conta.TabIndex = 2
        '
        'Txt_Nome
        '
        Me.Txt_Nome.Location = New System.Drawing.Point(15, 120)
        Me.Txt_Nome.Name = "Txt_Nome"
        Me.Txt_Nome.Size = New System.Drawing.Size(262, 22)
        Me.Txt_Nome.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(294, 27)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SaveToolStripButton
        '
        Me.SaveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SaveToolStripButton.Image = CType(resources.GetObject("SaveToolStripButton.Image"), System.Drawing.Image)
        Me.SaveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SaveToolStripButton.Name = "SaveToolStripButton"
        Me.SaveToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.SaveToolStripButton.Text = "&Save"
        '
        'Frm_ContaCorrente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 173)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Txt_Nome)
        Me.Controls.Add(Me.Txt_Conta)
        Me.Controls.Add(Me.Txt_Agencia)
        Me.Controls.Add(Me.Lbl_ContaCorrente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_ContaCorrente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_ContaCorrente"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_ContaCorrente As Label
    Friend WithEvents Txt_Agencia As TextBox
    Friend WithEvents Txt_Conta As TextBox
    Friend WithEvents Txt_Nome As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SaveToolStripButton As ToolStripButton
End Class
