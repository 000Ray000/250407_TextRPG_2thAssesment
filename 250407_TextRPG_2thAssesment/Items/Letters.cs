using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250407_TextRPG_2thAssesment.Items
{
    public class Letters : Item
    {
        public string name = "Letters";
        public string details = "F / D / K / N / I / A / E / R";
        public bool isused = false;


        public void SetStatus(bool used)
        {
            this.isused = used;
        }

    }
}
