using CCFoodsServer2.Models;
using CCFoodsServer2.Persistencia.Dal;
using System.Collections.Generic;

namespace CCFoodsServer2.Servicos
{
    public class GarcomServico
    {
        private GarcomDAL garcomDAL = new GarcomDAL();

        public IEnumerable<Garcom> GetAll()
        {
            return garcomDAL.GetAll();
        }

        public void Insert(Garcom garcon)
        {
            garcomDAL.Insert(garcon);
        }
    }
}
