using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lobby_service.Models
{
    public class LobbyCharacter
    {
        [Key]
        public int CharacterId { get; set; }
        public bool IsAdmin { get; set; }


    }
}
