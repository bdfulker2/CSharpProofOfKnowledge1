using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolLibrary
{
    /// <summary>
    /// Class for assignment type English Paper
    /// </summary>
    public class EnglishPaper
    {
        /// <summary>
        /// Property for accessing Title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Property for accessing Minimum Word count
        /// </summary>
        public int MinimumWordCount { get; set; }

        /// <summary>
        /// Property for accessing the text of the paper
        /// </summary>
        public string PaperText { get; set; }
    }
}
