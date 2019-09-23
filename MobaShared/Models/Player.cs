using System;

namespace MobaShared.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        public string Name { get; set; }

        public string NickName { get; set; }

        public string Gender { get; set; }

        public DateTime BirthDate { get; set; }

        public int CountryId { get; set; }

        public int Popularity { get; set; }

        public int Mechanics { get; set; }

        public int Strategy { get; set; }

        public int Adaptability { get; set; }

        public int Leadership { get; set; }

        public int Teamwork { get; set; }
        
        public int Consistency { get; set; }

    }
}
