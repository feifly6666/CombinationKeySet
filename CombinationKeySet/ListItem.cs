using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CombinationKeySet
{
    class ListItem
    {
        public string text{get;set;}
        public int value { get; set; }

        public ListItem(int value,string text) {
            this.text = text;
            this.value = value;
        }
    }
}
