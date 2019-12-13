using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019030066
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch(toolStrip1.Items.IndexOf(e.ClickedItem))
            {
                case 0:
                    Form Renter = new Renter();
                    for (int x=0;x<this.MdiChildren.Length;x++)
                    {
                        Form tempChild = (Form)this.MdiChildren[x];
                        tempChild.Close();
                    }
                    Renter.MdiParent = this;
                    Renter.WindowState = FormWindowState.Maximized;
                    Renter.Show();
                    break;
                case 1:
                    Form Room = new Room();
                    for(int x=0;x<this.MdiChildren.Length;x++)
                    {
                        Form tempChild = (Form)this.MdiChildren[x];
                        tempChild.Close();
                    }
                    Room.MdiParent = this;
                    Room.WindowState = FormWindowState.Maximized;
                    Room.Show();
                    break;
                case 2:
                    Form RoomQuery = new RoomQuery();
                    for(int x=0;x<this.MdiChildren.Length;x++)
                    {
                        Form tempChild = (Form)this.MdiChildren[x];
                        tempChild.Close();
                    }
                    RoomQuery.MdiParent = this;
                    RoomQuery.WindowState = FormWindowState.Maximized;
                    RoomQuery.Show();
                    break;
                case 3:
                    Form CustomerQuery = new CustomerQuery();
                    for(int x=0;x<this.MdiChildren.Length;x++)
                    {
                        Form tempChild = (Form)this.MdiChildren[x];
                        tempChild.Close();
                    }
                    CustomerQuery.MdiParent = this;
                    CustomerQuery.WindowState = FormWindowState.Maximized;
                    CustomerQuery.Show();
                    break;
                case 4:
                    Form Profit = new Profit();
                    for(int x=0;x<MdiChildren.Length;x++)
                    {
                        Form tempChild = (Form)MdiChildren[x];
                        tempChild.Close();
                    }
                    Profit.MdiParent = this;
                    Profit.WindowState = FormWindowState.Maximized;
                    Profit.Show();
                    break;
                case 5:
                    Application.Exit();
                    break;
            }
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            Form Help = new Help();
            for(int x=0;x<MdiChildren.Length;x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            Help.MdiParent = this;
            Help.WindowState = FormWindowState.Maximized;
            Help.Show();
        }

        private void menuItem5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            Form Renter = new Renter();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)this.MdiChildren[x];
                tempChild.Close();
            }
            Renter.MdiParent = this;
            Renter.WindowState = FormWindowState.Maximized;
            Renter.Show();
        }

        private void menuItem7_Click(object sender, EventArgs e)
        {
            Form Room = new Room();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)this.MdiChildren[x];
                tempChild.Close();
            }
            Room.MdiParent = this;
            Room.WindowState = FormWindowState.Maximized;
            Room.Show();
        }

        private void menuItem8_Click(object sender, EventArgs e)
        {
            Form RoomQuery = new RoomQuery();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)this.MdiChildren[x];
                tempChild.Close();
            }
            RoomQuery.MdiParent = this;
            RoomQuery.WindowState = FormWindowState.Maximized;
            RoomQuery.Show();
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            Form CustomerQuery = new CustomerQuery();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)this.MdiChildren[x];
                tempChild.Close();
            }
            CustomerQuery.MdiParent = this;
            CustomerQuery.WindowState = FormWindowState.Maximized;
            CustomerQuery.Show();
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            Form Customer = new Customer();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)this.MdiChildren[x];
                tempChild.Close();
            }
            Customer.MdiParent = this;
            Customer.WindowState = FormWindowState.Maximized;
            Customer.Show();
        }

        private void menuItem11_Click(object sender, EventArgs e)
        {
            Form Profit = new Profit();
            for (int x = 0; x < MdiChildren.Length; x++)
            {
                Form tempChild = (Form)MdiChildren[x];
                tempChild.Close();
            }
            Profit.MdiParent = this;
            Profit.WindowState = FormWindowState.Maximized;
            Profit.Show();
        }

        private void 数据维护DToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
