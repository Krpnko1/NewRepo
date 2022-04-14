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
    }
}
