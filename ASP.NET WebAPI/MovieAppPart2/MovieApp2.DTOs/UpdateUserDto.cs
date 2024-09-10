using MovieApp2.Domain.Models.Enums;
using MovieApp2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp2.DTOs
{
    public class UpdateUserDto
    {
        public int Id { get; set;  }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RoleEnum Role { get; set; }
        public string ConfirmPassword { get; set; }

        public GenreEnum FavouriteGenre { get; set; }

    }
}
