using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromptManagementSystem.Domain.Entities
{
    public class FewShotPrompt: Prompt
    {
        // Add specific properties for FewShot prompts
        public List<Tuple<string, string>> Examples { get; set; } = new List<Tuple<string, string>>();
    }
}
