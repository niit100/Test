namespace Cards_Example.Models
{
    public class Card
    {
        public string Name { get; set; }
        public string ManaCost { get; set; }
        public int CMC { get; set; }
        public List<string> Colors { get; set; }
        public List<string> ColorIdentity { get; set; }
        public string Type { get; set; }
        public List<string> Types { get; set; }
        public List<string> Subtypes { get; set; }
        public string Rarity { get; set; }
        public string Set { get; set; }
        public string SetName { get; set; }
        public string Text { get; set; }
        public string Artist { get; set; }
        public string Number { get; set; }
        public int Power { get; set; }
        public int Toughness { get; set; }
        public string Layout { get; set; }
        public string MultiverseId { get; set; }
        public List<string> Variations { get; set; }
        public List<ForeignName> ForeignNames { get; set; }
        public List<string> Printings { get; set; }
        public string OriginalText { get; set; }
        public string OriginalType { get; set; }
        public List<LegalityObj> Legalities { get; set; }
        public string Id { get; set; }
    }
    public class ForeignName
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public string Flavor { get; set; }
        public string ImageUrl { get; set; }
        public string Language { get; set; }
        public string MultiverseId { get; set; }
    }

    public class LegalityObj
    {
        public string Format { get; set; }
        public string Legality { get; set; }
    }
}
