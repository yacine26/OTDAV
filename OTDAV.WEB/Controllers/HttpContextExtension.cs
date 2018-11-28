
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OTDAV.DOMAIN.Entities;

namespace Epione.Web.Extensions
{
    public static class HttpContextExtensions
    {
        public static adherent GetUser(this HttpContextBase context)
        {
            return (adherent)context.Session["IUser"];
        }
    }
}