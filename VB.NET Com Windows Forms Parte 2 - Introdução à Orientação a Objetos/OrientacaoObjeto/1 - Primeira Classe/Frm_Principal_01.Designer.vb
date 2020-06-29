<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal_01
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
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.Btm_Acao = New System.Windows.Forms.Button()
        Me.Lbl_Saldo = New System.Windows.Forms.Label()
        Me.Lbl_Incremento = New System.Windows.Forms.Label()
        Me.Txt_Saldo = New System.Windows.Forms.TextBox()
        Me.Txt_Incremento = New System.Windows.Forms.TextBox()
        Me.Btm_Acao2 = New System.Windows.Forms.Button()
        Me.Btm_ValRef = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(51, 17)
        Me.Lbl_Principal.TabIndex = 0
        Me.Lbl_Principal.Text = "Label1"
        '
        'Btm_Acao
        '
        Me.Btm_Acao.Location = New System.Drawing.Point(15, 47)
        Me.Btm_Acao.Name = "Btm_Acao"
        Me.Btm_Acao.Size = New System.Drawing.Size(249, 88)
        Me.Btm_Acao.TabIndex = 1
        Me.Btm_Acao.Text = "Button1"
        Me.Btm_Acao.UseVisualStyleBackColor = True
        '
        'Lbl_Saldo
        '
        Me.Lbl_Saldo.AutoSize = True
        Me.Lbl_Saldo.Location = New System.Drawing.Point(12, 169)
        Me.Lbl_Saldo.Name = "Lbl_Saldo"
        Me.Lbl_Saldo.Size = New System.Drawing.Size(51, 17)
        Me.Lbl_Saldo.TabIndex = 2
        Me.Lbl_Saldo.Text = "Label1"
        '
        'Lbl_Incremento
        '
        Me.Lbl_Incremento.AutoSize = True
        Me.Lbl_Incremento.Location = New System.Drawing.Point(158, 169)
        Me.Lbl_Incremento.Name = "Lbl_Incremento"
        Me.Lbl_Incremento.Size = New System.Drawing.Size(51, 17)
        Me.Lbl_Incremento.TabIndex = 3
        Me.Lbl_Incremento.Text = "Label1"
        '
        'Txt_Saldo
        '
        Me.Txt_Saldo.Location = New System.Drawing.Point(15, 189)
        Me.Txt_Saldo.Name = "Txt_Saldo"
        Me.Txt_Saldo.Size = New System.Drawing.Size(103, 22)
        Me.Txt_Saldo.TabIndex = 4
        '
        'Txt_Incremento
        '
        Me.Txt_Incremento.Location = New System.Drawing.Point(161, 189)
        Me.Txt_Incremento.Name = "Txt_Incremento"
        Me.Txt_Incremento.Size = New System.Drawing.Size(103, 22)
        Me.Txt_Incremento.TabIndex = 5
        '
        'Btm_Acao2
        '
        Me.Btm_Acao2.Location = New System.Drawing.Point(539, 47)
        Me.Btm_Acao2.Name = "Btm_Acao2"
        Me.Btm_Acao2.Size = New System.Drawing.Size(249, 88)
        Me.Btm_Acao2.TabIndex = 6
        Me.Btm_Acao2.Text = "Button1"
        Me.Btm_Acao2.UseVisualStyleBackColor = True
        '
        'Btm_ValRef
        '
        Me.Btm_ValRef.Location = New System.Drawing.Point(274, 297)
        Me.Btm_ValRef.Name = "Btm_ValRef"
        Me.Btm_ValRef.Size = New System.Drawing.Size(249, 88)
        Me.Btm_ValRef.TabIndex = 7
        Me.Btm_ValRef.Text = "Button1"
        Me.Btm_ValRef.UseVisualStyleBackColor = True
        '
        'Frm_Principal_01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btm_ValRef)
        Me.Controls.Add(Me.Btm_Acao2)
        Me.Controls.Add(Me.Txt_Incremento)
        Me.Controls.Add(Me.Txt_Saldo)
        Me.Controls.Add(Me.Lbl_Incremento)
        Me.Controls.Add(Me.Lbl_Saldo)
        Me.Controls.Add(Me.Btm_Acao)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Name = "Frm_Principal_01"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btm_Acao As Button
    Friend WithEvents Lbl_Saldo As Label
    Friend WithEvents Lbl_Incremento As Label
    Friend WithEvents Txt_Saldo As TextBox
    Friend WithEvents Txt_Incremento As TextBox
    Friend WithEvents Btm_Acao2 As Button
    Friend WithEvents Btm_ValRef As Button
End Class
