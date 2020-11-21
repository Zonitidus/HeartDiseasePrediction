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
using HeartDiseaseInvestigation.DecisionTreeClassifier;

namespace HeartDiseaseInvestigation.UI
{
    public partial class AddPatientControl : UserControl
    {
        Connection cn = new Connection();
        Node<Patient> root;
        DecisionTree<Patient> tree;


        public AddPatientControl()
        {
            InitializeComponent();
            //pictureBoxLogo.Image = Image.FromFile("../../Data/logo.ico");
        }

        private void buttonRegisterAuto_Click(object sender, EventArgs e)
        {
            string id = textBoxID.Text;
            if(id == "")
            {
                MessageBox.Show("Please enter de patient ID", "Error", MessageBoxButtons.OK);

            }

            int age = Convert.ToInt32(numericUpDownAge.Value);

            int sex = -1;
            if (radioButtonMale.Checked)
            {
                sex = 1;
            }
            else if(radioButtonFemale.Checked)
            {
                sex = 0;
            }
            else
            {
                MessageBox.Show("Please choose an option for the gender", "Error", MessageBoxButtons.OK);
            }

            int cp = -1;
            if (radioButtonCP1.Checked)
            {
                cp = 0;
            }
            else if (radioButtonCP2.Checked)
            {
                cp = 1;
            }
            else if (radioButtonCP3.Checked)
            {
                cp = 2;
            }
            else if (radioButtonCP4.Checked)
            {
                cp = 3;
            }
            else
            {
                MessageBox.Show("Please choose an option for the chest pain", "Error", MessageBoxButtons.OK);
            }

            int trestbps = Convert.ToInt32(numericUpDownTrestbps.Value);

            int chol = Convert.ToInt32(numericUpDownChol.Value);

            int fbs = -1;
            if (radioButtonFbsYes.Checked)
            {
                fbs = 1;
            }
            else if(radioButtonFbsNo.Checked){
                fbs = 0;
            }
            else
            {
                MessageBox.Show("Please choose an option for the fasting blood sugar", "Error", MessageBoxButtons.OK);
            }

            int restecg = -1;
            if (radioButtonRestecg1.Checked)
            {
                restecg = 0;
            }
            else if (radioButtonRestecg2.Checked)
            {
                restecg = 1;
            }
            else if (radioButtonRestecg3.Checked)
            {
                restecg = 2;
            }
            else
            {
                MessageBox.Show("Please choose an option for the resting electrocardiographic results", "Error", MessageBoxButtons.OK);
            }

            int thalach = Convert.ToInt32(numericUpDownThalach.Value);

            int exang = -1;
            if (radioButtonExangYes.Checked)
            {
                exang = 1;
            }
            else if (radioButtonExangNo.Checked)
            {
                exang = 0;
            }
            else
            {
                MessageBox.Show("Please choose an option for the exercise induced angina", "Error", MessageBoxButtons.OK);
            }

            double oldpeak = Decimal.ToDouble(numericUpDownOldpeak.Value);

            int slope = -1;
            if (radioButtonSlope1.Checked)
            {
                slope = 0;
            }
            else if (radioButtonSlope2.Checked)
            {
                slope = 1;
            }
            else if (radioButtonSlope3.Checked)
            {
                slope = 2;
            }
            else
            {
                MessageBox.Show("Please choose an option for the slope of the peak exercise ST", "Error", MessageBoxButtons.OK);
            }

            int ca = -1;
            if (radioButtonCa0.Checked)
            {
                ca = 0;
            }
            else if (radioButtonCa1.Checked)
            {
                ca = 1;
            }
            else if (radioButtonCa2.Checked)
            {
                ca = 2;
            }
            else if (radioButtonCa3.Checked)
            {
                ca = 3;
            }
            else
            {
                MessageBox.Show("Please choose an option for the number of major vessels colored by flourosopy", "Error", MessageBoxButtons.OK);
            }

            int thal = -1;
            if (radioButtonThal0.Checked)
            {
                thal = 0;
            }
            else if (radioButtonThal1.Checked)
            {
                thal = 1;
            }
            else if (radioButtonThal2.Checked)
            {
                thal = 2;
            }
            else if (radioButtonThal3.Checked)
            {
                thal = 3;
            }
            else
            {
                MessageBox.Show("Please choose an option for the thalassemia", "Error", MessageBoxButtons.OK);
            }

            try
            {
                Patient pt = new Patient(id, age, sex, cp, trestbps, chol, fbs, restecg, thalach, exang, oldpeak, slope, ca, thal, 0);
                String aux = cn.SendPatientToServer("https://pi-final-app.herokuapp.com/classify-patient", pt);
                MessageBox.Show(aux, "Register", MessageBoxButtons.OK);
            }
            catch (Exception excep)
            {
                MessageBox.Show("Error, cannot create the patient, please check and try again.", "Error", MessageBoxButtons.OK);
                Console.WriteLine(excep.Message);
            }
        }

        private void buttonResetForm_Click(object sender, EventArgs e)
        {
            radioButtonCa0.Checked = false;
            radioButtonCa1.Checked = false;
            radioButtonCa2.Checked = false;
            radioButtonCa3.Checked = false;
            radioButtonCP1.Checked = false;
            radioButtonCP2.Checked = false;
            radioButtonCP3.Checked = false;
            radioButtonCP4.Checked = false;
            radioButtonExangNo.Checked = false;
            radioButtonExangYes.Checked = false;
            radioButtonFbsNo.Checked = false;
            radioButtonFbsYes.Checked = false;
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            radioButtonRestecg1.Checked = false;
            radioButtonRestecg2.Checked = false;
            radioButtonRestecg3.Checked = false;
            radioButtonSlope1.Checked = false;
            radioButtonSlope2.Checked = false;
            radioButtonSlope3.Checked = false;
            radioButtonThal0.Checked = false;
            radioButtonThal1.Checked = false;
            radioButtonThal2.Checked = false;
            radioButtonThal3.Checked = false;
            numericUpDownAge.Value = 0;
            numericUpDownChol.Value = 0;
            numericUpDownOldpeak.Value = 0;
            numericUpDownThalach.Value = 0;
            numericUpDownTrestbps.Value = 0;
            textBoxID.Text = "";

        }


        private void buttonRegisterManual_Click(object sender, EventArgs e)
        {
            if (this.root != null)
            {
                string id = textBoxID.Text;
                if (id == "")
                {
                    MessageBox.Show("Please enter de patient ID", "Error", MessageBoxButtons.OK);

                }

                int age = Convert.ToInt32(numericUpDownAge.Value);

                int sex = -1;
                if (radioButtonMale.Checked)
                {
                    sex = 1;
                }
                else if (radioButtonFemale.Checked)
                {
                    sex = 0;
                }
                else
                {
                    MessageBox.Show("Please choose an option for the gender", "Error", MessageBoxButtons.OK);
                }

                int cp = -1;
                if (radioButtonCP1.Checked)
                {
                    cp = 0;
                }
                else if (radioButtonCP2.Checked)
                {
                    cp = 1;
                }
                else if (radioButtonCP3.Checked)
                {
                    cp = 2;
                }
                else if (radioButtonCP4.Checked)
                {
                    cp = 3;
                }
                else
                {
                    MessageBox.Show("Please choose an option for the chest pain", "Error", MessageBoxButtons.OK);
                }

                int trestbps = Convert.ToInt32(numericUpDownTrestbps.Value);

                int chol = Convert.ToInt32(numericUpDownChol.Value);

                int fbs = -1;
                if (radioButtonFbsYes.Checked)
                {
                    fbs = 1;
                }
                else if (radioButtonFbsNo.Checked)
                {
                    fbs = 0;
                }
                else
                {
                    MessageBox.Show("Please choose an option for the fasting blood sugar", "Error", MessageBoxButtons.OK);
                }

                int restecg = -1;
                if (radioButtonRestecg1.Checked)
                {
                    restecg = 0;
                }
                else if (radioButtonRestecg2.Checked)
                {
                    restecg = 1;
                }
                else if (radioButtonRestecg3.Checked)
                {
                    restecg = 2;
                }
                else
                {
                    MessageBox.Show("Please choose an option for the resting electrocardiographic results", "Error", MessageBoxButtons.OK);
                }

                int thalach = Convert.ToInt32(numericUpDownThalach.Value);

                int exang = -1;
                if (radioButtonExangYes.Checked)
                {
                    exang = 1;
                }
                else if (radioButtonExangNo.Checked)
                {
                    exang = 0;
                }
                else
                {
                    MessageBox.Show("Please choose an option for the exercise induced angina", "Error", MessageBoxButtons.OK);
                }

                double oldpeak = Decimal.ToDouble(numericUpDownOldpeak.Value);

                int slope = -1;
                if (radioButtonSlope1.Checked)
                {
                    slope = 0;
                }
                else if (radioButtonSlope2.Checked)
                {
                    slope = 1;
                }
                else if (radioButtonSlope3.Checked)
                {
                    slope = 2;
                }
                else
                {
                    MessageBox.Show("Please choose an option for the slope of the peak exercise ST", "Error", MessageBoxButtons.OK);
                }

                int ca = -1;
                if (radioButtonCa0.Checked)
                {
                    ca = 0;
                }
                else if (radioButtonCa1.Checked)
                {
                    ca = 1;
                }
                else if (radioButtonCa2.Checked)
                {
                    ca = 2;
                }
                else if (radioButtonCa3.Checked)
                {
                    ca = 3;
                }
                else
                {
                    MessageBox.Show("Please choose an option for the number of major vessels colored by flourosopy", "Error", MessageBoxButtons.OK);
                }

                int thal = -1;
                if (radioButtonThal0.Checked)
                {
                    thal = 0;
                }
                else if (radioButtonThal1.Checked)
                {
                    thal = 1;
                }
                else if (radioButtonThal2.Checked)
                {
                    thal = 2;
                }
                else if (radioButtonThal3.Checked)
                {
                    thal = 3;
                }
                else
                {
                    MessageBox.Show("Please choose an option for the thalassemia", "Error", MessageBoxButtons.OK);
                }

                try
                {
                    Patient pt = new Patient(id, age, sex, cp, trestbps, chol, fbs, restecg, thalach, exang, oldpeak, slope, ca, thal, 0);

                    String clas = this.tree.PrintLeaf(this.tree.Classify(pt, this.root))[1];

                    String r = "DOES NOT";
                        
                    if (clas.Equals("1"))
                    {
                        r = "DOES";
                    }

                    String aux = "The patient "+r+" have a heart disease.";
                    MessageBox.Show(aux, "Register", MessageBoxButtons.OK);
                }
                catch (Exception excep)
                {
                    MessageBox.Show("Error, cannot create the patient, please check and try again.", "Error", MessageBoxButtons.OK);
                    Console.WriteLine(excep.Message);
                }
            }
            else
            {
                MessageBox.Show("Please train the model by looking at the decision tree manual tab.", "Error", MessageBoxButtons.OK);
            }
        }

        public void SetRoot(Node<Patient> ro)
        {
            this.root = ro;
        }

        public void SetTree(DecisionTree<Patient> destree)
        {
            this.tree = destree;
        }
    }
}
