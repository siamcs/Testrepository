using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testrepository.DAL
{
   public  class TSP
    {

        public int TSPId;
        public string TSPName;
        public string TSPAddress;
        public TSP()
        {
        }
        public TSP(int id, string name, string address)
        {
            TSPId = id;
            TSPName = name;
            TSPAddress = address;
        }
    }
}
