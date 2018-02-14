Module Module1

    Sub Main()
        Dim i, NumeroAlunos, positivas, negativas As Integer
        Dim NotaAluno, NotaTotal As Single

        i = 1
        positivas = 0
        negativas = 0
        NotaTotal = 0
        Console.Write("Olá Professor Luís! Quantos alunos tem a turma? ")
        NumeroAlunos = Console.ReadLine()
        While (i <= NumeroAlunos)
            Console.Write("Nota do aluno nº" & i & ": ")
            NotaAluno = Console.ReadLine()
            If (NotaAluno >= 10) Then
                positivas = positivas + 1
            Else
                negativas = negativas + 1
            End If
            NotaTotal = NotaTotal + NotaAluno
            i = i + 1
        End While
        Console.WriteLine("Professor esta turma teve " & positivas & " notas positivas e " & negativas & " notas negativas.")
        Console.WriteLine("A nota média foi " & NotaTotal / NumeroAlunos)
        Console.ReadLine()

    End Sub

End Module
