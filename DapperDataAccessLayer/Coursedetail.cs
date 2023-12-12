using System;

namespace DapperDataAccessLayer
{ 
    public class CourseDetails
    {
        public long ID { get; set; }
        public string CourseName { get; set; }
        public DateTime Duration { get; set; }
        public DateTime StartDate { get; set; }
        public int NumberOfStudents { get; set; }
        public string ContactPerson { get; set; }
    }
}
