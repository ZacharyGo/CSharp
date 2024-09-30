using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CRUDwithEntityFramework.Entities;

namespace CRUDwithEntityFramework
{
    public partial class Form1 : Form
    {
        Detail MyDetail = new Detail();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopGridView();
        }

        private void PopGridView()
        {
            using (var MyModelEntities = new MyModel())
            {
                dataGridView1.DataSource = MyModelEntities.Details.ToList<Detail>();
            }
             
        }
    }
}
