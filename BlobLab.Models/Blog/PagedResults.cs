using System;
using System.Collections.Generic;
using System.Text;

namespace BlobLab.Models.Blog
{
    public class PagedResults<T>
    {
        public IEnumerable<T> Items { get; set; }

        public int PageSize { get; set; }
    }
}
