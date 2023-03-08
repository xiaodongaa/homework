using Microsoft.VisualStudio.TestTools.UnitTesting;
using DemoUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoUser.Tests
{
    [TestClass()]
    public class UserTests
    {
        [TestMethod()]
        public void UserConstructorTest()
        {
            string userEmail = "dandanw0707@tzc.com"; // 初始化为适当的值
            User target = new User(userEmail); //为被测试对象创建用例
            Assert.IsTrue(target != null);//比较实际结果和期望结果
        }

        public void MainTest()
        {
            Assert.Fail();
        }
    }
}
