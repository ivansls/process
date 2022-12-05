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



while (true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    Console.Clear();
    process.proc();
    menu.strelki(key);
    
}
