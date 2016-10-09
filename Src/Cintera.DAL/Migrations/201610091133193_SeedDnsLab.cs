using System.Collections.Generic;

namespace Cintera.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDnsLab : DbMigration
    {
        private readonly IList<string> _data;

        public SeedDnsLab()
        {
            _data = new List<string>
            {
                "Lab Name 1",
                "Lab Name 2",
                "Lab Name 3",
                "Lab Name 4",
                "Lab Name 5",
                "Lab Name 6"
            };


        }
        public override void Up()
        {
            foreach (var data in _data)
            {
                Sql($"insert into DnsLab(name) values(N'{data}')");
            }
        }
        
        public override void Down()
        {
            foreach (var data in _data)
            {
                Sql($"delete from DnsLab where name = N'{data}'");
            }
        }
    }
}
