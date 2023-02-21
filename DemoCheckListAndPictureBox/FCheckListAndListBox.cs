using System.Linq.Expressions;

namespace DemoCheckListAndPictureBox
{
    public partial class fDemo : Form
    {
        public fDemo()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbDanhSach.Items.Clear();
            foreach (var item in clbDanhSach.CheckedItems)
            { 
                lbDanhSach.Items.Add(item);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for(int i = lbDanhSach.SelectedItems.Count -1; i >= 0; i--) {
                for(int j = clbDanhSach.Items.Count -1; j>=0; j--)
                {
                    if (clbDanhSach.Items[j] == lbDanhSach.SelectedItems[i])
                    {
                        clbDanhSach.SetItemChecked(j, false);
                        break;
                    }
                }
                lbDanhSach.Items.Remove(lbDanhSach.SelectedItems[i]);
            }
        }

        private void fDemo_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lbDanhSach.Items.Clear();
            for (var i = 0; i < clbDanhSach.Items.Count; i++)
            {
                clbDanhSach.SetItemChecked(i, false);
            }
            
        }

    }
}