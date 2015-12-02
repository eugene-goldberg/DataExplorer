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
    public class Entity : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Entity(Session session)
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

        [Association("EntityDataDictionaryItem", typeof(DataDictionaryItem))]
        public XPCollection<DataDictionaryItem> DataDictionary
        { get { return GetCollection<DataDictionaryItem>("DataDictionary"); } }

        [Association("EntitySynonim", typeof(Synonim))]
        public XPCollection<Synonim> EntitySynonims
        { get { return GetCollection<Synonim>("EntitySynonims"); } }

        [Association("EntityGambiTool", typeof(GambiTool))]
        public XPCollection<GambiTool> UsedInGambiTools
        { get { return GetCollection<GambiTool>("UsedInGambiTools"); } }

        [Association("EntityAttribute", typeof(Attribute))]
        public XPCollection<Attribute> EntityAttributes
        { get { return GetCollection<Attribute>("EntityAttributes"); } }


        Entity _PrimaryEntity;

        [Association("EntityRelationship")]

        [ModelDefault("EditMask", "(000)-00"), VisibleInDetailView(false)]
        public Entity PrimaryEntity
        {

            get { return _PrimaryEntity; }

            set { SetPropertyValue("PrimaryEntity", ref _PrimaryEntity, value); }

        }



        [Association("EntityRelationship")]

        public XPCollection<Entity> RelatedEntities
        {

            get { return GetCollection<Entity>("RelatedEntities"); }

        }

        [Association("EntityDataSource", typeof(DataSource))]
        public XPCollection<DataSource> EntityDataSources
        { get { return GetCollection<DataSource>("EntityDataSources"); } }


        [Association("EntityOwner", typeof(Employee))]
        public XPCollection<Employee> EntityOwners
        { get { return GetCollection<Employee>("EntityOwners"); } }

        [Association("EntitySubjectArea", typeof(SubjectArea))]
        public XPCollection<SubjectArea> EntitySubjectAreas
        { get { return GetCollection<SubjectArea>("EntitySubjectAreas"); } }

        [Association("InformationComponentEntity", typeof(InformationComponent))]
        public XPCollection<InformationComponent> EntityInformationComponents
        { get { return GetCollection<InformationComponent>("EntityInformationComponents"); } }

       



        private string entityName;
        [Size(SizeAttribute.Unlimited)]
        public string EntityName
        {
            get { return entityName; }
            set
            {
                string oldValue = EntityName;
                if (oldValue == value) return;
                entityName = value;
                OnChanged("EntityName", oldValue, value);
            }
        }

        private string entityDefinition;
        [Size(SizeAttribute.Unlimited)]
        public string EntityDefinition
        {
            get { return entityDefinition; }
            set
            {
                string oldValue = EntityDefinition;
                if (oldValue == value) return;
                entityDefinition = value;
                OnChanged("EntityDefinition", oldValue, value);
            }
        }

        private string correspondingLdeName;
        [Size(SizeAttribute.Unlimited)]
        public string CorrespondingLdeName
        {
            get { return correspondingLdeName; }
            set
            {
                string oldValue = CorrespondingLdeName;
                if (oldValue == value) return;
                correspondingLdeName = value;
                OnChanged("CorrespondingLdeName", oldValue, value);
            }
        }

        private string usage;
        [Size(SizeAttribute.Unlimited)]
        public string Usage
        {
            get { return usage; }
            set
            {
                string oldValue = Usage;
                if (oldValue == value) return;
                usage = value;
                OnChanged("Usage", oldValue, value);
            }
        }

        private string coverage;
        [Size(SizeAttribute.Unlimited)]
        public string Coverage
        {
            get { return coverage; }
            set
            {
                string oldValue = Coverage;
                if (oldValue == value) return;
                coverage = value;
                OnChanged("Coverage", oldValue, value);
            }
        }

        private string informationContext;
        [Size(SizeAttribute.Unlimited)]
        public string InformationContext
        {
            get { return informationContext; }
            set
            {
                string oldValue = InformationContext;
                if (oldValue == value) return;
                informationContext = value;
                OnChanged("InformationContext", oldValue, value);
            }
        }

        private string comments;
        [Size(SizeAttribute.Unlimited)]
        public string Comments
        {
            get { return comments; }
            set
            {
                string oldValue = Comments;
                if (oldValue == value) return;
                comments = value;
                OnChanged("Comments", oldValue, value);
            }
        }

        private string relationshipType;
        [Size(SizeAttribute.Unlimited)]
        public string RelationshipType
        {
            get { return relationshipType; }
            set
            {
                string oldValue = RelationshipType;
                if (oldValue == value) return;
                relationshipType = value;
                OnChanged("RelationshipType", oldValue, value);
            }
        }
        
        
        
        
    }
}
