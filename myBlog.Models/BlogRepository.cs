using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Linq;

namespace myBlog.Models
{
    public class BlogRepository : IBlogRepository
    {
        private readonly ISession _session;

        public BlogRepository(ISession session)
        {
            _session = session;
        }

        public IList<Post> Posts(int pageNo, int pageSize)
        {
            var post =
                _session.Query<Post>()
                    .Where(p => p.IsPublished)
                    .OrderByDescending(p => p.PostedDate)
                    .Skip(pageNo*pageSize)
                    .Take(pageSize)
                    .Fetch(p => p.Category)
                    .ToList();
            var postIds = post.Select(x => x.Id).ToList();
            return
                _session.Query<Post>()
                    .Where(x => postIds.Contains(x.Id))
                    .OrderByDescending(x => x.PostedDate)
                    .FetchMany(x => x.Tags)
                    .ToList();
        }

        public int TotalPosts()
        {
            return _session.Query<Post>().Where(x => x.IsPublished).Count();
        } 
    }
}
