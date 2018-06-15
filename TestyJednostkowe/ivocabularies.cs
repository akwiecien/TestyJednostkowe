using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyJednostkowe
{
    public interface ivocabularies
    {
        List<vocabulary> GetItems();
        vocabulary GetFirst();
    }
}
