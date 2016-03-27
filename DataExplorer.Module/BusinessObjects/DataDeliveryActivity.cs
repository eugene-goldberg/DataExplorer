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
    public class DataDeliveryActivity : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public DataDeliveryActivity(Session session)
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

        private DateTime dateRecorded;

        public DateTime DateRecorded
        {
            get { return dateRecorded; }
            set
            {
                DateTime oldValue = DateRecorded;
                if (oldValue == value) return;
                dateRecorded = value;
                OnChanged("DateRecorded", oldValue, value);
            }
        }

        private string dataDescription;
        [Size(SizeAttribute.Unlimited)]
        public string DataDescription
        {
            get { return dataDescription; }
            set
            {
                string oldValue = DataDescription;
                if (oldValue == value) return;
                dataDescription = value;
                OnChanged("DataDescription", oldValue, value);
            }
        }
        

        private ActivityType activity;
   
        public ActivityType Activity
        {
            get { return activity; }
            set
            {
                ActivityType oldValue = Activity;
                if (oldValue == value) return;
                activity = value;
                OnChanged("Activity", oldValue, value);
            }
        }

        private string dataSource;
        [Size(SizeAttribute.Unlimited)]
        public string DataSource
        {
            get { return dataSource; }
            set
            {
                string oldValue = DataSource;
                if (oldValue == value) return;
                dataSource = value;
                OnChanged("DataSource", oldValue, value);
            }
        }

        private SourceFormat sourceDataFormat;
        [Size(SizeAttribute.Unlimited)]
        public SourceFormat SourceDataFormat
        {
            get { return sourceDataFormat; }
            set
            {
                SourceFormat oldValue = SourceDataFormat;
                if (oldValue == value) return;
                sourceDataFormat = value;
                OnChanged("SourceDataFormat", oldValue, value);
            }
        }

        private TargetFormat targetDataFormat;
        [Size(SizeAttribute.Unlimited)]
        public TargetFormat TargetDataFormat
        {
            get { return targetDataFormat; }
            set
            {
                TargetFormat oldValue = TargetDataFormat;
                if (oldValue == value) return;
                targetDataFormat = value;
                OnChanged("TargetDataFormat", oldValue, value);
            }
        }

        private string targetName;
        [Size(SizeAttribute.Unlimited)]
        public string TargetName
        {
            get { return targetName; }
            set
            {
                string oldValue = TargetName;
                if (oldValue == value) return;
                targetName = value;
                OnChanged("TargetName", oldValue, value);
            }
        }
        
        

        private string personPerformingActivity;
        [Size(SizeAttribute.Unlimited)]
        public string PersonPerformingActivity
        {
            get { return personPerformingActivity; }
            set
            {
                string oldValue = PersonPerformingActivity;
                if (oldValue == value) return;
                personPerformingActivity = value;
                OnChanged("PersonPerformingActivity", oldValue, value);
            }
        }

        private DateTime activityStartDate;

        public DateTime ActivityStartDate
        {
            get { return activityStartDate; }
            set
            {
                DateTime oldValue = ActivityStartDate;
                if (oldValue == value) return;
                activityStartDate = value;
                OnChanged("ActivityStartDate", oldValue, value);
            }
        }

        private DateTime activityEndDate;

        public DateTime ActivityEndDate
        {
            get { return activityEndDate; }
            set
            {
                DateTime oldValue = ActivityEndDate;
                if (oldValue == value) return;
                activityEndDate = value;
                OnChanged("ActivityEndDate", oldValue, value);
            }
        }

        private ActivityStatus currentStatus;
        [Size(SizeAttribute.Unlimited)]
        public ActivityStatus CurrentStatus
        {
            get { return currentStatus; }
            set
            {
                ActivityStatus oldValue = CurrentStatus;
                if (oldValue == value) return;
                currentStatus = value;
                OnChanged("CurrentStatus", oldValue, value);
            }
        }

        private int numberOfRecordsLoaded;

        public int NumberOfRecordsLoaded
        {
            get { return numberOfRecordsLoaded; }
            set
            {
                int oldValue = NumberOfRecordsLoaded;
                if (oldValue == value) return;
                numberOfRecordsLoaded = value;
                OnChanged("NumberOfRecordsLoaded", oldValue, value);
            }
        }

        private int totalNumberOfRecordsInTheTarget;

        public int TotalNumberOfRecordsInTheTarget
        {
            get { return totalNumberOfRecordsInTheTarget; }
            set
            {
                int oldValue = TotalNumberOfRecordsInTheTarget;
                if (oldValue == value) return;
                totalNumberOfRecordsInTheTarget = value;
                OnChanged("TotalNumberOfRecordsInTheTarget", oldValue, value);
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

       public enum ActivityType
        {
            ManualExtractFromDataSource,
            AutomatedExtractFromDataSource,
            DataLoadIntoEngageSecure,
            DataLoadIntoOdmDatabase,
            DataLoadIntoOdmFileSystem
        };

        public enum ActivityStatus
        {
            AwaitingOdmLoad,
            AwaitingVdiShareLoad,
            AwaitingEngageLoad,
            InProgressOdmLoad,
            InProgressVdiShareLoad,
            InProgressEnageLoad,
            FinishedEngageLoad,
            FinishedOdmLoad,
            FinishedVdiShareLoad
        };

        public enum SourceFormat
        {
            FlatFile,
            FullDatabaseDump,
            DatabaseExport
        };

        public enum TargetFormat
        {
            FlatFile,
            NewSqlDatabase,
            ExistingSqlDatabase
        };
        
    }
}
