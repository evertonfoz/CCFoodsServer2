using CCFoodsServer2.Models;
using CCFoodsServer2.Persistencia.Contexts;
using System.Collections.Generic;

namespace CCFoodsServer2.Persistencia.Dal
{
    public class GarcomDAL
    {
        private CCFContexts contexto = new CCFContexts();

        public IEnumerable<Garcom> GetAll()
        {
            return contexto.Garcons;
        }

        public void Insert(Garcom garcom)
        {
            contexto.Garcons.Add(garcom);
            contexto.SaveChanges();
        }
    }
}
