using StudentGrader;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Student's Grading System");
        Console.WriteLine("------------------------");
        
        List<Student> students = new List<Student>();


        var nick = new Student()
        {
            Name = "Nick",
            ID = 3330
        };
        students.Add(nick);

        var harry = new Student()
        {
            Name = "Harry",
            ID = 3380
        };
        students.Add(harry);

        var andy = new Student()
        {
            Name = "Andy",
            ID = 7865
        };
        students.Add(andy);

        var chuck = new Student()
        {
            Name = "Chuck",
            ID = 6594
        };
        students.Add(chuck);
        
        
        //Nick grades
        nick.AddGrade(75.2);
        nick.AddGrade(85.2, 80.0, 92.1);
        
        //Harry grades
        harry.AddGrade(81.2);
        harry.AddGrade(85.0, 88.0, 96.1);
        
        
        //Andy grades
        andy.AddGrade(86.7);
        andy.AddGrade(85.0, 88.0, 96.1);
        
        //Chuck grades
        chuck.AddGrade(86.7);
        chuck.AddGrade(85.0, 88.0, 96.1);

        
        
        foreach (var student in students)
        {
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"Student's Name: {student.Name}\nStudent's ID: {student.ID}");
            Console.WriteLine($"Student's Grade Average:{student.CalculateAverageGrade()}");
        }
        
        
        

    }
    

}