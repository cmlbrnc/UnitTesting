using System;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CartTests
    {
        private static CartItem _cartItem;
        private static CartManager _cartManager;

      // [TestInitialize]
      [ClassInitialize]
        public static void testInit(TestContext context)
        {
             _cartManager =new CartManager();

             _cartItem =new CartItem
            {
                Product =  new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitPrice = 2500
                },
                Quantity = 1
            };
             _cartManager.Add((_cartItem));
          
        }


        [TestMethod]
        public void increase_total_number_products_already_in_the_cart()
        {
            //Arrange
            int totalQuantity = _cartManager.TotalQuantity;

            int totalITems = _cartManager.TotalItems;
            //act
           

            _cartManager.Add((_cartItem));


            //Assert

            Assert.AreEqual(totalQuantity + 1, _cartManager.TotalQuantity);

            Assert.AreEqual(totalITems , _cartManager.TotalItems,"{0} {1}", totalITems, _cartManager.TotalItems);

        }
        [TestMethod]
        public void increase_total_number_products_and_number_each_product_in_cart()
        {
            //Arrange
            int totalQuantity = _cartManager.TotalQuantity;

            int totalITems = _cartManager.TotalItems;
           
            
            //Act
            
            _cartManager.Add(new CartItem
            {

                Product = new Product
                {
                    ProductId = 2,
                    ProductName = "Mouse",
                    UnitPrice = 10
                },
                Quantity = 1

            });


            //Assert

            Assert.AreEqual(totalQuantity+1,_cartManager.TotalQuantity);

            Assert.AreEqual(totalITems + 1, _cartManager.TotalItems);

        }

        [TestMethod]
        public void add_product_to_cart()
        {
            //Arrange
            const int expectedValue = 1;
            //Act
            var actualResult = _cartManager.TotalItems;

            Assert.AreEqual(expectedValue, actualResult);
        }

        [TestMethod]
        public void remove_product_from_cart()
        {
            //Arrange
            var productsLenght = _cartManager.TotalItems;
            //Act
            _cartManager.Remove(1);
            var productsLeft = _cartManager.TotalItems;
            //Assert
            Assert.AreEqual(productsLenght-1, productsLeft);
        }

        [TestMethod]
        public void clear_cart()
        {      //Act
            _cartManager.Clear();
          
          
            //Assert
            Assert.AreEqual(0, _cartManager.TotalQuantity);
            Assert.AreEqual(0, _cartManager.TotalItems);
        }


        //[TestCleanup]
       [ClassCleanup]
        public static void TestCleanUp()
        {
            _cartManager.Clear();
        }


        //Mocking : Fake Framework 
        // nuget : moq framework

        // var mock =new Mock<IProductDal>();
        //mock.Setup(t=>t.IsExist(It.IsAny<Expression<Func<Product,bool>>>))).Returns(true);
        // var manager =new ProductManager(mock.Object)
        //manager.Insert(It.IsAny<PRoduct>());
    }
}
