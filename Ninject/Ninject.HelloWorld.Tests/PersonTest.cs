using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Model;

namespace Ninject.HelloWorld.Tests
{
    /// <summary>
    /// Summary description for PersonTest
    /// </summary>
    [TestClass]
    public class PersonTest
    {
        private class MockMessage : IMessage
        {
            private bool emittedMessage  = false;

            public bool isEmittedMessage
            {
                get { return emittedMessage; }
            }

            public void emit()
            {
                emittedMessage = true;
            }
        }

        [TestMethod]
        public void TestSaludar()
        {
            MockMessage message = new MockMessage();
            Person personTest = new Person(message);
            personTest.greet();
            Assert.IsTrue(message.isEmittedMessage);
        }
    }
}
