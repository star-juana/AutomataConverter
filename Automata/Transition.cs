using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFNDConverter
{
    class Transition
    {
        public string inicia;            
        public string con;
        public string termina;

        public Transition(string from, string with, string to)
        {
            this.inicia = from;
            this.con = with;
            this.termina = to;
        }

        #region Metodos de Validación
        public string From
        {
            get { return inicia; }
            set { inicia = value; }
        }
        public string With
        {
            get { return con; }
            set { con = value; }
        }
        public string To
        {
            get { return termina; }
            set { termina = value; }
        }

        #endregion
    }
}