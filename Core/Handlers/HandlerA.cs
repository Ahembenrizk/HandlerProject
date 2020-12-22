using Core.Interfaces;
using static Core.Context;

namespace Core.Handlers
{
        public class MilkHandler : AbstractHandler 
    {
        public override object Handle(object request)
        {
            if ((request as string) == "Milk")
            {
                return $"Milk: available {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}