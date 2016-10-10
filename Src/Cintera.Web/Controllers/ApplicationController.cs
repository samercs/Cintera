using Cintera.DAL;
using System.Web.Mvc;

namespace Cintera.Web.Controllers
{
    public class ApplicationController : Controller
    {
        public ApplicationController(IDatabaseContext context)
        {

        }
    }
}