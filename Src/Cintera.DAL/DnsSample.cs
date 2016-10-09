using System.ComponentModel.DataAnnotations.Schema;

namespace Cintera.DAL
{
    public partial class DnsSample
    {
        public int Id { get; set; }
        public Enum.DnsSample.DnsSampleStatusEnum SampleStatusId { get; set; }
        [ForeignKey("SampleStatusId")]
        public virtual DnsSampleStatus SampleStatus { get; set; }
    }
}