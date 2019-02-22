﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using KaliteGiris.Bll;
using KaliteGiris.Entities;

namespace KaliteGiris.UITest
{
    /// <summary>
    /// Summary description for PersonelTest
    /// </summary>
    [TestClass]
    public class PersonelTest
    {
        public PersonelTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }      
        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethodPersonelList()
        {
            PersonelManager bll = new PersonelManager();
            List<Personel> list = bll.PersonelListele();
            Assert.AreNotEqual(list.Count, null);
        }

        [TestMethod]
        public void TestMethodPersonelAdd()
        {
            Personel personel = new Personel();

            personel.Adi = "Nefise";
            personel.PersonelNo = 000;

            PersonelManager bll = new PersonelManager();
            int result = bll.PersonelEkle(personel);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestMethodPersonelUpdate()
        {
            Personel personel = new Personel();

            personel.PersonelId = new Guid("722c34e8-e68f-e811-8e16-001cc0c1464b");
            personel.Adi = "Nefise";
            personel.PersonelNo = 000;

            PersonelManager bll = new PersonelManager();
            int result = bll.PersonelEkle(personel);
            Assert.AreEqual(result, 1);
        }

        [TestMethod]
        public void TestMethodPersonelDelete()
        {
            Personel personel = new Personel();

            personel.PersonelId = new Guid("732c34e8-e68f-e811-8e16-001cc0c1464b");

            PersonelManager bll = new PersonelManager();
            int result = bll.PersonelSil(personel);
            Assert.AreEqual(result, 1);
        }
    }
}
