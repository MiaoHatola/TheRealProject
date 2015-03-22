using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TcpHandlerProject.TcpClientHandler;

namespace UI
{
    public class MyUserInterface
    {
        MyTcpClient cl;
        bool _running;

        public MyUserInterface(MyTcpClient cl)
        {
            this.cl = cl;
            _running = false;
        }
        public void Run()
        {
            Console.Clear();
            _running = true;
            string s;

            while (_running)
            {
                Console.WriteLine(cl.StreamOut("printMenu"));
                Console.Write("input >> ");
                s = Console.ReadLine();
                Console.WriteLine(cl.StreamOut(s));
                Console.WriteLine();
            }


        }
        public void RequestStop()
        {
            this._running = false;
        }
    }
}
