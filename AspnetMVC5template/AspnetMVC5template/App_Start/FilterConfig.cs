﻿using System.Web;
using System.Web.Mvc;

namespace AspnetMVC5template
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
