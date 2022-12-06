/*using System.Diagnostics;

Process[] procList = Process.GetProcesses();
ConsoleKeyInfo key = Console.ReadKey();
foreach (Process p in procList)
{
    
    *//*string info = string.Format("  PID: {0} Имя: {1}", p.Id, p.ProcessName);*//*
    string info = p.ProcessName;
    if (key.Key == ConsoleKey.D & info == "browser")
    {
        p.Kill();
    }
    Console.WriteLine(info);


}*/

using disp_zadach;

Menu menu = new Menu();

int wind = 0;
int www = 0;

while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();

    if (key.Key == ConsoleKey.D)
    {
        wind = 1;
        process.menuuu(wind);
    }
    else if (key.Key == ConsoleKey.Delete)
    {
        wind = 2;
        process.menuuu(wind);
    }
    else if (key.Key == ConsoleKey.Enter)
    {
        wind = 3;
        www = 4;
        process.menuuu(wind);
    }
    else if (key.Key == ConsoleKey.Backspace)
    {
        wind = 0;
        www = 0;
        
    }
    process.menuuu(wind);
    if (www == 0)
    {
        menu.strelki(key);
    }


}
