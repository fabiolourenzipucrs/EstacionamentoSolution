using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace EstacionamentoApp
{
    public class ticket
    {

        Guid id;
        DateTime time;

        public ticket()
        {
            new ticket();
            id = new Guid();
        }

        Guid getid()
        {
            return id;
        }

        DateTime gettime()
        {
            return time;
        }
        

    }
}