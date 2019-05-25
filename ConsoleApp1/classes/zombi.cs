using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    
    class Zombi
    {
        public bool unsecurete;
        int xit = 2;
        public int Attack()
        {
            Random random = new Random();
            if (unsecurete)
            {
                int x = random.Next(3);
                Console.WriteLine("zombi -" +x);
                
                return x;
            }
            else
            {
                return 0;
            }
            
        }
        virtual public void about()
        {
            Console.WriteLine("xit:"+xit+"I'm zombi");
        }
    }
}
