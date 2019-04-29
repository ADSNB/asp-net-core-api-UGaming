using DapperExtensions.Mapper;
using UGaming.Domain.Entities;

namespace UGaming.Context.Mapping
{
    public class GameResultMapper : ClassMapper<GameResult>
    {
        public GameResultMapper()
        {
            Schema("ugaming");
            Table("game_result");

            Map(prop => prop.Id).Column("id_game_result").Key(KeyType.Identity);
            Map(prop => prop.CodGame).Column("cod_game");
            Map(prop => prop.CodPlayer).Column("cod_player");
            Map(prop => prop.Win).Column("win");
            Map(prop => prop.Timestamp).Column("data_criacao");
        }
    }
}
