using GigHub.Models;
using System.Collections.Generic;

namespace GigHub.ViewModel
{
    public class GigsViewModel
    {
        public IEnumerable<Gig> UpcomingGigs { get; set; }
        public bool ShowActions { get; set; }
        public string Headers { get; set; }
    }
}