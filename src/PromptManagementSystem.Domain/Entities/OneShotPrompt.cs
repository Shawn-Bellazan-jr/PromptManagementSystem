using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptManagementSystem.Domain.Entities
{
    public class OneShotPrompt : Prompt
    {
        // Add specific properties for OneShot prompts
        public string ExampleInput { get; set; }
        public string ExampleOutput { get; set; }
    }
}
