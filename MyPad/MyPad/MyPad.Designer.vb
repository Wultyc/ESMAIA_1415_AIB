<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyPadTextEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MyPadTextEditor))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FicheiroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuNF = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuNFE = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuCancelar = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCortar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCopiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuColar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuApagar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuAlinhar = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuAlinarE = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuAlinharC = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuAlinharD = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuLetra = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCor = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCorTexto = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCorFundo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuEncontrar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuSelecionrTudo = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuDataO = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuData = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuHora = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuDataHora = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuAjuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuSobreOMyPad = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ConMnuCortar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConMnuCopiar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConMnuColar = New System.Windows.Forms.ToolStripMenuItem()
        Me.RtbTexto = New System.Windows.Forms.RichTextBox()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MnuGuardar = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MnuAF = New System.Windows.Forms.ToolStripMenuItem()
        Me.EncriptarOTextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FicheiroToolStripMenuItem, Me.EditarToolStripMenuItem, Me.MnuAjuda})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(984, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FicheiroToolStripMenuItem
        '
        Me.FicheiroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuNF, Me.MnuNFE, Me.ToolStripSeparator1, Me.MnuAF, Me.EncriptarOTextoToolStripMenuItem, Me.ToolStripSeparator2, Me.MnuGuardar, Me.MnuCancelar})
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
        'MnuCancelar
        '
        Me.MnuCancelar.Image = Global.MyPad.My.Resources.Resources.cancel
        Me.MnuCancelar.Name = "MnuCancelar"
        Me.MnuCancelar.Size = New System.Drawing.Size(208, 22)
        Me.MnuCancelar.Text = "Cancelar"
        '
        'EditarToolStripMenuItem
        '
        Me.EditarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuCortar, Me.MnuCopiar, Me.MnuColar, Me.MnuApagar, Me.ToolStripSeparator4, Me.MnuAlinhar, Me.MnuLetra, Me.MnuCor, Me.ToolStripSeparator6, Me.MnuEncontrar, Me.ToolStripSeparator5, Me.MnuSelecionrTudo, Me.MnuDataO})
        Me.EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        Me.EditarToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.EditarToolStripMenuItem.Text = "Editar"
        '
        'MnuCortar
        '
        Me.MnuCortar.Image = Global.MyPad.My.Resources.Resources.cut
        Me.MnuCortar.Name = "MnuCortar"
        Me.MnuCortar.Size = New System.Drawing.Size(159, 22)
        Me.MnuCortar.Text = "Cortar"
        '
        'MnuCopiar
        '
        Me.MnuCopiar.Image = Global.MyPad.My.Resources.Resources.copy
        Me.MnuCopiar.Name = "MnuCopiar"
        Me.MnuCopiar.Size = New System.Drawing.Size(159, 22)
        Me.MnuCopiar.Text = "Copiar"
        '
        'MnuColar
        '
        Me.MnuColar.Image = Global.MyPad.My.Resources.Resources.paste
        Me.MnuColar.Name = "MnuColar"
        Me.MnuColar.Size = New System.Drawing.Size(159, 22)
        Me.MnuColar.Text = "Colar"
        '
        'MnuApagar
        '
        Me.MnuApagar.Image = Global.MyPad.My.Resources.Resources.delete
        Me.MnuApagar.Name = "MnuApagar"
        Me.MnuApagar.Size = New System.Drawing.Size(159, 22)
        Me.MnuApagar.Text = "Apagar"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(156, 6)
        '
        'MnuAlinhar
        '
        Me.MnuAlinhar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuAlinarE, Me.MnuAlinharC, Me.MnuAlinharD})
        Me.MnuAlinhar.Image = Global.MyPad.My.Resources.Resources.shapes_align_hori_center
        Me.MnuAlinhar.Name = "MnuAlinhar"
        Me.MnuAlinhar.Size = New System.Drawing.Size(159, 22)
        Me.MnuAlinhar.Text = "Alinhar"
        '
        'MnuAlinarE
        '
        Me.MnuAlinarE.Image = Global.MyPad.My.Resources.Resources.shapes_align_hori_left
        Me.MnuAlinarE.Name = "MnuAlinarE"
        Me.MnuAlinarE.Size = New System.Drawing.Size(172, 22)
        Me.MnuAlinarE.Text = "Alinhar à Esquerda"
        '
        'MnuAlinharC
        '
        Me.MnuAlinharC.Image = Global.MyPad.My.Resources.Resources.shapes_align_hori_center
        Me.MnuAlinharC.Name = "MnuAlinharC"
        Me.MnuAlinharC.Size = New System.Drawing.Size(172, 22)
        Me.MnuAlinharC.Text = "Alinhar ao Centro"
        '
        'MnuAlinharD
        '
        Me.MnuAlinharD.Image = Global.MyPad.My.Resources.Resources.shapes_align_hori_right
        Me.MnuAlinharD.Name = "MnuAlinharD"
        Me.MnuAlinharD.Size = New System.Drawing.Size(172, 22)
        Me.MnuAlinharD.Text = "Alinhar à Direita"
        '
        'MnuLetra
        '
        Me.MnuLetra.Image = Global.MyPad.My.Resources.Resources.font
        Me.MnuLetra.Name = "MnuLetra"
        Me.MnuLetra.Size = New System.Drawing.Size(159, 22)
        Me.MnuLetra.Text = "Letra"
        '
        'MnuCor
        '
        Me.MnuCor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuCorTexto, Me.MnuCorFundo})
        Me.MnuCor.Image = Global.MyPad.My.Resources.Resources.color_picker
        Me.MnuCor.Name = "MnuCor"
        Me.MnuCor.Size = New System.Drawing.Size(159, 22)
        Me.MnuCor.Text = "Cores"
        '
        'MnuCorTexto
        '
        Me.MnuCorTexto.Image = Global.MyPad.My.Resources.Resources.font
        Me.MnuCorTexto.Name = "MnuCorTexto"
        Me.MnuCorTexto.Size = New System.Drawing.Size(147, 22)
        Me.MnuCorTexto.Text = "Cor do Texto"
        '
        'MnuCorFundo
        '
        Me.MnuCorFundo.Image = Global.MyPad.My.Resources.Resources.color_picker
        Me.MnuCorFundo.Name = "MnuCorFundo"
        Me.MnuCorFundo.Size = New System.Drawing.Size(147, 22)
        Me.MnuCorFundo.Text = "Cor do Fundo"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(156, 6)
        '
        'MnuEncontrar
        '
        Me.MnuEncontrar.Image = Global.MyPad.My.Resources.Resources.search
        Me.MnuEncontrar.Name = "MnuEncontrar"
        Me.MnuEncontrar.Size = New System.Drawing.Size(159, 22)
        Me.MnuEncontrar.Text = "Encontrar"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(156, 6)
        '
        'MnuSelecionrTudo
        '
        Me.MnuSelecionrTudo.Image = Global.MyPad.My.Resources.Resources.document
        Me.MnuSelecionrTudo.Name = "MnuSelecionrTudo"
        Me.MnuSelecionrTudo.Size = New System.Drawing.Size(159, 22)
        Me.MnuSelecionrTudo.Text = "Selecionar Tudo"
        '
        'MnuDataO
        '
        Me.MnuDataO.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuData, Me.MnuHora, Me.MnuDataHora})
        Me.MnuDataO.Image = Global.MyPad.My.Resources.Resources.calendar
        Me.MnuDataO.Name = "MnuDataO"
        Me.MnuDataO.Size = New System.Drawing.Size(159, 22)
        Me.MnuDataO.Text = "Data e Hora"
        '
        'MnuData
        '
        Me.MnuData.Image = Global.MyPad.My.Resources.Resources.calendar_alt_2
        Me.MnuData.Name = "MnuData"
        Me.MnuData.Size = New System.Drawing.Size(152, 22)
        Me.MnuData.Text = "Só data"
        '
        'MnuHora
        '
        Me.MnuHora.Image = Global.MyPad.My.Resources.Resources.calendar1
        Me.MnuHora.Name = "MnuHora"
        Me.MnuHora.Size = New System.Drawing.Size(152, 22)
        Me.MnuHora.Text = "Só Hora"
        '
        'MnuDataHora
        '
        Me.MnuDataHora.Image = Global.MyPad.My.Resources.Resources.calendar_alt_1
        Me.MnuDataHora.Name = "MnuDataHora"
        Me.MnuDataHora.Size = New System.Drawing.Size(152, 22)
        Me.MnuDataHora.Text = "Data e Hora"
        '
        'MnuAjuda
        '
        Me.MnuAjuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuSobreOMyPad})
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
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConMnuCortar, Me.ConMnuCopiar, Me.ConMnuColar})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(108, 70)
        '
        'ConMnuCortar
        '
        Me.ConMnuCortar.Image = Global.MyPad.My.Resources.Resources.cut
        Me.ConMnuCortar.Name = "ConMnuCortar"
        Me.ConMnuCortar.Size = New System.Drawing.Size(107, 22)
        Me.ConMnuCortar.Text = "cortar"
        '
        'ConMnuCopiar
        '
        Me.ConMnuCopiar.Image = Global.MyPad.My.Resources.Resources.copy
        Me.ConMnuCopiar.Name = "ConMnuCopiar"
        Me.ConMnuCopiar.Size = New System.Drawing.Size(107, 22)
        Me.ConMnuCopiar.Text = "copiar"
        '
        'ConMnuColar
        '
        Me.ConMnuColar.Image = Global.MyPad.My.Resources.Resources.paste
        Me.ConMnuColar.Name = "ConMnuColar"
        Me.ConMnuColar.Size = New System.Drawing.Size(107, 22)
        Me.ConMnuColar.Text = "colar"
        '
        'RtbTexto
        '
        Me.RtbTexto.ContextMenuStrip = Me.ContextMenuStrip1
        Me.RtbTexto.Location = New System.Drawing.Point(0, 28)
        Me.RtbTexto.Name = "RtbTexto"
        Me.RtbTexto.Size = New System.Drawing.Size(984, 435)
        Me.RtbTexto.TabIndex = 2
        Me.RtbTexto.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MnuGuardar
        '
        Me.MnuGuardar.Image = Global.MyPad.My.Resources.Resources.save
        Me.MnuGuardar.Name = "MnuGuardar"
        Me.MnuGuardar.Size = New System.Drawing.Size(208, 22)
        Me.MnuGuardar.Text = "Guardar"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(205, 6)
        '
        'MnuAF
        '
        Me.MnuAF.Image = Global.MyPad.My.Resources.Resources.file
        Me.MnuAF.Name = "MnuAF"
        Me.MnuAF.Size = New System.Drawing.Size(208, 22)
        Me.MnuAF.Text = "Abrir Ficheiro"
        '
        'EncriptarOTextoToolStripMenuItem
        '
        Me.EncriptarOTextoToolStripMenuItem.Image = Global.MyPad.My.Resources.Resources.keyhole
        Me.EncriptarOTextoToolStripMenuItem.Name = "EncriptarOTextoToolStripMenuItem"
        Me.EncriptarOTextoToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.EncriptarOTextoToolStripMenuItem.Text = "Encriptar o texto"
        '
        'MyPadTextEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 461)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.RtbTexto)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MyPadTextEditor"
        Me.Text = "MyPad - Editor de Texto"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ConMnuCortar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConMnuCopiar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConMnuColar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FicheiroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuNF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuNFE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuCancelar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuCortar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuCopiar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuColar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuApagar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuAlinhar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuAlinarE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuAlinharC As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuAlinharD As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuLetra As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuCor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuEncontrar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuSelecionrTudo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuDataO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuHora As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuDataHora As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuAjuda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuSobreOMyPad As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RtbTexto As System.Windows.Forms.RichTextBox
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents MnuCorTexto As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuCorFundo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MnuAF As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MnuGuardar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EncriptarOTextoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
