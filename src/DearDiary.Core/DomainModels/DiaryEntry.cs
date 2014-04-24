using System;

namespace DearDiary.Core.DomainModels
{
    public class DiaryEntry
    {
        //A unique id
        public Guid Id { get; set; }
        /// <summary>
        /// The date when the diary entry was created
        /// </summary>
        public DateTime DateTime { get; set; }

        //the name of the author
        public string Author { get; set; }

        //the location where diary was written
        public string Location { get; set; }

        //the content of the diary
        public string Content { get; set; }
    }
}