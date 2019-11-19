using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListAppProof
{
    public partial class Form1 : Form
    {
        private List<Item> items = new List<Item>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            //Make new item
            Item newItem = new Item(txtNewItem.Text);
            //Add new item to list
            items.Add(newItem);
            //Refresh list
            refreshList();
        }

        private void refreshList()
        {
            lstItems.Items.Clear();
            lstItems.Items.AddRange(items.ToArray());
            updateText();
        }

        private void lstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateText();
        }

        private void chkComplete_CheckedChanged(object sender, EventArgs e)
        {
            Item selectedItem = (Item)lstItems.SelectedItem;
            if (selectedItem)
            {
                selectedItem.Complete = chkComplete.Checked;
            }
            updateText();
        }

        void updateText()
        {
            Item selectedItem = (Item)lstItems.SelectedItem;
            if (selectedItem)
            {
                //Current values
                txtItem.Text = selectedItem.DisplayInfo;
                chkComplete.Checked = selectedItem.Complete;
            }
            else
            {
                //Default values
                txtItem.Text = "";
                chkComplete.Checked = false;
            }
            lstItems.DisplayMember = "";
            lstItems.DisplayMember = " ";
            //Calculate complete count
            lblCompleteCount.Text = 
                calculateCompleteCount()
                + " / "
                + items.Count;
        }

        private int calculateCompleteCount()
        {
            int count = 0;
            foreach(Item item in items)
            {
                if (item.Complete)
                {
                    count++;
                }
            }
            return count;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selectedIndex = lstItems.SelectedIndex;
            if (selectedIndex >= 0)
            {
                items.RemoveAt(selectedIndex);
            }
            refreshList();
            updateText();
        }
    }
}
