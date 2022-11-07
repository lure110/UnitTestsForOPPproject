using Microsoft.VisualStudio.TestTools.UnitTesting;
using csgame_backend.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csgame_backend.Data.Entities;
using Xunit;
using Assert = Xunit.Assert;

namespace csgame_backend.Patterns.Tests
{
    public class UtilityTests
    {
        IBuilder? _builder;
        [Fact]
        public void hlthUpTest()
        {
            _builder = new Builder();
            _builder.AddGunPistol();
            Player player = _builder.Build();
            Player mockplayer = new Player("Unit_Test_Player", 0, 0);
            mockplayer.Health = 250;

            player.Health += 150;

            bool same = player.Health.Equals(mockplayer.Health);

            Assert.True(same, "first players Health: " + mockplayer.Health + " should be same as player: " + player.Health);
        }

        [Fact]
        public void hlthDownTest()
        {
            _builder = new Builder();
            _builder.AddGunPistol();
            Player player = _builder.Build();
            Player mockplayer = new Player("Unit_Test_Player", 0, 0);
            mockplayer.Health = 70;

            player.Health -= 30;

            bool same = player.Health.Equals(mockplayer.Health);

            Assert.True(same, "first players Health: " + mockplayer.Health + " should be same as player: " + player.Health);
        }

    }
}