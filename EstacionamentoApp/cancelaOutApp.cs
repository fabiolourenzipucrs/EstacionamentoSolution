using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstacionamentoApp
{
    public class cancelaOutApp
    {

        IGenericDAO<ticket> generic;

        void valida(ticket t)
        {
            generic.Get(t);
        }
    }


}
