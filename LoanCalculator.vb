Program: Loan_Calculator
Objective: Calculate the loan 
Programmer: Felipe SG


Module Module1

    Sub Main()
        'R = Interest rate
        Dim R As Decimal
        Dim R1 As Decimal
        'P = Principal Amount of the Loan
        Dim P As Decimal
        'N = Total months for the Loan
        Dim N As Decimal
        'result1 = fisrt part of the formula (r*p)
        Dim result1 As Decimal
        'result2 = Seccond part of the formula (1-(1+R)^N
        Dim result2 As Decimal
        'result3 = result 1 divided by result 2
        Dim result3 As Decimal
        'Final = result 3 multiplied by N
        Dim Final As Decimal
        'Its the difference paid on the end of contract
        Dim Dif As Decimal
        'Ask user to insert the amount of loan
        Console.WriteLine("Enter the loan amount")
        'save the information
        P = Console.ReadLine()
        'Ask user to insert annual Interest Rate
        Console.WriteLine("Enter the annual Interest Rate")
        'save the information
        R1 = Console.ReadLine()
        'Ask user to insert the loan period in months
        Console.WriteLine("Enter the loan period in months")
        'save the information
        N = Console.ReadLine()
        'Calculate R dividing the annual Interest rate by 100 and by 12 to have it bu month
        R = ((R1 / 100) / 12)
        'Fisrt part of formula
        result1 = (R * P)
        'Second part of formula
        result2 = 1 - (1 + R) ^ (-N)
        'Third part of formula
        result3 = result1 / result2
        'Final part of the formula 
        Final = result3 * N
        'Calculate interest 
        Dif = (Final - P)
        'Print all the information to user
        Console.WriteLine("Loan amount")
        Console.WriteLine("-----------")
        Console.WriteLine($"{P}")
        Console.WriteLine("Interest Rate")
        Console.WriteLine("-----------")
        Console.WriteLine($"{R1}%")
        Console.WriteLine("Number of Months")
        Console.WriteLine("-----------")
        Console.WriteLine($"{N}")
        'Print the total cost of loan wih 2 decimals
        Console.WriteLine($"Total cost of the Loan  {Final.ToString("n2")}")
        'Print the total interest of loan wih 2 decimals
        Console.WriteLine($"Total Interest  {Dif.ToString("n2")}")
        Console.WriteLine("Press any key!")
        Console.ReadKey(True)

    End Sub

End Module
