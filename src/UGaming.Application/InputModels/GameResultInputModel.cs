using System.ComponentModel.DataAnnotations;
using System;

namespace UGaming.Application.InputModels
{
    public class GameResultInputModel
    {
        [Required, Display(Name = "Identificador do jogador é obrigatório")]
        public long? PlayerId { get; set; }

        [Required, Display(Name = "Identificador do jogo é obrigatório")]
        public long? GameId { get; set; }

        [Required, Display(Name = "Pontos ganhos/perdidos devem ser informados")]
        public long? Win { get; set; }

        [Required, Display(Name = "Data em que o jogo foi realizado é obrigatória")]
        public DateTime? TimeStamp { get; set; }
    }
}