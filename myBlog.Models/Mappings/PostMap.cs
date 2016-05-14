using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;

namespace myBlog.Models.Mappings
{
    public class PostMap : ClassMap<Post>
    {
        public PostMap()
        {
            Id(x => x.Id);
            Map(x => x.Title).Length(500).Not.Nullable();
            Map(x => x.ShortDescription).Length(5000).Not.Nullable();
            Map(x => x.Description).Length(5000).Not.Nullable();
            Map(x => x.Meta).Length(1000).Not.Nullable();
            Map(x => x.IsPublished).Not.Nullable();
            Map(x => x.UrlBlog).Length(200).Not.Nullable();
            Map(x => x.PostedDate).Not.Nullable();
            Map(x => x.ModifiedDate);
            References(x => x.Category).Column("Category").Not.Nullable();
            HasManyToMany(x => x.Tags).Table("PostTagMap");
        }
    }
}
