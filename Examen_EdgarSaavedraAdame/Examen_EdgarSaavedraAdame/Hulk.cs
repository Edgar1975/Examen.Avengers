using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_EdgarSaavedraAdame
{
    class Hulk: Vengadores //Herencia
    {
        //Sobrecarga.
        public Hulk()
        {

        }

        //Constructores.
        public Hulk(string nombre, string arma, int edad, char genero)
        {
            this.nombre = nombre;
            this.arma = arma;
            this.edad = edad;
            this.genero = genero;
        }

        //Polimorfismo.
        public override void Atacar()
        {
            base.Atacar();
            Console.WriteLine(this.nombre + " ha atacado a un rival.");
        }

        public override void RecibirDaño()
        {
            base.RecibirDaño();
            Console.WriteLine(this.nombre + " ha recibido daño.");
        }

        public override void Morir()
        {
            base.Morir();
            Console.WriteLine(this.nombre + " ha muerto.");
        }
    }
}
