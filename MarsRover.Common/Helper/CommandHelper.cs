using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Common.Helper
{
    public static class CommandHelper
    {
        public static List<Tuple<string, string>> CommandToRoverParse(this string command)
        {
            var seperatedCommand = SeperatedCommand(command);
         
            List<Tuple<string, string>> parsedCommands=new List<Tuple<string, string>>();
            for (var i = 1; i < seperatedCommand.Length; i += 2)
            {
               parsedCommands.Add(new Tuple<string, string>(seperatedCommand[i]?.Trim(), seperatedCommand[i + 1]?.Trim()));
            }

            return parsedCommands;
        }

        public static string CommandToPleteauParse(this string command)
        {
            var seperatedCommand = SeperatedCommand(command);
            return seperatedCommand[0]?.Trim();
        }

        private static string[] SeperatedCommand(string command)
        {
            command = command ?? string.Empty;
            string[] lines = command.Split(new[] { "\\n", "|" }, StringSplitOptions.RemoveEmptyEntries)
                .Select(line => line.Trim())
                .Where(line => !string.IsNullOrEmpty(line))
                .ToArray();
            return lines;
        }
    }
}
