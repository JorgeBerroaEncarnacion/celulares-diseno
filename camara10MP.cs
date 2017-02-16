using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celularesDiseno 
{
    class camara10MP : camara
    {
        private PersonalCel Cel;
        private string Camaras;
        
        public camara10MP(celular cel) : base(cel)
        {
        }

        public new void capturar()
        {
        }

        protected celular celu(celular cel)
        {
            return Cel;
        }

        public override float costo()
        {
            return this.Cel.costo() + 100;
        }

        public override string descripcion()
        {
            return this.Cel.descripcion() + ", camara 10mp";
        }
    }
}
