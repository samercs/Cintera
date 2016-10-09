using System.Collections.Generic;

namespace Cintera.DAL
{
    public class Case
    {
        public int CaseId { get; set; }

        public virtual ICollection<Sighting> Sightings { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}