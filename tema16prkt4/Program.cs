using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tema16prkt4
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите кол-во сотрудников: ");
            int n = int.Parse(ReadLine());
            Collaborator[] ms = new Collaborator[n];
            for(int i = 0;i<ms.Length;i++)
            {
                ms[i] = new Collaborator();
                ms[i].Pringles();

            }
            foreach(var elem in ms)
            {
                elem.Print();
                elem.Voz();
            }
            ReadKey();

        }
    }
}
