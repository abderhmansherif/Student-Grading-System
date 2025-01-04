using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System
{
    internal class GradingSystem
    {
        public void GradeSystem(List<Student> students , Func<List<double>,double> SumAverage,
            Predicate<double> CheckIFPassed,
            Action<Student,double,bool> DispalyTheResult)
        {
            foreach (var student in students)
            {
                double result = SumAverage(student.StudentGrades);
                bool Checked = CheckIFPassed(result);
                DispalyTheResult(student, result, Checked);
            }

        }
    }
}
