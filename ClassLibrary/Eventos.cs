using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class Eventos
    {
        private string txt;
        public event EventHandler ok;

        public Eventos(string texto)
        {
            this.txt = texto;
        }

        public void Escribir()
        {
            Console.WriteLine(txt);
            ok ("Evento capturado",null);
        }
    }
}
