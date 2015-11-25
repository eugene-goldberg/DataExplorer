using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace DataExplorer.Module.BusinessObjects
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112701.aspx).
    public class SubjectArea : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public SubjectArea(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //private string _PersistentProperty;
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty {
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue("PersistentProperty", ref _PersistentProperty, value); }
        //}

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}

        [Association("EntitySubjectArea", typeof(Entity))]
        public XPCollection<Entity> SubjectAreaEntities
        { get { return GetCollection<Entity>("SubjectAreaEntities"); } }

        [Association("SubjectAreaInformationComponent", typeof(InformationComponent))]
        public XPCollection<InformationComponent> SubjectAreaInformationComponents
        { get { return GetCollection<InformationComponent>("SubjectAreaInformationComponents"); } }

        [Association("BusinessInitiativeSubjectArea", typeof(BusinessInitiative))]
        public XPCollection<BusinessInitiative> SubjectAreaBusinessInitiatives
        { get { return GetCollection<BusinessInitiative>("SubjectAreaBusinessInitiatives"); } }

        [Association("GovernanceSubjectArea", typeof(Governance))]
        public XPCollection<Governance> GovernedBy
        { get { return GetCollection<Governance>("GovernedBy"); } }

        private string name;
        [Size(SizeAttribute.Unlimited)]
        public string Name
        {
            get { return name; }
            set
            {
                string oldValue = Name;
                if (oldValue == value) return;
                name = value;
                OnChanged("Name", oldValue, value);
            }
        }

        private string purpose;
        [Size(SizeAttribute.Unlimited)]
        public string Purpose
        {
            get { return purpose; }
            set
            {
                string oldValue = Purpose;
                if (oldValue == value) return;
                purpose = value;
                OnChanged("Purpose", oldValue, value);
            }
        }
        
        
    }
}
