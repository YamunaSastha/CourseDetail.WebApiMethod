using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDataAccessLayer
{
    
        public interface ICourseDetailsRepository
        {
            public CourseDetails InsertSP(CourseDetails CourseDt);
            public CourseDetails UpdateSP(long id, CourseDetails Dts);
            public IEnumerable<CourseDetails> ReadSP();
            public void DeleteSP(long id);

        }
    
}
