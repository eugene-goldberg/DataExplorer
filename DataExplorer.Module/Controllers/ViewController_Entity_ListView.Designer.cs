namespace DataExplorer.Module.Controllers
{
    partial class ViewController_Entity_ListView
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
            this.singleChoiceActionAssociateSubjectArea = new DevExpress.ExpressApp.Actions.SingleChoiceAction(this.components);
            // 
            // singleChoiceActionAssociateSubjectArea
            // 
            this.singleChoiceActionAssociateSubjectArea.Caption = "Associate Subject Area";
            this.singleChoiceActionAssociateSubjectArea.ConfirmationMessage = null;
            this.singleChoiceActionAssociateSubjectArea.Id = "AssociateSubjectArea";
            this.singleChoiceActionAssociateSubjectArea.ToolTip = null;
            this.singleChoiceActionAssociateSubjectArea.Execute += new DevExpress.ExpressApp.Actions.SingleChoiceActionExecuteEventHandler(this.singleChoiceActionAssociateSubjectArea_Execute);
            // 
            // ViewController_Entity_ListView
            // 
            this.Actions.Add(this.singleChoiceActionAssociateSubjectArea);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SingleChoiceAction singleChoiceActionAssociateSubjectArea;
    }
}
