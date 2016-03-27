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
    public class Account : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Account(Session session)
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

        [Association("DataSourceAccount", typeof(DataSource))]
        public XPCollection<DataSource> DataSourcesWhichSupportThisAccount
        { get { return GetCollection<DataSource>("DataSourcesWhichSupportThisAccount"); } }


        private string accountName;
        [Size(SizeAttribute.Unlimited)]
        public string AccountName
        {
            get { return accountName; }
            set
            {
                string oldValue = AccountName;
                if (oldValue == value) return;
                accountName = value;
                OnChanged("AccountName", oldValue, value);
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
