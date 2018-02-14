Public Class MyPad_Crypt
    Dim pass As String
    Dim resposta As Integer = 0
    'Redimencionamento da Ritch Text Box conforme a janela
    Private Sub MyPad_Crypt_Resize(sender As Object, e As System.EventArgs) Handles Me.Resize
        TxtCript.Size = New Size(Me.Size.Width - 15, Me.Size.Height - 85)
    End Sub

    Private Sub MnuNF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuNF.Click
        MyPadTextEditor.Show()
        Me.Close()

    End Sub

    Private Sub MnuSobreOMyPad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuSobreOMyPad.Click
        MyPad_Sobre.Show()
    End Sub

    Private Sub MnuEncriptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuEncriptar.Click
        crypt(TxtCript.Text, "Encriptar")
    End Sub

    Private Sub MnuDesencriptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuDesencriptar.Click
        crypt(TxtCript.Text, "Desencriptar")
    End Sub

    'SUB ROTINAS PRÓPRIAS
    Public Sub crypt(ByRef texto As String, ByVal operacao As String)
        Dim txt, pass, txtcrpted As String
        Dim passcode, tmp, tmp1, tmp2, limite, AscChr As Integer
        passcode = 0
        tmp = 0
        txt = texto
        pass = InputBox("Introduza a password" & vbNewLine & "Se deixar em branco a operação será cancelada", "Password")
        If pass.Length < 1 Then
            Exit Sub
        End If
        For i As Integer = 1 To Len(pass)
            tmp = tmp + Asc(Mid(pass, i, 1))
            While tmp > 10
                tmp1 = Int(tmp / 10)
                tmp2 = Int(tmp - tmp1 * 10)
                tmp = tmp1 + tmp2
            End While
        Next
        passcode = tmp
        tmp = 1
        tmp1 = 0
        tmp2 = 0
        limite = 200 - 32
        txtcrpted = ""
        If operacao = "Encriptar" Then
            While Len(txt) > 0
                If Asc(Mid(txt, 1, 1)) >= 32 And Asc(Mid(txt, 1, 1)) <= 200 Then
                    If Len(txt) > 1 Then
                        AscChr = Asc(Mid(txt, 1, 1))
                        If AscChr + passcode > limite Then
                            tmp1 = AscChr + passcode - limite
                        Else
                            tmp1 = AscChr + passcode
                        End If

                        AscChr = Asc(Mid(txt, 2, 1))
                        If AscChr + passcode > limite Then
                            tmp2 = AscChr + passcode - limite
                        Else
                            tmp2 = Asc(Mid(txt, 2, 1)) + passcode
                        End If
                        txtcrpted &= Chr(tmp2) & Chr(tmp1)
                        txt = Mid(txt, 3)
                    Else
                        AscChr = Asc(Mid(txt, 1, 1))
                        If AscChr + passcode > limite Then
                            tmp1 = AscChr + passcode - limite
                        Else
                            tmp1 = AscChr + passcode
                        End If

                        txtcrpted &= Chr(tmp1)
                        txt = Mid(txt, 2)
                    End If

                Else
                    txtcrpted &= Mid(txt, 1, 1)
                    txt = Mid(txt, 2)
                End If
            End While
            texto = txtcrpted
            Exit Sub
        Else
            While Len(txt) > 0
                If Asc(Mid(txt, 1, 1)) >= 32 And Asc(Mid(txt, 1, 1)) <= 200 Then
                    If Len(txt) > 1 Then
                        AscChr = Asc(Mid(txt, 1, 1))
                        If AscChr < 32 + passcode Then
                            tmp1 = AscChr + limite - passcode
                        Else
                            tmp1 = AscChr - passcode
                        End If
                        AscChr = Asc(Mid(txt, 2, 1))
                        If AscChr < 32 + passcode Then
                            tmp2 = AscChr + limite - passcode
                        Else
                            tmp2 = AscChr - passcode
                        End If
                        txtcrpted &= Chr(tmp2) & Chr(tmp1)
                        txt = Mid(txt, 3)
                    Else
                        AscChr = Asc(Mid(txt, 1, 1))
                        If AscChr < 32 + passcode Then
                            tmp1 = AscChr + limite - passcode
                        Else
                            tmp1 = AscChr - passcode
                        End If
                        txtcrpted &= Chr(tmp1)
                        txt = Mid(txt, 2)
                    End If
                Else
                    txtcrpted &= Mid(txt, 1, 1)
                    txt = Mid(txt, 2)
                End If
            End While
            texto = txtcrpted
        End If

    End Sub

    Private Sub MnuCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnuCancelar.Click
        End
    End Sub
End Class