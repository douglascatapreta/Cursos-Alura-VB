<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExemploInterface
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
        Me.Lbl_ExemploInterface = New System.Windows.Forms.Label()
        Me.Btm_ExemploInterface = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_ExemploInterface
        '
        Me.Lbl_ExemploInterface.AutoSize = True
        Me.Lbl_ExemploInterface.Location = New System.Drawing.Point(12, 9)
        Me.Lbl_ExemploInterface.Name = "Lbl_ExemploInterface"
        Me.Lbl_ExemploInterface.Size = New System.Drawing.Size(51, 17)
        Me.Lbl_ExemploInterface.TabIndex = 0
        Me.Lbl_ExemploInterface.Text = "Label1"
        '
        'Btm_ExemploInterface
        '
        Me.Btm_ExemploInterface.Location = New System.Drawing.Point(15, 52)
        Me.Btm_ExemploInterface.Name = "Btm_ExemploInterface"
        Me.Btm_ExemploInterface.Size = New System.Drawing.Size(202, 48)
        Me.Btm_ExemploInterface.TabIndex = 1
        Me.Btm_ExemploInterface.Text = "Button1"
        Me.Btm_ExemploInterface.UseVisualStyleBackColor = True
        '
        'ExemploInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btm_ExemploInterface)
        Me.Controls.Add(Me.Lbl_ExemploInterface)
        Me.Name = "ExemploInterface"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_ExemploInterface As Label
    Friend WithEvents Btm_ExemploInterface As Button
End Class
