using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SimpleREST
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        private static List<Chips> chipsList = new List<Chips>
        {
            new Chips(1, "Pringles"),
            new Chips(2, "Lays"),
            new Chips {Id = 3, Name = "Taffel"}
        };

        public List<Chips> GetAllChips()
        {
            return chipsList;
        }
    }
}
