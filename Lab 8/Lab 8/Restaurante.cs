using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Restaurante : Local
    {
        bool exclusivas;

        public Restaurante(string dueno, string id, string horario, string tipo, bool exclusivas) : base(dueno, id, horario, tipo)
        {
            this.exclusivas = exclusivas;
        }
    }
}
