namespace UnitTesting.TestImplementation
{
    using NUnit.Framework;
    using HomeTaskSimpleOrderApp.Products;

    using HomeTaskSimpleOrderApp.MyExceptions;

    [TestFixture]
    public class NUnitProductTests
    {

        [Test]
         
        public void VerifyingTestBookPriceCannotBeLessZero()
        {
            Assert.Throws(typeof(NegativeArgumentException), () => GetBook());            
        }

        private Book GetBook()
        {
            return new("Book name", -10);
        }

        [Test]        
        public void VerifyingTestOnDefaultAuthorOfBook ()
        {
            Book _book = new ("Book name", 10);
            Assert.AreEqual("No Author", _book.Author);
        }

        [Test, Timeout(500)]
        public void ShelfDateInFoodMustBeLessThanFiveDays ()
        {
            Food _food = new Food("Food", 15);
            Assert.GreaterOrEqual(_food.ShelfDate, DateTime.Now.AddDays(4));
            Assert.LessOrEqual(_food.ShelfDate, DateTime.Now.AddDays(5));
        }
        


    }
}
