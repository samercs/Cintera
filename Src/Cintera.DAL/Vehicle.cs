namespace Cintera.DAL
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public int CaseId { get; set; }
        public virtual Case Case { get; set; }
        public string VehicleIdentitficationNumber { get; set; }
    }
}