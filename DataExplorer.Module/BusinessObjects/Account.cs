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


        private string masterAccountName;
        [Size(SizeAttribute.Unlimited)]
        public string MasterAccountName
        {
            get { return masterAccountName; }
            set
            {
                string oldValue = MasterAccountName;
                if (oldValue == value) return;
                masterAccountName = value;
                OnChanged("MasterAccountName", oldValue, value);
            }
        }

        private string sfdcAccountName;
        [Size(SizeAttribute.Unlimited)]
        public string SfdcAccountName
        {
            get { return sfdcAccountName; }
            set
            {
                string oldValue = SfdcAccountName;
                if (oldValue == value) return;
                sfdcAccountName = value;
                OnChanged("SfdcAccountName", oldValue, value);
            }
        }

        private string beaconAccountName;
        [Size(SizeAttribute.Unlimited)]
        public string BeaconAccountName
        {
            get { return beaconAccountName; }
            set
            {
                string oldValue = BeaconAccountName;
                if (oldValue == value) return;
                beaconAccountName = value;
                OnChanged("BeaconAccountName", oldValue, value);
            }
        }

        private string accountStatus;
        [Size(SizeAttribute.Unlimited)]
        public string AccountStatus
        {
            get { return accountStatus; }
            set
            {
                string oldValue = AccountStatus;
                if (oldValue == value) return;
                accountStatus = value;
                OnChanged("AccountStatus", oldValue, value);
            }
        }

        private string region;
        [Size(SizeAttribute.Unlimited)]
        public string Region
        {
            get { return region; }
            set
            {
                string oldValue = Region;
                if (oldValue == value) return;
                region = value;
                OnChanged("Region", oldValue, value);
            }
        }

        private string rdeName;
        [Size(SizeAttribute.Unlimited)]
        public string RdeName
        {
            get { return rdeName; }
            set
            {
                string oldValue = RdeName;
                if (oldValue == value) return;
                rdeName = value;
                OnChanged("RdeName", oldValue, value);
            }
        }

        private string accountAde;
        [Size(SizeAttribute.Unlimited)]
        public string AccountAde
        {
            get { return accountAde; }
            set
            {
                string oldValue = AccountAde;
                if (oldValue == value) return;
                accountAde = value;
                OnChanged("AccountAde", oldValue, value);
            }
        }

        private string applicationEngagementManager;
        [Size(SizeAttribute.Unlimited)]
        public string ApplicationEngagementManager
        {
            get { return applicationEngagementManager; }
            set
            {
                string oldValue = ApplicationEngagementManager;
                if (oldValue == value) return;
                applicationEngagementManager = value;
                OnChanged("ApplicationEngagementManager", oldValue, value);
            }
        }

        private string accountAgm;
        [Size(SizeAttribute.Unlimited)]
        public string AccountAgm
        {
            get { return accountAgm; }
            set
            {
                string oldValue = AccountAgm;
                if (oldValue == value) return;
                accountAgm = value;
                OnChanged("AccountAgm", oldValue, value);
            }
        }

        private string accountCcm;
        [Size(SizeAttribute.Unlimited)]
        public string AccountCcm
        {
            get { return accountCcm; }
            set
            {
                string oldValue = AccountCcm;
                if (oldValue == value) return;
                accountCcm = value;
                OnChanged("AccountCcm", oldValue, value);
            }
        }

        private string accountCountry;
        [Size(SizeAttribute.Unlimited)]
        public string AccountCountry
        {
            get { return accountCountry; }
            set
            {
                string oldValue = AccountCountry;
                if (oldValue == value) return;
                accountCountry = value;
                OnChanged("AccountCountry", oldValue, value);
            }
        }

        private string accountFinance;
        [Size(SizeAttribute.Unlimited)]
        public string AccountFinance
        {
            get { return accountFinance; }
            set
            {
                string oldValue = AccountFinance;
                if (oldValue == value) return;
                accountFinance = value;
                OnChanged("AccountFinance", oldValue, value);
            }
        }

        private string accountIndustry;
        [Size(SizeAttribute.Unlimited)]
        public string AccountIndustry
        {
            get { return accountIndustry; }
            set
            {
                string oldValue = AccountIndustry;
                if (oldValue == value) return;
                accountIndustry = value;
                OnChanged("AccountIndustry", oldValue, value);
            }
        }

        private string projectManager;
        [Size(SizeAttribute.Unlimited)]
        public string ProjectManager
        {
            get { return projectManager; }
            set
            {
                string oldValue = ProjectManager;
                if (oldValue == value) return;
                projectManager = value;
                OnChanged("ProjectManager", oldValue, value);
            }
        }

        private string aghCoach;
        [Size(SizeAttribute.Unlimited)]
        public string AghCoach
        {
            get { return aghCoach; }
            set
            {
                string oldValue = AghCoach;
                if (oldValue == value) return;
                aghCoach = value;
                OnChanged("AghCoach", oldValue, value);
            }
        }

        private string accountTcv;
        [Size(SizeAttribute.Unlimited)]
        public string AccountTcv
        {
            get { return accountTcv; }
            set
            {
                string oldValue = AccountTcv;
                if (oldValue == value) return;
                accountTcv = value;
                OnChanged("AccountTcv", oldValue, value);
            }
        }

        private string adeLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string AdeLnEmail
        {
            get { return adeLnEmail; }
            set
            {
                string oldValue = AdeLnEmail;
                if (oldValue == value) return;
                adeLnEmail = value;
                OnChanged("AdeLnEmail", oldValue, value);
            }
        }

        private string agmLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string AgmLnEmail
        {
            get { return agmLnEmail; }
            set
            {
                string oldValue = AgmLnEmail;
                if (oldValue == value) return;
                agmLnEmail = value;
                OnChanged("AgmLnEmail", oldValue, value);
            }
        }

        private string ahgParticipant;
        [Size(SizeAttribute.Unlimited)]
        public string AhgParticipant
        {
            get { return ahgParticipant; }
            set
            {
                string oldValue = AhgParticipant;
                if (oldValue == value) return;
                ahgParticipant = value;
                OnChanged("AhgParticipant", oldValue, value);
            }
        }


        private string beaconParticipant;
        [Size(SizeAttribute.Unlimited)]
        public string BeaconParticipant
        {
            get { return beaconParticipant; }
            set
            {
                string oldValue = BeaconParticipant;
                if (oldValue == value) return;
                beaconParticipant = value;
                OnChanged("BeaconParticipant", oldValue, value);
            }
        }


        private string capCode;
        [Size(SizeAttribute.Unlimited)]
        public string CapCode
        {
            get { return capCode; }
            set
            {
                string oldValue = CapCode;
                if (oldValue == value) return;
                capCode = value;
                OnChanged("CapCode", oldValue, value);
            }
        }

        private string clientAdvocacyAccount;
        [Size(SizeAttribute.Unlimited)]
        public string ClientAdvocacyAccount
        {
            get { return clientAdvocacyAccount; }
            set
            {
                string oldValue = ClientAdvocacyAccount;
                if (oldValue == value) return;
                clientAdvocacyAccount = value;
                OnChanged("ClientAdvocacyAccount", oldValue, value);
            }
        }

        private string clientPulseAccount;
        [Size(SizeAttribute.Unlimited)]
        public string ClientPulseAccount
        {
            get { return clientPulseAccount; }
            set
            {
                string oldValue = ClientPulseAccount;
                if (oldValue == value) return;
                clientPulseAccount = value;
                OnChanged("ClientPulseAccount", oldValue, value);
            }
        }

        private string contentType;
        [Size(SizeAttribute.Unlimited)]
        public string ContentType
        {
            get { return contentType; }
            set
            {
                string oldValue = ContentType;
                if (oldValue == value) return;
                contentType = value;
                OnChanged("ContentType", oldValue, value);
            }
        }

        private string contractDataFeedComments;
        [Size(SizeAttribute.Unlimited)]
        public string ContractDataFeedComments
        {
            get { return contractDataFeedComments; }
            set
            {
                string oldValue = ContractDataFeedComments;
                if (oldValue == value) return;
                contractDataFeedComments = value;
                OnChanged("ContractDataFeedComments", oldValue, value);
            }
        }


        private DateTime contractExpiryDate;

        public DateTime ContractExpiryDate
        {
            get { return contractExpiryDate; }
            set
            {
                DateTime oldValue = ContractExpiryDate;
                if (oldValue == value) return;
                contractExpiryDate = value;
                OnChanged("ContractExpiryDate", oldValue, value);
            }
        }

        private string contractLexbaseAccountName;
        [Size(SizeAttribute.Unlimited)]
        public string ContractLexbaseAccountName
        {
            get { return contractLexbaseAccountName; }
            set
            {
                string oldValue = ContractLexbaseAccountName;
                if (oldValue == value) return;
                contractLexbaseAccountName = value;
                OnChanged("ContractLexbaseAccountName", oldValue, value);
            }
        }

        private DateTime contractStartDate;

        public DateTime ContractStartDate
        {
            get { return contractStartDate; }
            set
            {
                DateTime oldValue = ContractStartDate;
                if (oldValue == value) return;
                contractStartDate = value;
                OnChanged("ContractStartDate", oldValue, value);
            }
        }

        private string contractTerm;
        [Size(SizeAttribute.Unlimited)]
        public string ContractTerm
        {
            get { return contractTerm; }
            set
            {
                string oldValue = ContractTerm;
                if (oldValue == value) return;
                contractTerm = value;
                OnChanged("ContractTerm", oldValue, value);
            }
        }

        private string emsrtAccountName;
        [Size(SizeAttribute.Unlimited)]
        public string EmsrtAccountName
        {
            get { return emsrtAccountName; }
            set
            {
                string oldValue = EmsrtAccountName;
                if (oldValue == value) return;
                emsrtAccountName = value;
                OnChanged("EmsrtAccountName", oldValue, value);
            }
        }

        private string focusAccountName;
        [Size(SizeAttribute.Unlimited)]
        public string FocusAccountName
        {
            get { return focusAccountName; }
            set
            {
                string oldValue = FocusAccountName;
                if (oldValue == value) return;
                focusAccountName = value;
                OnChanged("FocusAccountName", oldValue, value);
            }
        }

        private string focusAccountParticipant;
        [Size(SizeAttribute.Unlimited)]
        public string FocusAccountParticipant
        {
            get { return focusAccountParticipant; }
            set
            {
                string oldValue = FocusAccountParticipant;
                if (oldValue == value) return;
                focusAccountParticipant = value;
                OnChanged("FocusAccountParticipant", oldValue, value);
            }
        }

        private string gcrlAccountName;
        [Size(SizeAttribute.Unlimited)]
        public string GcrlAccountName
        {
            get { return gcrlAccountName; }
            set
            {
                string oldValue = GcrlAccountName;
                if (oldValue == value) return;
                gcrlAccountName = value;
                OnChanged("GcrlAccountName", oldValue, value);
            }
        }

        private string gcrlDataFeedComments;
        [Size(SizeAttribute.Unlimited)]
        public string GcrlDataFeedComments
        {
            get { return gcrlDataFeedComments; }
            set
            {
                string oldValue = GcrlDataFeedComments;
                if (oldValue == value) return;
                gcrlDataFeedComments = value;
                OnChanged("GcrlDataFeedComments", oldValue, value);
            }
        }

        private string incidentManagementTool;
        [Size(SizeAttribute.Unlimited)]
        public string IncidentManagementTool
        {
            get { return incidentManagementTool; }
            set
            {
                string oldValue = IncidentManagementTool;
                if (oldValue == value) return;
                incidentManagementTool = value;
                OnChanged("IncidentManagementTool", oldValue, value);
            }
        }

        private string leadOffering;
        [Size(SizeAttribute.Unlimited)]
        public string LeadOffering
        {
            get { return leadOffering; }
            set
            {
                string oldValue = LeadOffering;
                if (oldValue == value) return;
                leadOffering = value;
                OnChanged("LeadOffering", oldValue, value);
            }
        }

        private string primaryServiceLevelManagerName;
        [Size(SizeAttribute.Unlimited)]
        public string PrimaryServiceLevelManagerName
        {
            get { return primaryServiceLevelManagerName; }
            set
            {
                string oldValue = PrimaryServiceLevelManagerName;
                if (oldValue == value) return;
                primaryServiceLevelManagerName = value;
                OnChanged("PrimaryServiceLevelManagerName", oldValue, value);
            }
        }

        private string qaLeadName;
        [Size(SizeAttribute.Unlimited)]
        public string QaLeadName
        {
            get { return qaLeadName; }
            set
            {
                string oldValue = QaLeadName;
                if (oldValue == value) return;
                qaLeadName = value;
                OnChanged("QaLeadName", oldValue, value);
            }
        }

        private string qaLeadShortName;
        [Size(SizeAttribute.Unlimited)]
        public string QaLeadShortName
        {
            get { return qaLeadShortName; }
            set
            {
                string oldValue = QaLeadShortName;
                if (oldValue == value) return;
                qaLeadShortName = value;
                OnChanged("QaLeadShortName", oldValue, value);
            }
        }

        private string sapAccountName;
        [Size(SizeAttribute.Unlimited)]
        public string SapAccountName
        {
            get { return sapAccountName; }
            set
            {
                string oldValue = SapAccountName;
                if (oldValue == value) return;
                sapAccountName = value;
                OnChanged("SapAccountName", oldValue, value);
            }
        }

        private string sapDataFeedComments;
        [Size(SizeAttribute.Unlimited)]
        public string SapDataFeedComments
        {
            get { return sapDataFeedComments; }
            set
            {
                string oldValue = SapDataFeedComments;
                if (oldValue == value) return;
                sapDataFeedComments = value;
                OnChanged("SapDataFeedComments", oldValue, value);
            }
        }

        private string ahgCoachLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string AhgCoachLnEmail
        {
            get { return ahgCoachLnEmail; }
            set
            {
                string oldValue = AhgCoachLnEmail;
                if (oldValue == value) return;
                ahgCoachLnEmail = value;
                OnChanged("AhgCoachLnEmail", oldValue, value);
            }
        }

        private string serviceEnhancementProgrammeSepAccount;
        [Size(SizeAttribute.Unlimited)]
        public string ServiceEnhancementProgrammeSepAccount
        {
            get { return serviceEnhancementProgrammeSepAccount; }
            set
            {
                string oldValue = ServiceEnhancementProgrammeSepAccount;
                if (oldValue == value) return;
                serviceEnhancementProgrammeSepAccount = value;
                OnChanged("ServiceEnhancementProgrammeSepAccount", oldValue, value);
            }
        }

        private string servicesDelivered;
        [Size(SizeAttribute.Unlimited)]
        public string ServicesDelivered
        {
            get { return servicesDelivered; }
            set
            {
                string oldValue = ServicesDelivered;
                if (oldValue == value) return;
                servicesDelivered = value;
                OnChanged("ServicesDelivered", oldValue, value);
            }
        }

        private string sfdcDataFeedComments;
        [Size(SizeAttribute.Unlimited)]
        public string SfdcDataFeedComments
        {
            get { return sfdcDataFeedComments; }
            set
            {
                string oldValue = SfdcDataFeedComments;
                if (oldValue == value) return;
                sfdcDataFeedComments = value;
                OnChanged("SfdcDataFeedComments", oldValue, value);
            }
        }

        private string sfdcIdNumber;
        [Size(SizeAttribute.Unlimited)]
        public string SfdcIdNumber
        {
            get { return sfdcIdNumber; }
            set
            {
                string oldValue = SfdcIdNumber;
                if (oldValue == value) return;
                sfdcIdNumber = value;
                OnChanged("SfdcIdNumber", oldValue, value);
            }
        }

        private string vocAccountName;
        [Size(SizeAttribute.Unlimited)]
        public string VocAccountName
        {
            get { return vocAccountName; }
            set
            {
                string oldValue = VocAccountName;
                if (oldValue == value) return;
                vocAccountName = value;
                OnChanged("VocAccountName", oldValue, value);
            }
        }

        private string modified;
        [Size(SizeAttribute.Unlimited)]
        public string Modified
        {
            get { return modified; }
            set
            {
                string oldValue = Modified;
                if (oldValue == value) return;
                modified = value;
                OnChanged("Modified", oldValue, value);
            }
        }

        private string modifiedBy;
        [Size(SizeAttribute.Unlimited)]
        public string ModifiedBy
        {
            get { return modifiedBy; }
            set
            {
                string oldValue = ModifiedBy;
                if (oldValue == value) return;
                modifiedBy = value;
                OnChanged("ModifiedBy", oldValue, value);
            }
        }

        private string changeManagementTool;
        [Size(SizeAttribute.Unlimited)]
        public string ChangeManagementTool
        {
            get { return changeManagementTool; }
            set
            {
                string oldValue = ChangeManagementTool;
                if (oldValue == value) return;
                changeManagementTool = value;
                OnChanged("ChangeManagementTool", oldValue, value);
            }
        }

        private string problemManagementTool;
        [Size(SizeAttribute.Unlimited)]
        public string ProblemManagementTool
        {
            get { return problemManagementTool; }
            set
            {
                string oldValue = ProblemManagementTool;
                if (oldValue == value) return;
                problemManagementTool = value;
                OnChanged("ProblemManagementTool", oldValue, value);
            }
        }

        private string t3Name;
        [Size(SizeAttribute.Unlimited)]
        public string T3Name
        {
            get { return t3Name; }
            set
            {
                string oldValue = T3Name;
                if (oldValue == value) return;
                t3Name = value;
                OnChanged("T3Name", oldValue, value);
            }
        }

        private string ahgAccountName;
        [Size(SizeAttribute.Unlimited)]
        public string AhgAccountName
        {
            get { return ahgAccountName; }
            set
            {
                string oldValue = AhgAccountName;
                if (oldValue == value) return;
                ahgAccountName = value;
                OnChanged("AhgAccountName", oldValue, value);
            }
        }

        private string select50;
        [Size(SizeAttribute.Unlimited)]
        public string Select50
        {
            get { return select50; }
            set
            {
                string oldValue = Select50;
                if (oldValue == value) return;
                select50 = value;
                OnChanged("Select50", oldValue, value);
            }
        }

        private string accountServiceLeadAsl;
        [Size(SizeAttribute.Unlimited)]
        public string AccountServiceLeadAsl
        {
            get { return accountServiceLeadAsl; }
            set
            {
                string oldValue = AccountServiceLeadAsl;
                if (oldValue == value) return;
                accountServiceLeadAsl = value;
                OnChanged("AccountServiceLeadAsl", oldValue, value);
            }
        }

        private string customerOperationsCdm;
        [Size(SizeAttribute.Unlimited)]
        public string CustomerOperationsCdm
        {
            get { return customerOperationsCdm; }
            set
            {
                string oldValue = CustomerOperationsCdm;
                if (oldValue == value) return;
                customerOperationsCdm = value;
                OnChanged("CustomerOperationsCdm", oldValue, value);
            }
        }

        private string enterpriseServiceCdm;
        [Size(SizeAttribute.Unlimited)]
        public string EnterpriseServiceCdm
        {
            get { return enterpriseServiceCdm; }
            set
            {
                string oldValue = EnterpriseServiceCdm;
                if (oldValue == value) return;
                enterpriseServiceCdm = value;
                OnChanged("EnterpriseServiceCdm", oldValue, value);
            }
        }

        private string usefulComments;
        [Size(SizeAttribute.Unlimited)]
        public string UsefulComments
        {
            get { return usefulComments; }
            set
            {
                string oldValue = UsefulComments;
                if (oldValue == value) return;
                usefulComments = value;
                OnChanged("UsefulComments", oldValue, value);
            }
        }

        private string rapidResponse;
        [Size(SizeAttribute.Unlimited)]
        public string RapidResponse
        {
            get { return rapidResponse; }
            set
            {
                string oldValue = RapidResponse;
                if (oldValue == value) return;
                rapidResponse = value;
                OnChanged("RapidResponse", oldValue, value);
            }
        }

        private string americasAccountDeliveryReview;
        [Size(SizeAttribute.Unlimited)]
        public string AmericasAccountDeliveryReview
        {
            get { return americasAccountDeliveryReview; }
            set
            {
                string oldValue = AmericasAccountDeliveryReview;
                if (oldValue == value) return;
                americasAccountDeliveryReview = value;
                OnChanged("AmericasAccountDeliveryReview", oldValue, value);
            }
        }

        private string sapClientGroup;
        [Size(SizeAttribute.Unlimited)]
        public string SapClientGroup
        {
            get { return sapClientGroup; }
            set
            {
                string oldValue = SapClientGroup;
                if (oldValue == value) return;
                sapClientGroup = value;
                OnChanged("SapClientGroup", oldValue, value);
            }
        }

        private string programExecutive;
        [Size(SizeAttribute.Unlimited)]
        public string ProgramExecutive
        {
            get { return programExecutive; }
            set
            {
                string oldValue = ProgramExecutive;
                if (oldValue == value) return;
                programExecutive = value;
                OnChanged("ProgramExecutive", oldValue, value);
            }
        }

        private string industryGm;
        [Size(SizeAttribute.Unlimited)]
        public string IndustryGm
        {
            get { return industryGm; }
            set
            {
                string oldValue = IndustryGm;
                if (oldValue == value) return;
                industryGm = value;
                OnChanged("IndustryGm", oldValue, value);
            }
        }

        private string americasFinancialManagerForAccount;
        [Size(SizeAttribute.Unlimited)]
        public string AmericasFinancialManagerForAccount
        {
            get { return americasFinancialManagerForAccount; }
            set
            {
                string oldValue = AmericasFinancialManagerForAccount;
                if (oldValue == value) return;
                americasFinancialManagerForAccount = value;
                OnChanged("AmericasFinancialManagerForAccount", oldValue, value);
            }
        }

        private string americasContractsManagerForAccount;
        [Size(SizeAttribute.Unlimited)]
        public string AmericasContractsManagerForAccount
        {
            get { return americasContractsManagerForAccount; }
            set
            {
                string oldValue = AmericasContractsManagerForAccount;
                if (oldValue == value) return;
                americasContractsManagerForAccount = value;
                OnChanged("AmericasContractsManagerForAccount", oldValue, value);
            }
        }

        private string cpName;
        [Size(SizeAttribute.Unlimited)]
        public string CpName
        {
            get { return cpName; }
            set
            {
                string oldValue = CpName;
                if (oldValue == value) return;
                cpName = value;
                OnChanged("CpName", oldValue, value);
            }
        }

        private string gbsInsuranceOrganizationOfferingDeliveryLead;
        [Size(SizeAttribute.Unlimited)]
        public string GbsInsuranceOrganizationOfferingDeliveryLead
        {
            get { return gbsInsuranceOrganizationOfferingDeliveryLead; }
            set
            {
                string oldValue = GbsInsuranceOrganizationOfferingDeliveryLead;
                if (oldValue == value) return;
                gbsInsuranceOrganizationOfferingDeliveryLead = value;
                OnChanged("GbsInsuranceOrganizationOfferingDeliveryLead", oldValue, value);
            }
        }

        private string gbsInsuranceOrganizationNearshoreDeliveryExec;
        [Size(SizeAttribute.Unlimited)]
        public string GbsInsuranceOrganizationNearshoreDeliveryExec
        {
            get { return gbsInsuranceOrganizationNearshoreDeliveryExec; }
            set
            {
                string oldValue = GbsInsuranceOrganizationNearshoreDeliveryExec;
                if (oldValue == value) return;
                gbsInsuranceOrganizationNearshoreDeliveryExec = value;
                OnChanged("GbsInsuranceOrganizationNearshoreDeliveryExec", oldValue, value);
            }
        }

        private string gbsInsuranceOrganizationServiceDeliveryExecutive;
        [Size(SizeAttribute.Unlimited)]
        public string GbsInsuranceOrganizationServiceDeliveryExecutive
        {
            get { return gbsInsuranceOrganizationServiceDeliveryExecutive; }
            set
            {
                string oldValue = GbsInsuranceOrganizationServiceDeliveryExecutive;
                if (oldValue == value) return;
                gbsInsuranceOrganizationServiceDeliveryExecutive = value;
                OnChanged("GbsInsuranceOrganizationServiceDeliveryExecutive", oldValue, value);
            }
        }

        private string doesThisAccountUseAido;
        [Size(SizeAttribute.Unlimited)]
        public string DoesThisAccountUseAido
        {
            get { return doesThisAccountUseAido; }
            set
            {
                string oldValue = DoesThisAccountUseAido;
                if (oldValue == value) return;
                doesThisAccountUseAido = value;
                OnChanged("DoesThisAccountUseAido", oldValue, value);
            }
        }

        private DateTime idoGoLiveDate;

        public DateTime IdoGoLiveDate
        {
            get { return idoGoLiveDate; }
            set
            {
                DateTime oldValue = IdoGoLiveDate;
                if (oldValue == value) return;
                idoGoLiveDate = value;
                OnChanged("IdoGoLiveDate", oldValue, value);
            }
        }

        private string offeringExecutive;
        [Size(SizeAttribute.Unlimited)]
        public string OfferingExecutive
        {
            get { return offeringExecutive; }
            set
            {
                string oldValue = OfferingExecutive;
                if (oldValue == value) return;
                offeringExecutive = value;
                OnChanged("OfferingExecutive", oldValue, value);
            }
        }

        private string igmLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string IgmLnEmail
        {
            get { return igmLnEmail; }
            set
            {
                string oldValue = IgmLnEmail;
                if (oldValue == value) return;
                igmLnEmail = value;
                OnChanged("IgmLnEmail", oldValue, value);
            }
        }

        private string primaryDeliveryRegion;
        [Size(SizeAttribute.Unlimited)]
        public string PrimaryDeliveryRegion
        {
            get { return primaryDeliveryRegion; }
            set
            {
                string oldValue = PrimaryDeliveryRegion;
                if (oldValue == value) return;
                primaryDeliveryRegion = value;
                OnChanged("PrimaryDeliveryRegion", oldValue, value);
            }
        }

        private string gisOfferingSalesSpecialist;
        [Size(SizeAttribute.Unlimited)]
        public string GisOfferingSalesSpecialist
        {
            get { return gisOfferingSalesSpecialist; }
            set
            {
                string oldValue = GisOfferingSalesSpecialist;
                if (oldValue == value) return;
                gisOfferingSalesSpecialist = value;
                OnChanged("GisOfferingSalesSpecialist", oldValue, value);
            }
        }

        private string clientRelationshipExecutive;
        [Size(SizeAttribute.Unlimited)]
        public string ClientRelationshipExecutive
        {
            get { return clientRelationshipExecutive; }
            set
            {
                string oldValue = ClientRelationshipExecutive;
                if (oldValue == value) return;
                clientRelationshipExecutive = value;
                OnChanged("ClientRelationshipExecutive", oldValue, value);
            }
        }

        private string gbsOfferingSalesSpecialist;
        [Size(SizeAttribute.Unlimited)]
        public string GbsOfferingSalesSpecialist
        {
            get { return gbsOfferingSalesSpecialist; }
            set
            {
                string oldValue = GbsOfferingSalesSpecialist;
                if (oldValue == value) return;
                gbsOfferingSalesSpecialist = value;
                OnChanged("GbsOfferingSalesSpecialist", oldValue, value);
            }
        }

        private string accountReview;
        [Size(SizeAttribute.Unlimited)]
        public string AccountReview
        {
            get { return accountReview; }
            set
            {
                string oldValue = AccountReview;
                if (oldValue == value) return;
                accountReview = value;
                OnChanged("AccountReview", oldValue, value);
            }
        }

        private string accountFinancialsParentFamily;
        [Size(SizeAttribute.Unlimited)]
        public string AccountFinancialsParentFamily
        {
            get { return accountFinancialsParentFamily; }
            set
            {
                string oldValue = AccountFinancialsParentFamily;
                if (oldValue == value) return;
                accountFinancialsParentFamily = value;
                OnChanged("AccountFinancialsParentFamily", oldValue, value);
            }
        }


        private string acmLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string AcmLnEmail
        {
            get { return acmLnEmail; }
            set
            {
                string oldValue = AcmLnEmail;
                if (oldValue == value) return;
                acmLnEmail = value;
                OnChanged("AcmLnEmail", oldValue, value);
            }
        }

        private string afLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string AfLnEmail
        {
            get { return afLnEmail; }
            set
            {
                string oldValue = AfLnEmail;
                if (oldValue == value) return;
                afLnEmail = value;
                OnChanged("AfLnEmail", oldValue, value);
            }
        }

        private string afmLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string AfmLnEmail
        {
            get { return afmLnEmail; }
            set
            {
                string oldValue = AfmLnEmail;
                if (oldValue == value) return;
                afmLnEmail = value;
                OnChanged("AfmLnEmail", oldValue, value);
            }
        }

        private string ara;
        [Size(SizeAttribute.Unlimited)]
        public string Ara
        {
            get { return ara; }
            set
            {
                string oldValue = Ara;
                if (oldValue == value) return;
                ara = value;
                OnChanged("Ara", oldValue, value);
            }
        }

        private string araLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string AraLnEmail
        {
            get { return araLnEmail; }
            set
            {
                string oldValue = AraLnEmail;
                if (oldValue == value) return;
                araLnEmail = value;
                OnChanged("AraLnEmail", oldValue, value);
            }
        }

        private string aslLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string AslLnEmail
        {
            get { return aslLnEmail; }
            set
            {
                string oldValue = AslLnEmail;
                if (oldValue == value) return;
                aslLnEmail = value;
                OnChanged("AslLnEmail", oldValue, value);
            }
        }

        private string ccmLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string CcmLnEmail
        {
            get { return ccmLnEmail; }
            set
            {
                string oldValue = CcmLnEmail;
                if (oldValue == value) return;
                ccmLnEmail = value;
                OnChanged("CcmLnEmail", oldValue, value);
            }
        }

        private string cocdmLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string CocdmLnEmail
        {
            get { return cocdmLnEmail; }
            set
            {
                string oldValue = CocdmLnEmail;
                if (oldValue == value) return;
                cocdmLnEmail = value;
                OnChanged("CocdmLnEmail", oldValue, value);
            }
        }

        private string contractBaseOptions;
        [Size(SizeAttribute.Unlimited)]
        public string ContractBaseOptions
        {
            get { return contractBaseOptions; }
            set
            {
                string oldValue = ContractBaseOptions;
                if (oldValue == value) return;
                contractBaseOptions = value;
                OnChanged("ContractBaseOptions", oldValue, value);
            }
        }

        private DateTime currentContractYear;

        public DateTime CurrentContractYear
        {
            get { return currentContractYear; }
            set
            {
                DateTime oldValue = CurrentContractYear;
                if (oldValue == value) return;
                currentContractYear = value;
                OnChanged("CurrentContractYear", oldValue, value);
            }
        }

        private string customer;
        [Size(SizeAttribute.Unlimited)]
        public string Customer
        {
            get { return customer; }
            set
            {
                string oldValue = Customer;
                if (oldValue == value) return;
                customer = value;
                OnChanged("Customer", oldValue, value);
            }
        }

        private string escLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string EscLnEmail
        {
            get { return escLnEmail; }
            set
            {
                string oldValue = EscLnEmail;
                if (oldValue == value) return;
                escLnEmail = value;
                OnChanged("EscLnEmail", oldValue, value);
            }
        }

        private string esmartDataFeedComments;
        [Size(SizeAttribute.Unlimited)]
        public string EsmartDataFeedComments
        {
            get { return esmartDataFeedComments; }
            set
            {
                string oldValue = EsmartDataFeedComments;
                if (oldValue == value) return;
                esmartDataFeedComments = value;
                OnChanged("EsmartDataFeedComments", oldValue, value);
            }
        }

        private string gaemLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string GaemLnEmail
        {
            get { return gaemLnEmail; }
            set
            {
                string oldValue = GaemLnEmail;
                if (oldValue == value) return;
                gaemLnEmail = value;
                OnChanged("GaemLnEmail", oldValue, value);
            }
        }

        private string gbosLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string GbosLnEmail
        {
            get { return gbosLnEmail; }
            set
            {
                string oldValue = GbosLnEmail;
                if (oldValue == value) return;
                gbosLnEmail = value;
                OnChanged("GbosLnEmail", oldValue, value);
            }
        }

        private string giosLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string GiosLnEmail
        {
            get { return giosLnEmail; }
            set
            {
                string oldValue = GiosLnEmail;
                if (oldValue == value) return;
                giosLnEmail = value;
                OnChanged("GiosLnEmail", oldValue, value);
            }
        }

        private string gndeLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string GndeLnEmail
        {
            get { return gndeLnEmail; }
            set
            {
                string oldValue = GndeLnEmail;
                if (oldValue == value) return;
                gndeLnEmail = value;
                OnChanged("GndeLnEmail", oldValue, value);
            }
        }

        private string godlLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string GodlLnEmail
        {
            get { return godlLnEmail; }
            set
            {
                string oldValue = GodlLnEmail;
                if (oldValue == value) return;
                godlLnEmail = value;
                OnChanged("GodlLnEmail", oldValue, value);
            }
        }

        private string gsdeLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string GsdeLnEmail
        {
            get { return gsdeLnEmail; }
            set
            {
                string oldValue = GsdeLnEmail;
                if (oldValue == value) return;
                gsdeLnEmail = value;
                OnChanged("GsdeLnEmail", oldValue, value);
            }
        }

        private DateTime idoStabilisationDate;

        public DateTime IdoStabilisationDate
        {
            get { return idoStabilisationDate; }
            set
            {
                DateTime oldValue = IdoStabilisationDate;
                if (oldValue == value) return;
                idoStabilisationDate = value;
                OnChanged("IdoStabilisationDate", oldValue, value);
            }
        }

        private string oeLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string OeLnEmail
        {
            get { return oeLnEmail; }
            set
            {
                string oldValue = OeLnEmail;
                if (oldValue == value) return;
                oeLnEmail = value;
                OnChanged("OeLnEmail", oldValue, value);
            }
        }

        private string paymentTerms;
        [Size(SizeAttribute.Unlimited)]
        public string PaymentTerms
        {
            get { return paymentTerms; }
            set
            {
                string oldValue = PaymentTerms;
                if (oldValue == value) return;
                paymentTerms = value;
                OnChanged("PaymentTerms", oldValue, value);
            }
        }

        private string peLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string PeLnEmail
        {
            get { return peLnEmail; }
            set
            {
                string oldValue = PeLnEmail;
                if (oldValue == value) return;
                peLnEmail = value;
                OnChanged("PeLnEmail", oldValue, value);
            }
        }

        private string pmLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string PmLnEmail
        {
            get { return pmLnEmail; }
            set
            {
                string oldValue = PmLnEmail;
                if (oldValue == value) return;
                pmLnEmail = value;
                OnChanged("PmLnEmail", oldValue, value);
            }
        }

        private string riom;
        [Size(SizeAttribute.Unlimited)]
        public string Riom
        {
            get { return riom; }
            set
            {
                string oldValue = Riom;
                if (oldValue == value) return;
                riom = value;
                OnChanged("Riom", oldValue, value);
            }
        }

        private string sepLeadName;
        [Size(SizeAttribute.Unlimited)]
        public string SepLeadName
        {
            get { return sepLeadName; }
            set
            {
                string oldValue = SepLeadName;
                if (oldValue == value) return;
                sepLeadName = value;
                OnChanged("SepLeadName", oldValue, value);
            }
        }

        private string snowAccountName;
        [Size(SizeAttribute.Unlimited)]
        public string SnowAccountName
        {
            get { return snowAccountName; }
            set
            {
                string oldValue = SnowAccountName;
                if (oldValue == value) return;
                snowAccountName = value;
                OnChanged("SnowAccountName", oldValue, value);
            }
        }

        private string snowDomainName;
        [Size(SizeAttribute.Unlimited)]
        public string SnowDomainName
        {
            get { return snowDomainName; }
            set
            {
                string oldValue = SnowDomainName;
                if (oldValue == value) return;
                snowDomainName = value;
                OnChanged("SnowDomainName", oldValue, value);
            }
        }

        private string tcvAwarded;
        [Size(SizeAttribute.Unlimited)]
        public string TcvAwarded
        {
            get { return tcvAwarded; }
            set
            {
                string oldValue = TcvAwarded;
                if (oldValue == value) return;
                tcvAwarded = value;
                OnChanged("TcvAwarded", oldValue, value);
            }
        }

        private string tcvPotential;
        [Size(SizeAttribute.Unlimited)]
        public string TcvPotential
        {
            get { return tcvPotential; }
            set
            {
                string oldValue = TcvPotential;
                if (oldValue == value) return;
                tcvPotential = value;
                OnChanged("TcvPotential", oldValue, value);
            }
        }


        private string securityRestrictions;
        [Size(SizeAttribute.Unlimited)]
        public string SecurityRestrictions
        {
            get { return securityRestrictions; }
            set
            {
                string oldValue = SecurityRestrictions;
                if (oldValue == value) return;
                securityRestrictions = value;
                OnChanged("SecurityRestrictions", oldValue, value);
            }
        }

        private string rdeLnEmail;
        [Size(SizeAttribute.Unlimited)]
        public string RdeLnEmail
        {
            get { return rdeLnEmail; }
            set
            {
                string oldValue = RdeLnEmail;
                if (oldValue == value) return;
                rdeLnEmail = value;
                OnChanged("RdeLnEmail", oldValue, value);
            }
        }

        private string dataInCscBi;
        [Size(SizeAttribute.Unlimited)]
        public string DataInCscBi
        {
            get { return dataInCscBi; }
            set
            {
                string oldValue = DataInCscBi;
                if (oldValue == value) return;
                dataInCscBi = value;
                OnChanged("DataInCscBi", oldValue, value);
            }
        }

        private string adrDeployment;
        [Size(SizeAttribute.Unlimited)]
        public string AdrDeployment
        {
            get { return adrDeployment; }
            set
            {
                string oldValue = AdrDeployment;
                if (oldValue == value) return;
                adrDeployment = value;
                OnChanged("AdrDeployment", oldValue, value);
            }
        }

        private string cscBiPhase;
        [Size(SizeAttribute.Unlimited)]
        public string CscBiPhase
        {
            get { return cscBiPhase; }
            set
            {
                string oldValue = CscBiPhase;
                if (oldValue == value) return;
                cscBiPhase = value;
                OnChanged("CscBiPhase", oldValue, value);
            }
        }

        private string customerH1;
        [Size(SizeAttribute.Unlimited)]
        public string CustomerH1
        {
            get { return customerH1; }
            set
            {
                string oldValue = CustomerH1;
                if (oldValue == value) return;
                customerH1 = value;
                OnChanged("CustomerH1", oldValue, value);
            }
        }

        private string customerH2;
        [Size(SizeAttribute.Unlimited)]
        public string CustomerH2
        {
            get { return customerH2; }
            set
            {
                string oldValue = CustomerH2;
                if (oldValue == value) return;
                customerH2 = value;
                OnChanged("CustomerH2", oldValue, value);
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
