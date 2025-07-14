using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class ctrlStatisticsWithBranchCard : UserControl
    {
        public ctrlStatisticsWithBranchCard()
        {
            InitializeComponent();
        }
        public void LoadData(int BranchID)
        {
            ctrlBranchCard1.LoadData(BranchID);
            ctrlStatistics1.LOadDateForBranchID(BranchID);
        }
        private void ctrlStatisticsWithName_Load(object sender, EventArgs e)
        {

        }
    }
}
