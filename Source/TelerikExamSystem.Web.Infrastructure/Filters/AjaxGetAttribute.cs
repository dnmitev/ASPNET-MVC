﻿namespace TelerikExamSystem.Web.Infrastructure.Filters
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Web.Mvc;

    public class AjaxGetAttribute : AjaxOnlyAttribute
    {
        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            return base.IsValidForRequest(controllerContext, methodInfo) &&
                   controllerContext.RequestContext.HttpContext.Request.HttpMethod == "GET";
        }
    }
}