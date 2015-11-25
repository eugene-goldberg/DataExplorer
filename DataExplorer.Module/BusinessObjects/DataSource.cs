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
    public class DataSource : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public DataSource(Session session)
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

        [Association("EntityDataSource", typeof(Entity))]
        public XPCollection<Entity> DataSourceEntities
        { get { return GetCollection<Entity>("DataSourceEntities"); } }

        [Association("DataDeliveryChannelDataSource", typeof(DataDeliveryChannel))]
        public XPCollection<DataDeliveryChannel> SourceChannel
        { get { return GetCollection<DataDeliveryChannel>("SourceChannel"); } }

        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                int oldValue = Id;
                if (oldValue == value) return;
                id = value;
                OnChanged("Id", oldValue, value);
            }
        }

        private string subjectArea;
        [Size(SizeAttribute.Unlimited)]
        public string SubjectArea
        {
            get { return subjectArea; }
            set
            {
                string oldValue = SubjectArea;
                if (oldValue == value) return;
                subjectArea = value;
                OnChanged("SubjectArea", oldValue, value);
            }
        }

        private string category;
        [Size(SizeAttribute.Unlimited)]
        public string Category
        {
            get { return category; }
            set
            {
                string oldValue = Category;
                if (oldValue == value) return;
                category = value;
                OnChanged("Category", oldValue, value);
            }
        }

        private string sourceSystemName;
        [Size(SizeAttribute.Unlimited)]
        public string SourceSystemName
        {
            get { return sourceSystemName; }
            set
            {
                string oldValue = SourceSystemName;
                if (oldValue == value) return;
                sourceSystemName = value;
                OnChanged("SourceSystemName", oldValue, value);
            }
        }

        private string intVarendedUse;
        [Size(SizeAttribute.Unlimited)]
        public string IntVarendedUse
        {
            get { return intVarendedUse; }
            set
            {
                string oldValue = IntVarendedUse;
                if (oldValue == value) return;
                intVarendedUse = value;
                OnChanged("IntVarendedUse", oldValue, value);
            }
        }

        private string source;
        [Size(SizeAttribute.Unlimited)]
        public string Source
        {
            get { return source; }
            set
            {
                string oldValue = Source;
                if (oldValue == value) return;
                source = value;
                OnChanged("Source", oldValue, value);
            }
        }

        private string accountableDataOwner;
        [Size(SizeAttribute.Unlimited)]
        public string AccountableDataOwner
        {
            get { return accountableDataOwner; }
            set
            {
                string oldValue = AccountableDataOwner;
                if (oldValue == value) return;
                accountableDataOwner = value;
                OnChanged("AccountableDataOwner", oldValue, value);
            }
        }

        private string dataOwner;
        [Size(SizeAttribute.Unlimited)]
        public string DataOwner
        {
            get { return dataOwner; }
            set
            {
                string oldValue = DataOwner;
                if (oldValue == value) return;
                dataOwner = value;
                OnChanged("DataOwner", oldValue, value);
            }
        }

        private string accessPoint;
        [Size(SizeAttribute.Unlimited)]
        public string AccessPoint
        {
            get { return accessPoint; }
            set
            {
                string oldValue = AccessPoint;
                if (oldValue == value) return;
                accessPoint = value;
                OnChanged("AccessPoint", oldValue, value);
            }
        }

        private string toolTechnicalSupport;
        [Size(SizeAttribute.Unlimited)]
        public string ToolTechnicalSupport
        {
            get { return toolTechnicalSupport; }
            set
            {
                string oldValue = ToolTechnicalSupport;
                if (oldValue == value) return;
                toolTechnicalSupport = value;
                OnChanged("ToolTechnicalSupport", oldValue, value);
            }
        }

        private string alternativeSource;
        [Size(SizeAttribute.Unlimited)]
        public string AlternativeSource
        {
            get { return alternativeSource; }
            set
            {
                string oldValue = AlternativeSource;
                if (oldValue == value) return;
                alternativeSource = value;
                OnChanged("AlternativeSource", oldValue, value);
            }
        }

        private string issue;
        [Size(SizeAttribute.Unlimited)]
        public string Issue
        {
            get { return issue; }
            set
            {
                string oldValue = Issue;
                if (oldValue == value) return;
                issue = value;
                OnChanged("Issue", oldValue, value);
            }
        }

        private string action;
        [Size(SizeAttribute.Unlimited)]
        public string Action
        {
            get { return action; }
            set
            {
                string oldValue = Action;
                if (oldValue == value) return;
                action = value;
                OnChanged("Action", oldValue, value);
            }
        }

        private string isNewRecord;
        [Size(SizeAttribute.Unlimited)]
        public string IsNewRecord
        {
            get { return isNewRecord; }
            set
            {
                string oldValue = IsNewRecord;
                if (oldValue == value) return;
                isNewRecord = value;
                OnChanged("IsNewRecord", oldValue, value);
            }
        }
        
    }
}
