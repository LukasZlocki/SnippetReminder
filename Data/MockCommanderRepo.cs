using System.Collections.Generic;
using Commander.Models;

namespace Commander.Data
{
    public class MockCommanderRepo : ICommanderRepo
    {
        public void CreateCommmand(Command command)
        {
            
        }

        public void DeleteCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            var command = new List<Command>
            {
                new Command{Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan"},
                new Command{Id = 1, HowTo = "Cut bread", Line = "Get a knife", Platform = "knife & chopping board"},
                new Command{Id = 2, HowTo = "Make cup of tea", Line = "Place tea bag in cup", Platform = "tea time"}
            };
            return command;

        }

        public Command GetCommandById(int id)
        {
            return new Command{Id = 0, HowTo = "Boil an egg", Line = "Boil water", Platform = "Kettle & Pan"}; 
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new System.NotImplementedException();
        }
    }
}