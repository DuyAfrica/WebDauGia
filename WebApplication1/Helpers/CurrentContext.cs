using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Helpers
{
    public class CurrentContext
    {
        public static bool IsLogged()
        {
            var flag = HttpContext.Current.Session["isLogin"];
            if(flag==null||(int)flag==0)
            {
                return false;
            }
            return true;
        }

        internal static void Destroy()
        {
            HttpContext.Current.Session["isLogin"] = 0;
        }
    }
}