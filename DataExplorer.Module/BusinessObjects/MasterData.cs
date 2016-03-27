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
    public class MasterData : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public MasterData(Session session)
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

        [Association("MasterDataEntity", typeof(Entity))]
        public XPCollection<Entity> AssociatedEntities
        { get { return GetCollection<Entity>("AssociatedEntities"); } }

        [Association("MasterDataDataTable", typeof(DataTable))]
        public XPCollection<DataTable> AssociatedDataTables
        { get { return GetCollection<DataTable>("AssociatedDataTables"); } }

        [Association("MasterDataDataSource", typeof(DataSource))]
        public XPCollection<DataSource> AssociatedDataSources
        { get { return GetCollection<DataSource>("AssociatedDataSources"); } }

        [Association("MasterDataGambiTool", typeof(GambiTool))]
        public XPCollection<GambiTool> AssociatedGambiTools
        { get { return GetCollection<GambiTool>("AssociatedGambiTools"); } }

        private string masterDataEntityName;
        [Size(SizeAttribute.Unlimited)]
        public string MasterDataEntityName
        {
            get { return masterDataEntityName; }
            set
            {
                string oldValue = MasterDataEntityName;
                if (oldValue == value) return;
                masterDataEntityName = value;
                OnChanged("MasterDataEntityName", oldValue, value);
            }
        }

        private string masterDataElementName;
        [Size(SizeAttribute.Unlimited)]
        public string MasterDataElementName
        {
            get { return masterDataElementName; }
            set
            {
                string oldValue = MasterDataElementName;
                if (oldValue == value) return;
                masterDataElementName = value;
                OnChanged("MasterDataElementName", oldValue, value);
            }
        }

        private string masterDataAuthoritativeSystemName;
        [Size(SizeAttribute.Unlimited)]
        public string MasterDataAuthoritativeSystemName
        {
            get { return masterDataAuthoritativeSystemName; }
            set
            {
                string oldValue = MasterDataAuthoritativeSystemName;
                if (oldValue == value) return;
                masterDataAuthoritativeSystemName = value;
                OnChanged("MasterDataAuthoritativeSystemName", oldValue, value);
            }
        }

        private string masterDataLink;
        [Size(SizeAttribute.Unlimited)]
        public string MasterDataLink
        {
            get { return masterDataLink; }
            set
            {
                string oldValue = MasterDataLink;
                if (oldValue == value) return;
                masterDataLink = value;
                OnChanged("MasterDataLink", oldValue, value);
            }
        }


    }
}
