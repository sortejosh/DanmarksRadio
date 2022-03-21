using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace DanmarksRadio
{
    public class MusicRecord
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public int Duration { get; set; }
        public int PublicationYear { get; set; }

        public MusicRecord(/*string title, string artist, int duration, int publicationYear*/)
        {

        }

        public override string ToString()
        {
            return $"Id:{Id} -Title:{Title} - Artist:{Artist} - Duration:{Duration} - PublicationYear:{PublicationYear}";
        }
    }
}
