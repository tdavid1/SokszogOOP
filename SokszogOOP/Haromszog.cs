using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokszogOOP
{
    internal class Haromszog : Sokszog
    {
        private double b;
        private double c;
        private static Random r = new Random();

        public Haromszog(double b, double c, double a) : base(a)
        {
            this.b = b;
            this.c = c;
            if (!Szerkeszthetoe())
            {
                throw new ArgumentException("Nem létrehozható a háromszög");
            }
        }
        public Haromszog() : base(Veletlenoldalhoz())
        {
            this.b = Veletlenoldalhoz();
            this.c = Veletlenoldalhoz();
            while (!this.Szerkeszthetoe())
            {
                base.A = Veletlenoldalhoz();
                this.b = Veletlenoldalhoz();
                this.c = Veletlenoldalhoz();
            }
        }

        private static int Veletlenoldalhoz()
        {
            return r.Next(5, 15);
        }
        public override double A
        {
            set
            {
                base.A = value;
                if (!Szerkeszthetoe())
                {
                    throw new ArgumentException("Nem létrehozható a háromszög", nameof(value));
                }
            }
        }
        public double B 
        { get => b; 
            set 
            {
                b = value;
                if (!Szerkeszthetoe())
                {
                    throw new ArgumentException("Nem létrehozható a háromszög", nameof(value));
                }
            } 
        }
        public double C 
        { get => c; 
            set
            {
                c = value;
                if (!Szerkeszthetoe())
                {
                    throw new ArgumentException("Nem létrehozható a háromszög", nameof(value));
                }
            }
        }
        
        private bool Szerkeszthetoe()
        {
            return this.A + this.b>this.c && this.b + this.c>this.A && this.A +  this.c>this.b;
        }
        public override double GetKerulet()
        {
            return this.A + this.b + this.c;
        }
        public override double GetTerulet()
        {
            double s = (this.A + this.b + this.c) / 2;
            return Math.Sqrt(s*(s-this.A)*(s-this.b)*(s-this.c));
        }
        public override string ToString()
        {
            return $"a:{this.A} b:{this.b} c:{this.c} {base.ToString()}";
        }
    }
}
