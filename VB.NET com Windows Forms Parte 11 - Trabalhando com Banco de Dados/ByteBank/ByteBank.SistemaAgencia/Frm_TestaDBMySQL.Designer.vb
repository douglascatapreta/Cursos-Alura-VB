<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TestaDBMySQL
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DtGrid_Resultado = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DtGrid_Resultado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(6, 140)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 39)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(6, 85)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 39)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DtGrid_Resultado
        '
        Me.DtGrid_Resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtGrid_Resultado.Location = New System.Drawing.Point(138, 31)
        Me.DtGrid_Resultado.Name = "DtGrid_Resultado"
        Me.DtGrid_Resultado.Size = New System.Drawing.Size(425, 228)
        Me.DtGrid_Resultado.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 31)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 39)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Frm_TestaDBMySQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 289)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DtGrid_Resultado)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Frm_TestaDBMySQL"
        Me.Text = "Frm_TestaDBMySQL"
        CType(Me.DtGrid_Resultado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DtGrid_Resultado As DataGridView
    Friend WithEvents Button1 As Button
End Class
