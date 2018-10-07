using System.Collections.Generic;

namespace Blog.Resources
{
    public class ResultsRes
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public IEnumerable<string> Skills { get; set; }
        public string Gender { get; set; }

        public ResultsRes()
        {
            Skills = new List<string>();
        }

    }
}