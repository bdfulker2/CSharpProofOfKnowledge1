using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    public interface IScored
    {
        float score { get; set; }
        float MaximumScore { get; set; }
    }
}
