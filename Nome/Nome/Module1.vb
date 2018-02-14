Module Module1

    Sub Main()
1:
        Console.Write("Insira o seu nome: ")
        Dim nome As String = Trim(Console.ReadLine())

        Dim i As Integer
        Dim UltEspaco As Integer = 0
        Dim letra As String
        Dim Iniciais As String = "a"
        Dim Verifica As String

        'Determina a posição do ultimo espaço
        For i = 1 To Len(nome)
            ' Guardar na variável a o carater de cada iteração.
            letra = Mid(nome, i, 1)
            If letra = " " Then
                UltEspaco = i
            End If
        Next

        'Encontra as iniciais
        For i = 1 To UltEspaco - 1
            If Iniciais = "a" Then
                Iniciais = Mid(nome, i, 1) & "."
            Else
                If (Mid(nome, i, 1) = " ") Then
                    Iniciais = Iniciais & " " & Mid(nome, i + 1, 1) & "."
                End If
            End If
        Next

        'Imprime a mensagem
        Console.WriteLine(Mid(nome, UltEspaco + 1) & ", " & Iniciais)

        'Verifica se o Utilizador quer utilizar de novo o software
        Console.WriteLine(vbNewLine)
        Console.Write("Deseja executar de novo a operação? (S/n) ")
        Verifica = Console.ReadLine

        If (Verifica = "s" Or Verifica = "S") Then
            Console.WriteLine(vbNewLine)
            GoTo 1
        End If
    End Sub

End Module
