Module Module1

    Sub Main()
1:      Dim i, v As Integer
        Dim A, B, A1, B1, Q As String

        i = 1

        'Captura de dados
        Console.Write("Escreva uma palavra: ")
        A = Console.ReadLine()
        Console.Write("Escreva a palavra que quer verificar se é um palindrmo de " & A & ": ")
        B = Console.ReadLine()

        'Verificação do comprimento das strings têm o mesmo tamanho 
        If (Len(A) = Len(B)) Then
            'Verifica se os carateres em posições opostas são iguais
            While i <= Len(A)
                A1 = Mid(A, i, 1)
                B1 = Mid(B, Len(B) + 1 - i, 1)
                If (A1 = B1) Then
                    i += 1
                    v = 1
                Else
                    i = Len(A) + 1
                    v = 0
                End If
            End While
        Else
            v = 0
        End If

        'Analisa o valor da variavel v (Verdade). Se for 1 são palindromos se não não são palindromos
        If (v = 1) Then
            Console.WriteLine("São palindromos!")
        Else
            Console.WriteLine("Não são palindromos!")
        End If

        'Pergunta ao utilizador se quer reiniciar o programa
        Console.Write(vbNewLine & "Deseja recomeçar o programa? (S/n)")
        Q = Console.ReadLine()

        If (Q = "S" Or Q = "s") Then
            Console.Write(vbNewLine)
            GoTo 1
        End If
    End Sub

End Module
