'------------------------------------------------------------------------------------------------
'Program Info
'------------------------------------------------------------------------------------------------
'Program: Game Selector
'Date: 18/10/2019
'Autor: Felipe SG
'Operation: 
'Prompts the user To Select one Of 10 different games. 
'Once the Game has been selected, 
'the number Of players should be prompted. 
'Games 1, 3 And 5 are 1 player games. Games 2, 4 And 6 are 2 Player Games
'All remaining games are 4 player games. 
'Once the number Of players have been selected
'Prompt For their names.
'Report the Selected Game, how many players the game has And Each player's Name to the console.


'------------------------------------------------------------------------------------------------
'Change Log
'------------------------------------------------------------------------------------------------
' Date              Programmer              Change
'------------------------------------------------------------------------------------------------
'18/10/2019         Felipe SG        Initial Version


Module Module1

    Sub Main()
        Dim Game As String
        Dim Name1 As String
        Dim Name2 As String
        Dim Name3 As String
        Dim Name4 As String

        Console.WriteLine("------List of Games-----")
        Console.WriteLine("------------------------")
        Console.WriteLine("-Doom ---------------- 1")
        Console.WriteLine("-Double Dragon ------- 2")
        Console.WriteLine("-Enduro -------------- 3")
        Console.WriteLine("-Frogger ------------- 4")
        Console.WriteLine("-Mario --------------- 5")
        Console.WriteLine("-Pitfal! ------------- 6")
        Console.WriteLine("-Pong ---------------- 7")
        Console.WriteLine("-Quake --------------- 8")
        Console.WriteLine("-Space Invaders ------ 9")
        Console.WriteLine("-Zelda -------------- 10")
        Console.WriteLine("------------------------")
        Console.WriteLine("-Please select one GAME-")
        Game = Console.ReadLine()

        'This first case is used to assign values to variables
        '------------------------------------------------------------
        Select Case True
            Case Not (IsNumeric(Game))
                Console.WriteLine("ERROR, Please use Numbers")
            Case Game < 0 Or Game > 10 Or Game = 0
                Console.WriteLine("ERROR, Please Select a number from 1 to 10")
            Case Else
                Console.WriteLine("------------------------")
        End Select
        Select Case Game
            Case 1, 3, 5
                Console.WriteLine("For the game selected only 1 Player allowed")
                Console.WriteLine("Please inform the name of Player 1")
                Name1 = Console.ReadLine()
            Case 2, 4, 6
                Console.WriteLine("For the game selected only 2 Players allowed")
                Console.WriteLine("Please inform the name of Player 1")
                Name1 = Console.ReadLine()
                Console.WriteLine("Please inform the name of Player 2")
                Name2 = Console.ReadLine()
            Case 7, 8, 9, 10
                Console.WriteLine("For the game selected only 4 Players allowed")
                Console.WriteLine("Please inform the name of Player 1")
                Name1 = Console.ReadLine()
                Console.WriteLine("Please inform the name of Player 2")
                Name2 = Console.ReadLine()
                Console.WriteLine("Please inform the name of Player 3")
                Name3 = Console.ReadLine()
                Console.WriteLine("Please inform the name of Player 4")
                Name4 = Console.ReadLine()
        End Select
        'This case is used to print personalized messages to the user
        '------------------------------------------------------------
        Select Case Game
            Case 1
                Console.WriteLine("------------------------------------")
                Console.WriteLine("You have selected the game DOOM")
                Console.WriteLine("This game is single player")
                Console.WriteLine($"Go ahead {Name1} KILL some monsters")
                Console.WriteLine($"By the way, DDDQD might help")
                Console.WriteLine("------------------------------------")
            Case 5
                Console.WriteLine("--------------------------------------")
                Console.WriteLine("You have selected the game Mario")
                Console.WriteLine("This game is single player")
                Console.WriteLine($"Go ahead {Name1} Do not let Yoshi die")
                Console.WriteLine("--------------------------------------")
            Case 3
                Console.WriteLine("----------------------------------------")
                Console.WriteLine("You have selected the game Enduro")
                Console.WriteLine("This game is single player")
                Console.WriteLine($"Go ahead {Name1} run Forest!")
                Console.WriteLine("----------------------------------------")
            Case 2
                Console.WriteLine("----------------------------------------")
                Console.WriteLine("You have selected the game Double Dragon")
                Console.WriteLine("This game is 2 players game")
                Console.WriteLine($"Go ahead {Name1} Fight for your life")
                Console.WriteLine($"And {Name2} dont let {Name1} die!")
                Console.WriteLine("----------------------------------------")
            Case 4
                Console.WriteLine("----------------------------------------")
                Console.WriteLine("You have selected the game Frogger")
                Console.WriteLine("This game is 2 players game")
                Console.WriteLine($"Go ahead {Name1} Cross that road")
                Console.WriteLine($"And {Name2} dont be smashed like {Name1}")
                Console.WriteLine("----------------------------------------")
            Case 6
                Console.WriteLine("----------------------------------------")
                Console.WriteLine("You have selected the game Pitfal!")
                Console.WriteLine("This game is 2 players game")
                Console.WriteLine($"Go ahead {Name1} jump jump jump jump")
                Console.WriteLine($"And {Name2} jump around.. jump jump jump")
                Console.WriteLine("----------------------------------------")

            Case 7
                Console.WriteLine("----------------------------------------")
                Console.WriteLine("You have selected the game Pong")
                Console.WriteLine("This game is 4 players game")
                Console.WriteLine($"{Name1} ponged {Name2} that")
                Console.WriteLine($"ponged {Name3} that ponged {Name4}")
                Console.WriteLine("----------------------------------------")

            Case 8
                Console.WriteLine("----------------------------------------")
                Console.WriteLine("You have selected the game Quake")
                Console.WriteLine("This game is 4 players game")
                Console.WriteLine($"Its not 4 players in fact, Lets do it in turns: first {Name1}")
                Console.WriteLine($"When he dies {Name2} should grab the control")
                Console.WriteLine($"{Name3} You're next")
                Console.WriteLine($"please {Name4} dont be like your friends, you are the last chance")
                Console.WriteLine("----------------------------------------")
            Case 9
                Console.WriteLine("----------------------------------------")
                Console.WriteLine("You have selected the game Space Invaders")
                Console.WriteLine("This game is 4 players game (or not)")
                Console.WriteLine($"Go ahead {Name1}, {Name2}, {Name3}, and {Name4}")
                Console.WriteLine($"Save the earth")
                Console.WriteLine("----------------------------------------")
            Case 10
                Console.WriteLine("----------------------------------------")
                Console.WriteLine("You have selected the game Zelda")
                Console.WriteLine("This game is 4 players game (really??)")
                Console.WriteLine($"{Name1} The name of the main char its not Zelda")
                Console.WriteLine($"{Name2} You are the only one who knows his name right?")
                Console.WriteLine($"Sorry {Name3} and {Name4} as i said, it's not Zelda")
                Console.WriteLine($"I Will send to you guys a LINK with his name")
                Console.WriteLine("----------------------------------------")
        End Select
        Console.WriteLine("------Pres any key------")
        Console.ReadKey(True)
    End Sub

End Module
