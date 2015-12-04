using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;


namespace WebApplication6
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            //ModelBinders.Binders.Add(typeof(decimal),
            //    new FlexModelBinder(s => Convert.ToDecimal(s, CultureInfo.CurrentCulture)));
        }
    }

    //public class FlexModelBinder : IModelBinder
    //{
    //    private Func<object, decimal> p;
    //    Func<string, object> _convFn = null;

    //    public FlexModelBinder(Func<string, object> convFunc)
    //    {
    //        _convFn = convFunc;
    //    }

    //    public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
    //    {
    //        ValueProviderResult valueResult = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);
    //        ModelState modelState = new ModelState { Value = valueResult };
    //        object actualValue = null;
    //        try
    //        {
    //            actualValue = _convFn(valueResult.AttemptedValue);
    //        }
    //        catch(FormatException e)
    //        {
    //            modelState.Errors.Add(e);

    //        }

    //        bindingContext.ModelState.Add(bindingContext.ModelName, modelState);
    //        return actualValue;
    //        //throw new NotImplementedException();
    //    }
    //}
}
