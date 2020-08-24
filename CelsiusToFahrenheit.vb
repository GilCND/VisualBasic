'Program Name: Celsius_to_Fahrenheit
'Objective: Build a calculator in order to convert Celsius to Fahrenheit. 
'Programmer: Felipe SG

Module Module1

Sub Main()
	Dim num1 As Decimal
	Dim result As Decimal
  
  Console.writeline("Type the temperature in celsius")
  
  'Get the number and do the calculations
  num1 = Console.ReadLine()
  result =((num1 * (9/5)) + 32)
  
  'Print on the screen the result
  Console.WriteLine($" The temperature of {num1} is {result} in Fahrenheit")
  Console.writeline(vbCrLf + "Press any key!")
  Console.ReadKey(true)

End Sub

End Module
