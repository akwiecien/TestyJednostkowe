using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestyJednostkowe
{
    public class vocabularies : ivocabularies
    {
        private List<vocabulary> lista = new List<vocabulary>();

        public vocabularies()
        {
            lista = new List<vocabulary>()
            {
                new vocabulary{id=1,pol="jeden",eng="one",nextRepeat=new DateTime(2018,6,15)},
                new vocabulary{id=1,pol="dwa",eng="two",nextRepeat=new DateTime(2018,6,13)},
                new vocabulary{id=1,pol="trzy",eng="three",nextRepeat=new DateTime(2018,6,14)},
            };
        }

        public string Convert(string tekst)
        {
            return tekst.ToUpper();
        }

        public List<vocabulary> GetItems()
        {
            return this.lista;
        }

        public void Log(string tekst)
        {
            //TODO
        }
    }
}
