using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Data;
using Data.Models;
using Data.Repository;

namespace Api.Controllers
{
    public class InsultController : ApiController, IInsultController
    {
        private readonly IInsultRepository _insultRepository;

        public InsultController()
        {
            _insultRepository = new InsultRepository(new InsultContext());
        }

        [HttpGet]
        [Route("Insult/GetAll")]
        public List<Insult> GetInsults()
        {
            return _insultRepository.GetAll().ToList();
        }

        [HttpGet]
        [Route("Insult/Add")]
        public string AddInsult(string text)
        {
            _insultRepository.Add(new Insult { Text = text, Rating = 0});
            return "Success";
        }
    }
}
