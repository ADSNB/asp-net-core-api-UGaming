using System.ComponentModel.DataAnnotations;
using System;

namespace UGaming.Domain.Entities
{
    public sealed class Leaderboard
    {
        [Required, Display(Name = "Identificador do jogo é obrigatório")]
        public long CodPlayer { get; private set; }

        [Required, Display(Name = "Identificador do jogo é obrigatório")]
        public long Balance { get; private set; }

        [Required, Display(Name = "Identificador do jogo é obrigatório")]
        public DateTime LastUpdateDate { get; private set; }

        public void AtualizaBalance(long win, DateTime timestamp)
        {
            this.Balance += win;
            this.LastUpdateDate = timestamp;
        }

        public static class Factory
        {
            public static Leaderboard New(long codPlayer, long win, DateTime timestamp)
            {
                return new Leaderboard
                {
                    CodPlayer = codPlayer,
                    Balance = win,
                    LastUpdateDate = timestamp
                };
            }
        }
    }
}
