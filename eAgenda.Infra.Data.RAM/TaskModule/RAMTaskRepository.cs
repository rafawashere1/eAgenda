﻿using eAgenda.Domain.TaskModule;
using Task = eAgenda.Domain.TaskModule.Task;

namespace eAgenda.Infra.Data.RAM.TaskModule
{
    public class RAMTaskRepository : RAMBaseRepository<Task>, ITaskRepository
    {
        public RAMTaskRepository(List<Task> tasks)
        {
            registersList = tasks;
        }

        public List<Task>? SelectMarkeds()
        {
            return registersList.Where(x => x.CompletionPercentage == 100).OrderByDescending(x => x.Priority).ToList();
        }

        public List<Task>? SelectUnmarkeds()
        {
            return registersList.Where(x => x.CompletionPercentage < 100).OrderByDescending(x => x.Priority).ToList();
        }

        public List<Task>? SelectAllOrdenedByPriority()
        {
            return registersList.OrderByDescending(x => x.Priority).ToList();
        }
    }
}
