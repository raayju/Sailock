using System.Collections.Generic;

namespace Sailock.Models
{
    public class ChangelogEntry
    {
        public string Version { get; set; }
        public string Date { get; set; }
        public bool IsLatest { get; set; } = false;

        public List<string> Added { get; set; } = new();
        public List<string> Fixed { get; set; } = new();
        public List<string> Changed { get; set; } = new();
        public List<string> Removed { get; set; } = new();
    }
}