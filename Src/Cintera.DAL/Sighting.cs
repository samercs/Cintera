using System;

namespace Cintera.DAL
{
    public class Sighting
    {
        public int SightingId { get; set; }
        public int InvistigationId { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public virtual Invistigation Invistigation { get; set; }
    }
}