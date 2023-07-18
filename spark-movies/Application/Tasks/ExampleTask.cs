﻿using Coravel.Invocable;

namespace spark_movies.Application.Tasks
{
    public class ExampleTask : IInvocable
    {

        public ExampleTask()
        {
        }

        public Task Invoke()
        {
            Console.WriteLine("Do something in the background.");
            return Task.CompletedTask;
        }
    }
}
