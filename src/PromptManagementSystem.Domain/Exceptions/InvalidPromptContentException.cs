using PromptManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PromptManagementSystem.Domain.Entities.PromptContent;

namespace PromptManagementSystem.Domain.Exceptions
{
    public class InvalidPromptContentException : Exception
    {
        public PromptContent Content { get; }

        public InvalidPromptContentException(PromptContent content) 
            : base($"Invalid prompt content: {content.ContentType} - {content.ContentValue}")
        {
            Content = content;
        }
    }
}
