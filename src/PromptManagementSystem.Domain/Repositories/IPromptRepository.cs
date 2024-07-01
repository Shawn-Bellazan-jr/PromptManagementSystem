using PromptManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptManagementSystem.Domain.Repositories
{
    public interface IPromptRepository
    {
        Task<List<Prompt>> GetAllPromptsAsync();
        Task<Prompt> GetPromptByIdAsync(int id);
        Task<Prompt> CreatePromptAsync(Prompt prompt);
        Task UpdatePromptAsync(Prompt prompt);
        Task DeletePromptAsync(int id);
    }
}

