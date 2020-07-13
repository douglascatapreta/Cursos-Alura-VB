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
        Me.Lbl_Principal = New System.Windows.Forms.Label()
        Me.Btm_Principal = New System.Windows.Forms.Button()
        Me.Lbl_URL = New System.Windows.Forms.Label()
        Me.Lbl_Separador = New System.Windows.Forms.Label()
        Me.Txt_URL = New System.Windows.Forms.TextBox()
        Me.Txt_Separador = New System.Windows.Forms.TextBox()
        Me.Btm_Principal2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Principal
        '
        Me.Lbl_Principal.AutoSize = True
        Me.Lbl_Principal.Location = New System.Drawing.Point(9, 7)
        Me.Lbl_Principal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lbl_Principal.Name = "Lbl_Principal"
        Me.Lbl_Principal.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Principal.TabIndex = 0
        Me.Lbl_Principal.Text = "Label1"
        '
        'Btm_Principal
        '
        Me.Btm_Principal.Location = New System.Drawing.Point(337, 72)
        Me.Btm_Principal.Margin = New System.Windows.Forms.Padding(2)
        Me.Btm_Principal.Name = "Btm_Principal"
        Me.Btm_Principal.Size = New System.Drawing.Size(153, 27)
        Me.Btm_Principal.TabIndex = 1
        Me.Btm_Principal.Text = "Button1"
        Me.Btm_Principal.UseVisualStyleBackColor = True
        '
        'Lbl_URL
        '
        Me.Lbl_URL.AutoSize = True
        Me.Lbl_URL.Location = New System.Drawing.Point(9, 46)
        Me.Lbl_URL.Name = "Lbl_URL"
        Me.Lbl_URL.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_URL.TabIndex = 2
        Me.Lbl_URL.Text = "Label1"
        '
        'Lbl_Separador
        '
        Me.Lbl_Separador.AutoSize = True
        Me.Lbl_Separador.Location = New System.Drawing.Point(9, 79)
        Me.Lbl_Separador.Name = "Lbl_Separador"
        Me.Lbl_Separador.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_Separador.TabIndex = 3
        Me.Lbl_Separador.Text = "Label1"
        '
        'Txt_URL
        '
        Me.Txt_URL.Location = New System.Drawing.Point(72, 43)
        Me.Txt_URL.Name = "Txt_URL"
        Me.Txt_URL.Size = New System.Drawing.Size(418, 20)
        Me.Txt_URL.TabIndex = 4
        '
        'Txt_Separador
        '
        Me.Txt_Separador.Location = New System.Drawing.Point(72, 76)
        Me.Txt_Separador.Name = "Txt_Separador"
        Me.Txt_Separador.Size = New System.Drawing.Size(36, 20)
        Me.Txt_Separador.TabIndex = 5
        '
        'Btm_Principal2
        '
        Me.Btm_Principal2.Location = New System.Drawing.Point(180, 72)
        Me.Btm_Principal2.Margin = New System.Windows.Forms.Padding(2)
        Me.Btm_Principal2.Name = "Btm_Principal2"
        Me.Btm_Principal2.Size = New System.Drawing.Size(153, 27)
        Me.Btm_Principal2.TabIndex = 6
        Me.Btm_Principal2.Text = "Button 2"
        Me.Btm_Principal2.UseVisualStyleBackColor = True
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 127)
        Me.Controls.Add(Me.Btm_Principal2)
        Me.Controls.Add(Me.Txt_Separador)
        Me.Controls.Add(Me.Txt_URL)
        Me.Controls.Add(Me.Lbl_Separador)
        Me.Controls.Add(Me.Lbl_URL)
        Me.Controls.Add(Me.Btm_Principal)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btm_Principal As Button
    Friend WithEvents Lbl_URL As Label
    Friend WithEvents Lbl_Separador As Label
    Friend WithEvents Txt_URL As TextBox
    Friend WithEvents Txt_Separador As TextBox
    Friend WithEvents Btm_Principal2 As Button
End Class
