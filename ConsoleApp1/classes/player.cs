using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.classes
{
    class player
    {
        int xit = 10;
        int bulet = 10;
        string v = Console.ReadLine();
        public double Attac()
        {
            if (v=="nerf")
            {
                if (bulet!=0)
                {
                    Console.WriteLine("player attack nerf");
                    
                    bulet -= 1;
                    
                    
                    return 1;

                }
                else
                {
                    Attac();
                    // no bulet 
                    return 0;
                }

                
            }
            else
            {
                Console.WriteLine("player attack "+ v);
                return 0.5;

            }
        }        
    }
}
