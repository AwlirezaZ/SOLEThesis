﻿namespace SOFEThesis.Domain
{
    public class Picture
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string AmbiguousSituation { get; set; }
        public Picture(string name,string source, string ambiguousSituation) 
        { 
            Name = name;
            Source = source;
            AmbiguousSituation = ambiguousSituation;
        }
    }
    
}
