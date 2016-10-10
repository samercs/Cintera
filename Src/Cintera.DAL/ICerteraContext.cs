using System.Data.Entity;

namespace Cintera.DAL
{
    public interface ICerteraContext
    {
        IDbSet<Invistigation> Cases { get; set; }
        IDbSet<DnsSample> DnsSamples { get; set; }
        IDbSet<DnsSampleStatus> DnsSampleStatuses { get; set; }
        IDbSet<Region> Regions { get; set; }
        IDbSet<View1> View1 { get; set; }
    }
}