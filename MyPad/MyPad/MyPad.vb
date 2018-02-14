Imports System.IO

Public Class MyPadTextEditor
    Dim ficheiro, nome As String
    Dim resposta As Integer = 0

    Private Sub MyPadTextEditor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RtbTexto.SelectionFont = New Font("Consolas", 12, FontStyle.Regular)
    End Sub

    'Redimencionamento da Ritch Text Box conforme a janela
    Private Sub MyPadTextEditor_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        RtbTexto.Size = New Size(Me.Size.Width - 15, Me.Size.Height - 60)
    End Sub

    'Novo Ficheiro
    Private Sub MnuNF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuNF.Click
        'Verificar a existecia de alterações na Rich Text Box
        If RtbTexto.Modified Then
            resposta = MsgBox("Pertende apagar todas a alterações?", MsgBoxStyle.YesNoCancel, "Apagar Tudo?")
            If resposta = Windows.Forms.DialogResult.Yes Then
                SaveFile("Ficheiros RTF(*.rtf)|*.rtf|Ficheiros Texto(*.txt)|*.txt|Ficheiros Word(*.doc)|*.doc")
            ElseIf resposta = Windows.Forms.DialogResult.No Then
                RtbTexto.ResetText()
                RtbTexto.Modified = False
                ficheiro = Nothing
                resposta = 0
            End If
        Else
            RtbTexto.ResetText()
            RtbTexto.Modified = False
        End If
        Me.Text = "MyPad - Novo Ficheiro"
    End Sub

    'Novo Ficheiro Encriptado
    Private Sub MnuNFE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuNFE.Click
        'Verificar a existecia de alterações na Rich Text Box
        If RtbTexto.Modified Then
            resposta = MsgBox("Pertende apagar todas a alterações?", MsgBoxStyle.YesNoCancel, "Apagar Tudo?")
            If resposta = Windows.Forms.DialogResult.Yes Then
                SaveFile("Ficheiros RTF(*.rtf)|*.rtf|Ficheiros Texto(*.txt)|*.txt|Ficheiros Word(*.doc)|*.doc")
            End If
        End If

        If resposta = Windows.Forms.DialogResult.No Or RtbTexto.Modified = False Then
            RtbTexto.ResetText()
            RtbTexto.Modified = False
            ficheiro = Nothing
            resposta = 0
            MyPad_Crypt.Show()
            Me.Close()
        End If
    End Sub

    'Abrir um ficheiro
    Private Sub MnuAF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAF.Click
        'Verificar a existecia de alterações na Rich Text Box
        If RtbTexto.Modified Then
            resposta = MsgBox("Pertende apagar todas a alterações?", MsgBoxStyle.YesNo, "Apagar Tudo?")
        End If

        If resposta = 6 Or resposta = 0 Then
            OpenFile("Ficheiros RTF(*.rtf)|*.rtf|Ficheiros Texto(*.txt)|*.txt|Ficheiros Word(*.doc)|*.doc")
        End If

    End Sub

    'Guardar
    Private Sub MnuGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuGuardar.Click
        If ficheiro <> "" Then
            RtbTexto.SaveFile(ficheiro)
            RtbTexto.Modified = False
        Else
            SaveFile("Ficheiros RTF(*.rtf)|*.rtf|Ficheiros Texto(*.txt)|*.txt|Ficheiros Word(*.doc)|*.doc")
        End If
    End Sub

    'Cancelar
    Private Sub MnuCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCancelar.Click
        resposta = MsgBox("Quer guardar o ficheiro?", MsgBoxStyle.YesNoCancel, "Guardar?")
        If resposta = Windows.Forms.DialogResult.Yes Then
            SaveFile("Ficheiros RTF(*.rtf)|*.rtf|Ficheiros Texto(*.txt)|*.txt|Ficheiros Word(*.doc)|*.doc")
            End
        ElseIf resposta = Windows.Forms.DialogResult.No Then
            End
        End If
    End Sub

    'Cortar
    Private Sub MnuCortar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCortar.Click
        RtbTexto.Cut()
    End Sub

    'Copiar
    Private Sub MnuCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCopiar.Click
        RtbTexto.Copy()
    End Sub

    'Colar
    Private Sub MnuColar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuColar.Click
        RtbTexto.Paste()
    End Sub

    'Alinhar à Esquerda
    Private Sub MnuAlinarE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAlinarE.Click
        RtbTexto.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    'Alinhar ao Centro
    Private Sub MnuAlinharC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAlinharC.Click
        RtbTexto.SelectionAlignment = HorizontalAlignment.Center
    End Sub

    'Alinhar à Direita
    Private Sub MnuAlinharD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuAlinharD.Click
        RtbTexto.SelectionAlignment = HorizontalAlignment.Right
    End Sub

    't
    Private Sub MnuLetra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuLetra.Click
        If Not RtbTexto.SelectionFont Is Nothing Then
            FontDialog1.Font = RtbTexto.SelectionFont
        Else
            FontDialog1.Font = Nothing
        End If
        FontDialog1.ShowDialog()
        RtbTexto.SelectionFont = FontDialog1.Font
    End Sub

    Private Sub MnuCorTexto_Click(sender As System.Object, e As System.EventArgs) Handles MnuCorTexto.Click
        ColorDialog1.ShowDialog()
        RtbTexto.SelectionColor = ColorDialog1.Color
    End Sub

    Private Sub MnuCorFundo_Click(sender As System.Object, e As System.EventArgs) Handles MnuCorFundo.Click
        ColorDialog1.ShowDialog()
        RtbTexto.SelectionBackColor = ColorDialog1.Color
    End Sub

    Private Sub MnuEncontrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuEncontrar.Click
        Dim txtproc As String
        Dim ocurrencias As Integer
        txtproc = InputBox("Indique o texto que está à procura")
        ocurrencias = RtbTexto.Find(txtproc)
        If ocurrencias < 0 Then
            MsgBox("Não foi encontrado nenhum texto igual ao que escreveu", MsgBoxStyle.OkOnly, "Nenhum resultado")
        End If
    End Sub

    Private Sub MnuSelecionrTudo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSelecionrTudo.Click
        RtbTexto.SelectAll()
    End Sub

    Private Sub MnuData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuData.Click
        RtbTexto.Text &= Now.Date
    End Sub

    Private Sub MnuHora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuHora.Click
        RtbTexto.Text &= Now.Hour & ":" & Now.Minute & ":" & Now.Second
    End Sub

    Private Sub MnuDataHora_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuDataHora.Click
        RtbTexto.Text &= Now.Date & " " & Now.Hour & ":" & Now.Minute & ":" & Now.Second

    End Sub

    Private Sub MnuSobreOMyPad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSobreOMyPad.Click
        MyPad_Sobre.Show()
    End Sub

    Private Sub ConMnuCortar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConMnuCortar.Click
        RtbTexto.Cut()
    End Sub

    Private Sub ConMnuCopiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConMnuCopiar.Click
        RtbTexto.Copy()
    End Sub

    Private Sub ConMnuColar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConMnuColar.Click
        RtbTexto.Paste()
    End Sub




    'SUB ROTINAS PRÓPRIAS
    Public Sub OpenFile(ByVal Filter)
        OpenFileDialog1.Filter = Filter
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            ficheiro = OpenFileDialog1.FileName
            RtbTexto.ResetText()

            If System.IO.Path.GetExtension(ficheiro) = ".txt" Then
                RtbTexto.Text = My.Computer.FileSystem.ReadAllText(ficheiro)
            Else
                RtbTexto.LoadFile(ficheiro)
            End If

        
            RtbTexto.Modified = False

            Me.Text = "MyPad - " & System.IO.Path.GetFileName(ficheiro)
            nome = ficheiro
            ficheiro = Nothing
            resposta = 0
        End If
    End Sub

    Public Sub SaveFile(ByVal Filter)
        SaveFileDialog1.Filter = Filter
        SaveFileDialog1.FileName = ""

        If System.IO.File.Exists(nome) Then
            ficheiro = nome
        Else
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                ficheiro = SaveFileDialog1.FileName
            End If
        End If

        'verifica o tipo de ficheiro que o utilizador pretende. se for texto escreve so o texto, caso contrário escreve em formato Rich Text
        If System.IO.Path.GetExtension(ficheiro) = ".txt" Then
            My.Computer.FileSystem.WriteAllText(ficheiro,RtbTexto.Text,False)
        Else
            RtbTexto.SaveFile(ficheiro)
        End If

        Me.Text = "MyPad - " & System.IO.Path.GetFileName(ficheiro)
        ficheiro = Nothing
        RtbTexto.Modified = False
    End Sub

    Private Sub EncriptarOTextoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EncriptarOTextoToolStripMenuItem.Click
        MyPad_Crypt.TxtCript.Text = RtbTexto.Text
        MyPad_Crypt.Show()
    End Sub
End Class
