using Commander.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commander.Data
{
    public class CommanderRepoImpl : ICommanderRepo
    {
        private readonly CommanderContext _context;

        public CommanderRepoImpl(CommanderContext context)
        {
            _context = context;

        }
        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command getCommandByID(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }
    }
}
