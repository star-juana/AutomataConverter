using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AFNDConverter
{
    class Transition
    {
        public string _inicia;            
        public string _con;
        public string _terminaEn;

        public Transition(string from, string with, string to)
        {
            this._inicia = from;
            this._con = with;
            this._terminaEn = to;
        }

        #region Metodos de Validación
        public string Inicia
        {
            get { return _inicia; }
            set { _inicia = value; }
        }
        public string Con
        {
            get { return _con; }
            set { _con = value; }
        }
        public string terminaEn
        {
            get { return terminaEn; }
            set { terminaEn = value; }
        }

        #endregion
    }
}