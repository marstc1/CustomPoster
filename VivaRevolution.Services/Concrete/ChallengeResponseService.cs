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
            if (!String.IsNullOrEmpty(System.Web.HttpContext.Current.User.Identity.Name))
            {
                string login = System.Web.HttpContext.Current.User.Identity.Name;
                string racfid = login.Split('\\')[1].ToUpper();

                return racfid;
            }
            else
            {
                return "Unknown";
            }
        }
    }
}
