Program: Imput_Exercise. 
Objective: Practice Imputs. 
Programmer: Felipe SG


Module Module1

    Sub Main(args as string())
Console.writeline(vbCrLf + "Whats your favorite color")
Dim color = Console.ReadLine()
Console.writeline($"{vbCrLf} You favorite color is {color}")
Console.writeline(vbCrLf + "press any key")
Console.ReadKey(true)

    End Sub

End Module
