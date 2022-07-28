using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc; //for custom helpers import

namespace CrudOperations
{
    public static class CustomHelper
    {
        //creating custom helper fuctionality
        public static IHtmlString Image(string src, string alt)
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}'></img>",src,alt));
        }
        public static IHtmlString Img(this HtmlHelper helprt, string src, string alt)
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt='{1}'></img>", src, alt));
        }
    }
}