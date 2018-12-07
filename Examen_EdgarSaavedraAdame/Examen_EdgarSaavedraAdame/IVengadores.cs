using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_EdgarSaavedraAdame
{
    interface IVengadores
    {
        string Nombre { get; set; }
        string Arma { get; set; }
        int Edad { get; set; }
        char Genero { get; set; }

        void Atacar();
        void Morir();
    }
}
