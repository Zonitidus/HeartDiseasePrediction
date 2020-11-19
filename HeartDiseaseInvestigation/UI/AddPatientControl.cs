using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HeartDiseaseInvestigation.Model;

namespace HeartDiseaseInvestigation.UI
{
    public partial class AddPatientControl : UserControl
    {
        Connection cn = new Connection();
        public AddPatientControl()
        {
            InitializeComponent();
        }
    }
}
