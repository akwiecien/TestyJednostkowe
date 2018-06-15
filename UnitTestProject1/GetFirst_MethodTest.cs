using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using TestyJednostkowe;

namespace UnitTestProject1
{
    [TestClass]
    public class GetFirst_MethodTest
    {
        [TestMethod]
        public void IF_First_Is_Correct()
        {
            //ARRANGE
            Mock<ivocabularies> mock = new Mock<ivocabularies>();
            //jeśli nie implementujemy interface tylko klasę, to metoda musi być virtual ??
            mock.Setup(x => x.GetFirst()).Returns(itemsAtrapa()[0]);
            //Wyobraśmy sobie sytuację, że motoda GetFirst() zwraca nam pierwszy obiekt z kolekcji
            //pozyskany z bazy danych lub z rest.
            //Nie możemy tworzyć testu na żywej bazie danych. Baza bedzie się zmieniać, może zniknąć a nawet może jeszcze nie istnieć
            //dlatego klasa moq będzie na potrzeby unit testu udawać ivocabularies i zwróci nam dane na niby z bazy danych
            //a jednocześne przetestuje nam w pełni klasę która która będzie korzystać z ivocabularies

            //dependency injection
            vocabularyTeacher teacher = new vocabularyTeacher(mock.Object);
            //ACT
            var ress = teacher.GetFirst();
            //ASSERT
            Assert.IsNotNull(ress);
            Assert.AreEqual("falszywy", ress.pol);
            Assert.AreEqual("fake", ress.eng);
            Assert.AreEqual(new DateTime(2018, 06, 11), ress.nextRepeat);

            //GENERALNIE
            //Nie tworzymy Moq dla klasy i metody którą chcemy przetestować.
            //Moq służy do stworzenia atrap bytów które sa potrzebne do przetestowania jakiejś metody
            //inaczej moq-iem tworzymy obiekty wykorzystywane, będące źródłem dla naszej testowanej metody lub które są jej potrzebne
        }
        /// <summary>
        /// Prywatna metoda dla testowania metody GetItems()
        /// </summary>
        /// <returns></returns>
        private List<vocabulary> itemsAtrapa()
        {
            return new List<vocabulary>()
            {
                new vocabulary{id=1,pol="falszywy",eng="fake",nextRepeat=new DateTime(2018,06,11)},
                new vocabulary{id=1,pol="falszywy2",eng="fake2",nextRepeat=new DateTime(2018,06,13)}
            };
        }
    }
}
