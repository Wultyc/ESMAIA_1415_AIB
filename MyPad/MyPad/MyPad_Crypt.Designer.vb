<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyPad_Crypt
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyPad_Crypt))
        Me.TxtCript = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FicheiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuNF = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuNFE = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuEncriptar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuDesencriptar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuCancelar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuAjuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuSobreOMyPad = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ConMnuCortar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConMnuCopiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConMnuColar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtCript
        '
        Me.TxtCript.Location = New System.Drawing.Point(0, 27)
        Me.TxtCript.Multiline = True
        Me.TxtCript.Name = "TxtCript"
        Me.TxtCript.Size = New System.Drawing.Size(984, 413)
        Me.TxtCript.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FicheiroToolStripMenuItem, Me.MnuAjuda})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FicheiroToolStripMenuItem
        '
        Me.FicheiroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuNF, Me.MnuNFE, Me.ToolStripSeparator1, Me.ToolStripSeparator2, Me.MnuEncriptar, Me.MnuDesencriptar, Me.ToolStripSeparator3, Me.MnuCancelar})
        Me.FicheiroToolStripMenuItem.Name = "FicheiroToolStripMenuItem"
        Me.FicheiroToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FicheiroToolStripMenuItem.Text = "Ficheiro"
        '
        'MnuNF
        '
        Me.MnuNF.Image = Global.MyPad.My.Resources.Resources.document_new
        Me.MnuNF.Name = "MnuNF"
        Me.MnuNF.Size = New System.Drawing.Size(208, 22)
        Me.MnuNF.Text = "Novo Ficheiro"
        '
        'MnuNFE
        '
        Me.MnuNFE.Image = Global.MyPad.My.Resources.Resources.document_new
        Me.MnuNFE.Name = "MnuNFE"
        Me.MnuNFE.Size = New System.Drawing.Size(208, 22)
        Me.MnuNFE.Text = "Novo Ficheiro Encriptado"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(205, 6)
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(205, 6)
        '
        'MnuEncriptar
        '
        Me.MnuEncriptar.Image = Global.MyPad.My.Resources.Resources.keyhole
        Me.MnuEncriptar.Name = "MnuEncriptar"
        Me.MnuEncriptar.Size = New System.Drawing.Size(208, 22)
        Me.MnuEncriptar.Text = "Encriptar"
        '
        'MnuDesencriptar
        '
        Me.MnuDesencriptar.Image = Global.MyPad.My.Resources.Resources.key
        Me.MnuDesencriptar.Name = "MnuDesencriptar"
        Me.MnuDesencriptar.Size = New System.Drawing.Size(208, 22)
        Me.MnuDesencriptar.Text = "Desencriptar"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(205, 6)
        '
        'MnuCancelar
        '
        Me.MnuCancelar.Image = Global.MyPad.My.Resources.Resources.cancel
        Me.MnuCancelar.Name = "MnuCancelar"
        Me.MnuCancelar.Size = New System.Drawing.Size(208, 22)
        Me.MnuCancelar.Text = "Cancelar"
        '
        'MnuAjuda
        '
        Me.MnuAjuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuSobreOMyPad, Me.ToolStripSeparator7})
        Me.MnuAjuda.Name = "MnuAjuda"
        Me.MnuAjuda.Size = New System.Drawing.Size(50, 20)
        Me.MnuAjuda.Text = "Ajuda"
        '
        'MnuSobreOMyPad
        '
        Me.MnuSobreOMyPad.Image = Global.MyPad.My.Resources.Resources.help
        Me.MnuSobreOMyPad.Name = "MnuSobreOMyPad"
        Me.MnuSobreOMyPad.Size = New System.Drawing.Size(154, 22)
        Me.MnuSobreOMyPad.Text = "Sobre o MyPad"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(151, 6)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConMnuCortar, Me.ConMnuCopiar, Me.ConMnuColar})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 70)
        '
        'ConMnuCortar
        '
        Me.ConMnuCortar.Name = "ConMnuCortar"
        Me.ConMnuCortar.Size = New System.Drawing.Size(107, 22)
        Me.ConMnuCortar.Text = "cortar"
        '
        'ConMnuCopiar
        '
        Me.ConMnuCopiar.Name = "ConMnuCopiar"
        Me.ConMnuCopiar.Size = New System.Drawing.Size(107, 22)
        Me.ConMnuCopiar.Text = "copiar"
        '
        'ConMnuColar
        '
        Me.ConMnuColar.Name = "ConMnuColar"
        Me.ConMnuColar.Size = New System.Drawing.Size(107, 22)
        Me.ConMnuColar.Text = "colar"
        '
        'MyPad_Crypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TxtCript)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MyPad_Crypt"
        Me.Text = "MyPad - Crypt"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtCript As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FicheiroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuNF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuNFE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuCancelar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuAjuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuSobreOMyPad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ConMnuCortar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConMnuCopiar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConMnuColar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuEncriptar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuDesencriptar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
End Class
