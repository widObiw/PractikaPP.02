using InternalApplicationWPF.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] 
        public void CheckIAIDTrue()
        {
            bool IsTrue = TestClass.AddInternalAplication(5, "05-04-2022", "12-05-2023", "1", "1");
        }
        [TestMethod]
        public void CheckDateEndTrue()
        {
            bool IsTrue = TestClass.AddInternalAplication(5, "05-04-2022", "12-05-2023", "1", "1");
            Assert.AreEqual(true, IsTrue);
        }
        [TestMethod]
        public void ChechDateEndFalse()
        {
            bool IsFalse = TestClass.AddInternalAplication(5, "05-04-2022", "Одиннадцатое февраля", "1", "1");
            Assert.AreEqual(false, IsFalse);
        }
        [TestMethod]
        public void ChechDateEndFalse2()
        {
            bool IsFalse = TestClass.AddInternalAplication(5, "05-04-2022", "11.02.2023 v", "1", "1");
            Assert.AreEqual(false, IsFalse);
        }
        [TestMethod]
        public void CheckDateStartTrue()
        {
            bool IsTrue = TestClass.AddInternalAplication(5, "05-04-2022", "12-05-2023", "1", "1");
            Assert.AreEqual(true, IsTrue);
        }
        [TestMethod]
        public void ChechDateStartFalse()
        {
            bool IsFalse = TestClass.AddInternalAplication(5, "Одиннадцатое февраля", "05-04-2022", "1", "1");
            Assert.AreEqual(false, IsFalse);
        }
        [TestMethod]
        public void CheckWorkerTrue()
        {
            
            bool IsTrue = TestClass.AddInternalAplication(5, "05-04-2022","12-05-2023", "1", "1");
            Assert.AreEqual(true, IsTrue);
        }
        [TestMethod]
        public void CheckStatusFalse2()
        {

            bool IsFalse = TestClass.AddInternalAplication(5, "05-04-2022", "12-05-2023", "1", "Три");
            Assert.AreEqual(false, IsFalse);
        }
        [TestMethod]
        public void CheckWorkerFalse()
        {
            DateTime dateTime = DateTime.Now;
            bool IsFalse = TestClass.AddInternalAplication(5, "05-04-2022", "12-05-2022", "1", "Алёшин");
            Assert.AreEqual(false, IsFalse);
        }
        [TestMethod]
        public void CheckStatusTrue()
        {
            
            bool IsTrue = TestClass.AddInternalAplication(5, "05-04-2022", "12-05-2023", "1", "1");
            Assert.AreEqual(true, IsTrue);
        }
        [TestMethod]
        public void CheckStatusFalse()
        {
            
            bool IsFalse = TestClass.AddInternalAplication(5, "05-04-2022", "12-05-2023", "1", "Просрочен");
            Assert.AreEqual(false, IsFalse);
        }

        [TestMethod]
        public void CheckProdNameTrue()
        {

            bool IsTrue = TestClass.AddProduct(10, "Самса", "4 дня", "1");
            Assert.AreEqual(true, IsTrue);
        }
        [TestMethod]
        public void CheckProdNameFalse()
        {

            bool IsFalse = TestClass.AddProduct(10, "5", "4 дня", "1");
            Assert.AreEqual(true, IsFalse);
        }

        [TestMethod]
        public void CheckShelfTrue()
        {

            bool IsTrue = TestClass.AddProduct(10, "Самса", "4 дня", "1");
            Assert.AreEqual(true, IsTrue);
        }
        [TestMethod]
        public void CheckShelfFalse()
        {

            bool IsFalse = TestClass.AddProduct(10, "Самса", "1", "1");
            Assert.AreEqual(true, IsFalse);
        }
        [TestMethod]
        public void CheckAmountTrue()
        {

            bool IsFalse = TestClass.AddProduct(10, "**(Y", "4 дня", "1");
            Assert.AreEqual(true, IsFalse);
        }

        [TestMethod]
        public void CheckUnitTrue()
        {

            bool IsTrue = TestClass.AddProduct(10, "Самса", "4 дня", "1");
            Assert.AreEqual(true, IsTrue);
        }
        [TestMethod]
        public void CheckUnitFalse()
        {

            bool IsFalse = TestClass.AddProduct(10, "5", "4 дня", "кг");
            Assert.AreEqual(false, IsFalse);
        }
        [TestMethod]
        public void CheckProdIDTrue()
        {

            bool IsTrue = TestClass.AddProduct(10, "Самса", "4 дня", "1");
            Assert.AreEqual(true, IsTrue);
        }
        [TestMethod]
        public void CheckunitFalse()
        {

            bool IsFalse = TestClass.AddProduct(10, "5", "4 дня", "шт");
            Assert.AreEqual(false, IsFalse);
        }
    }
}
