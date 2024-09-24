using System.Diagnostics;
using Command_Line_interface_2024_09_24;

Console.OutputEncoding = System.Text.Encoding.UTF8;
void StartScreen()
{
    string Input = "";
    Console.WriteLine("debug");
    while (Input != "4")
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.SetCursorPosition(0, 2);
        Console.WriteLine(" ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine(" ┃                                                      ┃");
        Console.WriteLine(" ┃  _____     _                  _____ _ _         _    ┃");
        Console.WriteLine(" ┃ |   __|___| |_ _ _ ___ _ _   |     | |_|___ ___| |_  ┃");
        Console.WriteLine(" ┃ |__   | . |   | | |   |_'_|  |   --| | | -_|   |  _| ┃");
        Console.WriteLine(" ┃ |_____|  _|_|_|_  |_|_|_,_|  |_____|_|_|___|_|_|_|   ┃");
        Console.WriteLine(" ┃       |_|     |___|                                  ┃");
        Console.WriteLine(" ┃                                                      ┃");
        Console.WriteLine(" ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine(" ┏━━━━━━━━━━━━━━━━━━━━━━━━━┓");
        Console.WriteLine(" ┃1.        Login          ┃");
        Console.WriteLine(" ┃                         ┃");
        Console.WriteLine(" ┃                         ┃");
        Console.WriteLine(" ┃2.    Create account     ┃");
        Console.WriteLine(" ┃                         ┃");
        Console.WriteLine(" ┃                         ┃");
        Console.WriteLine(" ┃3.         ...           ┃");
        Console.WriteLine(" ┃                         ┃");
        Console.WriteLine(" ┃                         ┃");
        Console.WriteLine(" ┃4.        Quit           ┃");
        Console.WriteLine(" ┗━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        //Input Responses
        Input = Console.ReadLine();
        if (Input == "1")
        {
            Console.Clear();
            
        }
        else if (Input == "2")
        {
            Console.Clear();
            CreateAccount();
        }
        else if (Input == "3")
        {
            Console.Clear();
            Console.ReadLine();
        }
        else if (Input == "4")
        {
            Console.Clear();
        }
        else
        {
            NullInput();
        }
    }
    Console.Clear();
}
void NullInput()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Clear();
    Console.WriteLine("Input Returned Null");
    Console.ReadLine();
}
//input 1
void Login()
{
    Console.WriteLine("Debug");
    Console.ReadLine();
}
//input 2
void CreateAccount()
{
    Accounts CreateNewAccount = new Accounts();
    string Input = "";
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.SetCursorPosition(0, 2);
    Console.WriteLine(" ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
    Console.WriteLine(" ┃                                                      ┃");
    Console.WriteLine(" ┃  _____     _                  _____ _ _         _    ┃");
    Console.WriteLine(" ┃ |   __|___| |_ _ _ ___ _ _   |     | |_|___ ___| |_  ┃");
    Console.WriteLine(" ┃ |__   | . |   | | |   |_'_|  |   --| | | -_|   |  _| ┃");
    Console.WriteLine(" ┃ |_____|  _|_|_|_  |_|_|_,_|  |_____|_|_|___|_|_|_|   ┃");
    Console.WriteLine(" ┃       |_|     |___|                                  ┃");
    Console.WriteLine(" ┃                                                      ┃");
    Console.WriteLine(" ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("");
    Console.WriteLine("");
    //Input Username
    Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━┓");
    Console.WriteLine("┃ Type desired username ┃");
    Console.WriteLine("┃                       ┃");
    Console.SetCursorPosition(36, 105);
    Input = Console.ReadLine();
    Console.WriteLine("┃                       ┃");
    Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━┛"2);
    CreateNewAccount.Username = Input;
    Input = string.Empty;
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.SetCursorPosition(0, 2);
    Console.WriteLine(" ┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
    Console.WriteLine(" ┃                                                      ┃");
    Console.WriteLine(" ┃  _____     _                  _____ _ _         _    ┃");
    Console.WriteLine(" ┃ |   __|___| |_ _ _ ___ _ _   |     | |_|___ ___| |_  ┃");
    Console.WriteLine(" ┃ |__   | . |   | | |   |_'_|  |   --| | | -_|   |  _| ┃");
    Console.WriteLine(" ┃ |_____|  _|_|_|_  |_|_|_,_|  |_____|_|_|___|_|_|_|   ┃");
    Console.WriteLine(" ┃       |_|     |___|                                  ┃");
    Console.WriteLine(" ┃                                                      ┃");
    Console.WriteLine(" ┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("");
    Console.WriteLine("");
    //Input Password
    Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━┓");
    Console.WriteLine("┃ Type desired password ┃");
    Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━┛");
    Input = Console.ReadLine();
    CreateNewAccount.Password = Input;
    Input = string.Empty;
    Console.Clear();
}

StartScreen();