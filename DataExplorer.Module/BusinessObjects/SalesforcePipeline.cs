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
    public class SalesforcePipeline : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public SalesforcePipeline(Session session)
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


        private string opportunityId;
        [Size(SizeAttribute.Unlimited)]
        public string OpportunityId
        {
            get { return opportunityId; }
            set
            {
                string oldValue = OpportunityId;
                if (oldValue == value) return;
                opportunityId = value;
                OnChanged("OpportunityId", oldValue, value);
            }
        }

        private string look;
        [Size(SizeAttribute.Unlimited)]
        public string Look
        {
            get { return look; }
            set
            {
                string oldValue = Look;
                if (oldValue == value) return;
                look = value;
                OnChanged("Look", oldValue, value);
            }
        }

        private string newStage;
        [Size(SizeAttribute.Unlimited)]
        public string NewStage
        {
            get { return newStage; }
            set
            {
                string oldValue = NewStage;
                if (oldValue == value) return;
                newStage = value;
                OnChanged("NewStage", oldValue, value);
            }
        }
        
        
        private double totalAcv;
         
         public double TotalAcv
                    {
                        get { return totalAcv; }
                        set
                        {
                            double oldValue = TotalAcv;
                            if (oldValue == value) return;
                            totalAcv = value;
                            OnChanged("TotalAcv", oldValue, value);
                        }
                    }

         private string opportunityName;
         [Size(SizeAttribute.Unlimited)]
         public string OpportunityName
         {
             get { return opportunityName; }
             set
             {
                 string oldValue = OpportunityName;
                 if (oldValue == value) return;
                 opportunityName = value;
                 OnChanged("OpportunityName", oldValue, value);
             }
         }

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

         private string opportunityOwner;
         [Size(SizeAttribute.Unlimited)]
         public string OpportunityOwner
         {
             get { return opportunityOwner; }
             set
             {
                 string oldValue = OpportunityOwner;
                 if (oldValue == value) return;
                 opportunityOwner = value;
                 OnChanged("OpportunityOwner", oldValue, value);
             }
         }

         private DateTime decisionDate;

         public DateTime DecisionDate
         {
             get { return decisionDate; }
             set
             {
                 DateTime oldValue = DecisionDate;
                 if (oldValue == value) return;
                 decisionDate = value;
                 OnChanged("DecisionDate", oldValue, value);
             }
         }

         private string stage;
         [Size(SizeAttribute.Unlimited)]
         public string Stage
         {
             get { return stage; }
             set
             {
                 string oldValue = Stage;
                 if (oldValue == value) return;
                 stage = value;
                 OnChanged("Stage", oldValue, value);
             }
         }

         private string industry;
         [Size(SizeAttribute.Unlimited)]
         public string Industry
         {
             get { return industry; }
             set
             {
                 string oldValue = Industry;
                 if (oldValue == value) return;
                 industry = value;
                 OnChanged("Industry", oldValue, value);
             }
         }

         private string cscRegion;
         [Size(SizeAttribute.Unlimited)]
         public string CscRegion
         {
             get { return cscRegion; }
             set
             {
                 string oldValue = CscRegion;
                 if (oldValue == value) return;
                 cscRegion = value;
                 OnChanged("CscRegion", oldValue, value);
             }
         }

         private string dealScope;
         [Size(SizeAttribute.Unlimited)]
         public string DealScope
         {
             get { return dealScope; }
             set
             {
                 string oldValue = DealScope;
                 if (oldValue == value) return;
                 dealScope = value;
                 OnChanged("DealScope", oldValue, value);
             }
         }

         private string accountType;
         [Size(SizeAttribute.Unlimited)]
         public string AccountType
         {
             get { return accountType; }
             set
             {
                 string oldValue = AccountType;
                 if (oldValue == value) return;
                 accountType = value;
                 OnChanged("AccountType", oldValue, value);
             }
         }

         private string opportunityRecordType;
         [Size(SizeAttribute.Unlimited)]
         public string OpportunityRecordType
         {
             get { return opportunityRecordType; }
             set
             {
                 string oldValue = OpportunityRecordType;
                 if (oldValue == value) return;
                 opportunityRecordType = value;
                 OnChanged("OpportunityRecordType", oldValue, value);
             }
         }

         private string scope;
         [Size(SizeAttribute.Unlimited)]
         public string Scope
         {
             get { return scope; }
             set
             {
                 string oldValue = Scope;
                 if (oldValue == value) return;
                 scope = value;
                 OnChanged("Scope", oldValue, value);
             }
         }

         private DateTime revenueStartDate;

         public DateTime RevenueStartDate
         {
             get { return revenueStartDate; }
             set
             {
                 DateTime oldValue = RevenueStartDate;
                 if (oldValue == value) return;
                 revenueStartDate = value;
                 OnChanged("RevenueStartDate", oldValue, value);
             }
         }

         private string revenueTerm;
         [Size(SizeAttribute.Unlimited)]
         public string RevenueTerm
         {
             get { return revenueTerm; }
             set
             {
                 string oldValue = RevenueTerm;
                 if (oldValue == value) return;
                 revenueTerm = value;
                 OnChanged("RevenueTerm", oldValue, value);
             }
         }
        
       
        private double totalContractValueConverted;
         
         public double TotalContractValueConverted
                    {
                        get { return totalContractValueConverted; }
                        set
                        {
                            double oldValue = TotalContractValueConverted;
                            if (oldValue == value) return;
                            totalContractValueConverted = value;
                            OnChanged("TotalContractValueConverted", oldValue, value);
                        }
                    }

         private DateTime closeDate;

         public DateTime CloseDate
         {
             get { return closeDate; }
             set
             {
                 DateTime oldValue = CloseDate;
                 if (oldValue == value) return;
                 closeDate = value;
                 OnChanged("CloseDate", oldValue, value);
             }
         }

         private DateTime proposalSubmissionDate;

         public DateTime ProposalSubmissionDate
         {
             get { return proposalSubmissionDate; }
             set
             {
                 DateTime oldValue = ProposalSubmissionDate;
                 if (oldValue == value) return;
                 proposalSubmissionDate = value;
                 OnChanged("ProposalSubmissionDate", oldValue, value);
             }
         }
        
        
        private double probabilityPercentage;
         
         public double ProbabilityPercentage
                    {
                        get { return probabilityPercentage; }
                        set
                        {
                            double oldValue = ProbabilityPercentage;
                            if (oldValue == value) return;
                            probabilityPercentage = value;
                            OnChanged("ProbabilityPercentage", oldValue, value);
                        }
                    }

         private string fiscalYear;
         [Size(SizeAttribute.Unlimited)]
         public string FiscalYear
         {
             get { return fiscalYear; }
             set
             {
                 string oldValue = FiscalYear;
                 if (oldValue == value) return;
                 fiscalYear = value;
                 OnChanged("FiscalYear", oldValue, value);
             }
         }

         private string fiscalQuerter;
         [Size(SizeAttribute.Unlimited)]
         public string FiscalQuerter
         {
             get { return fiscalQuerter; }
             set
             {
                 string oldValue = FiscalQuerter;
                 if (oldValue == value) return;
                 fiscalQuerter = value;
                 OnChanged("FiscalQuerter", oldValue, value);
             }
         }

         private DateTime opportunityStartDate;

         public DateTime OpportunityStartDate
         {
             get { return opportunityStartDate; }
             set
             {
                 DateTime oldValue = OpportunityStartDate;
                 if (oldValue == value) return;
                 opportunityStartDate = value;
                 OnChanged("OpportunityStartDate", oldValue, value);
             }
         }

         private string strategicGrowthApprovedDeal;
         [Size(SizeAttribute.Unlimited)]
         public string StrategicGrowthApprovedDeal
         {
             get { return strategicGrowthApprovedDeal; }
             set
             {
                 string oldValue = StrategicGrowthApprovedDeal;
                 if (oldValue == value) return;
                 strategicGrowthApprovedDeal = value;
                 OnChanged("StrategicGrowthApprovedDeal", oldValue, value);
             }
         }

         private DateTime dateQualified;

         public DateTime DateQualified
         {
             get { return dateQualified; }
             set
             {
                 DateTime oldValue = DateQualified;
                 if (oldValue == value) return;
                 dateQualified = value;
                 OnChanged("DateQualified", oldValue, value);
             }
         }

         private DateTime downselectedToOneDate;

         public DateTime DownselectedToOneDate
         {
             get { return downselectedToOneDate; }
             set
             {
                 DateTime oldValue = DownselectedToOneDate;
                 if (oldValue == value) return;
                 downselectedToOneDate = value;
                 OnChanged("DownselectedToOneDate", oldValue, value);
             }
         }

         private string opportunityDealComplexity;
         [Size(SizeAttribute.Unlimited)]
         public string OpportunityDealComplexity
         {
             get { return opportunityDealComplexity; }
             set
             {
                 string oldValue = OpportunityDealComplexity;
                 if (oldValue == value) return;
                 opportunityDealComplexity = value;
                 OnChanged("OpportunityDealComplexity", oldValue, value);
             }
         }

         private string nextStepsAndStatus;
         [Size(SizeAttribute.Unlimited)]
         public string NextStepsAndStatus
         {
             get { return nextStepsAndStatus; }
             set
             {
                 string oldValue = NextStepsAndStatus;
                 if (oldValue == value) return;
                 nextStepsAndStatus = value;
                 OnChanged("NextStepsAndStatus", oldValue, value);
             }
         }

       
        private double bigDataTcv;
         
         public double BigDataTcv
                    {
                        get { return bigDataTcv; }
                        set
                        {
                            double oldValue = BigDataTcv;
                            if (oldValue == value) return;
                            bigDataTcv = value;
                            OnChanged("BigDataTcv", oldValue, value);
                        }
                    }

         private double cloudTcv;

         public double CloudTcv
         {
             get { return cloudTcv; }
             set
             {
                 double oldValue = CloudTcv;
                 if (oldValue == value) return;
                 cloudTcv = value;
                 OnChanged("CloudTcv", oldValue, value);
             }
         }

         private double cyberTcv;

         public double CyberTcv
         {
             get { return cyberTcv; }
             set
             {
                 double oldValue = CyberTcv;
                 if (oldValue == value) return;
                 cyberTcv = value;
                 OnChanged("CyberTcv", oldValue, value);
             }
         }

         private double gbsTcv;

         public double GbsTcv
         {
             get { return gbsTcv; }
             set
             {
                 double oldValue = GbsTcv;
                 if (oldValue == value) return;
                 gbsTcv = value;
                 OnChanged("GbsTcv", oldValue, value);
             }
         }

         private double gisTcv;

         public double GisTcv
         {
             get { return gisTcv; }
             set
             {
                 double oldValue = GisTcv;
                 if (oldValue == value) return;
                 gisTcv = value;
                 OnChanged("GisTcv", oldValue, value);
             }
         }

         private double gisAcv;

         public double GisAcv
         {
             get { return gisAcv; }
             set
             {
                 double oldValue = GisAcv;
                 if (oldValue == value) return;
                 gisAcv = value;
                 OnChanged("GisAcv", oldValue, value);
             }
         }

         private double dataCenterTcv;

         public double DataCenterTcv
         {
             get { return dataCenterTcv; }
             set
             {
                 double oldValue = DataCenterTcv;
                 if (oldValue == value) return;
                 dataCenterTcv = value;
                 OnChanged("DataCenterTcv", oldValue, value);
             }
         }

         private double platformTcv;

         public double PlatformTcv
         {
             get { return platformTcv; }
             set
             {
                 double oldValue = PlatformTcv;
                 if (oldValue == value) return;
                 platformTcv = value;
                 OnChanged("PlatformTcv", oldValue, value);
             }
         }

         private double serviceManagementTcv;

         public double ServiceManagementTcv
         {
             get { return serviceManagementTcv; }
             set
             {
                 double oldValue = ServiceManagementTcv;
                 if (oldValue == value) return;
                 serviceManagementTcv = value;
                 OnChanged("ServiceManagementTcv", oldValue, value);
             }
         }

         private double workplaceTcv;

         public double WorkplaceTcv
         {
             get { return workplaceTcv; }
             set
             {
                 double oldValue = WorkplaceTcv;
                 if (oldValue == value) return;
                 workplaceTcv = value;
                 OnChanged("WorkplaceTcv", oldValue, value);
             }
         }

         private int numberOfOfferings;

         public int NumberOfOfferings
         {
             get { return numberOfOfferings; }
             set
             {
                 int oldValue = NumberOfOfferings;
                 if (oldValue == value) return;
                 numberOfOfferings = value;
                 OnChanged("NumberOfOfferings", oldValue, value);
             }
         }

         private string allOfferingNames;
         [Size(SizeAttribute.Unlimited)]
         public string AllOfferingNames
         {
             get { return allOfferingNames; }
             set
             {
                 string oldValue = AllOfferingNames;
                 if (oldValue == value) return;
                 allOfferingNames = value;
                 OnChanged("AllOfferingNames", oldValue, value);
             }
         }
        
        
    }
}
