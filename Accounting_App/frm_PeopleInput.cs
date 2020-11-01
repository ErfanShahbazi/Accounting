using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting_App
{
    public partial class frm_PeopleInput : Form
    {
        public frm_PeopleInput()
        {
            InitializeComponent();
        }

        private void frm_PeopleInput_Load(object sender, EventArgs e)
        {

        }


        private void btnPictureSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog pictureSelect = new OpenFileDialog();
            if (pictureSelect.ShowDialog() == DialogResult.OK)
            {
                PersonImage.ImageLocation = pictureSelect.FileName;

            }
        }
    }
}
