using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hubble
{
    using NUnit.Framework;

    [TestFixture]
    class TestSystemInfoEngine
    {
        SystemInfoEngine system_info = new SystemInfoEngine();
        [Test]
        public void getTotalRam()
        {
            string total_ram = system_info.getTotalRam();
            Assert.NotZero(int.Parse(total_ram));
        }

        [Test]
        public void getCpuUsage()
        {
            string cpu_usage = system_info.getCpuUsage();
            Assert.LessOrEqual(cpu_usage.Length, 3);
        }

    }
}
