using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoDelegate
{
    public partial class FormFileSorter : Form
    {
        public FormFileSorter()
        {
            InitializeComponent();
        }

        private void FormFileSorter_DoubleClick(object sender, EventArgs e)
        {
            NumbersSort numbersSort = new NumbersSort();
            labelFileContent.Text = numbersSort.Content;
        }
    }
}
