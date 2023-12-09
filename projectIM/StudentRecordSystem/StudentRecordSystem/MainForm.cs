using System;
using System.Windows.Forms;

namespace StudentRecordSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customizeDesign();

        }
        private void MainForm_load(object sender, EventArgs e)
        {

        }
        private void customizeDesign()
        {
            panel_studSubmenu.Visible = false;
            panel_subjectSubmenu.Visible = false;
            panel_scoreSubmenu.Visible = false;
            panel_enrollSubmenu.Visible = false;
            panel_requirementSubmenu.Visible = false;
        }
        private void hideSubmenu()
        {
            if (panel_studSubmenu.Visible == true)
                panel_studSubmenu.Visible = false;

            if (panel_subjectSubmenu.Visible == true)
                panel_subjectSubmenu.Visible = false;

            if (panel_scoreSubmenu.Visible == true)
                panel_scoreSubmenu.Visible = false;

            if (panel_enrollSubmenu.Visible == true)
                panel_enrollSubmenu.Visible = false;

            if (panel_requirementSubmenu.Visible == true)
                panel_requirementSubmenu.Visible = false;
        }
        private void showSubmenu(Panel Submenu)
        {
            if (Submenu.Visible == false)
            {
                hideSubmenu();
                Submenu.Visible = true;
            }
            else
                Submenu.Visible = false;
        }

        private void button_student_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_studSubmenu);
        }
        #region studSubmenu 
        private void button_registration_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubmenu();
        }

        private void button_enrolledStud_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubmenu();
        }

        private void button_stdPrint_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubmenu();
        }
        #endregion studSubmenu
        private void button_subject_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_subjectSubmenu);
        }
        #region subjectSubmenu
        private void button_subjectName_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubmenu();
        }

        private void button_manageSub_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubmenu();
        }

        private void button_subjectPrint_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubmenu();
        }
        #endregion subjectSubmenu
        private void button_score_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_scoreSubmenu);
        }

        #region scoreSubmenu
        private void button_newScore_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubmenu();
        }

        private void button_manageScore_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubmenu();
        }

        private void button_scorePrint_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubmenu();
        }
        #endregion scoreSubmenu
        private void button_enrollmentrates_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_enrollSubmenu);
        }
        #region enrollSubmenu
        private void button_enrollRates_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubmenu();
        }

        private void button_enrollFees_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubmenu();
        }

        private void button_enrollPrint_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubmenu();
        }
        #endregion enrollSubmenu
        private void button_admissionReq_Click(object sender, EventArgs e)
        {
            showSubmenu(panel_requirementSubmenu);
        }
        #region requirementSubmenu
        private void button_Req_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //    
            hideSubmenu();
        }

        private void button_requirementPrint_Click(object sender, EventArgs e)
        {
            //
            //Your code
            //
            hideSubmenu();
        }





        #endregion requirementSubmenu

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void label_admin_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
 }
