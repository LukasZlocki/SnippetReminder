using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public interface ICommanderRepo
    {
        bool SaveChanges();

        IEnumerable<Command> GetAllCommands();
        Command GetCommandById(int id);
        void CreateCommmand(Command command);
        void UpdateCommand(Command cmd);
        void DeleteCommand(Command cmd);
    }
}