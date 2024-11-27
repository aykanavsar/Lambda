using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoinPratik1
{
    public class Yazarlar
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }

    }

    public class Kitaplar
    {
        public int BookID { get; set; }
        public string Title { get; set; }

        public int BAuthorID { get; set; }
    }
}
