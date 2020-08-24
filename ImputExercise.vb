Program: Imput Exercise
Objective: Learn how imput works
Programmer: Felipe SG

Module Module1

    Sub Main()
        Console.WriteLine(vbCrLf + "Whats your name?")
        Dim name = Console.ReadLine()
        Dim currentDate = DateTime.Now
        Console.WriteLine($"{vbCrLf}Eai, {name}, Today is {currentDate:d} as {currentDate:t}")
        Console.Write(vbCrLf + "Press any key")
        Console.ReadKey(True)


    End Sub

End Module
