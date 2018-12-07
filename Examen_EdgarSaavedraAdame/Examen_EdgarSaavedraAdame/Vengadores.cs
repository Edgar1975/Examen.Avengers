using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_EdgarSaavedraAdame
{
    class Vengadores: IVengadores
    {
        //Atributos.
        //"Protected" representa el encapsulamiento.
        protected string nombre = " ", arma = " ";
        protected int edad = 0;
        protected char genero = ' ';

        //Propiedades.
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Arma
        {
            get { return this.arma; }
            set { this.arma = value; }
        }

        public int Edad 
        {
            get { return this.edad; }
            set { this.edad = value; }
        }

        public char Genero
        {
            get { return this.genero; }
            set { this.genero = value; }
        }

        //Métodos o funciones.
        //"Virtual" representa el polimorfismo.
        public virtual void Atacar()
        {

        }

        public virtual void RecibirDaño()
        {

        }

        public virtual void Morir()
        {

        }
    }
}
