using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_103022300069
{
    class DoorMachine
    {
        public enum State { TERKUNCI, TERBUKA };
        string[] doorMsg = { "Pintu terkunci", "Pintu tidak terkunci" };
        bool stop = false;

        State state = State.TERKUNCI;

        public void Simulasi()
        {
            while (!stop)
            {
                Console.WriteLine(doorMsg[(int) state]);

                Console.Write("Setstate pintu(buka/kunci/keluar): ");
                string input = Console.ReadLine().ToLower();

                if (input == "buka")
                {
                    state = State.TERBUKA;
                }
                else if (input == "kunci")
                {
                    state = State.TERKUNCI;
                }
                else
                {
                    stop = true;
                }
            }

            Console.WriteLine("Keluar...");
        }
    }
}
