<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_TelaPrincipal_03
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Btm_Principal = New System.Windows.Forms.Button()
        Me.Lbl_NomeProjeto = New System.Windows.Forms.Label()
        Me.Btm_Char = New System.Windows.Forms.Button()
        Me.Txb_NumeroChar = New System.Windows.Forms.TextBox()
        Me.Lbl_Curso = New System.Windows.Forms.Label()
        Me.Txt_Curso = New System.Windows.Forms.TextBox()
        Me.Btm_Adicionar = New System.Windows.Forms.Button()
        Me.Txt_Lista = New System.Windows.Forms.TextBox()
        Me.Btm_MostraLista = New System.Windows.Forms.Button()
        Me.Btm_GuardarVariavel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Btm_Principal
        '
        Me.Btm_Principal.Location = New System.Drawing.Point(19, 41)
        Me.Btm_Principal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btm_Principal.Name = "Btm_Principal"
        Me.Btm_Principal.Size = New System.Drawing.Size(224, 97)
        Me.Btm_Principal.TabIndex = 0
        Me.Btm_Principal.Text = "Botão Principal"
        Me.Btm_Principal.UseVisualStyleBackColor = True
        '
        'Lbl_NomeProjeto
        '
        Me.Lbl_NomeProjeto.AutoSize = True
        Me.Lbl_NomeProjeto.Location = New System.Drawing.Point(16, 11)
        Me.Lbl_NomeProjeto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_NomeProjeto.Name = "Lbl_NomeProjeto"
        Me.Lbl_NomeProjeto.Size = New System.Drawing.Size(140, 21)
        Me.Lbl_NomeProjeto.TabIndex = 1
        Me.Lbl_NomeProjeto.Text = "Título do Projeto"
        '
        'Btm_Char
        '
        Me.Btm_Char.Location = New System.Drawing.Point(340, 69)
        Me.Btm_Char.Name = "Btm_Char"
        Me.Btm_Char.Size = New System.Drawing.Size(383, 69)
        Me.Btm_Char.TabIndex = 2
        Me.Btm_Char.Text = "Button1"
        Me.Btm_Char.UseVisualStyleBackColor = True
        '
        'Txb_NumeroChar
        '
        Me.Txb_NumeroChar.Location = New System.Drawing.Point(340, 41)
        Me.Txb_NumeroChar.Name = "Txb_NumeroChar"
        Me.Txb_NumeroChar.Size = New System.Drawing.Size(383, 22)
        Me.Txb_NumeroChar.TabIndex = 3
        '
        'Lbl_Curso
        '
        Me.Lbl_Curso.AutoSize = True
        Me.Lbl_Curso.Location = New System.Drawing.Point(16, 179)
        Me.Lbl_Curso.Name = "Lbl_Curso"
        Me.Lbl_Curso.Size = New System.Drawing.Size(51, 17)
        Me.Lbl_Curso.TabIndex = 4
        Me.Lbl_Curso.Text = "Label1"
        '
        'Txt_Curso
        '
        Me.Txt_Curso.Location = New System.Drawing.Point(19, 208)
        Me.Txt_Curso.Name = "Txt_Curso"
        Me.Txt_Curso.Size = New System.Drawing.Size(475, 22)
        Me.Txt_Curso.TabIndex = 5
        '
        'Btm_Adicionar
        '
        Me.Btm_Adicionar.Location = New System.Drawing.Point(518, 208)
        Me.Btm_Adicionar.Name = "Btm_Adicionar"
        Me.Btm_Adicionar.Size = New System.Drawing.Size(258, 51)
        Me.Btm_Adicionar.TabIndex = 6
        Me.Btm_Adicionar.Text = "Button1"
        Me.Btm_Adicionar.UseVisualStyleBackColor = True
        '
        'Txt_Lista
        '
        Me.Txt_Lista.Location = New System.Drawing.Point(19, 249)
        Me.Txt_Lista.Multiline = True
        Me.Txt_Lista.Name = "Txt_Lista"
        Me.Txt_Lista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_Lista.Size = New System.Drawing.Size(475, 189)
        Me.Txt_Lista.TabIndex = 7
        '
        'Btm_MostraLista
        '
        Me.Btm_MostraLista.Location = New System.Drawing.Point(518, 265)
        Me.Btm_MostraLista.Name = "Btm_MostraLista"
        Me.Btm_MostraLista.Size = New System.Drawing.Size(258, 51)
        Me.Btm_MostraLista.TabIndex = 8
        Me.Btm_MostraLista.Text = "Button1"
        Me.Btm_MostraLista.UseVisualStyleBackColor = True
        '
        'Btm_GuardarVariavel
        '
        Me.Btm_GuardarVariavel.Location = New System.Drawing.Point(518, 387)
        Me.Btm_GuardarVariavel.Name = "Btm_GuardarVariavel"
        Me.Btm_GuardarVariavel.Size = New System.Drawing.Size(258, 51)
        Me.Btm_GuardarVariavel.TabIndex = 9
        Me.Btm_GuardarVariavel.Text = "Button1"
        Me.Btm_GuardarVariavel.UseVisualStyleBackColor = True
        '
        'Frm_TelaPrincipal_03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btm_GuardarVariavel)
        Me.Controls.Add(Me.Btm_MostraLista)
        Me.Controls.Add(Me.Txt_Lista)
        Me.Controls.Add(Me.Btm_Adicionar)
        Me.Controls.Add(Me.Txt_Curso)
        Me.Controls.Add(Me.Lbl_Curso)
        Me.Controls.Add(Me.Txb_NumeroChar)
        Me.Controls.Add(Me.Btm_Char)
        Me.Controls.Add(Me.Lbl_NomeProjeto)
        Me.Controls.Add(Me.Btm_Principal)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Frm_TelaPrincipal_03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação Alô Mundo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btm_Principal As Button
    Friend WithEvents Lbl_NomeProjeto As Label
    Friend WithEvents Btm_Char As Button
    Friend WithEvents Txb_NumeroChar As TextBox
    Friend WithEvents Lbl_Curso As Label
    Friend WithEvents Txt_Curso As TextBox
    Friend WithEvents Btm_Adicionar As Button
    Friend WithEvents Txt_Lista As TextBox
    Friend WithEvents Btm_MostraLista As Button
    Friend WithEvents Btm_GuardarVariavel As Button
End Class
