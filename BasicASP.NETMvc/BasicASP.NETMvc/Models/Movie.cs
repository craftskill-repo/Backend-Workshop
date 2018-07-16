using System;

namespace BasicASP.NETMvc.Models
{
    public class Movie
        {
            public int ID { get; set; }
            public string Title { get; set; }
            public DateTime ReleaseDate { get; set; }
            public decimal Price { get; set; }

            public Movie(int id, string title, DateTime releaseDate, decimal price)
            {
                ID = id;
                Title = title;
                ReleaseDate = releaseDate;
                Price = price;
            }
        }
}