using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsRovers
{
    [Binding]
    public class TurnRoverSteps
    {
        private readonly RoverTestContext _roverContext;

        public TurnRoverSteps(RoverTestContext roverTestContext)
        {
            _roverContext = roverTestContext;
        }
        [When(@"rover turns L")]
        public void WhenRoverTurnsL()
        {
            _roverContext._rover.TurnLeft();
        }

        [When(@"rover turns R")]
        public void WhenRoverTurnsR()
        {
            _roverContext._rover.TurnRight();
        }
    }
}