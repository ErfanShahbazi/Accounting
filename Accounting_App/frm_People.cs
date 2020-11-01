using Accounting_DataLayer;
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
    public partial class frm_People : Form
    {
        public frm_People()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_People_Load(object sender, EventArgs e)
        {
            dgPeople.AutoGenerateColumns = false;
            BindGrid();
        }

        public void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgPeople.DataSource = db.PeopleRepository.GetAllPeople();
            }
            
        }

        

       



        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void btnShowSearchBox_Click(object sender, EventArgs e)
        {
            txtSearch.Visible = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgPeople.DataSource = db.PeopleRepository.FindPersonBySearch(txtSearch.Text);
            }
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {

            if (dgPeople.CurrentCell != null)
            {
                if (MessageBox.Show("Do you really want to delete this person from your database?","Sure?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int idToDelete = int.Parse(dgPeople.CurrentRow.Cells[0].Value.ToString());
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.PeopleRepository.DeletePerson(idToDelete);
                        db.SaveChanges();
                        BindGrid();
                    }
                }
                
            }
            else
            {
                MessageBox.Show("None of the people have been selected.");
            }
            
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frm_PeopleInput frm_PeopleInput = new frm_PeopleInput();
            frm_PeopleInput.ShowDialog();
        }
    }
}
