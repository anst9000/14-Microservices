using System.Collections.Generic;
using CommandService.Models;

namespace CommandService.Data
{
    public class CommandRepo : ICommandRepo
    {
        public void CreateCommand(int platformId, Command command)
        {
            throw new System.NotImplementedException();
        }

        public void CreatePlatform(Platform platform)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            throw new System.NotImplementedException();
        }

        public Command GetCommand(int platformId, int commandId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Command> GetCommandsForPlatform(int platformId)
        {
            throw new System.NotImplementedException();
        }

        public bool PlatformExists(int platformId)
        {
            throw new System.NotImplementedException();
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }
    }
}