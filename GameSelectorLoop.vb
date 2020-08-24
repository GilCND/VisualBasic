'------------------------------------------------------------------------------------------------
'Program Info
'------------------------------------------------------------------------------------------------
'Program: Game Selector LOOP
'Date: 01/11/2019
'Autor: Felipe SG
'
'------------------------------------------------------------------------------------------------
'Change Log
'------------------------------------------------------------------------------------------------
' Date              Programmer              Change
'------------------------------------------------------------------------------------------------
'01/11/2019         Felipe SG         Initial Version

Module Module1

    Sub Main()
        Dim game As String
        Dim validate As String = "x"
        Dim Name1 As String
        Dim Name2 As String
        Dim Name3 As String
        Dim Name4 As String

        ' The loop will repeat itself until the condition validate equals to Y or y
        Do Until validate = "y"
            Console.Clear()
            Console.WriteLine("------List of Games-----")
            Console.WriteLine("------------------------")
            Console.WriteLine("-Doom ---------------- 1")
            Console.WriteLine("-Double Dragon ------- 2")
            Console.WriteLine("-Enduro -------------- 3")
            Console.WriteLine("-Frogger ------------- 4")
            Console.WriteLine("-Mario --------------- 5")
            Console.WriteLine("-Pitfall! ------------- 6")
            Console.WriteLine("-Pong ---------------- 7")
            Console.WriteLine("-Quake --------------- 8")
            Console.WriteLine("-Space Invaders ------ 9")
            Console.WriteLine("-Zelda -------------- 10")
            Console.WriteLine("------------------------")
            Console.WriteLine("-Please select one GAME-")
            game = Console.ReadLine()

            'If it's numeric and between a range of 1 to 10 the case will be avaiable
            If IsNumeric(game) Then
                If game >= 1 And game <= 10 Then

                    Select Case game
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
                    Select Case game
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
                            Console.WriteLine("You have selected the game Pitfall!")
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
                    Console.WriteLine("Type y to run the game")
                    validate = Console.ReadLine().ToLower
                Else
                    Console.WriteLine("Invalid Selection")
                    Console.WriteLine("Just numbers 1 to 10")
                    Console.ReadKey()
                End If
            Else
                Console.WriteLine("Invalid Selection")
                Console.WriteLine("Just numbers 1 to 10")
                Console.ReadKey()
            End If
        Loop

    End Sub

End Module

