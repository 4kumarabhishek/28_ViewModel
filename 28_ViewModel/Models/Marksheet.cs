using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _28_ViewModel.Models
{
    public class Marksheet
    {
        public Student MyStudent { get; set; }
        public Assessment Assessment { get; set; }

        public int Total
        {
            get
            {
                return Assessment.MVCmarks + Assessment.Bootstrapmarks + Assessment.Csharpmarks;
            }
        }
    }
}