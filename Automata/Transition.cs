using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFNDConverter
{
    class Transition
    {
        public string from;
        public string with;
        public string[] to;

        public Transition(string from, string with, string[] to)
        {
            this.from = from;
            this.with = with;
            this.to = to;
        }

        #region Metodos de Validación
        #endregion
    }
}