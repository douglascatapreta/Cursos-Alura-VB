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
        Me.Btm_Autentica = New System.Windows.Forms.Button()
        Me.Btm_Autentica2 = New System.Windows.Forms.Button()
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
        'Btm_Autentica
        '
        Me.Btm_Autentica.Location = New System.Drawing.Point(15, 55)
        Me.Btm_Autentica.Name = "Btm_Autentica"
        Me.Btm_Autentica.Size = New System.Drawing.Size(359, 57)
        Me.Btm_Autentica.TabIndex = 1
        Me.Btm_Autentica.Text = "Button1"
        Me.Btm_Autentica.UseVisualStyleBackColor = True
        '
        'Btm_Autentica2
        '
        Me.Btm_Autentica2.Location = New System.Drawing.Point(429, 55)
        Me.Btm_Autentica2.Name = "Btm_Autentica2"
        Me.Btm_Autentica2.Size = New System.Drawing.Size(359, 57)
        Me.Btm_Autentica2.TabIndex = 2
        Me.Btm_Autentica2.Text = "Button1"
        Me.Btm_Autentica2.UseVisualStyleBackColor = True
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btm_Autentica2)
        Me.Controls.Add(Me.Btm_Autentica)
        Me.Controls.Add(Me.Lbl_Principal)
        Me.Name = "Frm_Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Principal As Label
    Friend WithEvents Btm_Autentica As Button
    Friend WithEvents Btm_Autentica2 As Button
End Class
