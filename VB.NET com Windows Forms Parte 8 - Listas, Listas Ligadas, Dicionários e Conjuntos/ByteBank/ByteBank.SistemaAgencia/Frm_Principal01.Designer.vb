﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Principal01
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Principal01))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArquivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContasCorrentesArrayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContasCorrentesListasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContasCorrentesAgênciaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContasCorrentesAgênciaDicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SimulaçãoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArquivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArquivoToolStripMenuItem
        '
        Me.ArquivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContasCorrentesArrayToolStripMenuItem, Me.ContasCorrentesListasToolStripMenuItem, Me.ContasCorrentesAgênciaToolStripMenuItem, Me.ContasCorrentesAgênciaDicToolStripMenuItem, Me.SimulaçãoToolStripMenuItem})
        Me.ArquivoToolStripMenuItem.Name = "ArquivoToolStripMenuItem"
        Me.ArquivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArquivoToolStripMenuItem.Text = "Arquivo"
        '
        'ContasCorrentesArrayToolStripMenuItem
        '
        Me.ContasCorrentesArrayToolStripMenuItem.Name = "ContasCorrentesArrayToolStripMenuItem"
        Me.ContasCorrentesArrayToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ContasCorrentesArrayToolStripMenuItem.Text = "Contas Correntes Array"
        '
        'ContasCorrentesListasToolStripMenuItem
        '
        Me.ContasCorrentesListasToolStripMenuItem.Name = "ContasCorrentesListasToolStripMenuItem"
        Me.ContasCorrentesListasToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ContasCorrentesListasToolStripMenuItem.Text = "Contas Correntes Listas"
        '
        'ContasCorrentesAgênciaToolStripMenuItem
        '
        Me.ContasCorrentesAgênciaToolStripMenuItem.Name = "ContasCorrentesAgênciaToolStripMenuItem"
        Me.ContasCorrentesAgênciaToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ContasCorrentesAgênciaToolStripMenuItem.Text = "Contas Correntes Agência"
        '
        'ContasCorrentesAgênciaDicToolStripMenuItem
        '
        Me.ContasCorrentesAgênciaDicToolStripMenuItem.Name = "ContasCorrentesAgênciaDicToolStripMenuItem"
        Me.ContasCorrentesAgênciaDicToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.ContasCorrentesAgênciaDicToolStripMenuItem.Text = "Contas Correntes Agência Dic"
        '
        'SimulaçãoToolStripMenuItem
        '
        Me.SimulaçãoToolStripMenuItem.Name = "SimulaçãoToolStripMenuItem"
        Me.SimulaçãoToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.SimulaçãoToolStripMenuItem.Text = "Simulação"
        '
        'Frm_Principal01
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_Principal01"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArquivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContasCorrentesArrayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContasCorrentesListasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContasCorrentesAgênciaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContasCorrentesAgênciaDicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SimulaçãoToolStripMenuItem As ToolStripMenuItem
End Class
