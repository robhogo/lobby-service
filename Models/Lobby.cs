using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lobby_service.Models
{
    public class Lobby
    {
        [Key]
        public Guid Id { get; set; }
        public string Password { get; set; }
        public List<LobbyCharacter> LobbyCharacters { get; set; }
    }
}
