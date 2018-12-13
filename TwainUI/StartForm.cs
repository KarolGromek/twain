using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TwainKG
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();

            
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            //if (MessageBox.Show("Its running....", "TWAIN") == DialogResult.OK)
            //{
            //    //Close();
            //}
        }
    }
}
