using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace VaccineRegistration
{
    class Vaccination
    {
        private static string MyConn = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public string Id { get; set; }

        public string Surname { get; set; }

        public string FirstName { get; set; }

        public string Gender { get; set; }

        public string Province { get; set; }

       


    }
   
}
    

