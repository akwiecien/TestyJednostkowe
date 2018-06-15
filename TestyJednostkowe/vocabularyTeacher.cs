using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyJednostkowe
{
    public class vocabularyTeacher
    {
        ivocabularies vocabularies;
        public vocabularyTeacher(ivocabularies vocabularies)
        {
            this.vocabularies = vocabularies;
        }

        public vocabulary GetFirst()
        {
            return vocabularies.GetFirst();
        }
    }
}
