Module Module1

    Sub Main()
        Dim n1, n2, n3 As Single

        Console.Write("Introduza a 1ª Nota: ")
        n1 = Console.ReadLine()

        Console.Write("Introduza a 2ª Nota: ")
        n2 = Console.ReadLine()

        Console.Write("Introduza a 3ª Nota: ")
        n3 = Console.ReadLine()

        If ((n1 + n2 + n3) / 3 >= 15) Then
            Console.WriteLine("Parabéns!")
        Else
            Console.Write("Não Aprovado")
        End If

        Console.Read()
    End Sub

End Module
