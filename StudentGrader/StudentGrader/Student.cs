namespace StudentGrader;

public class Student
{
    public string Name { get; set; }
    public int ID { get; set; }
    private List<double> Grades { get; set; } = new List<double>();


    public void AddGrade(double grade)
    {
        Grades.Add(grade);
    }

    public void AddGrade(params double[] grades)
    {
        Grades.AddRange(grades);
    }

    public double CalculateAverageGrade()
    {
        double progressReport = 0;

        foreach (var grade in Grades)
        {
            progressReport += grade;
        }
        return progressReport / Grades.Count;
    }
}