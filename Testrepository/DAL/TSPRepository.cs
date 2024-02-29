using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testrepository.DAL
{
    public class TSPRepository:ITSPRepository
    {
        List<TSP> listTSP = new List<TSP>()
        {
            new TSP(1, "USSL", "PanthoPath"),
            new TSP(2, "BITL", "Mirpur"),
            new TSP(3, "PNTL", "PanthoPath"),
            new TSP(4, "CGNT", "Palton")
        };
        public List<TSP> Get()
        {
            return listTSP.OrderBy(T => T.TSPId).ToList();
        }
        public TSP Get(int id)
        {
            TSP oTSP = listTSP.Where(T => T.TSPId == id).FirstOrDefault();
            return oTSP;
        }

        public bool Add(TSP name)
        {
            listTSP.Add(name);
            return true;
        }

        public bool Update(TSP name)
        {
            bool isExecuted = false;
            TSP oTSP = listTSP.Where(T => T.TSPId == name.TSPId).FirstOrDefault();
            if (oTSP != null)
            {
                listTSP.Remove(oTSP);
                listTSP.Add(name);
                isExecuted = true;
            }
            return isExecuted;
        }

        public bool Delete(int id)
        {
            bool isExecuted = false;
            TSP oTSP = listTSP.Where(L => L.TSPId == id).FirstOrDefault();
            if (oTSP != null)
            {
                listTSP.Remove(oTSP);
                isExecuted = true;
            }
            return isExecuted;
        }
    }
}
