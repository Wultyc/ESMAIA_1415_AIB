Module Module1

    Sub Main()
        Dim mensage As String
        Dim cripted As String
        Dim code As String
        Dim alfabt As String
        Dim i As Integer

        code = "4No3XizAsCgGrqSyxeFYJ8L6mWPktpI51cQDT9bflZvH0dnMVw"
        alfabt = "1234567890'«»\|<>€,;.:-_ºª~^´`+*¨?=)(/&%$#!@£§€{[]}abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáÁãÃâÂàÀéÉêÊíÍóÓõÕôÔúÚçÇ"
        i = 1

        Console.Write("Escreva a mensagem ")
        mensage = Console.ReadLine()

        cripted = ""

        While i <= Len(mensage)
            code = Asc(Mid(mensage, i, 1))
            cripted = cripted & Chr(Math.Round(code / 2))
            i = i + 1
        End While

        Console.Write(cripted)
        Console.Read()

    End Sub

End Module
