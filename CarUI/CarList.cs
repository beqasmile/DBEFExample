using CarCommon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarUI
{
    public partial class CarList : Form , IObserverNotify
    {
        public CarList()
        {
            InitializeComponent();
            CarObserver.GetInstance().AddNotifier(this);
        }

        public void Notification(object somedata)
        {
            this.allarmButton.Visible = true;
            this.allarmButton.Text = somedata.ToString();
        }

        private void CarList_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = CarDataST.GetInstance().Cars; 
            
        }
    }
}
