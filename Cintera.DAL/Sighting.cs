using System;

namespace Cintera.DAL
{
    public class Sighting
    {
        public int SightingId { get; set; }
        public int CaseId { get; set; }
        public virtual Case Case { get; set; }

        public string Address { get; set; }
        public DateTime Date { get; set; }
    }
}