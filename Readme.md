<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128603086/10.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2477)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/EUD_RenameToolboxItems/Form1.cs) (VB: [Form1.vb](./VB/EUD_RenameToolboxItems/Form1.vb))
<!-- default file list end -->
# How to rename Toolbox items in End-User Designer


<p>This example demonstrates how to rename Toolbox items in End-User Designer.</p><p>To do this, handle the <strong>XRDesignMdiController.DesignPanelLoaded</strong> event, obtain the <strong>System.Drawing.Design.IToolboxService</strong> object from the report's designer, and customize the collection of Toolbox items as you need.</p><p>In this example, a prefix is added to the names of all the items in the Toolbox.</p>

<br/>


