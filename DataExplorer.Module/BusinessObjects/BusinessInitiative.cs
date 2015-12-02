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
    public class BusinessInitiative : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public BusinessInitiative(Session session)
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

        [Association("BusinessInitiativeSubjectArea", typeof(SubjectArea))]
        public XPCollection<SubjectArea> BusinessInitiativeSubjectAreas
        { get { return GetCollection<SubjectArea>("BusinessInitiativeSubjectAreas"); } }

        [Association("BusinessInitiativeGoal", typeof(BusinessGoal))]
        public XPCollection<BusinessGoal> BusinessInitiativeGoals
        { get { return GetCollection<BusinessGoal>("BusinessInitiativeGoals"); } }

        [Association("BusinessInitiativeEmployee", typeof(Employee))]
        public XPCollection<Employee> BusinessInitiativeOwner
        { get { return GetCollection<Employee>("BusinessInitiativeOwner"); } }

        [Association("BusinessInitiativePerformanceMetrics", typeof(PerformanceMetric))]
        public XPCollection<PerformanceMetric> BusinessInitiativePerformanceMetrics
        { get { return GetCollection<PerformanceMetric>("BusinessInitiativePerformanceMetrics"); } }

        [Association("GovernanceBusinessInitiative", typeof(Governance))]
        public XPCollection<Governance> BusinessInitiativeGovernance
        { get { return GetCollection<Governance>("BusinessInitiativeGovernance"); } }

        [Association("GambiToolBusinessInitiative", typeof(GambiTool))]
        public XPCollection<GambiTool> SupportedByGambiTools
        { get { return GetCollection<GambiTool>("SupportedByGambiTools"); } }

        private string initiativeName;
        [Size(SizeAttribute.Unlimited)]
        public string InitiativeName
        {
            get { return initiativeName; }
            set
            {
                string oldValue = InitiativeName;
                if (oldValue == value) return;
                initiativeName = value;
                OnChanged("InitiativeName", oldValue, value);
            }
        }

        private string description;
        [Size(SizeAttribute.Unlimited)]
        public string Description
        {
            get { return description; }
            set
            {
                string oldValue = Description;
                if (oldValue == value) return;
                description = value;
                OnChanged("Description", oldValue, value);
            }
        }
        

        private DateTime startDate;

        public DateTime StartDate
        {
            get { return startDate; }
            set
            {
                DateTime oldValue = StartDate;
                if (oldValue == value) return;
                startDate = value;
                OnChanged("StartDate", oldValue, value);
            }
        }

        private DateTime endDate;

        public DateTime EndDate
        {
            get { return endDate; }
            set
            {
                DateTime oldValue = EndDate;
                if (oldValue == value) return;
                endDate = value;
                OnChanged("EndDate", oldValue, value);
            }
        }

        private string currentStatus;
        [Size(SizeAttribute.Unlimited)]
        public string CurrentStatus
        {
            get { return currentStatus; }
            set
            {
                string oldValue = CurrentStatus;
                if (oldValue == value) return;
                currentStatus = value;
                OnChanged("CurrentStatus", oldValue, value);
            }
        }
        
        
        
        
    }
}
