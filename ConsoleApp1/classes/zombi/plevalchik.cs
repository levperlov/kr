using System;
namespace ConsoleApp1
{
    class plevalchik : Zombi
    {
        int xit = 4;
        public override void about()
        {
            base.about();
            Console.WriteLine("-plevalchek");
        }
    }
}
