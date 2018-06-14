using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestyJednostkowe;
using Moq;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class GetItemsMetodTests
    {
        [TestMethod][Owner("akwiecien")]
        public void GetItemsCountEquals1()
        {
            Mock<ivocabularies> vocsMoq = new Mock<ivocabularies>();
            //jeśli nie implementujemy interface tylko klasę, to metoda musi być virtual ??
            vocsMoq.Setup(x => x.GetItems()).Returns(itemsAtrapa());
            //Wyobraśmy sobie sytuację, że motoda GetItems() zwraca nam kolekcję obiektów
            //pozyskany z bazy danych lub z rest.
            //Nie możemy tworzyć testu na żywej bazie danyc. Baza bedzie się zmieniać, lub może zniknąć
            //dlatego klasa moq będzie na potrzeby unit testu udawać vocabularies i zwróci nam dane na niby z bazy danych
            //a jednocześne przetestuje nam w pełni klasę która się łączy z bazą danych
            Assert.AreEqual(1, vocsMoq.Object.GetItems().Count);
        }
        [TestMethod][Owner("akwiecien")]
        public void GetItemsIsNotNull()
        {
            Mock<ivocabularies> vocsMoq = new Mock<ivocabularies>();
            vocsMoq.Setup(x => x.GetItems()).Returns(itemsAtrapa());
            Assert.IsNotNull(vocsMoq.Object.GetItems());
        }
        [TestMethod][Owner("akwiecien")]
        public void GetItemsPropertiesValuesChcek()
        {
            Mock<ivocabularies> vocsMoq = new Mock<ivocabularies>();
            vocsMoq.Setup(x => x.GetItems()).Returns(itemsAtrapa());
            Assert.AreEqual("falszywy", vocsMoq.Object.GetItems()[0].pol);
            Assert.AreEqual("fake", vocsMoq.Object.GetItems()[0].eng);
            Assert.AreEqual(1, vocsMoq.Object.GetItems()[0].id);
            Assert.AreEqual(new DateTime(2018, 06, 11).ToString(), vocsMoq.Object.GetItems()[0].nextRepeat.ToString());
            vocsMoq.Verify();
        }
        /// <summary>
        /// Prywatna metoda dla testowania metody GetItems()
        /// </summary>
        /// <returns></returns>
        private List<vocabulary> itemsAtrapa()
        {
            return new List<vocabulary>()
            {
                new vocabulary{id=1,pol="falszywy",eng="fake",nextRepeat=new DateTime(2018,06,11)}
            };
        }


    }
}
