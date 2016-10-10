using System.Collections.Generic;

namespace Cintera.DAL
{
    public class Invistigation
    {
        public int InvistigationId { get; set; }

        public virtual ICollection<Sighting> Sightings { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}