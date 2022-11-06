using csgame_backend.Data.Entities;
using csgame_backend.Patterns;
using csgame_backend.player_websocket;
using Moq;
using NUnit.Framework;
using WebSocketSharp;
using Xunit;
using Assert = Xunit.Assert;

namespace csgame_backend.Tests;

public class UnitTestsWithPlayer
{
    IBuilder? _builder;

    [Fact]
    public void BuildPlayer()
    {

        _builder = new Builder();
        Player player = _builder.Build();
        bool created = player == null;

       Assert.False(created, "Player should be created after requesting builder for building");
    }

    [Fact]
    public void BuildPlayerWithSameParams()
    {
        Player mockPlayer = new Player("Unit_Test_Player", 0, 0);
        _builder = new Builder();
        Player player = _builder.Build("Unit_Test_Player", 0, 0);

        bool same = player.Equals(mockPlayer);

        Assert.True(same, "Player: " + mockPlayer.Username + " should be same as player: " + player.Username);

    }

    [Fact]
    public void BuildPlayerWithGun()
    {
        _builder = new Builder();
        _builder.AddGunPistol();
        Player player = _builder.Build();
        
        bool created = player.guns.Count > 0;
        Assert.True(created, "The player should have guns after the builder provides them");
    }

    public void BuildPlayerStub()
    {
        
    }
}