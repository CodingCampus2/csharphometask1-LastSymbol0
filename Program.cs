using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task1, string> TaskSolver = task =>
            {
                float sickPeopleCount = float.Parse(task.City.Population) * float.Parse(task.City.SickPercentage);
                float deadPeopleCount = float.Parse(task.Virus.KillProbability) * sickPeopleCount;

                return $"There are {Math.Truncate(sickPeopleCount)} people sick with {task.Virus.Name} in the city of {task.City.Name}, {Math.Truncate(deadPeopleCount)} of which died";
            };

            Task1.CheckSolver(TaskSolver);
        }
    }
}
