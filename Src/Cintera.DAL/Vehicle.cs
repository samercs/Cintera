namespace Cintera.DAL
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public int InvistigationId { get; set; }
        public virtual Invistigation Invistigation { get; set; }
        public string VehicleIdentitficationNumber { get; set; }
    }
}