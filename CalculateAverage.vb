'Program Name: Calculate_Average
'Objective: Calculate the average of 3 numbers typed by the user. 
'Programmer: Felipe SG

Module Module1

    Dim num1 As Integer
    Dim num2 As Integer
    Dim num3 As Integer
  	Dim result As Integer
    
'Request the numbers from the user and save each on its variable
    Sub Main(args as string())
Console.writeline(vbCrLf + "Type number 1")
num1 = Console.ReadLine()
Console.writeline(vbCrLf + "Type number 2")
num2 = Console.ReadLine()
Console.writeline(vbCrLf + "Type number 3")
num3 = Console.ReadLine()

'Calculate the average
result =(num1 + num2 + num3)/3

'Print the result
Console.WriteLine($"{vbCrLf}The average of, {num1},{num2} and {num3} is {result}")
Console.writeline(vbCrLf + "Press any key!")
Console.ReadKey(true)

    End Sub

End Module
