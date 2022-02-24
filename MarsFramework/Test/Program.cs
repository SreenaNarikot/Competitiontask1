using MarsFramework.Pages;
using NUnit.Framework;
using System;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]
            public void Test()
            {
                ShareSkill shareSkill = new ShareSkill();
                shareSkill.EnterShareSkill();
                

            }



        }
    }
}