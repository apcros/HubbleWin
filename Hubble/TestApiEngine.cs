using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hubble
{
    using NUnit.Framework;
    using System.Web.Script.Serialization;
    [TestFixture]
    class TestApiEngine
    {
        [Test]
        public void getJSON()
        {
            ApiEngine ae = new ApiEngine(new Config());
            string json = ae.getJson();

            Assert.IsFalse(String.IsNullOrEmpty(json));

            JavaScriptSerializer jss = new JavaScriptSerializer();

            HubbleJSON hubble_json = jss.Deserialize<HubbleJSON>(json);

            Assert.IsFalse(String.IsNullOrEmpty(hubble_json.name));
            Assert.IsFalse(String.IsNullOrEmpty(hubble_json.os_version));
            Assert.IsFalse(String.IsNullOrEmpty(hubble_json.client_version));
            Assert.IsFalse(String.IsNullOrEmpty(hubble_json.ram_total));
            Assert.IsFalse(String.IsNullOrEmpty(hubble_json.ram_free));
            Assert.IsFalse(String.IsNullOrEmpty(hubble_json.cpu_usage));
        }
    }
}
