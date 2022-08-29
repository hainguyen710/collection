using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal interface ICar
    {
        string Model
        {
            get; set; 
        }
        string Color
        {
            get; set;
        }
        void Start()
        {
            Console.WriteLine("start");
                return;
        }
        void Stop()
        {
            Console.WriteLine("STOP");
            return;
        }

    }
}
