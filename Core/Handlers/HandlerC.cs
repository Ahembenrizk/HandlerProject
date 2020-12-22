 using Core;
 using Core.Interfaces;
using static Core.Context;

namespace Core.Handlers
{
    public class CoffeeHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Coffee")
            {
                return $"Coffee: available {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }

}