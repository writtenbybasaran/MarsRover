﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Model.CommonModels;
using MarsRover.Model.Enums;

namespace MarsRover.Model.Objects
{
    public class Rover
    {
        public Point Position { get; set; }
        public Direction Direction { get; set; }
        public List<Action> Actions { get; private set; }
        private readonly IDictionary<Movement, Action> RoverAbility;

        public Rover(Point startPosition, Direction startDirection)
        {
            Position = startPosition;
            Direction = startDirection;
            Actions = new List<Action>();
            RoverAbility = new Dictionary<Movement, Action>()
            {
                {Movement.M, () => MoveRover()},
                {Movement.L, () => TurnLeft()},
                {Movement.R, () => TurnRight()}
            };
        }

        public void SetRoverActions(List<Movement> movements)
        {
            foreach (var move in movements)
            {
                switch (move)
                {
                    case Movement.L:
                        Actions.Add(TurnLeft);
                        break;
                    case Movement.R:
                        Actions.Add(TurnRight);
                        break;
                    case Movement.M:
                        Actions.Add(MoveRover);
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }

        private void TurnLeft()
        {
            var newDirection = (int)Direction + 90;
            Direction = newDirection.Equals(360) ? 0 : (Direction)newDirection;
        }
        private void TurnRight()
        {
            var newDirection = (int)Direction - 90;
            Direction = newDirection.Equals(-90) ? (Direction)270 : (Direction)newDirection;
        }
        private void MoveRover()
        {
            switch (Direction)
            {
                case Direction.N:
                    Position = new Point(Position.X, Position.Y + 1);
                    break;
                case Direction.E:
                    Position = new Point(Position.X + 1, Position.Y);
                    break;
                case Direction.S:
                    Position = new Point(Position.X, Position.Y - 1);
                    break;
                case Direction.W:
                    Position = new Point(Position.X - 1, Position.Y);
                    break;
                default:
                    break;
            }
        }

    }
}