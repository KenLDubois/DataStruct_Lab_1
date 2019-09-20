using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStructures_Lab1
{
    public partial class CensusForm : Form
    {
        static CensusInfo[] censusInfoArray;
        static int numOfProvs = 13;
        static int numOfRegions = 48;

        public CensusForm()
        {
            InitializeComponent();

            ClearInputs();
            censusInfoArray = new CensusInfo[numOfProvs * numOfRegions];

            ResetCensusInfoArray();
        }

        // EVENT HANDLERS

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.Title = "Please select a file name and location";
            sfd.DefaultExt = ".txt";
            sfd.FileName = $"CensusOutput_{DateTime.Today.ToShortDateString()}";
            sfd.ShowDialog();

            try
            {
                FileStream fs =
                new FileStream(sfd.FileName, FileMode.Create);

                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(BuildContent());
                }
            }
            catch (Exception)
            {

                sfd.Dispose();
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (InputIsValid(out int prov, out int reg, out int pop))
            {
                int index = CalculateIndex(prov, reg);
                censusInfoArray[index].Population = pop;

                MessageBox.Show($"Population {pop} saved for Prov #{prov}, Region #{reg}.");

                ClearInputs();
            }

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ResetCensusInfoArray();
            ClearInputs();
            MessageBox.Show("Data successfully cleared.");
        }

        // OTHER METHODS

        private void ResetCensusInfoArray()
        {
            int index = 0;

            for (int p = 0; p < numOfProvs; p++)
            {
                for (int r = 0; r < numOfRegions; r++)
                {

                    censusInfoArray[index] = new CensusInfo()
                    {
                        ProvID = p,
                        RegionID = r,
                        Population = -1
                    };

                    index++;
                }
            }
        }

        private void ClearInputs()
        {
            txtProvince.Text = "0";
            txtRegion.Text = "0";
            txtPopulation.Text = "0";

            InputIsValid(out int prov, out int reg, out int pop);
        }

        private bool InputIsValid(out int prov, out int reg, out int pop)
        {
            prov = int.TryParse(txtProvince.Text, out prov) && prov < numOfProvs ? prov : -1;
            reg = int.TryParse(txtRegion.Text, out reg) && reg < numOfRegions ? reg : -1;
            pop = int.TryParse(txtPopulation.Text, out pop) ? pop : -1;

            bool isValid = prov >= 0 && reg >= 0 && pop >= 0 ? true : false;

            lblProvVals.ForeColor = prov >= 0 ? SystemColors.ControlText : Color.Red;
            lblRegVals.ForeColor = reg >= 0 ? SystemColors.ControlText : Color.Red;
            lblPopVals.ForeColor = pop >= 0 ? SystemColors.ControlText : Color.Red;

            return isValid;
        }

        private string BuildContent()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Canadian Population Information ({DateTime.Now.ToShortDateString()})\n");

            int currentProv = -1;

            foreach(CensusInfo ci in censusInfoArray)
            {
                if(ci.ProvID != currentProv)
                {
                    sb.AppendLine($"Province ID #{ci.ProvID}");
                    currentProv++;
                }
                if(ci.Population >= 0 || chkIncludeNoPop.Checked == true)
                {
                    string population = ci.Population >= 0 ? ci.Population.ToString() : "Unknown";

                    sb.AppendLine($"\tRegion ID #{ci.RegionID.ToString()}: {population}");
                }
            }

            return sb.ToString();
        }

        private int CalculateIndex(int prov, int reg)
        {
            return prov * numOfRegions + reg;
        }
    }
}
