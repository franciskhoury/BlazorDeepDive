using System.ComponentModel.DataAnnotations;

namespace ServerManagement.Models
{
    public class Server
    {
        //private bool _isOnline = false;

        public Server()
        {
            Random random = new Random();
            int randomNumber = random.Next(0,2);
            IsOnline = randomNumber == 0;
        }

        [Key]
        public int ServerId { get; set; }

        public bool IsOnline { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? City { get; set; }

        public int UserCount { get; set; }

    }
}
