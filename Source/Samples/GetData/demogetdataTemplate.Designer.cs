using System;
using Smobiler.Core;
namespace Smobiler.Tutorials.Samples
{
    partial class demogetdataTemplate : Smobiler.Core.Controls.MobileUserControl
    {
        #region "SmobilerUserControl generated code "

        public demogetdataTemplate()
            : base()
        {
            //This call is required by the SmobilerUserControl.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerUserControl overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerUserControl
        //It can be modified using the SmobilerUserControl.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.panel1 = new Smobiler.Core.Controls.Panel();
            this.label1 = new Smobiler.Core.Controls.Label();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.label1});
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 40);
            this.panel1.Touchable = true;
            this.panel1.Press += new System.EventHandler(this.panel1_Press);
            // 
            // label1
            // 
            this.label1.DataMember = "ID";
            this.label1.DisplayMember = "ID";
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 40);
            this.label1.Text = "label1";
            // 
            // demogetdataTemplate
            // 
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.panel1});
            this.Size = new System.Drawing.Size(300, 40);
            this.Name = "demogetdataTemplate";

        }
        #endregion

        private Smobiler.Core.Controls.Panel panel1;
        private Smobiler.Core.Controls.Label label1;
    }
}