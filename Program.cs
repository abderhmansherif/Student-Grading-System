namespace Student_Grading_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                Console.WriteLine("Welcome To Student Grading System");

                Console.WriteLine("Please Enter Student Name : Or Write Done If You Finished :");

                string Name = Console.ReadLine();

                if (Name == "done" || Name == "Done")
                    break;

                Console.WriteLine("Enter Subjects Grades In order Arabic ..English..etc");

                List<double> Grades = new List<double>();

                for (int i = 0; i < 5; i++)
                {
                    int grade = int.Parse(Console.ReadLine());
                    Grades.Add(grade);
                }

                Student student = new Student();
                student.StudentName = Name;
                student.StudentGrades = Grades;
                students.Add(student);
            }

            GradingSystem gradingSystem = new GradingSystem();

            gradingSystem.GradeSystem(students,(List<double> list)=> list.Sum() / list.Count() , (double res) => res > 30,
                (Student student ,double result , bool Check)=>
                {
                    string status = "Passed";

                    if (!Check)
                        status = "Faield";

                    Console.WriteLine($"The Student \"{student.StudentName}\" his Avregae: {result}");
                    Console.WriteLine($"Student Status {status}");
                }
                );

        }

      //public static double GetAverage(List<double> list)
      //  {
      //      return list.Sum() / list.Count();
      //  }

      //  public static bool checkIfPassed (double result)
      //  {
      //      return result > 30;
      //  }

      //  public static void Dispaly(Student student , double result , bool IfPassed)
      //  {
      //      string status = "Passed";

      //      if(!IfPassed)
      //          status = "Faield";

      //      Console.WriteLine($"The Syudent {student.StudentName} and His Avregae {result}");
      //      Console.WriteLine($"The Student {student.StudentName} & Student Status {status}");
      //  }
            




            


        
    }
}
