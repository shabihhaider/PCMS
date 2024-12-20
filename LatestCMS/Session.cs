using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatestCMS
{
    public class Session
    {
        public string Username { get; set; }
        public string Role { get; set; }

        public string UserID { get; set; }

        public void ClearSession()
        {
            Username = null;
            Role = null;
            UserID = null;
        }
    }
}
