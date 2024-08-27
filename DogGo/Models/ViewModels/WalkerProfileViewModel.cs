using System;
using System.Collections.Generic;

namespace DogGo.Models.ViewModels
{
    public class WalkerProfileViewModel
    {
        public Walker Walker { get; set; }
        public List<Walks> Walks { get; set; }
        public int TotalWalkDuration
        {
            get
            {
                return Walks?.Sum(w => w.Duration) ?? 0;
            }
        }
        public string FormattedTotalWalkDuration
        {
            get
            {
                int hours = TotalWalkDuration / 60;
                int minutes = TotalWalkDuration % 60;
                return $"{hours}hrs {minutes}mins";
            }
        }
    }
}