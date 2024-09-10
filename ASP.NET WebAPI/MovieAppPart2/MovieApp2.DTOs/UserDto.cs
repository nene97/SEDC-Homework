using MovieApp2.Domain.Models.Enums;
using MovieApp2.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp2.DTOs
{
    public class UserDto
    {
        public string UserName { get; set; }
        public string FullName { get; set; }
        public GenreEnum FavouriteGenre { get; set; }
        public RoleEnum Role { get; set; }

        public List<MovieDto> MovieList { get; set; }
    }
}
