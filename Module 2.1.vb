Public Class 

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Count As Integer
        Console.Write("Enter number of donuts: ")
        Count = Console.ReadLine()
        If Count < 10 Then
            Console.WriteLine("Number of donuts: " & Count)
        Else : Console.WriteLine("Number of donuts: many")
        End If
        Console.ReadKey()



    End Sub
End Class
