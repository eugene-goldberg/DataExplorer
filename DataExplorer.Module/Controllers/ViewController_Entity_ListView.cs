using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DataExplorer.Module.BusinessObjects;
using DevExpress.Xpo;

namespace DataExplorer.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class ViewController_Entity_ListView : ViewController
    {

        XPCollection<SubjectArea> subjectAreaCollection;

        public ViewController_Entity_ListView()
        {
            InitializeComponent();
            TargetViewId = "Entity_ListView";

           
        }
        protected override void OnActivated()
        {
            base.OnActivated();

            subjectAreaCollection = ObjectSpace.CreateObject<XPCollection<SubjectArea>>();
            subjectAreaCollection.Load();

            PopulateSubjectAreaList();
        }

        private void PopulateSubjectAreaList()
        {
            singleChoiceActionAssociateSubjectArea.Items.Clear();
           
            foreach (SubjectArea subjectAreaItem in subjectAreaCollection)
            {
                singleChoiceActionAssociateSubjectArea.Items.Add(new ChoiceActionItem(subjectAreaItem.Name, subjectAreaItem.Name, subjectAreaItem));
            }
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void singleChoiceActionAssociateSubjectArea_Execute(object sender, SingleChoiceActionExecuteEventArgs e)
        {

            string selectedSubjectArea = singleChoiceActionAssociateSubjectArea.SelectedItem.Caption;

            List<Entity> selectedEntities = new List<Entity>();

            List<SubjectArea> subjectAreas = new List<SubjectArea>();

            foreach (Entity entity in View.SelectedObjects)
            {
                selectedEntities.Add(entity);
            }

            foreach (SubjectArea subjectArea in subjectAreaCollection)
            {
                foreach (Entity entity in selectedEntities)
                {
                    if(entity.SubjectArea == subjectArea.Name)
                    {
                        entity.EntitySubjectAreas.Add(subjectArea);
                        subjectArea.SubjectAreaEntities.Add(entity);

                        entity.Session.CommitTransaction();
                        subjectArea.Session.CommitTransaction();
                    }
                }
            }
        }
    }
}
