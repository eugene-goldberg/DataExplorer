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
    public class DataDictionaryItem : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public DataDictionaryItem(Session session)
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

        private Entity entity;
        [Association("EntityDataDictionaryItem")]
        public Entity Entity
        {
            get { return entity; }
            set { SetPropertyValue("Location", ref entity, value); }
        }

        [Association("DataTableDataDictionaryItem", typeof(DataTable))]
        public XPCollection<DataTable> AssociatedDataTables
        { get { return GetCollection<DataTable>("AssociatedDataTables"); } }

        private string attributeName;
        [Size(SizeAttribute.Unlimited)]
        public string AttributeName
        {
            get { return attributeName; }
            set
            {
                string oldValue = AttributeName;
                if (oldValue == value) return;
                attributeName = value;
                OnChanged("AttributeName", oldValue, value);
            }
        }

        private string dataType;
        [Size(SizeAttribute.Unlimited)]
        public string DataType
        {
            get { return dataType; }
            set
            {
                string oldValue = DataType;
                if (oldValue == value) return;
                dataType = value;
                OnChanged("DataType", oldValue, value);
            }
        }

        private string businessMeaning;
        [Size(SizeAttribute.Unlimited)]
        public string BusinessMeaning
        {
            get { return businessMeaning; }
            set
            {
                string oldValue = BusinessMeaning;
                if (oldValue == value) return;
                businessMeaning = value;
                OnChanged("BusinessMeaning", oldValue, value);
            }
        }
        
        
        
    }
}
