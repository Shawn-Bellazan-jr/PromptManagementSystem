using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptManagementSystem.Domain.Entities
{
    public abstract class Prompt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Instructions { get; set; }
        public string Category { get; set; }

        // List to store prompt content
        public List<PromptContent> Contents { get; set; } = new List<PromptContent>();

        // Add validation rules if needed
        public void Validate()
        {
            if (string.IsNullOrEmpty(Name))
            {
                throw new ArgumentException("Prompt name cannot be empty.");
            }

            // Ensure at least one input content
            if (!Contents.Any(c => c.ContentType == PromptContentType.Input))
            {
                throw new ArgumentException("Prompt must have at least one input content.");
            }

            // Additional validation rules for specific content types (optional)
            // ...
        }
    }
}
