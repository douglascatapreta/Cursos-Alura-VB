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
        Me.Btm_Click = New System.Windows.Forms.Button()
        Me.Btm_TesteHeranca = New System.Windows.Forms.Button()
        Me.Btm_ClasseBase = New System.Windows.Forms.Button()
        Me.Btm_Aumento = New System.Windows.Forms.Button()
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
        'Btm_Click
        '
        Me.Btm_Click.Location = New System.Drawing.Point(15, 55)
        Me.Btm_Click.Name = "Btm_Click"
        Me.Btm_Click.Size = New System.Drawing.Size(186, 60)
        Me.Btm_Click.TabIndex = 1
        Me.Btm_Click.Text = "Button1"
        Me.Btm_Click.UseVisualStyleBackColor = True
        '
        'Btm_TesteHeranca
        '
        Me.Btm_TesteHeranca.Location = New System.Drawing.Point(15, 143)
        Me.Btm_TesteHeranca.Name = "Btm_TesteHeranca"
        Me.Btm_TesteHeranca.Size = New System.Drawing.Size(186, 60)
        Me.Btm_TesteHeranca.TabIndex = 2
        Me.Btm_TesteHeranca.Text = "Button1"
        Me.Btm_TesteHeranca.UseVisualStyleBackColor = True
        '
        'Btm_ClasseBase
        '
        Me.Btm_ClasseBase.Location = New System.Drawing.Point(225, 55)
        Me.Btm_ClasseBase.Name = "Btm_ClasseBase"
        Me.Btm_ClasseBase.Size = New System.Drawing.Size(186, 60)
        Me.Btm_ClasseBase.TabIndex = 3
        Me.Btm_ClasseBase.Text = "Button1"
        Me.Btm_ClasseBase.UseVisualStyleBackColor = True
        '
        'Btm_Aumento
        '
        Me.Btm_Aumento.Location = New System.Drawing.Point(225, 143)
        Me.Btm_Aumento.Name = "Btm_Aumento"
        Me.Btm_Aumento.Size = New System.Drawing.Size(186, 60)
        Me.Btm_Aumento.TabIndex = 4
        Me.Btm_Aumento.Text = "Button1"
        Me.Btm_Aumento.UseVisualStyleBackColor = True
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btm_Aumento)
        Me.Controls.Add(Me.Btm_ClasseBase)
        Me.Controls.Add(Me.Btm_TesteHeranca)
        Me.Controls.Add(Me.Btm_Click)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btm_Click As Button
    Friend WithEvents Btm_TesteHeranca As Button
    Friend WithEvents Btm_ClasseBase As Button
    Friend WithEvents Btm_Aumento As Button
End Class
