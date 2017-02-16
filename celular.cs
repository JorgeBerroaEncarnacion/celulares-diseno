using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celularesDiseno
{
    abstract class celular 
    {
        private celular Cel;
       

       
        public abstract float costo();

        public abstract string descripcion();

        public void plug()
        {
            throw new NotImplementedException();
        }
    }
}
