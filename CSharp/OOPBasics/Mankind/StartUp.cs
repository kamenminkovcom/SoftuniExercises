using System;

namespace Mankind
{
    class StartUp
    {
        static void Main()
        {
            string[] studentInfo = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string[] workerInfo = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            Human student;
            Human worker;
            try
            {
                student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);
                worker = new Worker(workerInfo[0], workerInfo[1], decimal.Parse(workerInfo[2]), int.Parse(workerInfo[3]));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            Console.WriteLine(student.ToString());
            Console.WriteLine(worker.ToString());
        }
    }
}
