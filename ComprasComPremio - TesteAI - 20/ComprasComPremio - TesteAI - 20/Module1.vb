Module Module1

    Sub Main()
        Dim n, x, i, num, valormin As Integer
        Console.Write("Qual é o número de Clientes? ")
        n = Console.ReadLine - 1
        Console.Write("Qual o numero total de compras feitas? ")
        x = Console.ReadLine - 1
        Dim Nomes(n), premiado As String
        Dim Cliente(x) As Integer
        Dim Vendas(x) As Decimal
        valormin = 999999999
        premiado = ""

        For i = 0 To n
            Console.Write("Nome do Cliente nº " & i + 1 & ": ")
            Nomes(i) = Console.ReadLine()
        Next

        For i = 0 To x
            Console.WriteLine("---------------------------------- Venda Nº" & i + 1 & " -----------------------------------")
            Console.Write("Nº do Cliente: ")
            Cliente(i) = Console.ReadLine - 1
            Console.Write("Valor da Compra: ")
            Vendas(i) = Console.ReadLine
        Next

        Randomize()
        num = Int(Rnd() * n)

        For i = 0 To x
            If Cliente(i) = num Then
                If Vendas(i) <= valormin Then
                    valormin = Vendas(i)
                    premiado = Nomes(Cliente(i))
                End If
            End If
        Next

        For i = 0 To 79
            Console.Write("-")
        Next
        Console.WriteLine()


        Console.Write("Nomes:   |  ")
        For i = 0 To n
            Console.Write(Nomes(i) & " |  ")
        Next
        Console.WriteLine()

        Console.Write("Cliente: |  ")
        For i = 0 To x
            Console.Write(Cliente(i) + 1 & " |  ")
        Next
        Console.WriteLine()

        Console.Write("Vendas:  |  ")
        For i = 0 To x
            Console.Write(Vendas(i) & " |  ")
        Next
        Console.WriteLine()

        Console.Write("Valor Gerado: " & num + 1 & "       Cliente: " & premiado & "       Vale: " & valormin)


        Console.Read()

    End Sub

End Module
