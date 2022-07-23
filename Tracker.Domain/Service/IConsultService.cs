using Tracker.Domain.Dto;
using Tracker.Domain.Enum;

namespace Tracker.Domain.Service
{
    public interface IConsultService
    {
        public IList<GuildData> SearchGuilds(ServerEnum server, string guildName);        
    }
}
