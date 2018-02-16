using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clivingstone_qa_assignment1;

using NUnit.Framework;

namespace clivingstone_qa_assignment1.Tests
{
    [TestFixture]
    public class Class1
    {

        [Test]
        public void Test_Default_Constructor_Width_Expect_1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int result = rectangle.GetWidth();

            //Assert
            Assert.AreEqual(1, result);

        }

        [Test]
        public void Test_Length_Constructor_Length_Expect_1()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            int result = rectangle.GetLength();

            //Assert
            Assert.AreEqual(1, result);

        }

        [Test]
        public void Test_Length_Overloaded_Constructor_Length_Expect_5()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(5, 5);

            //Act
            int result = rectangle.GetLength();

            //Assert
            Assert.AreEqual(5, result);

        }

        [Test]
        public void Test_Width_Overloaded_Constructor_Length_Expect_5()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(5, 5);

            //Act
            int result = rectangle.GetWidth();

            //Assert
            Assert.AreEqual(5, result);

        }

        [Test]
        public void Test_setLength_Expect_10()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            rectangle.SetLength(10);
            int result = rectangle.GetLength();

            //Assert
            Assert.AreEqual(10, result);

        }

        public void Test_setWidth_Expect_20()
        {
            //Arrange
            Rectangle rectangle = new Rectangle();

            //Act
            rectangle.SetWidth(20);
            int result = rectangle.GetWidth();
            //Assert
            Assert.AreEqual(20, result);

        }

        public void Test_getPerimeter_Expect_20()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(5,5);

            //Act
            int result = rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(20, result);

        }

        public void Test_getArea_Expect_25()
        {
            //Arrange
            Rectangle rectangle = new Rectangle(5, 5);

            //Act
            int result = rectangle.GetArea();

            //Assert
            Assert.AreEqual(25, result);

        }


    }
}
