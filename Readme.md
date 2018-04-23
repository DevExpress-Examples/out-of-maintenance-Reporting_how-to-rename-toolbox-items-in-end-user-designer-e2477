# How to rename Toolbox items in End-User Designer


<p>This example demonstrates how to rename Toolbox items in End-User Designer.</p><p>To do this, handle the <strong>XRDesignMdiController.DesignPanelLoaded</strong> event, obtain the <strong>System.Drawing.Design.IToolboxService</strong> object from the report's designer, and customize the collection of Toolbox items as you need.</p><p>In this example, a prefix is added to the names of all the items in the Toolbox.</p>

<br/>


