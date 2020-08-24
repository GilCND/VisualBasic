'------------------------------------------------------------------------------------------------
'Program Info
'------------------------------------------------------------------------------------------------
'Program: Data Types
'Date: 30/09/2019
'Autor: Felipe SG
'Operation: This program will prompt the user for information about:
'           User's date of birth
'           User's Full Name 
'           User's bank acc balance                                         
'           User's Hapyness Yes or No                                       
'           User's scalefrom 1 to 10 to awesomeness
'           User's car Odometer value
'The program should print on the screen:       
'           User's Full name, date of birth and age 
'           User's bank balance
'           Inform the value of pi
'           Inform the temperature today
'           Inform user's car Odometer value
'           Inform the sacle of awesomeness
'           Inform the next class scheduled 
'------------------------------------------------------------------------------------------------
'Change Log
'------------------------------------------------------------------------------------------------
' Date              Programmer              Change
'------------------------------------------------------------------------------------------------
'30/09/2019         Felipe SG           Initial Version


Module Module1

    Sub Main()
        Dim DateBirth As Date
        Dim AccBalance As Decimal
        Dim Awesomeness As UInt16
        Dim YourName As String
        Dim Happyness As Boolean
        Dim Odo As Long
        Dim Age As SByte
        Dim Pi As Decimal
        Dim Celsius As Short
        Dim Schedule As String

        '__________________________________________________________________________________________________________

        Console.WriteLine("What's the date of your birth?")
        DateBirth = Console.ReadLine()
        Console.WriteLine("What's your age?")
        Age = Console.ReadLine()
        Console.WriteLine("Whats your full name")
        YourName = Console.ReadLine()
        Console.WriteLine("Whats your acc balance")
        AccBalance = Console.ReadLine()
        Console.WriteLine("Are you happy? 1 for Yes or 0 for No")
        Happyness = Console.ReadLine()
        Console.WriteLine("In 1 to 10 how awesomeness programming are? ")
        Awesomeness = Console.ReadLine()
        Console.WriteLine("Whats the value of your odometer's car?")
        Odo = Console.ReadLine()

        '__________________________________________________________________________________________________________
        Pi = 3.14
        Celsius = 25
        Schedule = 8


        ' Print to user the values
        '__________________________________________________________________________________________________________
        Console.WriteLine("---------------------------------------------------------------------------------")
        Console.WriteLine($"Hello {YourName}")
        Console.WriteLine($"The date of your birth is {DateBirth}")
        Console.WriteLine($"so you have {Age} years old")
        Console.WriteLine($"You have only $ {AccBalance}")
        Console.WriteLine($"Today the temperature is {Celsius} celsius")
        Console.WriteLine($"Your car has {Odo} Km")
        Console.WriteLine($"You think that programmming is {Awesomeness} in a scale of 1 to 10")
        Console.WriteLine($"Your next class will be at {Schedule} AM")
        Console.WriteLine($"By the way the value of pi is {Pi}")
        Console.WriteLine("---------------------------------------------------------------------------------")
        Console.ReadKey(True)



    End Sub

End Module
