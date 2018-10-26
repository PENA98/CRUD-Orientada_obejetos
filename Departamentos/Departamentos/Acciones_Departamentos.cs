using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// namespaces necesarios
using System.Data;
using System.Data.SqlClient;

namespace Departamentos
{
    class Acciones_Departamentos
    {
        protected SqlConnection conn = new SqlConnection(@"server = (local)\sqlexpress;
            integrated security = true; database = AdventureWorks2014");
        protected string sql;

        public Acciones_Departamentos() { }


    }
}
