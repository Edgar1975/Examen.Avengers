using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_EdgarSaavedraAdame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Hulk hulk = new Hulk("Hulk", "Fuerza", 30, 'M');

            Barton barton = new Barton("Barton", "Lanza flechas", 30, 'M');

            ViudaNegra viudaNegra = new ViudaNegra("Viuda Negra", "Pistolas", 25, 'F');

            Thor thor = new Thor("Thor", "Martillo", 37, 'M');

            IronMan ironMan = new IronMan("Iron Man", "Armadura", 34, 'M');

            CapitanAmerica capitanAmerica = new CapitanAmerica("Capitán América", "Escudo", 28, 'M');

            hulk.Atacar();
            Console.WriteLine(hulk.Nombre + " de " + hulk.Edad + " años de edad, atacó con " + hulk.Arma + " a " + viudaNegra.Nombre);
            viudaNegra.RecibirDaño();
            Console.WriteLine("");

            barton.Atacar();
            Console.WriteLine(barton.Nombre + " de " + barton.Edad + " años de edad, atacó con " + barton.Arma + " a " + hulk.Nombre);
            hulk.RecibirDaño();
            Console.WriteLine("");

            viudaNegra.Atacar();
            Console.WriteLine(viudaNegra.Nombre + " de " + viudaNegra.Edad + " años de edad, atacó con " + viudaNegra.Arma + " a " + barton.Nombre);
            barton.RecibirDaño();
            Console.WriteLine("");

            thor.Atacar();
            Console.WriteLine(thor.Nombre + " de " + thor.Edad + " años de edad, atacó con " + thor.Arma + " a " + hulk.Nombre);
            hulk.Morir();
            Console.WriteLine("");

            ironMan.Atacar();
            Console.WriteLine(ironMan.Nombre + " de " + ironMan.Edad + " años de edad, atacó con " + ironMan.Arma + " a " + barton.Nombre);
            barton.Morir();
            Console.WriteLine("");

            capitanAmerica.Atacar();
            Console.WriteLine(capitanAmerica.Nombre + " de " + capitanAmerica.Edad + " años de edad, atacó con " + capitanAmerica.Arma + " a " + thor.Nombre);
            thor.RecibirDaño();
            Console.WriteLine("");
        }
    }
}
