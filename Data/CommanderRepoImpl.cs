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

        public void CreteCommand(Command command)
        {
           if(command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }

            _context.Commands.Add(command);
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return _context.Commands.ToList();
        }

        public Command getCommandByID(int id)
        {
            return _context.Commands.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
