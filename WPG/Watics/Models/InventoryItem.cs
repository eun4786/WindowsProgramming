using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watics.Models
{
    class InventoryItem
    {
        public int itemID { get; set; }
        public string itemName { get; set; }
        //내구도 뺐음

        public InventoryItem(int itemID, string itemName)
        {
            this.itemID = itemID;
            this.itemName = itemName;
        }
    }
}
