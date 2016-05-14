using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace myBlog.Models.Mappings
{
    public class CategoryMap : ClassMap<Category>
    {
        public CategoryMap()
        {
            Id(x => x.Id);
            Map(x => x.Name).Length(500).Not.Nullable();
            Map(x => x.Description).Length(2000).Not.Nullable();
            Map(x => x.UrlBlog).Length(50).Not.Nullable();
            HasManyToMany(x => x.Posts).Cascade.All().Inverse().Table("PostTagMap");

        }
    }
}
