namespace Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("mahir" ,"musayev","AB106" ,99.9,true);
            student1.GetInfo();
            student1.CheckGraduation();
            student1.GetDiplomDegree();
        }

    }
}
