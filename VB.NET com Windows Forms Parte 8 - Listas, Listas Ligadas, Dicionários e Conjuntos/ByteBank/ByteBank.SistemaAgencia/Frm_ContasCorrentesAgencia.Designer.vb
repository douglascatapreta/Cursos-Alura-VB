<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ContasCorrentesAgencia
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
        Me.Txt_Array = New System.Windows.Forms.TextBox()
        Me.Btm_Remover = New System.Windows.Forms.Button()
        Me.Btm_Adicionar = New System.Windows.Forms.Button()
        Me.Txt_Conta = New System.Windows.Forms.TextBox()
        Me.Lbl_Agencia = New System.Windows.Forms.Label()
        Me.Txt_Nome = New System.Windows.Forms.TextBox()
        Me.Grp_Conta = New System.Windows.Forms.GroupBox()
        Me.Grp_Busca = New System.Windows.Forms.GroupBox()
        Me.Txt_ResultadoBusca = New System.Windows.Forms.TextBox()
        Me.Btm_CCBusca = New System.Windows.Forms.Button()
        Me.Txt_CCBusca = New System.Windows.Forms.TextBox()
        Me.Grp_AlterarCC = New System.Windows.Forms.GroupBox()
        Me.Txt_CCAlterar = New System.Windows.Forms.TextBox()
        Me.Txt_NomeAlterar = New System.Windows.Forms.TextBox()
        Me.Btm_AlterarCC = New System.Windows.Forms.Button()
        Me.Grp_Conta.SuspendLayout()
        Me.Grp_Busca.SuspendLayout()
        Me.Grp_AlterarCC.SuspendLayout()
        Me.SuspendLayout()
        '
        'Txt_Array
        '
        Me.Txt_Array.Location = New System.Drawing.Point(194, 9)
        Me.Txt_Array.Multiline = True
        Me.Txt_Array.Name = "Txt_Array"
        Me.Txt_Array.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Array.Size = New System.Drawing.Size(364, 421)
        Me.Txt_Array.TabIndex = 25
        '
        'Btm_Remover
        '
        Me.Btm_Remover.Location = New System.Drawing.Point(6, 71)
        Me.Btm_Remover.Name = "Btm_Remover"
        Me.Btm_Remover.Size = New System.Drawing.Size(75, 23)
        Me.Btm_Remover.TabIndex = 6
        Me.Btm_Remover.Text = "Button1"
        Me.Btm_Remover.UseVisualStyleBackColor = True
        '
        'Btm_Adicionar
        '
        Me.Btm_Adicionar.Location = New System.Drawing.Point(87, 71)
        Me.Btm_Adicionar.Name = "Btm_Adicionar"
        Me.Btm_Adicionar.Size = New System.Drawing.Size(75, 23)
        Me.Btm_Adicionar.TabIndex = 5
        Me.Btm_Adicionar.Text = "Button1"
        Me.Btm_Adicionar.UseVisualStyleBackColor = True
        '
        'Txt_Conta
        '
        Me.Txt_Conta.Location = New System.Drawing.Point(6, 19)
        Me.Txt_Conta.Name = "Txt_Conta"
        Me.Txt_Conta.Size = New System.Drawing.Size(156, 20)
        Me.Txt_Conta.TabIndex = 3
        '
        'Lbl_Agencia
        '
        Me.Lbl_Agencia.AutoSize = True
        Me.Lbl_Agencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Agencia.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Agencia.Name = "Lbl_Agencia"
        Me.Lbl_Agencia.Size = New System.Drawing.Size(72, 24)
        Me.Lbl_Agencia.TabIndex = 1
        Me.Lbl_Agencia.Text = "Label1"
        '
        'Txt_Nome
        '
        Me.Txt_Nome.Location = New System.Drawing.Point(6, 45)
        Me.Txt_Nome.Name = "Txt_Nome"
        Me.Txt_Nome.Size = New System.Drawing.Size(156, 20)
        Me.Txt_Nome.TabIndex = 4
        '
        'Grp_Conta
        '
        Me.Grp_Conta.Controls.Add(Me.Txt_Conta)
        Me.Grp_Conta.Controls.Add(Me.Txt_Nome)
        Me.Grp_Conta.Controls.Add(Me.Btm_Adicionar)
        Me.Grp_Conta.Controls.Add(Me.Btm_Remover)
        Me.Grp_Conta.Location = New System.Drawing.Point(16, 36)
        Me.Grp_Conta.Name = "Grp_Conta"
        Me.Grp_Conta.Size = New System.Drawing.Size(172, 102)
        Me.Grp_Conta.TabIndex = 26
        Me.Grp_Conta.TabStop = False
        Me.Grp_Conta.Text = "GroupBox1"
        '
        'Grp_Busca
        '
        Me.Grp_Busca.Controls.Add(Me.Txt_ResultadoBusca)
        Me.Grp_Busca.Controls.Add(Me.Btm_CCBusca)
        Me.Grp_Busca.Controls.Add(Me.Txt_CCBusca)
        Me.Grp_Busca.Location = New System.Drawing.Point(16, 161)
        Me.Grp_Busca.Name = "Grp_Busca"
        Me.Grp_Busca.Size = New System.Drawing.Size(172, 142)
        Me.Grp_Busca.TabIndex = 27
        Me.Grp_Busca.TabStop = False
        Me.Grp_Busca.Text = "GroupBox1"
        '
        'Txt_ResultadoBusca
        '
        Me.Txt_ResultadoBusca.Location = New System.Drawing.Point(6, 74)
        Me.Txt_ResultadoBusca.Multiline = True
        Me.Txt_ResultadoBusca.Name = "Txt_ResultadoBusca"
        Me.Txt_ResultadoBusca.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_ResultadoBusca.Size = New System.Drawing.Size(156, 59)
        Me.Txt_ResultadoBusca.TabIndex = 28
        '
        'Btm_CCBusca
        '
        Me.Btm_CCBusca.Location = New System.Drawing.Point(49, 45)
        Me.Btm_CCBusca.Name = "Btm_CCBusca"
        Me.Btm_CCBusca.Size = New System.Drawing.Size(75, 23)
        Me.Btm_CCBusca.TabIndex = 28
        Me.Btm_CCBusca.Text = "Button1"
        Me.Btm_CCBusca.UseVisualStyleBackColor = True
        '
        'Txt_CCBusca
        '
        Me.Txt_CCBusca.Location = New System.Drawing.Point(6, 19)
        Me.Txt_CCBusca.Name = "Txt_CCBusca"
        Me.Txt_CCBusca.Size = New System.Drawing.Size(156, 20)
        Me.Txt_CCBusca.TabIndex = 28
        '
        'Grp_AlterarCC
        '
        Me.Grp_AlterarCC.Controls.Add(Me.Txt_CCAlterar)
        Me.Grp_AlterarCC.Controls.Add(Me.Txt_NomeAlterar)
        Me.Grp_AlterarCC.Controls.Add(Me.Btm_AlterarCC)
        Me.Grp_AlterarCC.Location = New System.Drawing.Point(16, 328)
        Me.Grp_AlterarCC.Name = "Grp_AlterarCC"
        Me.Grp_AlterarCC.Size = New System.Drawing.Size(172, 102)
        Me.Grp_AlterarCC.TabIndex = 27
        Me.Grp_AlterarCC.TabStop = False
        Me.Grp_AlterarCC.Text = "GroupBox1"
        '
        'Txt_CCAlterar
        '
        Me.Txt_CCAlterar.Location = New System.Drawing.Point(6, 19)
        Me.Txt_CCAlterar.Name = "Txt_CCAlterar"
        Me.Txt_CCAlterar.Size = New System.Drawing.Size(156, 20)
        Me.Txt_CCAlterar.TabIndex = 3
        '
        'Txt_NomeAlterar
        '
        Me.Txt_NomeAlterar.Location = New System.Drawing.Point(6, 45)
        Me.Txt_NomeAlterar.Name = "Txt_NomeAlterar"
        Me.Txt_NomeAlterar.Size = New System.Drawing.Size(156, 20)
        Me.Txt_NomeAlterar.TabIndex = 4
        '
        'Btm_AlterarCC
        '
        Me.Btm_AlterarCC.Location = New System.Drawing.Point(87, 71)
        Me.Btm_AlterarCC.Name = "Btm_AlterarCC"
        Me.Btm_AlterarCC.Size = New System.Drawing.Size(75, 23)
        Me.Btm_AlterarCC.TabIndex = 5
        Me.Btm_AlterarCC.Text = "Button1"
        Me.Btm_AlterarCC.UseVisualStyleBackColor = True
        '
        'Frm_ContasCorrentesAgencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 441)
        Me.Controls.Add(Me.Grp_AlterarCC)
        Me.Controls.Add(Me.Grp_Busca)
        Me.Controls.Add(Me.Grp_Conta)
        Me.Controls.Add(Me.Txt_Array)
        Me.Controls.Add(Me.Lbl_Agencia)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_ContasCorrentesAgencia"
        Me.Text = "Frm_ContasCorrentesListas"
        Me.Grp_Conta.ResumeLayout(False)
        Me.Grp_Conta.PerformLayout()
        Me.Grp_Busca.ResumeLayout(False)
        Me.Grp_Busca.PerformLayout()
        Me.Grp_AlterarCC.ResumeLayout(False)
        Me.Grp_AlterarCC.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_Array As TextBox
    Friend WithEvents Btm_Remover As Button
    Friend WithEvents Btm_Adicionar As Button
    Friend WithEvents Txt_Conta As TextBox
    Friend WithEvents Txt_Agencia As TextBox
    Friend WithEvents Lbl_Agencia As Label
    Friend WithEvents Txt_Nome As TextBox
    Friend WithEvents Grp_Estatisticas As GroupBox
    Friend WithEvents Btm_Primeiro As Button
    Friend WithEvents Btm_Ultimo As Button
    Friend WithEvents Txt_Ultima As TextBox
    Friend WithEvents Txt_Primeira As TextBox
    Friend WithEvents Btm_Busca As Button
    Friend WithEvents Txt_NomeBusca As TextBox
    Friend WithEvents Txt_ContaBusca As TextBox
    Friend WithEvents Txt_AgenciaBusca As TextBox
    Friend WithEvents Btm_Ordena As Button
    Friend WithEvents Grp_Conta As GroupBox
    Friend WithEvents Grp_Busca As GroupBox
    Friend WithEvents Txt_ResultadoBusca As TextBox
    Friend WithEvents Btm_CCBusca As Button
    Friend WithEvents Txt_CCBusca As TextBox
    Friend WithEvents Grp_AlterarCC As GroupBox
    Friend WithEvents Txt_CCAlterar As TextBox
    Friend WithEvents Txt_NomeAlterar As TextBox
    Friend WithEvents Btm_AlterarCC As Button
End Class