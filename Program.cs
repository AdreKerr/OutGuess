using System.Runtime.InteropServices;

namespace RadomNumberGuessingGame {
    internal class Program {
        static void Main(string[] args) {


            //funciotn being call

            //FlickerGameOver();

            OutGuessAdd();

            //SPACE
            Spaces4();





        }//end main

        /*
        static void RandomNumberGuessingGame() {
            //VARIABLES
            int gessuesNumber = 0;
            //int guesses = 10;



            //INPUT

            //LOOPS
            for (int guess = 10; guess > 0 ; guess--) {


            }//END FOR


            //IF


            //OUTPUT



        }//END FUNCITON

        */
        /*
        static void OutGuess() {
            //MAKE OUTGUESS PROGRAM
            while (true) {
                //interduction
                Fancy("Welcome To Guess A Number");
               //Variables
               Random RNG = new Random();
               int cpuNum = RNG.Next(1,101);
               int playerNumber = 0;
                //RULES OF GAME     
                Console.WriteLine("YOU HAVE 10 TRIES TO GUESS THE RIGHT NUMBER 1-100. IF YOU CAN NOT GUESS THE RIGHT NUMBER TO WILL LOSS THE GAME.\nHAVE FUN PLAYING AND GUESSING ");
                  //LOOP
                  for (int guesses = 10; guesses > 0; guesses--) {
                     Spaces1();
                     playerNumber = PromptIntTry("Enter your guess?: ");
                     Spaces1();
                    //IF ELSE STATMENT
                     if (playerNumber > 100 || playerNumber < 1) {
                        FlickerError();
                        Console.WriteLine("YOU NEED TO ENTER A NUMBER 1-100!!!");
                        //ColorText("ERROR!!!!", ConsoleColor.DarkRed);
                        ColorText($"You have {guesses - 1} guesses left", ConsoleColor.Gray);
                     } else if (cpuNum > playerNumber) {
                        ColorText("Your guess is to low", ConsoleColor.Yellow);
                        ColorText($"You have {guesses - 1} guesses left", ConsoleColor.Gray);
                     } else if (cpuNum < playerNumber) {
                        ColorText("Your guess is to high", ConsoleColor.DarkYellow);
                        ColorText($"You have {guesses - 1} guesses left", ConsoleColor.Gray);
                     } else if (cpuNum == playerNumber) {
                        ColorText("Your guess is right!!", ConsoleColor.Green);
                        ColorText($"You had {guesses - 1} guesses left", ConsoleColor.Gray);
                        guesses = 0;
                     } else {
                        FlickerError();
                        break;
                     }//END IF ELSE TREE
                  }//END FOR LOOP
               //OUTPUT AT END IF RAN OUT OF TURNS
                
                 FlickerGameOver();                
                 Console.WriteLine($"The Number was: {cpuNum}");
                //game end
                ENDGAME();
            }//END While
        }//END FUNCTION
        */

        static void OutGuessAdd() {

           //MAKE OUTGUESSAA PROGRAM
           while (true) {

                //TITLE
                Fancy("Welcome To Guess A Number");

                //Variables
                Random RNG = new Random();
                int playerNumber = 0;
                int playerGesses = 0;
                double cashBrought = 0.0;
                double wager = 0.0;
                double winnings = 0.0;
                double totalWinnings = 0.0;
                int GamesPlayed = 0;
                

              while (wager >= cashBrought) {


                  //RULES OF GAME
                  Console.WriteLine("This is a number guessing game where you can wager monay and how many guesses you want to use");
                  Console.WriteLine("You can only wager up to 10 guesses");
                  Console.WriteLine("THE AMOUNT OF GUESSES YOU WAGER WILL DETERMINE HOW MANY GUESSES YOU HAVE TO GUESS THE RIGHT NUMBER");
                  Console.WriteLine("THE RIGHT NUMBER IS SOMEWHERE BETWEEN 1-100. IF YOU CAN NOT GUESS THE RIGHT NUMBER YOU WILL LOSS THE GAME AND THE MONEY YOU WANTED TO WAGER ON THAT BET");
                  Console.WriteLine("HAVE FUN PLAYING, GUESSING, AND TRYNG NOT TO LOSS ALL YOUR MONEY.");

                //ASK THE USES HOW MUCH CASH THEY BROUGHT TO WAGER
                Spaces2();
                cashBrought = PromptDoulbeTry("How much cash do you want to gamble?: $");

              }//end while

                //WHILE THE LOOPS TILL MONEY RUNS OUT
                while (cashBrought > 0) {
                    for (GamesPlayed = 1; GamesPlayed > 0; GamesPlayed++) {


                        //ASK THE USES HOW MUCH THEY WANT TO BET ON THE FIRST GAME
                        wager = PromptDoulbeTry($"How much money would you like to wager on game {GamesPlayed} you have ${cashBrought} left?: $");

                        //ASK PLAYER HOW MANY GUESSES THEY WANT TO WAGER
                        playerGesses = PromptIntTry("How many guesses would you like to wager?: ");
                    
                        //RNG 
                        int cpuNum = RNG.Next(1, 101);

                        //IF FOR THE GUESSES AND LOOP TO CONTUNIE
                        if (playerGesses <= 10 && playerGesses >= 1 && wager > 0 && wager <= cashBrought) {
                        //CALCULATIONS 
                        cashBrought = cashBrought - wager;
                            //LOOP
                            for (int guesses = playerGesses; guesses > 0; guesses--) {
                                Spaces1();
                                //ASK THE PLAYER FOR THERE GUESS
                                playerNumber = PromptIntTry("Enter your guess?: ");
                                Spaces1();
                                //IF ELSE STATMENT
                                if (playerNumber > 100 || playerNumber < 1) {
                                    FlickerError();
                                    Console.WriteLine("YOU NEED TO ENTER A NUMBER 1-100!!!");
                                    //ColorText("ERROR!!!!", ConsoleColor.DarkRed);
                                    ColorText($"You have {guesses - 1} guesses left", ConsoleColor.Gray);
                                } else if (cpuNum > playerNumber) {
                                    ColorText("Your guess is to low", ConsoleColor.Yellow);
                                    ColorText($"You have {guesses - 1} guesses left", ConsoleColor.Gray);
                                } else if (cpuNum < playerNumber) {
                                    ColorText("Your guess is to high", ConsoleColor.DarkYellow);
                                    ColorText($"You have {guesses - 1} guesses left", ConsoleColor.Gray);
                                } else if (cpuNum == playerNumber) {
                                    ColorText("Your guess is right!!", ConsoleColor.Green);
                                    ColorText($"You had {guesses - 1} guesses left", ConsoleColor.Gray);
                                    if (playerGesses == 1) {
                                        winnings = wager * 10;
                                        cashBrought = winnings + cashBrought;
                                        Console.WriteLine($"You have won ${winnings}");
                                    } else if (playerGesses == 2) {
                                        winnings = wager * 9;
                                        cashBrought = winnings + cashBrought;
                                        Console.WriteLine($"You have won ${winnings}");
                                    } else if (playerGesses == 3) {
                                        winnings = wager * 8;
                                        cashBrought = winnings + cashBrought;
                                        Console.WriteLine($"You have won ${winnings}");
                                    } else if (playerGesses == 4) {
                                        winnings = wager * 7;
                                        cashBrought = winnings + cashBrought;
                                        Console.WriteLine($"You have won ${winnings}");
                                    } else if (playerGesses == 5) {
                                        winnings = wager * 6;
                                        cashBrought = winnings + cashBrought;
                                        Console.WriteLine($"You have won ${winnings}");
                                    } else if (playerGesses == 6) {
                                        winnings = wager * 5;
                                        cashBrought = winnings + cashBrought;
                                        Console.WriteLine($"You have won ${winnings}");
                                    } else if (playerGesses == 7) {
                                        winnings = wager * 4;
                                        cashBrought = winnings + cashBrought;
                                        Console.WriteLine($"You have won ${winnings}");
                                    } else if (playerGesses == 8) {
                                        winnings = wager * 3;
                                        cashBrought = winnings + cashBrought;
                                        Console.WriteLine($"You have won ${winnings}");
                                    } else if (playerGesses == 9) {
                                        winnings = wager * 2;
                                        cashBrought = winnings + cashBrought;
                                        Console.WriteLine($"You have won ${winnings}");
                                    } else if (playerGesses == 10) {
                                        winnings = wager * 1;
                                        cashBrought = winnings + cashBrought;
                                        Console.WriteLine($"You have won ${winnings}");
                                    } else {
                                        FlickerError();
                                    }//end if else in the if else
                                    guesses = 0;
                                } else {
                                    FlickerError();
                                    break;
                                }//END IF ELSE TREE

                                //CALCULATIONS
                                totalWinnings = totalWinnings + winnings;

                            }//END FOR LOOP

                        //ELSE STATMENT THAT WILL TELL IF THEY ENTER A WRONG NUMBER
                        } else if (playerGesses > 10 || playerGesses < 1 || wager <= 0 || wager > cashBrought) {
                            FlickerError();
                            Console.WriteLine("You can only have a guess 1-10");
                            break;
                        }//END IF ELSE FOR PLAYER GUESSES


                        //FIGURE OUT HOW TO END GAME IF CASHBROUGTH = 0
                        if (cashBrought == 0) {
                            FlickerGameOver();
                            Console.WriteLine($"The Number was: {cpuNum}");
                            Thread.Sleep(1000);
                            Console.Clear();
                             //CALCULATE AVERAGE
                             totalWinnings = totalWinnings / GamesPlayed;
                             Console.WriteLine($"Your total percent average of winning is: {totalWinnings}");
                            break;
                        } else {
                            //TELLS GAMES OVER 
                            FlickerGameOver();
                            Console.WriteLine($"The Number was: {cpuNum}");
                            Thread.Sleep(1000);
                            Console.Clear();
                            //game end
                        }//END IF ESLE FOR TELLLING IF YOU RAN OUT OF MONEY AND GAME OVER
                         // ENDGAME();
                        bool done = false;
                        Spaces2();
                        //ASK IF DONE PLAYING GAME
                        Console.Write("Are you DONE playing (y/n): ");
                        //done?

                            if (Console.ReadKey(true).KeyChar == 'y');
                        done = true;
                        Spaces2();
                    }//END FOR LOOP 

                     //ASK THE USER TO MAKE SURE THAT THEY ARE DONE
                      ENDENDGAME();
                         totalWinnings = totalWinnings / GamesPlayed;
                         Console.WriteLine($"Your total percent average of winning is: {totalWinnings}");

                }//END WHILE CASH BROUGHT
            }//END While TRUE

        }//END FUNCITON








         static void Fancy(string input) {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"<---======-----======-----=======-----======-----======--->\n\t<--==--> {input} <--==-->\n<---======-----======-----=======-----======-----======--->");
            Console.ResetColor();
        }//end funciton 


        #region ERROR FUnciton
        static void Error(ConsoleColor color) {
        Console.ForegroundColor = color;
            Console.WriteLine(" <-------------------------------------------->");
            Console.WriteLine(" |  //====   ||=\\\\    ||=\\\\   //==\\\\   ||=\\\\  |");
            Console.WriteLine(" |  ||       ||  ||   ||  ||  ||  ||   ||  || |");
            Console.WriteLine(" |  ||====   ||=//    ||=//   ||  ||   ||=//  |");
            Console.WriteLine(" |  ||       ||\\\\     ||\\\\    ||  ||   ||\\\\   |");
            Console.WriteLine(" |  \\\\====   || \\\\    || \\\\   \\\\==//   || \\\\  |");
            Console.WriteLine(" <-------------------------------------------->");
            Console.ResetColor();
        }//end funiton

        static void FlickerError() {
            ConsoleColor[] colors = {ConsoleColor.DarkRed,ConsoleColor.Black};
            for (int i = 0; i < 9; i++) {
                Thread.Sleep(250);
                Console.Clear();
                Error(colors[i % colors.Length]);
            }//end for
                Console.Clear ();
        }//end function
        #endregion



        #region GAME OVER FUNCIOTN
        static void GameOver(ConsoleColor color) {
            Console.ForegroundColor = color;
            Console.WriteLine(" <---------------------------------------->  <------------------------------------->");
            Console.WriteLine(" |  //===\\\\   ||===||  ||\\\\  //||  //===  |  |  //==\\\\ \\\\        //  //===  ||=\\\\  |");
            Console.WriteLine(" |  ||        ||   ||  || \\\\// ||  ||     |  |  ||  ||  \\\\      //   ||     ||  || |");
            Console.WriteLine(" |  ||  ==\\\\  ||===||  ||  \\/  ||  ||===  |  |  ||  ||   \\\\    //    ||===  ||=//  |");
            Console.WriteLine(" |  ||    ||  ||   ||  ||      ||  ||     |  |  ||  ||    \\\\  //     ||     ||\\\\   |");
            Console.WriteLine(" |  \\\\===//   ||   ||  ||      ||  \\\\===  |  |  \\\\==//     \\\\//      \\\\===  || \\\\  |");
            Console.WriteLine(" <---------------------------------------->  <------------------------------------->");
            Console.ResetColor();

        }//end function

        static void FlickerGameOver() {
            Thread.Sleep(2000);
            Console.Clear();
            Spaces1();
            ConsoleColor[] colors = { ConsoleColor.Cyan, ConsoleColor.DarkRed, ConsoleColor.Blue, ConsoleColor.Red};
            for (int i = 0; i < 18; i++) {
                Thread.Sleep(300);
                Console.Clear();
                GameOver(colors[i % colors.Length]);
            }//end for
                Thread.Sleep(1000);
                //Console.Clear();
        }//end function
        #endregion



        static void ENDGAME() {
            //variables
            bool done = false;
            Spaces2();
            //ASK IF DONE PLAYING GAME
            Console.Write("Are you DONE playing (y/n): ");
            //done?
            done = Console.ReadKey(true).KeyChar == 'y';
            Spaces2();
        }//end funciton

        static void ENDENDGAME() {
            //variables
            bool done = false;
            Spaces2();
            //ASK IF DONE PLAYING GAME
            Console.Write("Are you SURE YOUR DONE playing (y/n): ");
            //done?
            done = Console.ReadKey(true).KeyChar == 'y';
            Spaces2();
        }//end funciton


        #region SPACES
        static void Spaces1() {
         Console.WriteLine();
        }//end funciton

        static void Spaces2() {
            Console.WriteLine();
            Console.WriteLine();
        }//end funciton

        static void Spaces3() {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }//end funciton

        static void Spaces4() {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }//end funciton
#endregion



        #region ColorFullMonths
        static void RainFallColorfulDays() {
            //variables
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            ConsoleColor[] colors = { ConsoleColor.Blue, ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Cyan, ConsoleColor.White, ConsoleColor.DarkCyan, ConsoleColor.DarkRed, ConsoleColor.DarkGray, ConsoleColor.Yellow, ConsoleColor.Magenta, ConsoleColor.DarkYellow, ConsoleColor.DarkGreen };
            double[] monthlyRain;
            double avgRainfall = 0;
            double totalRain = 0;
            int years = 0;
            int t = 0;
            //input
            years = PromptInt("How many years will we be tracking rainfall?: ");
            Console.WriteLine();
            monthlyRain = new double[years * 12];
            ///for
            for (int y = 0; y < years; y++) {
                for (int m = 0; m < 12; m++) {
                    //input
                    monthlyRain[t] = ColorTextDoulbe($"What was rain in month {months[m]}: ", colors[m]);
                    totalRain += monthlyRain[t++];
                    Console.WriteLine();
                }//end month for loop
            }//end  year for loop
            avgRainfall = totalRain / (years * 12);
            Console.WriteLine($"The average monthly rainfall for {years} years was {avgRainfall}\nTotal Rain Fall {totalRain}");
        }//end fucnton

        #endregion



        #region COLOR TEXT, INT, DOUBLE 

        static string ColorText(string message, ConsoleColor color) {
            string value = "";
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
            //value = Console.ReadLine();
            //return
            return value;
        }//end funciton


        static int ColorTextInt(string messege, ConsoleColor color) {
            int value = 0;
            Console.ForegroundColor = color;
            Console.Write(messege);
            Console.ResetColor();
            //value = int.Parse(Console.ReadLine());
            //return
            return value;

        }//end funciton


        static double ColorTextDoulbe(string messege, ConsoleColor color) {
            double value = 0.0;
            Console.ForegroundColor = color;
            Console.Write(messege);
            Console.ResetColor();
            value = double.Parse(Console.ReadLine());
            //return
            return value;
        }//end funciton

        #endregion



        #region COLORFUL DAYS
        static void ColorfulDays() {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            ConsoleColor[] colors = { ConsoleColor.Blue, ConsoleColor.DarkYellow, ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Magenta, ConsoleColor.Cyan, ConsoleColor.White };
            //for loop output
            for (int i = 0; i < days.Length; i++) {
                ColorText(days[i], colors[i]);
            }//end for
            #region USLESS TEXT
            /*
            //ouput like for but expanded
            ColorText(days[0], colors[0]);
            ColorText(days[1], colors[1]);
            ColorText(days[2], colors[2]);
            ColorText(days[3], colors[3]);
            ColorText(days[4], colors[4]);
            ColorText(days[5], colors[5]);
            ColorText(days[6], colors[6]);
            */
            /*
            //output but all writen out for show
            Console.Write("In my mind, ");
            ColorText(days[0], ConsoleColor.Blue, false);
            Console.WriteLine(" is always blue.");
            ColorText($"{days[1]} are brown for Taco {days[1]}s", ConsoleColor.DarkYellow);
            ColorText($"Red is the color of {days[2]}", ConsoleColor.Red);
            ColorText($"And {days[3]} is definitely green!", ConsoleColor.Green);
            ColorText($"{days[4]} is the last day of the work-week, so it's purple", ConsoleColor.Magenta);
            Console.BackgroundColor = ConsoleColor.White;
            ColorText($" And {days[5]}s are black", ConsoleColor.Black);
            Console.BackgroundColor = ConsoleColor.Black;
            ColorText($"Finally, {days[6]} are while because fuck you, I said so." , ConsoleColor.White);
            */
            #endregion
        }//end funciton
        #endregion



        #region TRY FUNCITON 
        // biging funciton int try
        static int PromptIntTry(string dataRequest) {
            //color
            Console.ForegroundColor = ConsoleColor.Cyan;
            //variabels
            int userInput = 0;
            bool isValid = false;
            //do while loop
            do {
                Console.Write(dataRequest);
                isValid = int.TryParse(Console.ReadLine(), out userInput);
                if(isValid == false)
                {
                    FlickerError();
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("YOU HAVE TO ENTER A NUMBER!!!!");
                    Spaces1();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
            } while (isValid == false);

            //retun
            return userInput;
        }// end funtion int




        // biging funciton dulbe try
        static double PromptDoulbeTry(string dataRequest) {
            
                //color
                Console.ForegroundColor = ConsoleColor.Cyan;
                //variabels
                double userInput = 0;
                bool isValid = false;
                //do while loop
                do {
                    Console.Write(dataRequest);
                    isValid = double.TryParse(Console.ReadLine(), out userInput);
                    if (isValid == false) {
                        FlickerError();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("YOU HAVE TO ENTER A NUMBER!!!!");
                        Spaces1();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                    }
                } while (isValid == false);

                //retun
                return userInput;
            }// end funtion doulbe tyr
        #endregion  



        #region PROMPT FUNCTIONS

        //begin funstion string
        static string Prompt(string dataRequest) {

            //color
            Console.ForegroundColor = ConsoleColor.Cyan;

            //variables
            string userInput = "";

            //request information from user
            Console.Write(dataRequest);

            //recive respones
            userInput = Console.ReadLine();

            //return
            return userInput;

        }//end funtion



        // biging funciton int
        static int PromptInt(string dataRequest) {

            //variabels
            int userInput = 0;

            //input
            userInput = int.Parse(Prompt(dataRequest));

            //return
            return userInput;

        }// end funtion int



        //regin funtion double
        static double PromptDouble(string dataRequest) {

            //variables 
            double userInput = 0.0;

            //input
            userInput = double.Parse(Prompt(dataRequest));

            //return
            return userInput;
        }// end funciton double 

        #endregion



    }//end class
}//end namespace
