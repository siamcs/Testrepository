using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testrepository.DAL
{
    public interface ITSPRepository
    {
        List<TSP> Get();
        TSP Get(int id);
        bool Add(TSP name);
        bool Update(TSP name);
        bool Delete(int id);
    }
}
