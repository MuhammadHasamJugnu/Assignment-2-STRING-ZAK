﻿Public Class 

    Private Sub 
        Dim s As String
        Dim first As Char
        Dim symb As Char = "*"
        Dim newS As String
        Console.Write("Enter string: ")
        s = Console.ReadLine()
        first = s(0)
        newS = first
        For i = 1 To Len(s) - 1
            If s(i) <> first Then
                newS = newS & s(i)
            Else : newS = newS & symb
            End If
        Next
        Console.WriteLine(newS)
        Console.ReadKey()
    End Sub
End Class
