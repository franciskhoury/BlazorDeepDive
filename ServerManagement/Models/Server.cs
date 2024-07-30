using System.ComponentModel.DataAnnotations;

namespace ServerManagement.Models
{
    public class Server
    {
        private bool _isOnline = false;

        public Server()
        {
            Random random = new Random();
            int randomNumber = random.Next(0,2);
            IsOnline = randomNumber == 0;
        }
        public int ServerId { get; set; }
        public bool IsOnline {
            get => _isOnline;
            set {
                if (value)
                {
                    Random random = new Random();
                    int randomNumber = random.Next(0, 1000);
                    UserCount = randomNumber;
                }
                else
                {
                    UserCount = 0;
                }
                _isOnline = value;

            } }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? City { get; set; }

        public int UserCount { get; set; }
    }
}
