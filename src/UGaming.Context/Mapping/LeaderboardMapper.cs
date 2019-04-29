using DapperExtensions.Mapper;
using UGaming.Domain.Entities;

namespace UGaming.Context.Mapping
{
    public class LeaderboardMapper : ClassMapper<Leaderboard>
    {
        public LeaderboardMapper()
        {
            Schema("ugaming");
            Table("leaderboard");
            
            Map(prop => prop.CodPlayer).Column("cod_player").Key(KeyType.Assigned);
            Map(prop => prop.Balance).Column("balance");
            Map(prop => prop.LastUpdateDate).Column("last_update_date");
        }
    }
}
