using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Rectangle : IDrawable
    {
        int widht;
        int height;

        public Rectangle(int widht, int height)
        {
            this.widht = widht;
            this.height = height;
        }

        public void Draw()
        {
            throw new NotImplementedException();
            DrawLine(this.widht,'*','*');
            for(int i = 1; i< this.widht; i++)
            {
                DrawLine(this.widht, ' ','*');

            }
             void DrawLine(int width, char end, char mid)
            {
                Console.Write(end);
                for(int i = 0; i < widht; i++)
                {
                    Console.Write(mid);
                }
                Console.Write(end);
            }
        }
    }
}
