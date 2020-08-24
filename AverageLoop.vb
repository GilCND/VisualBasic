'------------------------------------------------------------------------------------------------
'Program Info
'------------------------------------------------------------------------------------------------
'Program: Average Loop
'Date: 30/10/2019
'Autor: Felipe SG
'Operation: Using loops in order to calculate the average of arbitrary amount of numbers 
'It should calculate the average of all numbers entered by user.
'Invalid numbers should be pointed
'Should print the sum of numbers entered
'Should print the number of numbers entered
'Should print the average of numbers 

'------------------------------------------------------------------------------------------------
'Change Log
'------------------------------------------------------------------------------------------------
' Date              Programmer              Change
'------------------------------------------------------------------------------------------------
'30/10/2019         Felipe SG            Initial Version

Module Module1

    Sub Main()
        Dim Number As String
        Dim Old As Decimal
        Dim Average As Decimal
        Dim Counter As Integer = 1
        Dim YesNo As String


        'This loop waits until the variable YesNo receives the value "y" to jump out the loop
       
       Do Until YesNo = "y"
            Console.Clear()
            Console.WriteLine("Please inform numbers to calculate the average.")
            Number = Console.ReadLine()

            'In order to validate the input, this If statement only "accepts" numbers
            If IsNumeric(Number) Then
                Old = Old + Number
                Average = Old / Counter
                Counter += 1
                If Counter > 2 Then
                    Console.Clear()
                    Console.WriteLine("Is that all? (Y or N)")
                    YesNo = Console.ReadLine
                End If
            End If

            'Here is where we promp the user withh all infotmation needed
        Loop
        Console.Clear()
        Console.WriteLine("--------------------------------------------------------")
        Console.WriteLine($"The Sum of {Counter - 1} numbers is {Old.ToString("n2")}")
        Console.WriteLine($"The average Is {Average.ToString("n2")}")
        Console.WriteLine("--------------------------------------------------------")
        Console.WriteLine("Press any key to close it")
        Console.ReadKey()

    End Sub

End Module
