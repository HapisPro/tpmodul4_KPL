using System;
using tpmodul4_103022300069;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Soal 1 (Table Driven):");
        foreach (KodePos.Kelurahan kel in Enum.GetValues(typeof(KodePos.Kelurahan)))
        {
            Console.WriteLine(kel + " : " + KodePos.GetKodePos(kel));
        }
    }
}
