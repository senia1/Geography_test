using Geography_testClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geography_testWinFormsApp
{
    public partial class ResultsForm : Form
    {
        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            var results = UserResultsStorage.GetAll();

            foreach (var result in results)
            {
                resultsDataGridView.Rows.Add(result.Name, result.RightAnswersCount, result.Diagnos);
            }
        }

        private void resultsCloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
