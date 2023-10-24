using Cards_Example.InterfacesDLL;
using Cards_Example.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cards_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardController : ControllerBase
    {
       
        private readonly ICard _card;
        private List<Card> cards;
        public CardController(ICard card)
        {
            _card = card;
            cards = new List<Card>
            {
            };
        }

        [HttpGet]
        public ActionResult<IEnumerable<Card>> Get(Card request)
        {
           _card.Get(request);
            return Ok(cards);
        }

        [HttpGet("{name}")]
        public ActionResult<Card> Get(string name)
        {
            var card = cards.FirstOrDefault(c => c.Name == name);
            if (card == null)
            {
                return NotFound();
            }
            return Ok(card);
        }
    }
}
