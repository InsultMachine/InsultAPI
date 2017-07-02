using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Data.Models;
using Data.Presistence;

namespace Api.Controllers
{
    public class InsultController : ApiController
    {
        
        private readonly IUnitOfWork _unitOfWork;


        public InsultController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        [Route("Insult/GetAll")]
        public List<Insult> GetInsults()
        {
            return _unitOfWork.Insults.GetAll().ToList();
        }

        [HttpGet]
        [Route("Insult/Add")]
        public async Task<IHttpActionResult> AddInsult(string text)
        {
            await _unitOfWork.Insults.Add(new Insult { Text = text, Rating = 0 });
            _unitOfWork.Complete();
            return Ok();
        }


        [HttpGet]
        [Route("Insult/IncRating")]
        public async Task<IHttpActionResult> IncRating(int insultId)
        {
            await _unitOfWork.Insults.IncRating(insultId);
            _unitOfWork.Complete();
            return Ok();
        }

        [HttpGet]
        [Route("Insult/DecRating")]
        public async Task<IHttpActionResult> DecRating(int insultId)
        {
            await _unitOfWork.Insults.DecRating(insultId);
            _unitOfWork.Complete();
            return Ok();
        }

        [HttpGet]
        [Route("Insult/Delete")]
        public async Task<IHttpActionResult> Delete(Insult insult)
        {
            await _unitOfWork.Insults.Delete(insult);
            _unitOfWork.Complete();
            return Ok();
        }
    }
}
