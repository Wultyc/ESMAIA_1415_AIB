Module Module1

    Sub Main()
        Dim tabuada As Integer

        Console.Write("Qual é a tabuada? ")
        tabuada = Console.ReadLine()

        For i As Integer = 1 To 10
            If (i < 10) Then
                Console.WriteLine(i & "  x " & tabuada & " = " & i * tabuada)
            Else
                Console.WriteLine(i & " x " & tabuada & " = " & i * tabuada)
            End If

        Next
        Console.Read()
    End Sub

End Module
