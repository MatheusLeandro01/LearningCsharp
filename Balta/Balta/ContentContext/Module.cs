﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Balta.SharedContext;

namespace Balta.ContentContext
{
    public class Module : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }
        public IList<Lecture> Lectures { get; set; }
        public Module()
        {
            Lectures = new List<Lecture>();
        }

    }
}
