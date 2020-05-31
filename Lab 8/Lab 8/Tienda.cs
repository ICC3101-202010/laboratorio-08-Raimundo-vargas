using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Tienda : Local
    {
        List<string> categorias;

        public Tienda(string dueno, string id, string horario, string tipo, List<string> categorias) : base(dueno, id, horario, tipo)
        {
            this.categorias = categorias;
        }

        public override string Verinformacion()
        {
            string cat="";
            for (int i = 0; i < categorias.Count; i++)
            {
                cat += categorias[i]+"\n";
            }
            return cat;
            

        }
    }
}
