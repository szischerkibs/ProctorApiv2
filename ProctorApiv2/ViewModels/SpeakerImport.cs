﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProctorApiv2.ViewModels
{
    public class SpeakerImport
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public string GravatarUrl { get; set; }
        public string TwitterLink { get; set; }
        public string GitHubLink { get; set; }
        public string LinkedInProfile { get; set; }
        public string BlogUrl { get; set; }
        public List<string> SessionIds { get; set; }
    }
}