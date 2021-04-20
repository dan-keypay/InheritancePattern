using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Utility.Api;

namespace InheritancePattern.Controllers
{
    public class BaseController : Controller
    {
        protected ActionResult JsonSuccess(object data)
        {
            var model = new JsonResponse<object> {status = JsonStatus.success.ToString(), data = data};
            return JsonResult(model);
        }

        protected ActionResult JsonError(Dictionary<string, string> modelErrors)
        {
            var model = new JsonResponse<object> {status = JsonStatus.error.ToString(), errors = modelErrors, message = "Invalid data"};
            return JsonResult(model);
        }

        private ActionResult JsonResult(object model)
        {
            const string contentType = "application/json";

            return Json(model, contentType, JsonRequestBehavior.AllowGet);
        }
        
        protected Dictionary<string, string> ModelErrors
        {
            get
            {
                var errors = new Dictionary<string, string>();
                foreach (var key in ModelState.Keys.Where(x => ModelState[x].Errors.Count > 0))
                {
                    foreach (var error in ModelState[key].Errors)
                    {
                        if (errors.ContainsKey(key))
                            errors[key] += ", " + (error.ErrorMessage);
                        else
                            errors.Add(key, error.ErrorMessage);

                    }
                }

                return errors;
            }
        }
    }
}