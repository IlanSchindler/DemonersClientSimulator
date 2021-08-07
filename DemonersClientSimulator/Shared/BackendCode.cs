using System;
using System.Collections.Generic;
using System.Text;


namespace DemonersClientSimulator.Shared {

    public class ProjectType
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public List<string> Options { get; set; }
    }

    public class Difficulty
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int ElementCount { get; set; }
        public int Priority { get; set; }
        public List<string> Elements { get; set; }
    }

    public class Language
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }

    public class BackendCode {

        public BackendCode(List<Prompt> prompts)
        {
            promptList = prompts;

        }

        public List<Prompt> promptList;
        public Prompt generate(ProjectType type, Difficulty diff, Language lang)
        {
            List<Prompt> valid = new List<Prompt>();
            var rand = new Random();
            foreach (Prompt prompt in promptList)
            {
                if (prompt.type == type && prompt.diff == diff && prompt.lang == lang)
                {
                    valid.Add(prompt);
                }
            }

            return valid[rand.Next(valid.Count)];
        }

        



    }

   public class Prompt
    {
        public string desc { get; set; }
        public ProjectType type { get; set; }
        public Difficulty diff { get; set; }
        public Language lang { get; set; }

    }
}
