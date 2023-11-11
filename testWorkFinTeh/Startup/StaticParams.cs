using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testWorkFinTeh.Methods;
using testWorkFinTeh.Models;

namespace testWorkFinTeh.Startup
{
    internal class StaticParams
    {
        static List<IdGuidNameStruct> roleList;
        static List<IdGuidNameStruct> departList;
        public static List<IdGuidNameStruct> getRole()
        {
            if (roleList == null || roleList.Count == 0)
            {
                var loader = new GetData();
                roleList = loader.GetRoles();
            }

            return roleList;
        }
        public static List<IdGuidNameStruct> getDepart()
        {
            if (departList == null || departList.Count == 0)
            {
                var loader = new GetData();
                departList = loader.GetDeparts();
            }

            return departList;
        }
    }
}
