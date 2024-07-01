using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptManagementSystem.Domain.Exceptions
{
    public class PromptNotFoundException : Exception
    {
        public int PromptId { get; }

        public PromptNotFoundException(int promptId)
            : base($"Prompt with ID '{promptId}' not found.")
        {
            PromptId = promptId;
        }
    }
}
