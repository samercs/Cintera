namespace Cintera.DAL
{
    public class Region
    {
        public int RegionId { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public Region Parent { get; set; }

    }

    public class Country : Region { }

    public class County : Region { }

    public class State : Region { }
}