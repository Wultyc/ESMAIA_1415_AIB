Module Module1

    Sub Main()
        Dim palavra As String
        Dim i As Integer = 1
        Dim v, j As Integer


        'Captura do nome introduzido
        Console.Write("Escreva uma palavra ")
        palavra = Console.ReadLine

        j = Math.Round(Len(palavra) / 2)

        While i <= j
            If Mid(palavra, i, 1) <> Mid(palavra, Len(palavra) + 1 - i, 1) Then
                v = 0
                i = Len(palavra) + 1
            Else
                i = i + 1
                v = 1

            End If

        End While

        If (v = 1) Then
            Console.WriteLine("É palíndromo")
        Else
            Console.WriteLine("Não é palíndromo")
        End If

        Console.Read()
    End Sub

End Module
