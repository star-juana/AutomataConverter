using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AFNDConverter
{
    class Converter
    {
        //Atributo de la clase que contendrá el AFND a convertir
        //TODO: Discutir sobre el uso de propiedades o atributos
        public AFND _AFND;
        public AFD _AFD;

        #region Constructor
        public Converter(AFND afnd)
            {
                this._AFND = afnd;
            }
        #endregion


    }
}
