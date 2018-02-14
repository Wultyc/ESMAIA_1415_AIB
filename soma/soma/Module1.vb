Module Module1

    Sub Main()
        Dim num As Single
        Dim divide As Single
        Dim vdivide As Single
        Dim soma As Single

        divide = 1
        soma = 0
        vdivide = 1

        Console.Write("Escreva um numero inteiro ")
        num = Console.ReadLine()

        While vdivide <> 0
            divide = divide * 10
            vdivide = Int(num / divide)
        End While
        divide = divide / 10
        While divide <> 0.0
            soma = soma + Int(num / divide)
            num = num - Int(num / divide) * divide
            divide = divide / 10
        End While

        Console.WriteLine(soma)
        Console.ReadLine()

    End Sub

End Module
