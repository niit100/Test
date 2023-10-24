using Cards_Example.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cards_Example.InterfacesDLL
{
    public interface ICard
    {
        public ActionResult<IEnumerable<Card>> Get(Card request);
    }
}
