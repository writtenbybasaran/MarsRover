using MarsRover.Bussiness.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MarsRover.Model.Objects;
using MarsRover.Common.Exceptions;
using MarsRover.Model.CommonModels;
using MarsRover.Model.Enums;

namespace MarsRover.Bussiness.Services
{
    public class RoverBuilder : IRoverBuilder
    {
        public Rover Build(string arg)
        {
            Regex roverBuildRegex = new Regex(@"\d\s\d\s(N|E|S|W)");

            if (!roverBuildRegex.IsMatch(arg))
                throw new RoverBuildException("Rover Parameters are not expected.");

            string[] parameters = arg.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string xPoint = parameters[0];
            string yPoint = parameters[1];

            Point buildPoint = new Point(Int32.Parse(xPoint), Int32.Parse(yPoint));
            var builddirection = (Direction)Enum.Parse(typeof(Direction), parameters[2]);

            Rover rover = new Rover(buildPoint, builddirection);
            return rover;
        }

        public void SetMovements(Rover rover, string actionList)
        {
            var movementList = actionList
                .Select(x => (Movement) Enum.Parse(typeof(Movement) ,x.ToString())).ToList();
            rover.SetRoverActions(movementList);
        }
    }
}
