using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public abstract class Local
    {
        public string dueno;
        public string id;
        public string horario;
        public string tipo;

        protected Local(string dueno, string id, string horario, string tipo)
        {
            this.dueno = dueno;
            this.id = id;
            this.horario = horario;
            this.tipo = tipo;
        }

        public abstract string Verinformacion();
    }
}
