using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio39
{
    public class SobreSobreescrito: Sobreescrito
    {
        public override string MiPropiedad
        {
            get { return this._miAtributo; }
        }

        public SobreSobreescrito():base()
        {}

        public override string MiMetodo()
        {
            return this.MiPropiedad;
        }
    }
}
