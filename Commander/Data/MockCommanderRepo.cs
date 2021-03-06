﻿using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var commands = new List<Command>
            {
                new Command {Id=0, HowTo="list directory items.", Line="ls", Platform="OSX" },
                new Command {Id=1, HowTo="make a directory.", Line="mkdir <directory name>", Platform="OSX" },
                new Command {Id=2, HowTo="remove a directory.", Line="rm -rf <directory name>", Platform="OSX" },
            };

            return commands;
        }

        public Command GetCommandById(int id)
        {
            return new Command {Id=0, HowTo="list directory items.", Line="ls", Platform="OSX" };
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
