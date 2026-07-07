using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptography
{
    public class HelpItem
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public HelpItem(string title, string сontent)
        {
            Title = title;
            Content = сontent;
        }
    }
}
