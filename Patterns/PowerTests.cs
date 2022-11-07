using Microsoft.VisualStudio.TestTools.UnitTesting;
using csgame_backend.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using csgame_backend.Data.Entities;
using Assert = Xunit.Assert;

namespace csgame_backend.Patterns.Tests
{
    public class PowerTests
    {
        IBuilder? _builder;

        [Fact]
        public void dmgUpTest()
        {
            _builder = new Builder();
            _builder.AddGunPistol();
            Player player = _builder.Build();
            Player mockplayer = _builder.Build();

            foreach (Gun gun in player.guns)
            {
                gun.Damage += 5;
            }
            bool same = player.guns.Equals(mockplayer.guns);

            Assert.False(same, "first players guns: " + mockplayer.guns + " should be diferent as player: " + player.guns);
        }

        [Fact]
        public void dmgSuperUpTest()
        {
            _builder = new Builder();
            _builder.AddGunPistol();
            Player player = _builder.Build();
            Player mockplayer = _builder.Build();

            foreach (Gun gun in player.guns)
            {
                gun.Damage *= 5;
            }
            bool same = player.guns.Equals(mockplayer.guns);

            Assert.False(same, "first players guns: " + mockplayer.guns + " should be diferent as player: " + player.guns);
        }
    }
}