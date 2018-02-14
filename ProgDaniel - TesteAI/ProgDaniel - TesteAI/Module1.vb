Module Module1

    Sub Main()
        Randomize()
        Dim n, x, r, vm, sent As Integer
        Console.Write("Insira o número de clientes: ")
        n = Console.ReadLine()
        Dim nomes(n) As String
        For i = 1 To n
            Console.Write("Insira o nome do cliente nº " & i & ": ")
            nomes(i) = Console.ReadLine()
        Next

        Console.Write("Insira o número de vendas: ")
        x = Console.ReadLine()

        Dim vendas(x) As Integer
        Dim cliente(x) As Integer

        For i = 1 To x
            Console.Write("Insira o nº do cliente da " & i & "ª venda: ")
            cliente(i) = Console.ReadLine()
            If cliente(i) > n Then
                Console.WriteLine("Cliente inválido! Volte a inserir.")
                i = i - 1
            Else
                Console.Write("Insira o valor da compra efetuada pelo/a " & nomes(cliente(i)) & ": ")
                vendas(i) = Console.ReadLine()
            End If

        Next
        vm = 999999
        sent = 0
        r = Int(Rnd() * n) + 1
        For i = 1 To x
            If cliente(i) = r And vendas(i) < vm Then
                vm = vendas(i)
                sent = 1
            End If
        Next
        If sent = 1 Then
            Console.WriteLine("Valor gerado: " & r)
            Console.WriteLine("Cliente : " & nomes(r))
            Console.WriteLine("Vale: " & vm)
        Else
            Console.WriteLine("Valor gerado: " & r)
            Console.WriteLine("Cliente : " & nomes(r))
            Console.WriteLine("O cliente selecionado não efetuou qualquer compra.")
        End If


        Console.Read()
    End Sub

End Module
