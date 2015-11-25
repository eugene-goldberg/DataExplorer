namespace DataExplorer.Module.Controllers
{
    partial class ViewController_DataLoadMap_FieldMaps_ListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.simpleActionImportFieldMaps = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.simpleActionLoadDataUsingSelectedFieldMaps = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // simpleActionImportFieldMaps
            // 
            this.simpleActionImportFieldMaps.Caption = "Import Field Maps";
            this.simpleActionImportFieldMaps.ConfirmationMessage = null;
            this.simpleActionImportFieldMaps.Id = "ImportFieldMaps";
            this.simpleActionImportFieldMaps.ToolTip = null;
            this.simpleActionImportFieldMaps.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleActionImportFieldMaps_Execute);
            // 
            // simpleActionLoadDataUsingSelectedFieldMaps
            // 
            this.simpleActionLoadDataUsingSelectedFieldMaps.Caption = "Load Data Using Selected Field Maps";
            this.simpleActionLoadDataUsingSelectedFieldMaps.ConfirmationMessage = null;
            this.simpleActionLoadDataUsingSelectedFieldMaps.Id = "LoadDataUsingSelectedFieldMaps";
            this.simpleActionLoadDataUsingSelectedFieldMaps.ToolTip = null;
            this.simpleActionLoadDataUsingSelectedFieldMaps.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.simpleActionLoadDataUsingSelectedFieldMaps_Execute);
            // 
            // ViewController_DataLoadMap_FieldMaps_ListView
            // 
            this.Actions.Add(this.simpleActionImportFieldMaps);
            this.Actions.Add(this.simpleActionLoadDataUsingSelectedFieldMaps);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction simpleActionImportFieldMaps;
        private DevExpress.ExpressApp.Actions.SimpleAction simpleActionLoadDataUsingSelectedFieldMaps;
    }
}
