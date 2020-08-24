'------------------------------------------------------------------------------------------------
'Program Info
'------------------------------------------------------------------------------------------------
'Program: Haircut payment system
'Date: 25/10/2019
'Autor: Felipe SG
'Operation: This program should: 
'Output the Available Services for selection
'Allow the user to pick a service
'Calculate the discount of 10% to senior 65 and over
'Calculate the sales tax (15%)
'Calculate the final total
'Allow the user to enter the money the customer gives to pay the bill
'Calculate and display the change to give back to the customer
'Show a sales slip


'------------------------------------------------------------------------------------------------
'Change Log
'------------------------------------------------------------------------------------------------
' Date              Programmer              Change
'------------------------------------------------------------------------------------------------
'25/10/2019         Felipe SG           Initial Version

Module Module1

    Sub Main()
        'variables
        Dim service, service_selected, tax As String
        Dim price, age, discount, final_price, payed, change, price_taxed, price_elder As Decimal
        'constants
        tax = 0.15
        discount = 0.1

        Console.WriteLine("---------Welcome to Sally’s Shear Delight----------")
        Console.WriteLine("___________________________________________________")
        Console.WriteLine("---------------Please selec 1 service--------------")
        Console.WriteLine("___________________________________________________")
        Console.WriteLine("-1------Men’s dry cut----------------------|$18.75|")
        Console.WriteLine("-2------Men’s wash and cut-----------------|$29.50|")
        Console.WriteLine("-3------Ladies wash, cut & blow dry--------|$38.75|")
        Console.WriteLine("-4------Ladies color, cut & style----------|$79.80|")
        Console.WriteLine("-5------Ladies color, foils, cut & style---|$95.50|")
        Console.WriteLine("___________________________________________________")
        service = Console.ReadLine()



        'The program should check what service where selected an set the
        'price and the details of that specific service to its variables
        '__________________________________________________________________________________________
        Select Case service
            Case 1
                price = 18.75
                service_selected = "Men’s dry cut"
            Case 2
                price = 29.5
                service_selected = "Men’s wash and cut"
            Case 3
                price = 38.75
                service_selected = "Ladies wash, cut & blow dry"
            Case 4
                price = 79.8
                service_selected = "Ladies color, cut & stylet"
            Case 5
                price = 95.5
                service_selected = "Ladies color, foils, cut & style"
        End Select



        'Calculate the tax and the discount
        '__________________________________________________________________________________________

        price_taxed = price * tax
        price_elder = price * discount




        'Here is the part where the if statement will determine witch path to take depending on age
        '__________________________________________________________________________________________
        Console.WriteLine("What's the customer's age ")
        age = Console.ReadLine()

        If age > 64 Then
            Console.Clear()
            final_price = (price - price_elder) + price_taxed
            Console.WriteLine($"TOTAL = |{final_price.ToString("n2")}|")
            Console.WriteLine("Please inform the amount payed")
            payed = Console.ReadLine()
            change = (payed.ToString("n2") - final_price.ToString("n2"))
            Console.WriteLine("____________________________________________________________")
            Console.WriteLine($"The change will be $:{change.ToString("n2")}")
            Console.WriteLine("____________________________________________________________")
            Console.WriteLine("Press any key to print the receipt")
            Console.ReadKey(True)

            Console.Clear()
            Console.WriteLine("")
            Console.WriteLine("#################*Sally’s Shear Delight*####################")
            Console.WriteLine("")
            Console.WriteLine("=======================|RECEIPT|============================")
            Console.WriteLine("")
            Console.WriteLine("------------------------------------------------------------")
            Console.WriteLine($"|Service               | {service_selected}")
            Console.WriteLine("|                      |------------------------------------")
            Console.WriteLine($"|Price                 | =${price.ToString("n2")}")
            Console.WriteLine("|                      |------------------------------------")
            Console.WriteLine($"|Senior Discount 10%   | =-${price_elder.ToString("n2")}")
            Console.WriteLine("|                      |------------------------------------")
            Console.WriteLine($"|Tax 15%               | =${price_taxed.ToString("n2")}")
            Console.WriteLine("|                      |------------------------------------")
            Console.WriteLine($"|TOTAL                 | =${final_price.ToString("n2")}")
            Console.WriteLine("|                      |------------------------------------")
            Console.WriteLine($"|PAYED                 | =${payed.ToString("n2")}")
            Console.WriteLine("|                      |------------------------------------")
            Console.WriteLine($"|CHANGE                | =${change.ToString("n2")}")
            Console.WriteLine("|                      |------------------------------------")
            Console.WriteLine("____________________________________________________________")
            Console.WriteLine("                                                            ")
            Console.WriteLine("                    Have a Great Day!                       ")
            Console.WriteLine("____________________________________________________________")
        Else
            Console.Clear()
            final_price = price + price_taxed
            Console.WriteLine($"TOTAL = |${final_price.ToString("n2")}|")
            Console.WriteLine("Please inform the ammount payed")
            payed = Console.ReadLine()

            change = (payed.ToString("n2") - final_price.ToString("n2"))
            Console.WriteLine("____________________________________________________________")
            Console.WriteLine($"The change will be $:{change.ToString("n2")}")
            Console.WriteLine("____________________________________________________________")
            Console.WriteLine("Press any key to print the receipt")
            Console.ReadKey(True)

            Console.Clear()
            Console.WriteLine("")
            Console.WriteLine("#################*Sally’s Shear Delight*####################")
            Console.WriteLine("")
            Console.WriteLine("=======================|RECEIPT|============================")
            Console.WriteLine("")
            Console.WriteLine("------------------------------------------------------------")
            Console.WriteLine($"|Service               | {service_selected}")
            Console.WriteLine("|                      |------------------------------------")
            Console.WriteLine($"|Price                 | =${price.ToString("n2")}")
            Console.WriteLine("|                      |------------------------------------")
            Console.WriteLine($"|Tax 15%               | =${price_taxed.ToString("n2")}")
            Console.WriteLine("|                      |------------------------------------")
            Console.WriteLine($"|TOTAL                 | =${final_price.ToString("n2")}")
            Console.WriteLine("|                      |------------------------------------")
            Console.WriteLine($"|PAYED                 | =${payed.ToString("n2")}")
            Console.WriteLine("|                      |------------------------------------")
            Console.WriteLine($"|CHANGE                | =${change.ToString("n2")}")
            Console.WriteLine("|                      |------------------------------------")
            Console.WriteLine("____________________________________________________________")
            Console.WriteLine("                                                            ")
            Console.WriteLine("                    Have a Great Day!                       ")
            Console.WriteLine("____________________________________________________________")
        End If



        Console.ReadKey(True)
    End Sub
End Module
