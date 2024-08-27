using System.ComponentModel.DataAnnotations;

namespace DogGo.Models
{
    public class Walks
    {
        public int Id { get; set; }
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime Date { get; set; }
        public int Duration { get; set; }
        public string FormattedDuration
        {
            get
            {
                int hours = Duration / 60;
                int minutes = Duration % 60;
                return $"{hours}hrs {minutes}mins";
            }
        }
        public int WalkerId { get; set; }
        public Walker Walker { get; set; }
        public int DogId { get; set; }
        public Dog Dog { get; set; }
    }
}