using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Seat: ICar
    {
        private string v1;
        private string v2;

        public Seat(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

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
            Console.Write(Model + "with" + Color);
            
            return base.ToString();
        }
    }
}
