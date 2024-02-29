using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testrepository.DAL;

namespace Testrepository.BL
{
    public class TSPBusiness
    {
        ITSPRepository _repository;
        public TSPBusiness(ITSPRepository repository)
        {
             _repository = repository;
        }

        public List<TSP> Get()
        {
            return _repository.Get();
        }

        public TSP Get(int id)
        {
            return _repository.Get(id);
        }

        public bool Add(TSP name)
        {
            return _repository.Add(name);
        }

        public bool Update(TSP name)
        {
            return _repository.Update(name);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}
