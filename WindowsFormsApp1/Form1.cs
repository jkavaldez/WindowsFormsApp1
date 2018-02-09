using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aIMMDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.aIMMDataSet.Employee);

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.EndEdit)
            {
                if (MessageBox.Show("Do you want to save the changes?", "Save changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    

                    
                }
                else
                    e.Handled = true;
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            employeeTableAdapter.Update(aIMMDataSet);
        }

        private void gridControl1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();

        }
    }   
}
