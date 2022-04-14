using System;
using System.Collections.Generic;
using System.Text;

namespace Pr1
{
    class Obyv
    {
        private string Proizv { get; set; }
        private float Razmer { get; set; }
        private double Cena { get; set; }
        public Obyv()
        {
            Proizv = "";
            Razmer = 0;
            Cena = 0;
        }
        public Obyv(string proizv, float razmer, double cena)
        {
            this.Cena = cena;
            this.Proizv = proizv;
            this.Razmer = razmer;
        }
        public void Print ()
        {
            Console.WriteLine("Производитель" + " " + Proizv + " " + "Рамзер" + " " + Razmer + " " + "Цена" + " " + Cena);
        }
        public void Input ()
        {
            Console.WriteLine("Производтель: ");
            this.Proizv = Console.ReadLine();
            Console.WriteLine("Разер: ");
            this.Razmer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Цена: ");
            this.Cena = Convert.ToDouble(Console.ReadLine());
        }
    }
}
