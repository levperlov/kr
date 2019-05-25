using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class oxotnik:Zombi
    {
        int xit = 5;
        public override void about()
        {
            base.about();
            Console.Write("-oxotnik");
        }

    }
}
