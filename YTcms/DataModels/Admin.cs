using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YTcms.DataModels
{
    public class dt_users
    {
        public int Id { get; set; }
        public DateTime reg_time { get; set; }
        public string user_name { get; set; }
        public string password { get; set; }

        public int site_id { get; set; }
        public string nick_name { get; set; }
    }
}
