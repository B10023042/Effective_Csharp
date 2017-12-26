using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EffectiveCsharp._01
{
    class EnumerableAndQueryable
    {
        public IEnumerable<String> FindCustomersStartingWith1(string start)
        {
            IEnumerable<string> q =
                from c in db.Customer
                select c.ContactName;

            var q2 = q.Where(s => s.StartsWith(start));


            return q2;
        }

        public IEnumerable<String> FindCustomersStartingWith2(string start)
        {
            DataTable db = new DataTable();

            var q =
                from c in db
                select c.ContactName;

            var q2 = q.Where(s => s.StartsWith(start));


            return q2;
        }
    }
}
