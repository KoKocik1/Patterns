namespace Builder.Builders;

// public sealed class StudentBuilder
// {
//     private readonly List<Func<Student, Student> > actions 
//         = new List<Func<Student, Student>>();
//     
//     private StudentBuilder AddAction(Action<Student> action)
//     {
//         actions.Add(p =>
//         {
//             action(p);
//             return p;
//         });
//         return this;
//     }
//     
//     public StudentBuilder Do(Action<Student> action) => AddAction(action);
//     public StudentBuilder Called(string name) => Do(p => p.Name = name);
//     public Student Build() => actions.Aggregate(new Student(), (p, f) => f(p));
// } // make it generic in FunctionalBuilder.cs

public sealed class StudentBuilder : FunctionalBuilder<Student, StudentBuilder>
{
    public StudentBuilder Called(string name)
    {
        return Do(p => p.Name = name);
    }
}