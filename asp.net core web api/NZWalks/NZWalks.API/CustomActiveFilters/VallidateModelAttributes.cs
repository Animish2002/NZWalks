using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace NZWalks.API.CustomActiveFilters
{
    public class VallidateModelAttributes : ActionFilterAttribute

    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            if(context.ModelState.IsValid == false) 
            {
                context.Result = new BadRequestResult();    
            }
        }
    }
}
