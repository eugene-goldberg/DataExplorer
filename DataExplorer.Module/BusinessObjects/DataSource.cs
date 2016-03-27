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
        public XPCollection<Entity> EntitiesRelyingOnThisDataSource
        { get { return GetCollection<Entity>("EntitiesRelyingOnThisDataSource"); } }

        [Association("DataSourceGambiTool", typeof(GambiTool))]
        public XPCollection<GambiTool> SupportedGambiTools
        { get { return GetCollection<GambiTool>("SupportedGambiTools"); } }

        [Association("DataDeliveryChannelDataSource", typeof(DataDeliveryChannel))]
        public XPCollection<DataDeliveryChannel> DeliveredThroughChannels
        { get { return GetCollection<DataDeliveryChannel>("DeliveredThroughChannels"); } }

        [Association("DataSourceEmployee", typeof(Employee))]
        public XPCollection<Employee> DataSourceOwners
        { get { return GetCollection<Employee>("DataSourceOwners"); } }

        [Association("DataSourceAccount", typeof(Account))]
        public XPCollection<Account> AccountsSupportedByThisDataSource
        { get { return GetCollection<Account>("AccountsSupportedByThisDataSource"); } }

        [Association("DataTableDataSource", typeof(DataTable))]
        public XPCollection<DataTable> AssociatedDataTables
        { get { return GetCollection<DataTable>("AssociatedDataTables"); } }

        [Association("MasterDataDataSource", typeof(MasterData))]
        public XPCollection<MasterData> AssociatedMasterData
        { get { return GetCollection<MasterData>("AssociatedMasterData"); } }




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

        private string dataSourceInstance;
        [Size(SizeAttribute.Unlimited)]
        public string DataSourceInstance
        {
            get { return dataSourceInstance; }
            set
            {
                string oldValue = DataSourceInstance;
                if (oldValue == value) return;
                dataSourceInstance = value;
                OnChanged("DataSourceInstance", oldValue, value);
            }
        }

        private string systemTeam;
        [Size(SizeAttribute.Unlimited)]
        public string SystemTeam
        {
            get { return systemTeam; }
            set
            {
                string oldValue = SystemTeam;
                if (oldValue == value) return;
                systemTeam = value;
                OnChanged("SystemTeam", oldValue, value);
            }
        }

        private string systemOwner;
        [Size(SizeAttribute.Unlimited)]
        public string SystemOwner
        {
            get { return systemOwner; }
            set
            {
                string oldValue = SystemOwner;
                if (oldValue == value) return;
                systemOwner = value;
                OnChanged("SystemOwner", oldValue, value);
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

        private string sourceSystemLocation;
        [Size(SizeAttribute.Unlimited)]
        public string SourceSystemLocation
        {
            get { return sourceSystemLocation; }
            set
            {
                string oldValue = SourceSystemLocation;
                if (oldValue == value) return;
                sourceSystemLocation = value;
                OnChanged("SourceSystemLocation", oldValue, value);
            }
        }

        private string sourceSystemNetworkSegment;
        [Size(SizeAttribute.Unlimited)]
        public string SourceSystemNetworkSegment
        {
            get { return sourceSystemNetworkSegment; }
            set
            {
                string oldValue = SourceSystemNetworkSegment;
                if (oldValue == value) return;
                sourceSystemNetworkSegment = value;
                OnChanged("SourceSystemNetworkSegment", oldValue, value);
            }
        }

        private string sourceSystemOsType;
        [Size(SizeAttribute.Unlimited)]
        public string SourceSystemOsType
        {
            get { return sourceSystemOsType; }
            set
            {
                string oldValue = SourceSystemOsType;
                if (oldValue == value) return;
                sourceSystemOsType = value;
                OnChanged("SourceSystemOsType", oldValue, value);
            }
        }

        private string sourceDatabaseName;
        [Size(SizeAttribute.Unlimited)]
        public string SourceDatabaseName
        {
            get { return sourceDatabaseName; }
            set
            {
                string oldValue = SourceDatabaseName;
                if (oldValue == value) return;
                sourceDatabaseName = value;
                OnChanged("SourceDatabaseName", oldValue, value);
            }
        }

        private string sourceDatabaseType;
        [Size(SizeAttribute.Unlimited)]
        public string SourceDatabaseType
        {
            get { return sourceDatabaseType; }
            set
            {
                string oldValue = SourceDatabaseType;
                if (oldValue == value) return;
                sourceDatabaseType = value;
                OnChanged("SourceDatabaseType", oldValue, value);
            }
        }

        private string sourceDatabaseVersion;
        [Size(SizeAttribute.Unlimited)]
        public string SourceDatabaseVersion
        {
            get { return sourceDatabaseVersion; }
            set
            {
                string oldValue = SourceDatabaseVersion;
                if (oldValue == value) return;
                sourceDatabaseVersion = value;
                OnChanged("SourceDatabaseVersion", oldValue, value);
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
