using System.Collections.Generic;

namespace SingletonWinForms
{
    public class NoteStorage
    {
        private static NoteStorage instance;

        public static NoteStorage Instance 
        {
            get
            {
                if (instance==null) instance = new NoteStorage();
                
                return instance;
            }
        }

        public List<Note> Notes { get; set; }

        private NoteStorage()
        {
            Notes = new List<Note>();
        }
    }
}