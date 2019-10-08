using System;
using NUnit.Framework;
using PostcodeESIO;

namespace PostcodeESIO.test
{
    [TestFixture]
    public class SinglePostCodeServicesTests
    {
        singlePostcode SinglePostcodes = new singlePostcode();

        
        public SinglePostCodeServicesTests()
        {
            SinglePostcodes.GetSinglePostcodes("SE15 1PD");
        }
        [Test]
        public void Status200()
        {
            Assert.AreEqual("200", SinglePostcodes.PostcodesSingleResponseContent["status"].ToString());

        }

        public void ReturnCorrectPostCodes()
        {
            Assert.AreEqual("SE15 1PD", SinglePostcodes.PostcodesSingleResponseContent["result"]["postcode"].ToString());

        }
    }
}
