using NUnit.Framework;
using TeamCityDemoProject.Core;

namespace TeamCityDemoProject.CoreTests
{
    [TestFixture()]
    public class CommonTests
    {
        [Test()]
        public void ShouldGetDomainWhenInputNormalLInk()
        {
            string linkInput = "http://news.zing.vn/anh-hung-xa-dieu-that-bai-vo-hiep-kim-dung-da-het-thoi-post717747.html";
            string expectResult = "news.zing.vn";

            string realResult = Common.ParseDomain(linkInput);

            Assert.AreEqual(expectResult, realResult);
        }
    }
}
