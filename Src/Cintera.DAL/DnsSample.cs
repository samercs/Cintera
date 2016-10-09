using Cintera.DAL.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cintera.DAL
{
    public partial class DnsSample
    {
        public int Id { get; set; }
        public DnsSampleStatusEnum SampleStatusId { get; set; }
        [ForeignKey("SampleStatusId")]
        public virtual DnsSampleStatus SampleStatus { get; set; }
        public int DnsLabId { get; set; }
        public virtual DnsLab DnsLab { get; set; }
    }
}