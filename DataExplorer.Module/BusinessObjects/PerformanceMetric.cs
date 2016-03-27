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
    public class PerformanceMetric : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public PerformanceMetric(Session session)
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

        [Association("BusinessInitiativePerformanceMetrics", typeof(BusinessInitiative))]
        public XPCollection<BusinessInitiative> PerformanceMetricBusinessInitiatives
        { get { return GetCollection<BusinessInitiative>("PerformanceMetricBusinessInitiatives"); } }

        [Association("BusinessGoalPerformanceMetrics", typeof(BusinessGoal))]
        public XPCollection<BusinessGoal> PerformanceMetricsBusinessGoal
        { get { return GetCollection<BusinessGoal>("PerformanceMetricsBusinessGoal"); } }

        [Association("PerformanceMetricsDataDiscoveryMethod", typeof(DataDiscoveryMethod))]
        public XPCollection<DataDiscoveryMethod> PerformanceMetricsDataDiscoveryMethods
        { get { return GetCollection<DataDiscoveryMethod>("PerformanceMetricsDataDiscoveryMethods"); } }

        [Association("PerformanceMetricsTrackingMethod", typeof(PerformanceMetricTrackingMethod))]
        public XPCollection<PerformanceMetricTrackingMethod> PerformanceMetricsTrackingMethods
        { get { return GetCollection<PerformanceMetricTrackingMethod>("PerformanceMetricsTrackingMethods"); } }

        [Association("PerformanceMetricCalculations", typeof(MetricCalculation))]
        public XPCollection<MetricCalculation> PerformanceMetricCalculations
        { get { return GetCollection<MetricCalculation>("PerformanceMetricCalculations"); } }

        [Association("PerformanceMetricMockup", typeof(MetricMockup))]
        public XPCollection<MetricMockup> MetricMockups
        { get { return GetCollection<MetricMockup>("MetricMockups"); } }

        [Association("BusinessQuestionPerformanceMetric", typeof(BusinessQuestion))]
        public XPCollection<BusinessQuestion> RelatedBusinessQuestions
        { get { return GetCollection<BusinessQuestion>("RelatedBusinessQuestions"); } }

        [Association("PerformanceMetricAnalyticalMethod", typeof(AnalyticalMethod))]
        public XPCollection<AnalyticalMethod> RelatedAnalythicalMethods
        { get { return GetCollection<AnalyticalMethod>("RelatedAnalythicalMethods"); } }

        private string metricCategory;
        [Size(SizeAttribute.Unlimited)]
        public string MetricCategory
        {
            get { return metricCategory; }
            set
            {
                string oldValue = MetricCategory;
                if (oldValue == value) return;
                metricCategory = value;
                OnChanged("MetricCategory", oldValue, value);
            }
        }
        

        private string metricName;
        [Size(SizeAttribute.Unlimited)]
        public string MetricName
        {
            get { return metricName; }
            set
            {
                string oldValue = MetricName;
                if (oldValue == value) return;
                metricName = value;
                OnChanged("MetricName", oldValue, value);
            }
        }

        private string metricDefinition;
        [Size(SizeAttribute.Unlimited)]
        public string MetricDefinition
        {
            get { return metricDefinition; }
            set
            {
                string oldValue = MetricDefinition;
                if (oldValue == value) return;
                metricDefinition = value;
                OnChanged("MetricDefinition", oldValue, value);
            }
        }

        private string metricPurpose;
        [Size(SizeAttribute.Unlimited)]
        public string MetricPurpose
        {
            get { return metricPurpose; }
            set
            {
                string oldValue = MetricPurpose;
                if (oldValue == value) return;
                metricPurpose = value;
                OnChanged("MetricPurpose", oldValue, value);
            }
        }

        private string actionableDecisions;
        [Size(SizeAttribute.Unlimited)]
        public string ActionableDecisions
        {
            get { return actionableDecisions; }
            set
            {
                string oldValue = ActionableDecisions;
                if (oldValue == value) return;
                actionableDecisions = value;
                OnChanged("ActionableDecisions", oldValue, value);
            }
        }

        private string conditions;
        [Size(SizeAttribute.Unlimited)]
        public string Conditions
        {
            get { return conditions; }
            set
            {
                string oldValue = Conditions;
                if (oldValue == value) return;
                conditions = value;
                OnChanged("Conditions", oldValue, value);
            }
        }

        private string additionalAnalytics;
        [Size(SizeAttribute.Unlimited)]
        public string AdditionalAnalytics
        {
            get { return additionalAnalytics; }
            set
            {
                string oldValue = AdditionalAnalytics;
                if (oldValue == value) return;
                additionalAnalytics = value;
                OnChanged("AdditionalAnalytics", oldValue, value);
            }
        }
        
        
    }
}
