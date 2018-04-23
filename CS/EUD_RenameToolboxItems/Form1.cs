using System;
using System.Windows.Forms;
using System.Drawing.Design;
using DevExpress.XtraReports.UserDesigner;
// ...

namespace EUD_RenameToolboxItems {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create a new End-User Designer.
            XRDesignForm designForm = new XRDesignForm();

            // Handle the DesignPanelLoaded event.
            designForm.DesignMdiController.DesignPanelLoaded +=
                new DesignerLoadedEventHandler(DesignMdiController_DesignPanelLoaded);

            // Load the report into the designer. 
            designForm.OpenReport(new XtraReport1());

            // Show the End-User Designer window.
            designForm.Show();
        }

        private void DesignMdiController_DesignPanelLoaded(object sender, DesignerLoadedEventArgs e) {
            // Get the toolbox service.
            IToolboxService ts = (IToolboxService)e.DesignerHost.GetService(typeof(IToolboxService));

            // Get a collection of toolbox items.
            ToolboxItemCollection coll = ts.GetToolboxItems();

            // Iterate through toolbox items.
            foreach (ToolboxItem item in coll) {
                // Add the "Cool" prefix to all toolbox item names.
                item.DisplayName = "Cool " + item.DisplayName;
            }
        }

    }
}
