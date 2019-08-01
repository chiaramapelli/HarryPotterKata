using NUnit.Framework;

namespace HarryPotter.Logic.Tests
{
    public class HarryPotterLogicTests
    {

        [Test]
        public void Given_One_Book_The_Total_Should_Be_Eight()
        {
            // Arrange
            var harryPotterLogic = new HarryPotterLogic(); //start an instance of a class
            harryPotterLogic.Add("firstbook");

            // Act
            var result = harryPotterLogic.GetTotal(); //function attached to a class instance


            // Assert
            Assert.AreEqual(8, result);    //state what it is expected to happen
        }

        [Test]
        public void Given_Two_Different_Books_The_Result_Should_Be_Fifteen_Twenty()
        {
            // Arrange
            var harryPotterLogic = new HarryPotterLogic(); //start an instance of a class
            harryPotterLogic.Add("firstbook");
            harryPotterLogic.Add("secondbook");

            // Act
            var result = harryPotterLogic.GetTotal(); //function attached to a class instance


            // Assert
            Assert.AreEqual(15.20, result);    //state what it is expected to happen
        }
        [Test]
        public void Given_Three_Different_Books_The_Result_Should_Be_Twentyone_Sixty()
        {
            // Arrange
            var harryPotterLogic = new HarryPotterLogic(); //start an instance of a class
            harryPotterLogic.Add("firstbook");
            harryPotterLogic.Add("secondbook");
            harryPotterLogic.Add("thirdbook");

            // Act
            var result = harryPotterLogic.GetTotal(); //function attached to a class instance


            // Assert
            Assert.AreEqual(21.60, result);    //state what it is expected to happen
        }
        [Test]
        public void Given_Four_Different_Books_The_Result_Should_Be_Twentyseven_Twenty()
        {
            // Arrange
            var harryPotterLogic = new HarryPotterLogic(); //start an instance of a class
            harryPotterLogic.Add("firstbook");
            harryPotterLogic.Add("secondbook");
            harryPotterLogic.Add("thirdbook");
            harryPotterLogic.Add("fourthbook");

            // Act
            var result = harryPotterLogic.GetTotal(); //function attached to a class instance


            // Assert
            Assert.AreEqual(27.20, result);    //state what it is expected to happen
        }
        [Test]
        public void Given_Five_Different_Books_The_Result_Should_Be_Thirtytwo()
        {
            // Arrange
            var harryPotterLogic = new HarryPotterLogic(); //start an instance of a class
            harryPotterLogic.Add("firstbook");
            harryPotterLogic.Add("secondbook");
            harryPotterLogic.Add("thirdbook");
            harryPotterLogic.Add("fourthbook");
            harryPotterLogic.Add("fifthbook");

            // Act
            var result = harryPotterLogic.GetTotal(); //function attached to a class instance


            // Assert
            Assert.AreEqual(32.00, result);    //state what it is expected to happen
        }
        [Test]
        public void Given_Six_Different_Books_The_Result_Should_Be_Thirtysix()
        {
            // Arrange
            var harryPotterLogic = new HarryPotterLogic(); //start an instance of a class
            harryPotterLogic.Add("firstbook");
            harryPotterLogic.Add("secondbook");
            harryPotterLogic.Add("thirdbook");
            harryPotterLogic.Add("fourthbook");
            harryPotterLogic.Add("fifthbook");
            harryPotterLogic.Add("sixthbook");

            // Act
            var result = harryPotterLogic.GetTotal(); //function attached to a class instance


            // Assert
            Assert.AreEqual(36.00, result);    //state what it is expected to happen
        }
        [Test]
        public void Given_Seven_Different_Books_The_Result_Should_Be_Thirtynine_Twenty()
        {
            // Arrange
            var harryPotterLogic = new HarryPotterLogic(); //start an instance of a class
            harryPotterLogic.Add("firstbook");
            harryPotterLogic.Add("secondbook");
            harryPotterLogic.Add("thirdbook");
            harryPotterLogic.Add("fourthbook");
            harryPotterLogic.Add("fifthbook");
            harryPotterLogic.Add("sixthbook");
            harryPotterLogic.Add("seventhbook");

            // Act
            var result = harryPotterLogic.GetTotal(); //function attached to a class instance


            // Assert
            Assert.AreEqual(39.20, result);    //state what it is expected to happen
        }

        [Test]
        public void Given_Two_Same_Books_There_Should_Be_No_Discount()
        {
            // Arrange
            var harryPotterLogic = new HarryPotterLogic(); //start an instance of a class
            harryPotterLogic.Add("firstbook");
            harryPotterLogic.Add("firstbook");

            // Act
            var result = harryPotterLogic.GetTotal();


            // Assert
            Assert.AreEqual(16, result);
        }

        [Test]
        public void Given_Three_Same_And_Two_Different_Books_The_Price_Should_Be_ThirtyEight_Forty()
        {
            // Arrange
            var harryPotterLogic = new HarryPotterLogic(); //start an instance of a class
            harryPotterLogic.Add("firstbook");
            harryPotterLogic.Add("secondbook");
            harryPotterLogic.Add("firstbook");
            harryPotterLogic.Add("firstbook");
            harryPotterLogic.Add("secondbook");

            // Act
            var result = harryPotterLogic.GetTotal();


            // Assert
            Assert.AreEqual(38.40, result);
        }
        [Test]
        public void Given_Three_Four_And_Two_Same_Books_And_A_Single_One_I_Should_Get_SeventyTwo()
        {
            // Arrange
            var harryPotterLogic = new HarryPotterLogic(); //start an instance of a class
            harryPotterLogic.Add("firstbook");
            harryPotterLogic.Add("secondbook");
            harryPotterLogic.Add("thirdbook");
            harryPotterLogic.Add("fourthbook");
            harryPotterLogic.Add("firstbook");
            harryPotterLogic.Add("firstbook");
            harryPotterLogic.Add("secondbook");
            harryPotterLogic.Add("thirdbook");
            harryPotterLogic.Add("thirdbook");
            harryPotterLogic.Add("thirdbook");


            // Act
            var result = harryPotterLogic.GetTotal();


            // Assert
            Assert.AreEqual(72, result);
        }
        [Test]
        public void Given_Seven_Different_And_Five_Same_Books_I_Should_Get_EightyNine_Sixty()
        {
            // Arrange
            var harryPotterLogic = new HarryPotterLogic(); //start an instance of a class
            harryPotterLogic.Add("firstbook");
            harryPotterLogic.Add("secondbook");
            harryPotterLogic.Add("thirdbook");
            harryPotterLogic.Add("fourthbook");
            harryPotterLogic.Add("fifthbook");
            harryPotterLogic.Add("sixthbook");
            harryPotterLogic.Add("seventhbook");
            harryPotterLogic.Add("firstbook");
            harryPotterLogic.Add("firstbook");
            harryPotterLogic.Add("secondbook");
            harryPotterLogic.Add("thirdbook");
            harryPotterLogic.Add("thirdbook");
            harryPotterLogic.Add("thirdbook");
            harryPotterLogic.Add("fourthbook");


            // Act
            var result = harryPotterLogic.GetTotal();


            // Assert
            Assert.AreEqual(89.60, result);
        }

        [Test]
        public void Given_A_Basket_Of_One_Book_I_Should_Receive_One_Title()
        {
            // Arrange
            var harryPotterLogic = new HarryPotterLogic(); //start an instance of a class

            // Act
            harryPotterLogic.Add("bookone");
            var result = harryPotterLogic.GetAllBooksInBasket();
            


            // Assert
            Assert.AreEqual(1, result.Count);
        }

        [Test]
        public void Given_A_Basket_Of_Two_Books_I_Should_Receive_Two_Titles()
        {
            // Arrange
            var harryPotterLogic = new HarryPotterLogic(); //start an instance of a class

            // Act
            harryPotterLogic.Add("bookone");
            harryPotterLogic.Add("booktwo");
            var result = harryPotterLogic.GetAllBooksInBasket();



            // Assert
            Assert.AreEqual(2, result.Count);
        }

    }
}
