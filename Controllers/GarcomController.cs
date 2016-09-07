using CCFoodsServer2.Models;
using CCFoodsServer2.Servicos;
using System.Collections.Generic;
using System.Web.Http;

namespace CCFoodsServer2.Controllers
{
    public class GarcomController : ApiController
    {
        private GarcomServico garcomServico = new GarcomServico();

        // GET: api/Garcom
        public IEnumerable<Garcom> Get()
        {
            return garcomServico.GetAll();
        }

        // GET: api/Garcom/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Garcom
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Garcom/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Garcom/5
        public void Delete(int id)
        {
        }
    }
}
