﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal enum window
{
    D = 1,
    Del = 2,
    Back = 0,
    Enter = 3,
}

namespace disp_zadach
{
    internal class process
    {
        public static int pos = 0;
        static List<Process> processList = new List<Process>();
        static List<string> Name_Proc = new List<string> { };
        
        //static Menu men = new Menu();
        public static void menuuu(int wind, int www, int w2)
        {
            
            if (wind == (int)window.Back)
            {
                
                proc();


            }
            else if (wind == (int)window.Enter)
            {
                show_more_info(wind, www, w2);
            }
            
            
        }
        

        static void proc()
        {
            int c = 0;
            Process[] procList = Process.GetProcesses();
            foreach (Process p in procList)
            {

                //string info = string.Format("  PID: {0} Имя: {1}", p.Id, p.ProcessName);
                Name_Proc.Add(p.ProcessName);

                //p.Kill();
                processList.Add(p);
                Console.WriteLine("  " + Name_Proc[c] + " - " + p.WorkingSet64.ToString() + "мб");
                c++;
                
            }
        }

        static void show_more_info(int wind, int www, int w2)
        {
            Console.Clear();
            
            try
            {
                Console.WriteLine("  " + processList[pos].ProcessName + " " + processList[pos].PagedMemorySize + " " + processList[pos].StartTime + " " + processList[pos].Id);
            }
            catch { Console.WriteLine("Отказанно в доступе"); }
            finally
            {
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("ГОТОВО");

                ConsoleKeyInfo key = Console.ReadKey();
                //Console.Clear();

                if (key.Key == ConsoleKey.D)
                {
                    wind = 1;
                    w2 = 0;
                    del(pos);
                    process.menuuu(wind, www, w2);
                }
                else if (key.Key == ConsoleKey.Delete)
                {
                    wind = 2;
                    w2 = 0;
                    delete(wind);
                    process.menuuu(wind, www, w2);
                }

                else if (key.Key == ConsoleKey.Backspace)
                {
                    wind = 0;
                    w2 = 1;
                    www = 0;

                }
            }

        }

        private static void del(int wind)
        {
            try
            {
                processList[pos].Kill();
            }
            catch { Console.WriteLine("Отказанно в доступе"); }
            finally
            {
                wind = 3;
            }

            //Console.WriteLine(pos);
        }

        static void delete(int wind)
        {
            /*List<string> query = Name_Proc.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();*//*
            int m = 0;
            foreach (Process p in procList)
            {
                if (p.ProcessName.ToString() == "browser")
                {
                    p.Kill();
                    m++;
                }
            }*/

            foreach (Process p in processList)
            {
                if (p.ProcessName == processList[pos].ProcessName)
                {
                    p.Kill();

                }
            }
            wind = 3;
        }
    }
}
