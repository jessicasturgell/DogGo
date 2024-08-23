using System;
using System.Collections.Generic;

namespace DogGo.Models.ViewModels
{
    public class WalkerProfileViewModel
    {
        public Walker Walker { get; set; }
        public List<Walks> Walks { get; set; }
        public List<string> FormattedWalkDurations
        {
            get
            {
                return Walks?.Select(w => TimeSpan.FromMinutes(w.Duration).ToString(@"hh\:mm\:ss")).ToList();
            }
        }
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
                TimeSpan totalDuration = TimeSpan.FromMinutes(TotalWalkDuration);
                return totalDuration.ToString(@"hh\:mm\:ss");
            }
        }
    }
}