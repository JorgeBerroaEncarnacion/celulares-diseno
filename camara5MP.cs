using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celularesDiseno
{
    class camara5MP : camara
    {
        private celular Cel;
        private string Cam;

        

        public camara5MP(celular cel) : base(cel)
        {
            this.Cel = cel;
        }

        public new void capturar()
        {
            
        }

        public string cam()
        {
            return "camara 5mp";
        }

        public override float costo()
        {
            return this.Cel.costo() + 50;
        }

        public override string descripcion()
        {
            return this.Cel.descripcion() + ", camara 5mp";
        }
    }
}
