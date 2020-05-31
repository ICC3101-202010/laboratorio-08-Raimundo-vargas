using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Recreacional : Local

    {
        public Recreacional(string dueno, string id, string horario, string tipo) : base(dueno, id, horario, tipo)
        {
        }
        public override string Verinformacion()
        {
            return "";
        }
    }
}
