Module Module1

    Sub Main()
        Dim numero As Integer
        numero = Console.ReadLine()

        Dim numeroCortado As Integer
        numeroCortado = 0

        Dim numeroOperado As Integer
        numeroOperado = 0

        Dim divisor As Integer
        divisor = 10

        While Int(numero / divisor) <> 0
            divisor = divisor * 10

        End While

        While divisor <> 0
            divisor = divisor / 10
            numeroOperado = Int(numero / divisor)
            numeroCortado = numeroOperado * divisor
            numero = numero - numeroCortado
            Console.WriteLine(numeroOperado)

        End While

        Console.Read()

    End Sub

End Module
