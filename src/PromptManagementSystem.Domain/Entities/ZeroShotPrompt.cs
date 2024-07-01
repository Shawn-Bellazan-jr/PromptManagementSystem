using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptManagementSystem.Domain.Entities
{
    public class ZeroShotPrompt : Prompt
    {
        // Add specific properties for ZeroShot prompts
        public string InputFormat { get; set; }
        public string OutputFormat { get; set; }
    }
}
