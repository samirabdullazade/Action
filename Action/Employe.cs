using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Action
{
    internal class Employe : Human
    {
        public string Pozition { get; set; }
        public Employe(string name, string pozition) : base(name)
        {
            Pozition = pozition;
        }
        public void Muellim(List<Employe> employes)
        {
            Console.WriteLine("Ad:");
            string name = Console.ReadLine();
            Console.WriteLine("pozisiyasi:");
            string pozition = Console.ReadLine();
            Employe emp = new Employe(name, pozition);
            employes.Add(emp);

        }
    }
}
