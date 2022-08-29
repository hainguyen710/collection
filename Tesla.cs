using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Tesla : ICar, IElectricCar
    {
        public Tesla(string v1, string v2, int v3)
        {
        }

        public int Battery { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Model { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            Console.WriteLine(Model + "with" + Color + "with" + Battery);
            return base.ToString();
        }
    }
}
