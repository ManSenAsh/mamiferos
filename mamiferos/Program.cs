using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mamiferos
{
    class Animal
    {
        string Nombre;
        string TipoGeneroFamilia;
        int NumeroDePatas;
        bool TieneCola;
        bool NaceDeMadre;
        bool BebeLeche;
        string ColorDePelaje;
        bool PuedeVolar;
        bool PuedeNadar;
        bool PuedeSaltar;
        string QueCome;
        string DondeVive;
        int EdadPromedio;
        int PesoPromedio;

        void sonar()
        {
            Console.WriteLine("sonidos de animal");
        }

        void respirar()
        {
            Console.WriteLine("inalar exalar ");
        }

        void dormir()
        {
            Console.WriteLine("zzzzz");
        }

        static void Main()

        {
            Animal mamiferos = new Animal();

            mamiferos.Nombre = "Canguro";
            mamiferos.TipoGeneroFamilia = "Macropodidae";
            mamiferos.NumeroDePatas = 2;
            mamiferos.TieneCola = true;
            mamiferos.BebeLeche = true;
            mamiferos.ColorDePelaje = "marron rojizo";
            mamiferos.PuedeVolar = false;
            mamiferos.PuedeNadar = true;
            mamiferos.PuedeSaltar = true;
            mamiferos.QueCome = "pasto y raices";
            mamiferos.DondeVive = "oceania";
            mamiferos.EdadPromedio = 22;
            mamiferos.PesoPromedio = 50;

            Console.WriteLine("propiedad 1 de este mamifero " + mamiferos.Nombre);
            Console.WriteLine("propiedad 2 de este mamifero " + mamiferos.TipoGeneroFamilia);
            Console.WriteLine("propiedad 3 de este mamifero " + mamiferos.NumeroDePatas);
            Console.WriteLine("propiedad 4 de este mamifero " + mamiferos.TieneCola);
            Console.WriteLine("propiedad 5 de este mamifero " + mamiferos.BebeLeche);
            Console.WriteLine("propiedad 6 de este mamifero " + mamiferos.ColorDePelaje);
            Console.WriteLine("propiedad 7 de este mamifero " + mamiferos.PuedeVolar);
            Console.WriteLine("propiedad 8 de este mamifero " + mamiferos.PuedeSaltar);
            Console.WriteLine("propiedad 9 de este mamifero " + mamiferos.PuedeNadar);
            Console.WriteLine("propiedad 10 de este mamifero " + mamiferos.QueCome);
            Console.WriteLine("propiedad 11 de este mamifero " + mamiferos.DondeVive);
            Console.WriteLine("propiedad 12 de este mamifero " + mamiferos.EdadPromedio);
            Console.WriteLine("propiedad 13 de este mamifero " + mamiferos.PesoPromedio);
            

            Console.WriteLine("metodo 1 "); mamiferos.sonar();
            Console.WriteLine("metodo 2 "); mamiferos.dormir();
            Console.WriteLine("metodo 3 "); mamiferos.respirar();

            Console.ReadLine();
        }
    }
}
