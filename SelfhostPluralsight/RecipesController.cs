using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SelfhostPluralsight
{
    public class RecipesController : ApiController
    {
        public string Get()
        {
            return "Hello from my Controller";
        }
    }
}
