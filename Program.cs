using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class Program
    {
        public static void Main(string[] args)
        {
            Func<Task1, string> TaskSolver = task =>
            {
                float population = 0.0f, sickPercentage = 0.0f, killProbability = 0.0f;

                bool isParseSucceed = float.TryParse(task.City.Population, out population)
                                    && float.TryParse(task.City.SickPercentage, out sickPercentage)
                                    && float.TryParse(task.Virus.KillProbability, out killProbability);

                if (!isParseSucceed)
                {
                    Console.Error.WriteLine("Parse error.");
                }

                float sickPeopleCount = population * sickPercentage;
                float deadPeopleCount = killProbability * sickPeopleCount;

                return $"There are {Math.Truncate(sickPeopleCount)} people sick with {task.Virus.Name} in the city of {task.City.Name}, {Math.Truncate(deadPeopleCount)} of which died";
            };

            Task1.CheckSolver(TaskSolver);
        }
    }

}
