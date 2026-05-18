
#region Class Contain Field, Proptery and method
using System.Reflection.Metadata.Ecma335;

public  class BasicConcept
{
    // Field
    private  int experience;
public int Experience 
{
    get { return experience;}
    set {experience = value;}
}

public void CalculateSalary()
    {
        int salary = Experience * 300000;
        Console.WriteLine(salary);
    }

}
#endregion

#region  Encapsulation
public class Employee
{
    //Make field private
    private int empExperience;

    public int EmpExperience
    {
        
        get{return empExperience;}
        set{empExperience =value;}
    }
}
#endregion

#region  Polymorphism 
public class Polymorphism
{
    public int Add(int a, int b)
    {
        return a +b;
    }
    public string Add(string str1, string str2)
    {
        return str1 +str2;
    }
}
#endregion

#region  Method Overriding
public class BaseClass
{
    public virtual void Greetings()
    {
        Console.WriteLine("BasicClass Hello!");
    }
    public  void TestGreetings()
    {
        Console.WriteLine("BasicClass Hello!");
    }
}
public class DrivedClass: BaseClass
{
    public override void Greetings()
    {
        Console.WriteLine("DrivedClass Hello!");
    }

    // Method Hiding
    public new void TestGreetings()
    {
        Console.WriteLine("Method Hiding");
    }
}
#endregion