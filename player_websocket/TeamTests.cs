using Microsoft.VisualStudio.TestTools.UnitTesting;
using csgame_backend.player_websocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csgame_backend.Data.Entities;
using csgame_backend.Patterns;
using csgame_backend.player_websocket;
using Moq;
using NUnit.Framework;
using WebSocketSharp;
using Xunit;
using Assert = Xunit.Assert;

namespace csgame_backend.player_websocket.Tests
{
   
    public class TeamTests
    {
        [Fact]
        public void TeamTest()
        {
            Team team = new Team();
            bool created = team == null;

            Assert.False(created);
        }
    }
}