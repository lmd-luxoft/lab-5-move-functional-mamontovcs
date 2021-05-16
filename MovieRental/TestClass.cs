// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using MovieRental.Movies;
using NUnit.Framework;

namespace MovieRental
{
    [TestFixture]
    public class TestClass
    {
        private IStatementGenerator _statementGenerator;

        [SetUp]
        public void SetUp()
        {
            _statementGenerator = new StatementGenerator();
        }

        [Test]
        public void NameFilmShouldBeCorrect()
        {
            MovieBase movie = new NewMovie("Rio2");
            Assert.AreEqual("Rio2", movie.Title);
        }

        [Test]
        public void RentalShouldBeCorrectMovie()
        {
            MovieBase movie = new RegularMovie("Angry Birds");
            Rental rental = new Rental(movie, 20);
            Assert.AreEqual(movie, rental.Movie);
        }

        [Test]
        public void RentalShouldBeCorrectDayRented()
        {
            MovieBase movie = new RegularMovie("Angry Birds");
            Rental rental = new Rental(movie, 20);
            Assert.AreEqual(20, rental.DaysRental);
        }

        [Test]
        public void CustomerShouldBeCorrectName()
        {
            Customer customer = new Customer("Bug", _statementGenerator);
            Assert.AreEqual("Bug", customer.Name);
        }

        [Test]
        public void CustomerCreateCorrectStatement() // Fix this test
        {
            Customer customer = new Customer("Bug", _statementGenerator);

            MovieBase movie1 = new ChildMovie("Angry Birds");
            Rental rental1 = new Rental(movie1, 2);
            customer.AddRental(rental1);

            MovieBase movie2 = new NewMovie("StarWar");
            Rental rental2 = new Rental(movie2, 10);
            customer.AddRental(rental2);

            MovieBase movie3 = new RegularMovie("Hatico");
            Rental rental3 = new Rental(movie3, 4);
            customer.AddRental(rental3);

            string actual = customer.GetStatement();
            Assert.AreEqual("учет аренды для Bug\n\tAngry Birds\t15\n\tStarWar\t30\n\tHatico\t32\nСумма задолженности составляет 77\nВы заработали 4 очков за активность", actual);
        }
    }
}
