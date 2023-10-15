
public class Student
{
    // fields
    public string Name;
    public string Surname;
    public string Group;
    public double Point; // I chose double just in case that a point can be not a whole number
    public bool isGraduated;

    // constructor
    public Student(string name, string surname, string group, double point, bool isgraduated)
    {
        this.Name = name;
        this.Surname = surname; 
        this.Group = group; 
        this.Point = point; 
        this.isGraduated = isgraduated;
    }

    // A method that returns the name and the surname of a student 
    public string ShowFullname()
    {
        return $"{Name},{Surname}";    
    }

    // A method that returns all the information (based on fields) of a student 
    public string ShowFullInfo()
    { 
        // Condition that checks the bool value on based on it displays a message 
        if (isGraduated)
        {
            return $"{Name},{Surname},{Group},{Point},{isGraduated}, This student is graduated";
        } 
        else
        {
            return $"{Name},{Surname},{Group},{Point},{isGraduated}, This student is not graduated";
        }

        
    }

    // A method that returns a message if a student is allowed to take the second exam
    public string ExamInfo()
    {
        if (Point > 80)
        {
            return "You can take the second exam";
        }
        else
        {
            return " You are not allowed to take the second exam";
        }
        
    }

}


