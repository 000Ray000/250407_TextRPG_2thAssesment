﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment.Items
{
    public class Note : Item
    {
        public Note()
        {
            name = "Note";
            details = "Something is written, but it's too small to read.";
            isused = false;
        }
    }
}
