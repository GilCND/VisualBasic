'Program Name: Sum
'Objective: Sum 2 numbers
'Programmer: Felipe SG

Module Module1

    Public num1 As Integer
    Public num2 As Integer
    Public answer As Integer
   
   Sub Main()

        Console.WriteLine("Type a number and press Enter")
        num1 = Console.ReadLine()
        Console.WriteLine("Type another number to ad to it and press Enter")
        num2 = Console.ReadLine()
        answer = num1 + num2
        Console.WriteLine("The Answer is " & answer)
        Console.ReadLine()

    End Sub

End Module
