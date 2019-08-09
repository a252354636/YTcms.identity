using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YTcms.DataModels;

namespace YTcms.Services
{
   public interface IAdminService
    {
        Task<dt_users> GetByStr(string username, string pwd);//根据用户名和密码查找用户
    }
}
