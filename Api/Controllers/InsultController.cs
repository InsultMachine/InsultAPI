using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Data.Models;
using Data.Repository;

namespace Api.Controllers
{
    public class InsultController : ApiController
    {
        private readonly IInsultRepository _insultRepository;


        public InsultController(IInsultRepository insultRepository)
        {
            _insultRepository = insultRepository;
        }

        [HttpGet]
        [Route("Insult/GetAll")]
        public List<Insult> GetInsults()
        {
            return _insultRepository.GetAll().ToList();
        }

        [HttpGet]
        [Route("Insult/Add")]
        public async Task<IHttpActionResult> AddInsult(string text)
        {
            await _insultRepository.Add(new Insult { Text = text, Rating = 0 });
            return Ok();
        }


        [HttpGet]
        [Route("Insult/IncRating")]
        public async Task<IHttpActionResult> IncRating(int insultId)
        {
            await _insultRepository.IncRating(insultId);
            return Ok();
        }

        [HttpGet]
        [Route("Insult/DecRating")]
        public async Task<IHttpActionResult> DecRating(int insultId)
        {
            await _insultRepository.DecRating(insultId);
            return Ok();
        }

        [HttpGet]
        [Route("Insult/DecRating")]
        public async Task<IHttpActionResult> Delete(Insult insult)
        {
            await _insultRepository.Delete(insult);
            return Ok();
        }
    }
}
