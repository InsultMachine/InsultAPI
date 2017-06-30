using System.Collections.Generic;
using Data.Models;

namespace Api.Controllers
{
    public interface IInsultController
    {
        string AddInsult(string text);
        List<Insult> GetInsults();
    }
}