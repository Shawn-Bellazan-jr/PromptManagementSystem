using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptManagementSystem.Domain.Entities
{
    public record PromptContent(PromptContentType ContentType, string ContentValue)
    {
        public int Id { get; set; }
        public int PromptId { get; set; }

        public List<string> ReasoningSteps { get; set; } = new List<string>();

        public void Validate()
        {
            if (string.IsNullOrEmpty(ContentValue))
            {
                throw new ArgumentException("Content value cannot be empty.");
            }

            // Additional validation based on ContentType (e.g., check for valid code syntax)
            switch (ContentType)
            {
                case PromptContentType.Input:
                    // Validate input content (e.g., length, format)
                    break;
                case PromptContentType.Context:
                    // Validate context content
                    break;
                case PromptContentType.Example:
                    // Validate example content
                    break;
                case PromptContentType.ChainOfThought:
                    // Validate reasoning steps
                    break;
                default:
                    break;
            }
        }
    }





}
