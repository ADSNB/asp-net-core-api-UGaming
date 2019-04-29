using System.ComponentModel.DataAnnotations;
using System;

namespace UGaming.Domain.Entities
{
    public sealed class GameResult
    {
        public int Id { get; private set; }

        [Required, Display(Name = "Identificador do jogo é obrigatório")]
        public long CodGame { get; private set; }
        
        [Required, Display(Name = "Identificador do jogador é obrigatório")]
        public long CodPlayer { get; private set; }

        [Required, Display(Name = "Pontos ganhos devem ser informados")]
        public long Win { get; private set; }

        [Required, Display(Name = "Data em que o jogo foi realizado é obrigatória")]
        public DateTime Timestamp { get; private set; }

        public static class Factory
        {
            public static GameResult New(long game, long player, long win, DateTime timestamp)
            {
                return new GameResult
                {
                    CodGame = game,
                    CodPlayer = player,
                    Win = win,
                    Timestamp = timestamp
                };
            }
        }
    }
}
