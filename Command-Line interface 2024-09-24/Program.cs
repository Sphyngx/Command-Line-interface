Console.OutputEncoding = System.Text.Encoding.UTF8;
FileStream FileStream = new FileStream("SaveFile", FileMode.OpenOrCreate);
StreamWriter Writer;
StreamReader Reader;
bool quit = false;
while (!quit)
{
    StartScreen();
}
void StartScreen()
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("");
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
    Console.WriteLine(" ┃3.        Login          ┃");
    Console.WriteLine(" ┗━━━━━━━━━━━━━━━━━━━━━━━━━┛");
    string Input = Console.ReadLine();
    //Input Responses
    if (Input == "1")
    {
        Console.Clear();
        Console.ReadLine();
    }
    else if (Input == "2")
    {
        Console.Clear();
        Console.ReadLine();
    }
    else if (Input == "3")
    {
        Console.Clear();
        Console.ReadLine();
    }
    else
    {
        NullInput();
    }



}
void NullInput()
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Clear();
    Console.WriteLine("Input Returned Null");
    Console.ReadLine();
    StartScreen();
}