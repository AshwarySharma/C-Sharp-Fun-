using System;


namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            i = 1;
            while (i < 5)
            {
                Console.WriteLine("************************************************************************************************************");
                Console.WriteLine("Enter what do u want to play 1 for rps , 2 for 8 ball and 3 for a num guesser 4 for true or false 5 for" +
                    " calculator and 6 for table and 7 for a quiz  ");
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Rps();
                }
                else if (a == 2)
                {
                    ball();
                }
                else if (a == 3)
                {
                    numguesser();
                }
                else if (a == 4)
                {
                    TF();
                }
                else if (a == 5)
                {
                    calc();
                }
                else if (a == 6)
                {
                    table();
                }
                else if ( a == 7)
                {
                    pythonQuiz();
                }
                
                else
                {
                    Console.WriteLine("Enter correctly u piece of sheet");
                }
                Console.WriteLine("***************************************************************");
                Console.WriteLine("Hope you like my program!");
                Console.WriteLine("***************************************************************");
                i--;
            }


            static void Rps()
            {
                Random rd = new Random();
                int r = rd.Next(1, 3);
                Console.WriteLine("************************Rock Paper Scissors ************************");
                Console.WriteLine("Enter ur choice, r for rock, p for paper, s for scissors");
                char choice = Convert.ToChar(Console.ReadLine());
                //if player chooses rock
                if (choice == 'r')
                {
                    if (r == 1)
                    {
                        Console.WriteLine("Draw huh!");
                        Console.WriteLine("You choose " + choice + " and the bot choose r");
                        Console.WriteLine("**************************************************");
                    }
                    else if (r == 2)
                    {
                        Console.WriteLine("C'mon man, u lost to a bot smh");
                        Console.WriteLine("You choose " + choice + " and the bot choose p");
                        Console.WriteLine("**************************************************");
                    }
                    else
                    {
                        Console.WriteLine("Les goooo, POG! u won man! GG");
                        Console.WriteLine("You chose " + choice + " and the bot choose s");
                        Console.WriteLine("**************************************************");
                    }

                    //If they choose paper
                }
                else if (choice == 'p')
                {
                    if (r == 2)
                    {
                        Console.WriteLine("Draw huh!");
                        Console.WriteLine("You choose " + choice + " and the bot choose p");
                        Console.WriteLine("**************************************************");
                    }
                    else if (r == 3)
                    {
                        Console.WriteLine("C'mon man, u lost to a bot  smh");
                        Console.WriteLine("You choose " + choice + " and the bot choose s");
                        Console.WriteLine("**************************************************");
                    }
                    else
                    {
                       Console.WriteLine("Les goooo, POG! u won man! GG");
                        Console.WriteLine("You chose " + choice + " and the bot choose r");
                        Console.WriteLine("**************************************************");
                    }

                }
                //if they choose scissors
                else if (choice == 's')
                {
                    if (r == 3)
                    {
                        Console.WriteLine("Draw huh!");
                        Console.WriteLine("You choose " + choice + " and the bot choose s");
                        Console.WriteLine("**************************************************");
                    }
                    else if (r == 1)
                    {
                        Console.WriteLine("C'mon man, u lost to a bot smh");
                        Console.WriteLine("You choose " + choice + " and the bot choose r");
                        Console.WriteLine("**************************************************");
                    }
                    else
                    {
                        Console.WriteLine("Les goooo, POG! u won man! GG");
                        Console.WriteLine("You chose " + choice + " and the bot choose p");
                        Console.WriteLine("**************************************************");
                    }

                }

            }
            static void ball()
            {
                Console.WriteLine("**************************************** 8Ball **************************************");
                string[] ans = {"Yes",
                            "Probably not"
                           ,"Damn Yes",
                            "WTF NO!",
                            "U might",
                            "U dont want to",
                            "Straight up yes",
                            "A damn no!",
                            "NOOOOO!"
                };
                Random rd = new Random();
                int b = rd.Next(0, 7);
                Console.Write("Enter your question: ");
                string q = Console.ReadLine();
                Console.WriteLine("8Ball says: " + ans[b]);
                Console.WriteLine("***************************************************************************************");

            }
            static void numguesser()
            {
                int num = 48;
                Console.WriteLine("***********************************************************************************");
                Console.WriteLine("Enter you guess brio");
                int guess = Convert.ToInt32(Console.ReadLine());
                int tries = 1;
                Console.WriteLine("It is a numbr between 10-50, which is pretty close to 50, and has gap of a prime number between itself and 50, It is an even number!");
                while (tries < 5)
                {
                    if (guess != num)
                    {
                        Console.WriteLine("Enter you guess");
                        guess = Convert.ToInt32(Console.ReadLine());
                        tries++;
                    }
                    if (guess == num)
                    {
                        Console.WriteLine("U did it noob!");
                        tries++;
                    }
                }
                Console.WriteLine("F in the chat for you, cause u suck");
            }
            static void TF()
            {
                Random rd = new Random();
                int r = rd.Next(1, 3);
                string choice;
                Console.WriteLine("****************************************************************");
                Console.Write("Enter ur doubt nerd: ");
                choice = Console.ReadLine();
                if (r == 1)
                {
                    Console.WriteLine("God says: Yes");
                }
                else if (r == 2)
                {
                    Console.WriteLine("God says: No");
                }
                else
                {
                    Console.WriteLine("God says: In Another Universe");
                }
            }
            static void calc()
            {
                int num1;
                int num2;
                char op;
                Console.WriteLine("**********************************************************");
                Console.WriteLine("Enter ur first number");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter ur second number");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your operator noob");
                op = Convert.ToChar(Console.ReadLine());
                if (op == '+')
                {
                    Console.WriteLine(num1 + num2);
                }
                else if (op == '-')
                {
                    Console.WriteLine(num1 - num2);

                }
                else if (op == 'x')
                {
                    Console.WriteLine(num1 * num2);
                }
                else if (op == '/')
                {
                    Console.WriteLine(num1 / num2);
                }
                else
                {
                    Console.WriteLine("Open ur eyes blind man");
                }
            }
            static void table()
            {
                int num;
                int realNum;
                int end;
                Console.WriteLine("Enter a number");
                num = Convert.ToInt32(Console.ReadLine());
                end = num * 10;
                realNum = num;
                int i = 1;
                while (realNum <= end)
                {
                    Console.WriteLine(num + " x " + i + " = " + realNum);
                    realNum = realNum + num;
                    i++;
                }


            }
            static void pythonQuiz()
            {
                string name;
                string difficulty;
                int score =  0;
                int i = 0;
                string[] easyQuestions = { "How many data types are there in Python",
                                          "How many modes does python have",
                                            "Which letter is used to give space of a tab",
                                            "Shortcut key to run a program is",
                                            "Is python case sensitive ( Yes or No )"};
                string[] easyAnswers = { "Three",
                                          "Two",
                                           "t",
                                           "F5", 
                                            "Yes"};


                Console.WriteLine("Enter ur name");
                name = Console.ReadLine();
                Console.WriteLine("Hi {0}, choose ur difficulty between 'Beginner', 'Moderate' and 'Master' ", name);
                difficulty = Console.ReadLine();     
                Console.WriteLine("**********************************QUIZ***************************************************");
                Console.WriteLine("Remember to write answers in words with the first letter being capital, press enter when u are ready !!");
                string ready = Console.ReadLine();  
                if (difficulty == "Beginner" || difficulty == "beginner")
                {
                    Console.WriteLine("************************************EASY MODE**********************************************");
                    while (i < 5)
                    {
                        Console.WriteLine(easyQuestions[i]);
                        string ans = Console.ReadLine();
                        Console.WriteLine("__________________________________________________________________");
                        if (ans == easyAnswers[i])
                        {
                            score += 2;
                        }
                        Console.WriteLine("Score = {0}", score);
                     
                        i++;
                    };
                    if (score >7)
                    {
                        Console.WriteLine("Looks like its too easy for u , try another mode");
                    }
                    if (score <7)
                    {
                        Console.WriteLine("There is always a scope of improvement");
                    }

                }
            }
           
        }
    }
}