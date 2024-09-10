using MovieApp2.Domain.Models;
using MovieApp2.Domain.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApp2.DTOs
{
    public class AddMovieToListDto
    {   
        public int Id { get; set; }

        public int UserId { get; set; }
       
    }
}
