'------------------------------------------------------------------------------------------------
'Program Info
'------------------------------------------------------------------------------------------------
'Program: Gas Guzzler
'Date: 27/09/2019
'Autor: Felipe SG
'Operation: This program will prompt the user for information about a car trip.
'           It calculates all parameter of the trip.
'           After the calculation it prints to user what was the distance traveled in kilometers
'                                                   What was the distance traveled in miles
'                                                   how much gas it used in gallons
'                                                   how much it did in miles per gallon
'                                                   Houw much the travel cost in dollars per Kilometer
'------------------------------------------------------------------------------------------------
'Change Log
'------------------------------------------------------------------------------------------------
' Date              Programmer              Change
'------------------------------------------------------------------------------------------------
'27/09/2019         Felipe SG           Initial Version



Module Module1

    Sub Main()

        Dim Odo_Start As Decimal
        Dim Odo_End As Decimal
        Dim Fuel_Used As Decimal
        Dim Gas_Cost As Decimal

        ' Ask user to for data
        '-------------------------------------------------------------------------------------------------------
        Console.WriteLine("_______________________________________________")
        Console.WriteLine("Please Inform the Value Displayed on the Odometer when the travel STARTS")
        Console.WriteLine("Please inform the value in KILOMETERS")
        Odo_Start = Console.ReadLine()

        Console.WriteLine("_______________________________________________")
        Console.WriteLine("Please Inform the Value Displayed on the Odometer when the travel ENDS")
        Console.WriteLine("Please inform the value in KILOMETERS")
        Odo_End = Console.ReadLine()

        Console.WriteLine("_______________________________________________")
        Console.WriteLine("Please Inform the Amount of fuel used")
        Console.WriteLine("Please inform the value in LITERS")
        Fuel_Used = Console.ReadLine()

        Console.WriteLine("_______________________________________________")
        Console.WriteLine("Please Inform the gas cost")
        Console.WriteLine("Please inform all the amount spent on the FULL travel")
        Gas_Cost = Console.ReadLine()
        Console.WriteLine("_______________________________________________")

        ' Calculations
        '-------------------------------------------------------------------------------------------------------

        Console.WriteLine("")
        Console.WriteLine("You traveled")
        Console.WriteLine($"{(Odo_End - Odo_Start).ToString("n2")} Kilometers")
        Console.WriteLine("---------------------------------------------------------------------------------")

        Console.WriteLine("You traveled")
        Console.WriteLine($"{((Odo_End - Odo_Start) * 0.621371).ToString("n2")} Miles")
        Console.WriteLine("---------------------------------------------------------------------------------")

        Console.WriteLine("You used")
        Console.WriteLine($"{(Fuel_Used * 0.264172).ToString("n2")} Gallons")
        Console.WriteLine("---------------------------------------------------------------------------------")

        Console.WriteLine("You did")
        Console.WriteLine($"{(((Odo_End - Odo_Start) * 0.621371) / (Fuel_Used * 0.264172)).ToString("n2")}  Miles per Gallon")
        Console.WriteLine("---------------------------------------------------------------------------------")

        Console.WriteLine("You did")
        Console.WriteLine($"{(Gas_Cost / (Odo_End - Odo_Start)).ToString("n2") } Dollars per Kilometer")
        Console.WriteLine("---------------------------------------------------------------------------------")

        Console.WriteLine("Press Any key to EXIT")
        Console.WriteLine("---------------------------------------------------------------------------------")
        Console.ReadKey(True)

    End Sub

End Module
