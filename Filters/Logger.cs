using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Mvc;

namespace _0001_DemonstracaoMVC.Filters
{
    public class Logger : System.Web.Mvc.ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("Filtro antes da Execução");
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("Depois da Execução");
            base.OnActionExecuted(filterContext);
        }


        //public override void OnActionExecuting(HttpActionContext actionContext)
        //{
        //    Debug.WriteLine("Filtro antes da Execução");
        //    base.OnActionExecuting(actionContext);
        //}

        //public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        //{
        //    Debug.WriteLine("Depois da Execução");
        //    base.OnActionExecuted(actionExecutedContext);
        //}
    }
}