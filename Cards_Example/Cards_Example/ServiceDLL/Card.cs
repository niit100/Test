using Cards_Example.InterfacesDLL;
using Microsoft.AspNetCore.Mvc;

namespace Cards_Example.ServiceDLL
{
    public class Card : ICard
    {
        public ActionResult<IEnumerable<Models.Card>> Get(Models.Card request)
        {
            //All the database logic here..
            return null;
        }
       
    }
}
