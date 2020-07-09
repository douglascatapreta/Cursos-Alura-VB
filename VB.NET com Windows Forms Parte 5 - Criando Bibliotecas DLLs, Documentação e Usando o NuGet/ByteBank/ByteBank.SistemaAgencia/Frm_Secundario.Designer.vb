<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Secundario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Secundario))
        Me.Pic_Logo = New System.Windows.Forms.PictureBox()
        Me.Grp_ContaCorrente = New System.Windows.Forms.GroupBox()
        Me.Btm_Criar = New System.Windows.Forms.Button()
        Me.Txt_Conta = New System.Windows.Forms.TextBox()
        Me.Txt_Agencia = New System.Windows.Forms.TextBox()
        Me.Lbl_Conta = New System.Windows.Forms.Label()
        Me.Lbl_Agencia = New System.Windows.Forms.Label()
        Me.Lbl_ContaCorrenteCriada = New System.Windows.Forms.Label()
        CType(Me.Pic_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grp_ContaCorrente.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pic_Logo
        '
        Me.Pic_Logo.Image = CType(resources.GetObject("Pic_Logo.Image"), System.Drawing.Image)
        Me.Pic_Logo.Location = New System.Drawing.Point(9, 10)
        Me.Pic_Logo.Margin = New System.Windows.Forms.Padding(2)
        Me.Pic_Logo.Name = "Pic_Logo"
        Me.Pic_Logo.Size = New System.Drawing.Size(67, 67)
        Me.Pic_Logo.TabIndex = 0
        Me.Pic_Logo.TabStop = False
        '
        'Grp_ContaCorrente
        '
        Me.Grp_ContaCorrente.Controls.Add(Me.Btm_Criar)
        Me.Grp_ContaCorrente.Controls.Add(Me.Txt_Conta)
        Me.Grp_ContaCorrente.Controls.Add(Me.Txt_Agencia)
        Me.Grp_ContaCorrente.Controls.Add(Me.Lbl_Conta)
        Me.Grp_ContaCorrente.Controls.Add(Me.Lbl_Agencia)
        Me.Grp_ContaCorrente.Location = New System.Drawing.Point(90, 12)
        Me.Grp_ContaCorrente.Name = "Grp_ContaCorrente"
        Me.Grp_ContaCorrente.Size = New System.Drawing.Size(257, 126)
        Me.Grp_ContaCorrente.TabIndex = 1
        Me.Grp_ContaCorrente.TabStop = False
        Me.Grp_ContaCorrente.Text = "GroupBox1"
        '
        'Btm_Criar
        '
        Me.Btm_Criar.Location = New System.Drawing.Point(176, 97)
        Me.Btm_Criar.Name = "Btm_Criar"
        Me.Btm_Criar.Size = New System.Drawing.Size(75, 23)
        Me.Btm_Criar.TabIndex = 2
        Me.Btm_Criar.Text = "Button1"
        Me.Btm_Criar.UseVisualStyleBackColor = True
        '
        'Txt_Conta
        '
        Me.Txt_Conta.Location = New System.Drawing.Point(9, 87)
        Me.Txt_Conta.Name = "Txt_Conta"
        Me.Txt_Conta.Size = New System.Drawing.Size(161, 20)
        Me.Txt_Conta.TabIndex = 3
        '
        'Txt_Agencia
        '
        Me.Txt_Agencia.Location = New System.Drawing.Point(9, 45)
        Me.Txt_Agencia.Name = "Txt_Agencia"
        Me.Txt_Agencia.Size = New System.Drawing.Size(161, 20)
        Me.Txt_Agencia.TabIndex = 2
        '
        'Lbl_Conta
        '
        Me.Lbl_Conta.AutoSize = True
        Me.Lbl_Conta.Location = New System.Drawing.Point(6, 71)
        Me.Lbl_Conta.Name = "Lbl_Conta"
        Me.Lbl_Conta.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Conta.TabIndex = 1
        Me.Lbl_Conta.Text = "Label2"
        '
        'Lbl_Agencia
        '
        Me.Lbl_Agencia.AutoSize = True
        Me.Lbl_Agencia.Location = New System.Drawing.Point(6, 29)
        Me.Lbl_Agencia.Name = "Lbl_Agencia"
        Me.Lbl_Agencia.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Agencia.TabIndex = 0
        Me.Lbl_Agencia.Text = "Label1"
        '
        'Lbl_ContaCorrenteCriada
        '
        Me.Lbl_ContaCorrenteCriada.AutoSize = True
        Me.Lbl_ContaCorrenteCriada.Location = New System.Drawing.Point(87, 141)
        Me.Lbl_ContaCorrenteCriada.Name = "Lbl_ContaCorrenteCriada"
        Me.Lbl_ContaCorrenteCriada.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_ContaCorrenteCriada.TabIndex = 2
        Me.Lbl_ContaCorrenteCriada.Text = "Label1"
        '
        'Frm_Secundario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(374, 168)
        Me.Controls.Add(Me.Lbl_ContaCorrenteCriada)
        Me.Controls.Add(Me.Grp_ContaCorrente)
        Me.Controls.Add(Me.Pic_Logo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Frm_Secundario"
        Me.Text = "Frm_Secundario"
        CType(Me.Pic_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grp_ContaCorrente.ResumeLayout(False)
        Me.Grp_ContaCorrente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Pic_Logo As PictureBox
    Friend WithEvents Grp_ContaCorrente As GroupBox
    Friend WithEvents Lbl_Conta As Label
    Friend WithEvents Lbl_Agencia As Label
    Friend WithEvents Txt_Conta As TextBox
    Friend WithEvents Txt_Agencia As TextBox
    Friend WithEvents Btm_Criar As Button
    Friend WithEvents Lbl_ContaCorrenteCriada As Label
End Class
