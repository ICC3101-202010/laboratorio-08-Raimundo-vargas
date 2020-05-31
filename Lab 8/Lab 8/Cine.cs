using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    class Cine : Local
    {
        string salas;

        public Cine(string dueno, string id, string horario, string tipo, string salas) : base(dueno, id, horario, tipo)
        {
            this.salas = salas;
        }
    }
}
