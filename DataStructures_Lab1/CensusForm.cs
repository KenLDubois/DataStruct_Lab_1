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
        static int numOfRegions = 47;

        public CensusForm()
        {
            InitializeComponent();

            censusInfoArray = new CensusInfo[numOfProvs * numOfRegions];

            int index = 0;

            for (int p = 0; p < numOfProvs; p++) { 
                for(int r = 0; r < numOfRegions; r++)
                {

                    censusInfoArray[index] = new CensusInfo()
                    {
                        ProvID = p,
                        RegionID = r
                    };

                    index++;
                }
            }

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

                sb.AppendLine($"\tRegion ID #{ci.RegionID.ToString()}: {ci.Population.ToString()}");
            }

            return sb.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.ShowDialog();

            FileStream fs =
                new FileStream(sfd.FileName, FileMode.Create);

            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.Write(BuildContent());
            }
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {

            int prov = int.TryParse(txtProvince.Text, out prov) && prov < numOfProvs ? prov : -1;
            int reg = int.TryParse(txtRegion.Text, out reg) && reg < numOfRegions ? reg : -1;
            int pop = int.TryParse(txtPopulation.Text, out pop) ? prov : -1;

            if(prov <= 0 && reg <= 0 && pop <= 0)
            {
                //TODO: Code Insert logic
            }

        }
    }
}
