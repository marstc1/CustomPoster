using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaRevolution.Services.Abstract;

namespace VivaRevolution.Services.EmailService
{
    public class ChallengeResponseService : IChallengeResponseService
    {
        public string Invoke()
        {
            return System.Web.HttpContext.Current.User.Identity.Name.Split('\\')[1];
        }
    }
}
