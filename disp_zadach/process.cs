using System;
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
        static List<Process> processList = new List<Process>();
        static List<string> Name_Proc = new List<string> { };
        static Process[] procList = Process.GetProcesses();
        static Menu men = new Menu();
        static int dop_pos;
        public static void menuuu(int wind)
        {
            if (wind == (int)window.Back)
            {
                proc();
                
            }
            else if (wind == (int)window.D)
            {
                del(dop_pos);
            }
            else if (wind == (int)window.Del)
            {
                delete();
            }
            else if (wind == (int)window.Enter)
            {
                dop_pos = men.position;
                show_more_info(dop_pos);
            }
        }
        

        static void proc()
        {
            int c = 0;
            
            foreach (Process p in procList)
            {

                //string info = string.Format("  PID: {0} Имя: {1}", p.Id, p.ProcessName);
                Name_Proc.Add(p.ProcessName);

                //p.Kill();
                processList.Add(p);
                Console.WriteLine("  " + Name_Proc[c] + " - " + p.Id);
                c++;
                
            }
        }

        static void show_more_info(int dop_pos)
        {
            //Console.Clear();
            
            try
            {
                Console.WriteLine("  " + processList[dop_pos].ProcessName + " " + processList[dop_pos].PagedMemorySize + " " + processList[dop_pos].StartTime + " " + processList[dop_pos].Id);
            }
            catch { Console.WriteLine("Отказанно в доступе"); }
            finally
            {
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("ГОТОВО");
            }
        }

        static void del(int dop_pos)
        {
            try
            {
                processList[dop_pos].Kill();
            }
            catch { Console.WriteLine("Отказанно в доступе"); }
            finally
            {
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("ГОТОВО");
            }
        }

        static void delete()
        {

        }
    }
}
