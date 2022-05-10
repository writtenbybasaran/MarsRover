using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Bussiness.Interfaces;
using MarsRover.Common.Helper;
using MarsRover.Model.CommonModels;
using MarsRover.Model.Enums;
using MarsRover.Model.Objects;

namespace MarsRover.Bussiness.Services
{
    public class CommandHandler : ICommandHandler
    {
        private readonly IPlateauBuilder _plateauBuilder;
        private readonly IRoverBuilder _roverBuilder;
        private readonly IRoverEngine _roverEngine;
        public IList<Rover> _rovers;
      
        public Plateau _plateau;

        public CommandHandler(IRoverEngine roverEngine, IRoverBuilder roverBuilder, IPlateauBuilder plateauBuilder)
        {
            _roverEngine = roverEngine;
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
                rover.Actions.First().Invoke();
            }
        }
    }
}
