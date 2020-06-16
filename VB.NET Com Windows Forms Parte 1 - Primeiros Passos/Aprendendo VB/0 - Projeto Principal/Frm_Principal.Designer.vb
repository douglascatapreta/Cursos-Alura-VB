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
        Me.Btm_01 = New System.Windows.Forms.Button()
        Me.Btm_02 = New System.Windows.Forms.Button()
        Me.Btm_03 = New System.Windows.Forms.Button()
        Me.Btm_04 = New System.Windows.Forms.Button()
        Me.Btm_05 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btm_01
        '
        Me.Btm_01.Location = New System.Drawing.Point(24, 24)
        Me.Btm_01.Name = "Btm_01"
        Me.Btm_01.Size = New System.Drawing.Size(480, 48)
        Me.Btm_01.TabIndex = 0
        Me.Btm_01.Text = "Button1"
        Me.Btm_01.UseVisualStyleBackColor = True
        '
        'Btm_02
        '
        Me.Btm_02.Location = New System.Drawing.Point(25, 78)
        Me.Btm_02.Name = "Btm_02"
        Me.Btm_02.Size = New System.Drawing.Size(480, 48)
        Me.Btm_02.TabIndex = 1
        Me.Btm_02.Text = "Button2"
        Me.Btm_02.UseVisualStyleBackColor = True
        '
        'Btm_03
        '
        Me.Btm_03.Location = New System.Drawing.Point(24, 132)
        Me.Btm_03.Name = "Btm_03"
        Me.Btm_03.Size = New System.Drawing.Size(480, 48)
        Me.Btm_03.TabIndex = 2
        Me.Btm_03.Text = "Button3"
        Me.Btm_03.UseVisualStyleBackColor = True
        '
        'Btm_04
        '
        Me.Btm_04.Location = New System.Drawing.Point(25, 186)
        Me.Btm_04.Name = "Btm_04"
        Me.Btm_04.Size = New System.Drawing.Size(480, 48)
        Me.Btm_04.TabIndex = 3
        Me.Btm_04.Text = "Button4"
        Me.Btm_04.UseVisualStyleBackColor = True
        '
        'Btm_05
        '
        Me.Btm_05.Location = New System.Drawing.Point(24, 240)
        Me.Btm_05.Name = "Btm_05"
        Me.Btm_05.Size = New System.Drawing.Size(480, 48)
        Me.Btm_05.TabIndex = 4
        Me.Btm_05.Text = "Button5"
        Me.Btm_05.UseVisualStyleBackColor = True
        '
        'Frm_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 310)
        Me.Controls.Add(Me.Btm_05)
        Me.Controls.Add(Me.Btm_04)
        Me.Controls.Add(Me.Btm_03)
        Me.Controls.Add(Me.Btm_02)
        Me.Controls.Add(Me.Btm_01)
        Me.Name = "Frm_Principal"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Btm_01 As Button
    Friend WithEvents Btm_02 As Button
    Friend WithEvents Btm_03 As Button
    Friend WithEvents Btm_04 As Button
    Friend WithEvents Btm_05 As Button
End Class
