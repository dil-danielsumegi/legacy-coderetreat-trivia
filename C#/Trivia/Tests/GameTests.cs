using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Tests
{
    public class GameTests
    {
        //private readonly IMessageSink _output;
        private readonly ITestOutputHelper _outputHelper;

        public GameTests(ITestOutputHelper outputHelper)
        {
            //_output = output;
            _outputHelper = outputHelper;
        }
        [Fact]
        public void AddPlayer()
        {
            var game = new Trivia.Game();
            var players = game.HowManyPlayers();
            _outputHelper.WriteLine("test");
            //_output.OnMessage(new Xunit.Sdk.DiagnosticMessage("Chet was added"));
        }
    }
}
