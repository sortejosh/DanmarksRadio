using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanmarksRadio.Managers
{
    public class MusicRecordManagers
    {
        private static int _nextId = 1;

        private static readonly List<MusicRecord> Data = new List<MusicRecord>
        {
            new MusicRecord {Id = _nextId++, Title = "Smack that", Artist = "Akon" , Duration = 240, PublicationYear = 2006 },
            new MusicRecord {Id = _nextId++, Title = "Best song ever", Artist = "One Direction" , Duration = 205, PublicationYear = 2012 },
            new MusicRecord {Id = _nextId++, Title = "I was here", Artist = "Beyoncé" , Duration = 215, PublicationYear = 2010 },
            new MusicRecord {Id = _nextId++, Title = "Tættere på himlen", Artist = "Burhan G" , Duration = 213, PublicationYear = 2009 },
            new MusicRecord {Id = _nextId++, Title = "Candy shop", Artist = "50 cent" , Duration = 237, PublicationYear = 2007 }
        };

        public List<MusicRecord> GetAll(/*string substring = null, int duration = 0, int publicationYear = 0*/)
        {
          List<MusicRecord> result = new List<MusicRecord>(Data);
        //    if (substring !=null)
            {
                
            }
            return Data;
        }
    }
}
