namespace JohanniteLanding.Models
{
    public class Link
    {
        public int LinkId {get; set;}
        public string Href { get; set; }
        public string displayName { get; set; }

        public string ImageLink { get; set; }
        public bool Active { get; set; }
    }
}