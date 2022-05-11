using System;
using System.Collections.Generic;
using MarsRover.Bussiness.Interfaces;
using MarsRover.Common.Exceptions;
using MarsRover.Common.Helper;
using MarsRover.Model.Objects;

namespace MarsRover.Bussiness.Services
{
    public class CommandHandler : ICommandHandler
    {
        private readonly IPlateauBuilder _plateauBuilder;
        private readonly IRoverBuilder _roverBuilder;
        public IList<Rover> _rovers;
        public Plateau _plateau;

        public CommandHandler(IRoverBuilder roverBuilder, IPlateauBuilder plateauBuilder)
        {
            _roverBuilder = roverBuilder;
            _plateauBuilder = plateauBuilder;
            _rovers = new List<Rover>();
        }

        public void Build(string command)
        {
            string plateauCommand = command.CommandToPleteauParse();
            _plateau = _plateauBuilder.Build(plateauCommand);

            var roverCommands = command.CommandToRoverParse();
            foreach (var makeRoverCommand in roverCommands)
            {
                var buildedRover = _roverBuilder.Build(makeRoverCommand.Item1);
                _roverBuilder.SetMovements(buildedRover,makeRoverCommand.Item2);
                _rovers.Add(buildedRover);
            }
        }

        public void Execute()
        {
            foreach (var rover in _rovers)
            {
                ActionRun(rover);
            }
        }

        private void ActionRun(Rover rover)
        {
            foreach (var roverAction in rover.Actions)
            {
                roverAction.Invoke();
                if (!_plateau.IsValid(rover.Position)) throw new OutOfMapException("Disconnected from Rover.Rover out of map.");
            }
            Console.WriteLine(rover.GetInstantPosition());
        }
    }
}
