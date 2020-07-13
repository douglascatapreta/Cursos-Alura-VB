<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_PaginaWeb
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
        Me.Lbl_URL = New System.Windows.Forms.Label()
        Me.Txt_URL = New System.Windows.Forms.TextBox()
        Me.Wb_Pagina = New System.Windows.Forms.WebBrowser()
        Me.Btm_URL = New System.Windows.Forms.Button()
        Me.Grp_URL = New System.Windows.Forms.GroupBox()
        Me.Grp_WebBrowser = New System.Windows.Forms.GroupBox()
        Me.Btm_Propriedades = New System.Windows.Forms.Button()
        Me.Grp_URL.SuspendLayout()
        Me.Grp_WebBrowser.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_URL
        '
        Me.Lbl_URL.AutoSize = True
        Me.Lbl_URL.Location = New System.Drawing.Point(3, 9)
        Me.Lbl_URL.Name = "Lbl_URL"
        Me.Lbl_URL.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_URL.TabIndex = 0
        Me.Lbl_URL.Text = "Label1"
        '
        'Txt_URL
        '
        Me.Txt_URL.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txt_URL.Location = New System.Drawing.Point(2, 34)
        Me.Txt_URL.Multiline = True
        Me.Txt_URL.Name = "Txt_URL"
        Me.Txt_URL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_URL.Size = New System.Drawing.Size(738, 27)
        Me.Txt_URL.TabIndex = 1
        '
        'Wb_Pagina
        '
        Me.Wb_Pagina.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Wb_Pagina.Location = New System.Drawing.Point(3, 16)
        Me.Wb_Pagina.MinimumSize = New System.Drawing.Size(20, 20)
        Me.Wb_Pagina.Name = "Wb_Pagina"
        Me.Wb_Pagina.Size = New System.Drawing.Size(781, 356)
        Me.Wb_Pagina.TabIndex = 2
        '
        'Btm_URL
        '
        Me.Btm_URL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btm_URL.Location = New System.Drawing.Point(746, 34)
        Me.Btm_URL.Name = "Btm_URL"
        Me.Btm_URL.Size = New System.Drawing.Size(41, 27)
        Me.Btm_URL.TabIndex = 3
        Me.Btm_URL.Text = "Button1"
        Me.Btm_URL.UseVisualStyleBackColor = True
        '
        'Grp_URL
        '
        Me.Grp_URL.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grp_URL.Controls.Add(Me.Btm_Propriedades)
        Me.Grp_URL.Controls.Add(Me.Lbl_URL)
        Me.Grp_URL.Controls.Add(Me.Btm_URL)
        Me.Grp_URL.Controls.Add(Me.Txt_URL)
        Me.Grp_URL.Location = New System.Drawing.Point(3, 3)
        Me.Grp_URL.Name = "Grp_URL"
        Me.Grp_URL.Size = New System.Drawing.Size(787, 61)
        Me.Grp_URL.TabIndex = 4
        Me.Grp_URL.TabStop = False
        Me.Grp_URL.Text = "GroupBox1"
        '
        'Grp_WebBrowser
        '
        Me.Grp_WebBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Grp_WebBrowser.Controls.Add(Me.Wb_Pagina)
        Me.Grp_WebBrowser.Location = New System.Drawing.Point(3, 70)
        Me.Grp_WebBrowser.Name = "Grp_WebBrowser"
        Me.Grp_WebBrowser.Size = New System.Drawing.Size(787, 375)
        Me.Grp_WebBrowser.TabIndex = 5
        Me.Grp_WebBrowser.TabStop = False
        Me.Grp_WebBrowser.Text = "GroupBox2"
        '
        'Btm_Propriedades
        '
        Me.Btm_Propriedades.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btm_Propriedades.Location = New System.Drawing.Point(692, 3)
        Me.Btm_Propriedades.Name = "Btm_Propriedades"
        Me.Btm_Propriedades.Size = New System.Drawing.Size(95, 25)
        Me.Btm_Propriedades.TabIndex = 4
        Me.Btm_Propriedades.Text = "Button1"
        Me.Btm_Propriedades.UseVisualStyleBackColor = True
        '
        'Frm_PaginaWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 446)
        Me.Controls.Add(Me.Grp_WebBrowser)
        Me.Controls.Add(Me.Grp_URL)
        Me.Name = "Frm_PaginaWeb"
        Me.Text = "Frm_PaginaWeb"
        Me.Grp_URL.ResumeLayout(False)
        Me.Grp_URL.PerformLayout()
        Me.Grp_WebBrowser.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Lbl_URL As Label
    Friend WithEvents Txt_URL As TextBox
    Friend WithEvents Wb_Pagina As WebBrowser
    Friend WithEvents Btm_URL As Button
    Friend WithEvents Grp_URL As GroupBox
    Friend WithEvents Grp_WebBrowser As GroupBox
    Friend WithEvents Btm_Propriedades As Button
End Class
