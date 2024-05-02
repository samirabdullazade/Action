using System;
using System.Collections.Generic;

namespace Action
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<Employe> employe = new List<Employe>();
            List<Student> students = new List<Student>();
            do
            {
                Console.WriteLine("1-Student əlavə et\r\n2-Employe əlavə  et\r\n3-Axtarış et\r\n4-Çıxış  Menusu gəlsin.");
                int reqem = int.Parse(Console.ReadLine());
                Student stu = new("Samir", 24);
                Employe emp = new("Ali", "parta yoldasi");
                switch (reqem)
                {
                    case 1:
                        stu.Telebe(students);
                        break;
                    case 2:
                        emp.Muellim(employe);
                        break;
                    case 3:

                        Console.WriteLine("1-Employe üzrə axtarış\r\n   2-Student üzrə axtarış");
                        int secim = int.Parse(Console.ReadLine());
                        if (secim == 1)
                        {
                            Console.WriteLine("pozisiyyasini yaz:");
                            string poz = Console.ReadLine();
                            foreach (Employe s in employe.FindAll(x => x.Pozition == poz))
                            {
                                Console.WriteLine(s.Name);
                            }
                        }
                        else if (secim == 2)
                        {
                            Console.WriteLine("sinif araligini yaz");
                            int sinifmin = int.Parse(Console.ReadLine());
                            int sinifmax = int.Parse(Console.ReadLine());
                            foreach (Student d in students.FindAll(x => x.Grade > sinifmin && x.Grade < sinifmax))
                            {
                                Console.WriteLine(d.Name);
                            }

                        }
                        else
                        {
                            Console.WriteLine("Duzgun eded daxil edin");
                        }
                        break;
                    case 4:
                        Console.WriteLine("cixis");
                        break;

                }
            }
            while (true);
        }
    }
}
