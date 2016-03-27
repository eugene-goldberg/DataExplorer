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

        [Association("SubjectAreaBusinessQuestion", typeof(BusinessQuestion))]
        public XPCollection<BusinessQuestion> RelatedBusinessQuestions
        { get { return GetCollection<BusinessQuestion>("RelatedBusinessQuestions"); } }

        [Association("BusinessFunctionSubjectArea", typeof(BusinessFunction))]
        public XPCollection<BusinessFunction> AssociatedBusinessFunctions
        { get { return GetCollection<BusinessFunction>("AssociatedBusinessFunctions"); } }

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
        
        
    }
}
