using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment.Parts
{
    public class Heart : Part
    {
        public string name = "Heart";
        public string details = "Still warm.";
        public bool isused = false;

        public void SetStatus(bool used)
        {
            this.isused = used;
        }

    }
}
