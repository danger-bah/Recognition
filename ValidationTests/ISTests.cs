using Microsoft.VisualStudio.TestTools.UnitTesting;
using Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation.Tests
{
    [TestClass()]
    public class ISTests
    {
        [TestMethod()]
        public void FullPathTest()
        {
            Assert.IsFalse(IS.FullPath(null));
            Assert.IsFalse(IS.FullPath(string.Empty));
            Assert.IsFalse(IS.FullPath("  "));

            Assert.IsFalse(IS.FullPath(@"D:\temp\"));
            Assert.IsFalse(IS.FullPath(@"D:\temp\sd"));
            //разрешать такое или нет решать вам)))
            //Assert.IsFalse(IS.FullPath(@"D:\temp\sd\..\me.txt"));
            Assert.IsFalse(IS.FullPath(@"UDP:\temp\me.txt"));
            Assert.IsFalse(IS.FullPath(@"Com:\temp\me.txt"));
            Assert.IsFalse(IS.FullPath(@"C:\temp!\me.txt"));
            Assert.IsFalse(IS.FullPath(@"D:\temp\aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa\bbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbbb\ccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccccc\ddddddddddddddddddddddddddddddddddddddddddddd\me.txt"));

            Assert.IsTrue(IS.FullPath(@"D:\temp\e.dat"));
            Assert.IsTrue(IS.FullPath(@"D:\temp\edd.dat", ".dat"));
            Assert.IsFalse(IS.FullPath(@"D:\temp\edd.dt", ".dat"));
        }
        //ДЗ))
        [TestMethod()]
        public void DirectoryPathTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void FileNameTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EmailTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PasswordTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UrlTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void LoginTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void NameTest()
        {
            Assert.Fail();
        }
    }
}