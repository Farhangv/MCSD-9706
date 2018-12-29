using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace PropMan.Library
{
    public static class EnumExtensions
    {
        public static HtmlString GetDisplayName(this Enum enumValue)
        {
            return 
                new HtmlString(
                 enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()
                .GetName());
        }

        public static HtmlString GetEnumDisplayName(this HtmlHelper html, Enum enumValue)
        {
            return
                new HtmlString(
                 enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()
                .GetName());
        }
    }
}