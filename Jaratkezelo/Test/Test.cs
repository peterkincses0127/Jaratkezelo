using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Jaratkezelo.Test
{
    [TestFixture]
    class Test
    {
        [TestCase]
        public void UjJaratJaratSzamnincs(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas)
        {
            Jarat j1 = new Jarat("15", "Budapest", "Prága", DateTime.Parse("15:00"), 0);
            Assert.AreEqual(0, j1.JaratSzam);
            
        }
    }
}
