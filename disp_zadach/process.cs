using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace disp_zadach
{
    internal class process
    {
        static List<string> Name_Proc = new List<string> { };
        static Process[] procList = Process.GetProcesses();
        public static void proc()
        {
            int c = 0;
            
            foreach (Process p in procList)
            {

                string info = string.Format("  PID: {0} Имя: {1}", p.Id, p.ProcessName);
                Name_Proc.Add(p.ProcessName);

                //p.Kill();
                Console.WriteLine("  " + Name_Proc[c] + " - " + p.Id);
                c++;
            }
        }

        static void del()
        {
            foreach (Process i in procList)
            {


            }
        }
    }
}
