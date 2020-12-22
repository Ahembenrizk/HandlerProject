namespace Core.Interfaces 
{
     // The Handler interface declares a method for building the chain of
    // handlers. It also declares a method for executing a request.
    public interface HandlerInterface
    {
       public HandlerInterface SetNext(HandlerInterface handler);
        
        public object Handle(object request);
    }
}