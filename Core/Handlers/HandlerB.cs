using static Core.Context;

namespace Core.Handlers
{
   public class SugarHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            if (request.ToString() == "Sugar")
            {
                return $"Sugar: Available {request.ToString()}.\n";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}