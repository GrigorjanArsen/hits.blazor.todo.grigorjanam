using Microsoft.EntityFrameworkCore;
using TodoServerApp.Data.Interfaces;

namespace TodoServerApp.Data.Services
{
    public class MSSQLDataService : IDataService
    {
        private readonly ApplicationDbContext context;

        public MSSQLDataService(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<TaskItem>> GetAllAsync()
        {
            return await context.TaskItems.ToArrayAsync();
        }

        public async Task SaveAsync(TaskItem taskitem)
        {
            if (taskitem.Id == 0)
            {
                taskitem.CreatedDate = DateTime.Now;
                await context.TaskItems.AddAsync(taskitem);
            }
            else
            {
                context.TaskItems.Update(taskitem);
            }
            await context.SaveChangesAsync();
        }

        public async Task<TaskItem> GetTaskAsync(int id)
        {
            return await context.TaskItems.FirstAsync(x => x.Id == id);
        }

        public async Task DeleteAsync(int id)
        {
            var taskItem = await context.TaskItems.FirstAsync(x => x.Id == id);
            context.TaskItems.Remove(taskItem);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProjectItem>> GetAllProjectsAsync()
        {
            return await context.ProjectItems.ToArrayAsync();
        }

        public async Task SaveProjectAsync(ProjectItem project)
        {
            if (project.Id == 0)
            {
                project.RegisteredDate = DateTime.Now; // Присваиваем дату регистрации
                await context.ProjectItems.AddAsync(project); // Добавляем нового пользователя
            }
            else
            {
                context.ProjectItems.Update(project); // Обновляем существующего пользователя
            }
            await context.SaveChangesAsync();
        }

        public async Task<ProjectItem> GetProjectAsync(int id)
        {
            return await context.ProjectItems.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task DeleteProjectsAsync(int id)
        {
            var projectItem = await context.ProjectItems.FirstOrDefaultAsync(x => x.Id == id);
            if (projectItem != null)
            {
                context.ProjectItems.Remove(projectItem); 
                await context.SaveChangesAsync();
            }
        }
    }
}
