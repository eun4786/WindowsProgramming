using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Watics.Models
{
    class PlayerInventory
    {
        public List<InventoryItem> inventory { get; set; }
        private int nextItemID = 0;

        public PlayerInventory()
        {
            inventory = new List<InventoryItem>();
        }

        public void AddItem(GameItem gameItem)
        {
            inventory.Add(new InventoryItem(nextItemID, gameItem.name));
            nextItemID++;
        }

        public void RemoveItem(int itemID)
        {

            foreach (InventoryItem item in inventory)
            {
                if (item.itemID == itemID)
                {
                    //delete item from inventory
                }
            }

        }
    }
}
