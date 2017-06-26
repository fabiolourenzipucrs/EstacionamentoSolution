using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EstacionamentoApp
{
    public class cancelaInApp
    {

        IGenericDAO <ticket> generic;
        ticket t;
        

        void emite()
        {
            t = new ticket();
            generic.Add(t);
        }
    }

 
}