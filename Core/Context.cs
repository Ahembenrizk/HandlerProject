using System;
using Core.Interfaces;
using Core.Handlers;
using System.Collections.Generic;

namespace Core
{
    public class Context
    {
        
      // The default chaining behavior can be implemented inside a base handler
      // class.
       public abstract class AbstractHandler : HandlerInterface
       {
          private HandlerInterface _nextHandler;
          public HandlerInterface SetNext(HandlerInterface handler)
           {
              this._nextHandler = handler;
            
               // Returning a handler from here will let us link handlers in a
               // convenient way like this:
               // monkey.SetNext(squirrel).SetNext(dog);
              return handler;
            }
        
           public virtual object Handle(object request)
            {
                 if (this._nextHandler != null)
                {
                    return this._nextHandler.Handle(request);
                }
                else
                {
                   return null;
                }
            }
        }
          public static void ContextCode(AbstractHandler handler)
        {
           // foreach (var Cup in new List<string> { "Latte", "Espresso", "BlackCoffee" })
            //{
                  // Ask the user to choose an operator.
                Console.WriteLine("Select your coffee from the list below :");
                Console.WriteLine("\t 1 - Latte");
                Console.WriteLine("\t 2 - Espresso");
                Console.WriteLine("\t 3 - BlackCoffee");
                string Cup = Console.ReadLine();
              switch (Cup)
              {
                case "1" :
                {
                  foreach (var Ingredient  in new List<string> { "Milk", "Sugar", "Coffee" })
                  {
                    Console.WriteLine($" is there {Ingredient}?");
                    var result = handler.Handle(Ingredient);

                    if (result != null)
                    {
                       Console.Write($"   {result}");
                    }
                    else
                    {
                       Console.WriteLine($" {Ingredient} was left untouched.");
                    }
                  }
                  Console.WriteLine($" Your cup of {Cup} is ready ----------------- ");
                  break;
                }
//-------------------------------------------------------------------------------------------------------
                    case "2" :
                {
                  foreach (var Ingredient  in new List<string> { "Sugar", "Coffee" })
                  {
                    Console.WriteLine($" is there {Ingredient}?");
                    var result = handler.Handle(Ingredient);

                    if (result != null)
                    {
                       Console.Write($"   {result}");
                    }
                    else
                    {
                       Console.WriteLine($" {Ingredient} was left untouched.");
                    }
                  }
                  Console.WriteLine($" Your cup of {Cup} is ready ----------------- ");
                  break;
                }
 //----------------------------------------------------
                case "3" :
                {
                  foreach (var Ingredient  in new List<string> { "Water", "Sugar", "Coffee" })
                  {
                    Console.WriteLine($" is there {Ingredient}?");
                    var result = handler.Handle(Ingredient);

                    if (result != null)
                    {
                       Console.Write($"   {result}");
                    }
                    else
                    {
                       Console.WriteLine($" {Ingredient} was left untouched.");
                    }
                  }
                  Console.WriteLine($" Your cup of {Cup} is ready ----------------- ");
                  break;
                }
                  
                  default:
                  break;
              }
             

                
        
    
    
    }
  }
}


