namespace Cintera.DAL
{
    public class DatabaseContext : IDatabaseContext
    {
        public ICerteraContext GetContext()
        {
            return new CenteraContext();
        }
    }
}