using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFNDConverter
{
    class Transition
    {
        private string from;            
        public string with;
        public string to;

        public Transition(string from, string with, string to)
        {
            this.from = from;
            this.with = with;
            this.to = to;
        }

        #region Metodos de Validación
        public string From
        {
            get { return from; }
            set { from = value; }
        }
        public string With
        {
            get { return with; }
            set { with = value; }
        }
        public string To
        {
            get { return to; }
            set { to = value; }
        }

        #endregion
    }
}