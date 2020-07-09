<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.Pic_Logo = New System.Windows.Forms.PictureBox()
        Me.Grp_Login = New System.Windows.Forms.GroupBox()
        Me.Rb_Representante = New System.Windows.Forms.RadioButton()
        Me.Rb_Gerente = New System.Windows.Forms.RadioButton()
        Me.Txt_Senha = New System.Windows.Forms.TextBox()
        Me.Txt_Login = New System.Windows.Forms.TextBox()
        Me.Lbl_Senha = New System.Windows.Forms.Label()
        Me.Lbl_Login = New System.Windows.Forms.Label()
        Me.Btm_Logar = New System.Windows.Forms.Button()
        CType(Me.Pic_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grp_Login.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pic_Logo
        '
        Me.Pic_Logo.Image = CType(resources.GetObject("Pic_Logo.Image"), System.Drawing.Image)
        Me.Pic_Logo.Location = New System.Drawing.Point(9, 10)
        Me.Pic_Logo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Pic_Logo.Name = "Pic_Logo"
        Me.Pic_Logo.Size = New System.Drawing.Size(68, 68)
        Me.Pic_Logo.TabIndex = 0
        Me.Pic_Logo.TabStop = False
        '
        'Grp_Login
        '
        Me.Grp_Login.Controls.Add(Me.Btm_Logar)
        Me.Grp_Login.Controls.Add(Me.Rb_Representante)
        Me.Grp_Login.Controls.Add(Me.Rb_Gerente)
        Me.Grp_Login.Controls.Add(Me.Txt_Senha)
        Me.Grp_Login.Controls.Add(Me.Txt_Login)
        Me.Grp_Login.Controls.Add(Me.Lbl_Senha)
        Me.Grp_Login.Controls.Add(Me.Lbl_Login)
        Me.Grp_Login.Location = New System.Drawing.Point(81, 11)
        Me.Grp_Login.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Grp_Login.Name = "Grp_Login"
        Me.Grp_Login.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Grp_Login.Size = New System.Drawing.Size(249, 207)
        Me.Grp_Login.TabIndex = 1
        Me.Grp_Login.TabStop = False
        Me.Grp_Login.Text = "GroupBox1"
        '
        'Rb_Representante
        '
        Me.Rb_Representante.AutoSize = True
        Me.Rb_Representante.Location = New System.Drawing.Point(143, 133)
        Me.Rb_Representante.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Rb_Representante.Name = "Rb_Representante"
        Me.Rb_Representante.Size = New System.Drawing.Size(90, 17)
        Me.Rb_Representante.TabIndex = 5
        Me.Rb_Representante.TabStop = True
        Me.Rb_Representante.Text = "RadioButton1"
        Me.Rb_Representante.UseVisualStyleBackColor = True
        '
        'Rb_Gerente
        '
        Me.Rb_Gerente.AutoSize = True
        Me.Rb_Gerente.Location = New System.Drawing.Point(16, 133)
        Me.Rb_Gerente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Rb_Gerente.Name = "Rb_Gerente"
        Me.Rb_Gerente.Size = New System.Drawing.Size(90, 17)
        Me.Rb_Gerente.TabIndex = 4
        Me.Rb_Gerente.TabStop = True
        Me.Rb_Gerente.Text = "RadioButton1"
        Me.Rb_Gerente.UseVisualStyleBackColor = True
        '
        'Txt_Senha
        '
        Me.Txt_Senha.Location = New System.Drawing.Point(16, 94)
        Me.Txt_Senha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_Senha.Name = "Txt_Senha"
        Me.Txt_Senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Senha.Size = New System.Drawing.Size(217, 20)
        Me.Txt_Senha.TabIndex = 3
        '
        'Txt_Login
        '
        Me.Txt_Login.Location = New System.Drawing.Point(16, 43)
        Me.Txt_Login.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txt_Login.Name = "Txt_Login"
        Me.Txt_Login.Size = New System.Drawing.Size(217, 20)
        Me.Txt_Login.TabIndex = 2
        '
        'Lbl_Senha
        '
        Me.Lbl_Senha.AutoSize = True
        Me.Lbl_Senha.Location = New System.Drawing.Point(14, 78)
        Me.Lbl_Senha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Senha.Name = "Lbl_Senha"
        Me.Lbl_Senha.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Senha.TabIndex = 1
        Me.Lbl_Senha.Text = "Label2"
        '
        'Lbl_Login
        '
        Me.Lbl_Login.AutoSize = True
        Me.Lbl_Login.Location = New System.Drawing.Point(14, 27)
        Me.Lbl_Login.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Login.Name = "Lbl_Login"
        Me.Lbl_Login.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Login.TabIndex = 0
        Me.Lbl_Login.Text = "Label1"
        '
        'Btm_Logar
        '
        Me.Btm_Logar.Location = New System.Drawing.Point(158, 170)
        Me.Btm_Logar.Name = "Btm_Logar"
        Me.Btm_Logar.Size = New System.Drawing.Size(75, 23)
        Me.Btm_Logar.TabIndex = 6
        Me.Btm_Logar.Text = "Button1"
        Me.Btm_Logar.UseVisualStyleBackColor = True
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 238)
        Me.Controls.Add(Me.Grp_Login)
        Me.Controls.Add(Me.Pic_Logo)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Frm_Login"
        Me.Text = "Frm_Login"
        CType(Me.Pic_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grp_Login.ResumeLayout(False)
        Me.Grp_Login.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pic_Logo As PictureBox
    Friend WithEvents Grp_Login As GroupBox
    Friend WithEvents Lbl_Senha As Label
    Friend WithEvents Lbl_Login As Label
    Friend WithEvents Txt_Senha As TextBox
    Friend WithEvents Txt_Login As TextBox
    Friend WithEvents Rb_Gerente As RadioButton
    Friend WithEvents Rb_Representante As RadioButton
    Friend WithEvents Btm_Logar As Button
End Class
