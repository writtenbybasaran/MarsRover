using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MarsRover.Bussiness.Interfaces;
using MarsRover.Common.Exceptions;
using MarsRover.Model.CommonModels;
using MarsRover.Model.Enums;
using MarsRover.Model.Objects;

namespace MarsRover.Bussiness.Services
{
    public class PlateauBuilder : IPlateauBuilder
    {
        public Plateau Build(string arg)
        {
            Regex plateauBuildRegex = new Regex(@"\d\s\d");

            if (!plateauBuildRegex.IsMatch(arg))
                throw new PlateauBuildException("Plateau Parameters are not expected.");

            string[] parameters = arg.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string xPoint = parameters[0];
            string yPoint = parameters[1];

            Size buildPlateauSize = new Size(Int32.Parse(xPoint), Int32.Parse(yPoint));

            Plateau plateau = new Plateau();
            plateau.SetSize(buildPlateauSize);

            return plateau;
        }
    }
}
