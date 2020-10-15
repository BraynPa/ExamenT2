using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using N00029793T2.Models;

namespace N00029793T2.Controllers
{
    
        public abstract class BaseController : Controller
        {
            private readonly N00029793T2Context context;
            public BaseController(N00029793T2Context context)
            {
                this.context = context;
            }

            protected User LoggedUser()
            {
                var claim = HttpContext.User.Claims.FirstOrDefault();
                var user = context.Users.Where(o => o.Username == claim.Value).FirstOrDefault();
                return user;
            }
        }

}
