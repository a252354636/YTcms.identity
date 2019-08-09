using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YTcms.DataModels;
using YTcms.DBContext;

namespace YTcms.Services
{
    public class AdminService : IAdminService
    {
        public EFContext db;
        public AdminService(EFContext _efContext)
        {
            db = _efContext;
        }
        /// <summary>
        /// 验证用户，成功则返回用户信息，否则返回null
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public async Task<dt_users> GetByStr(string username, string pwd)
        {
            dt_users m = await db.dt_users.Where(a => a.user_name == username && a.site_id ==Convert.ToInt32(pwd)).SingleOrDefaultAsync();
            if (m != null)
            {
                return m;
            }
            else
            {
                return null;
            }
        }
    }
}
