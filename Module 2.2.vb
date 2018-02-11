Public Class 

    Private Sub 
        Dim text As String
        Console.Write("Enter string: ")
        text = Console.ReadLine
        If Len(text) < 2 Then
            Console.WriteLine("")
        Else : Console.WriteLine(Left(text, 2) & Right(text, 2))
        End If
        Console.ReadKey()

    End Sub
End Class
