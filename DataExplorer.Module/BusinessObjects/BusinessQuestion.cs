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
    public class BusinessQuestion : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public BusinessQuestion(Session session)
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

        [Association("SubjectAreaBusinessQuestion", typeof(SubjectArea))]
        public XPCollection<SubjectArea> RelatedSubjectAreas
        { get { return GetCollection<SubjectArea>("RelatedSubjectAreas"); } }

        [Association("BusinessQuestionBusinessGoal", typeof(BusinessGoal))]
        public XPCollection<BusinessGoal> RelatedSubjectGoals
        { get { return GetCollection<BusinessGoal>("RelatedSubjectGoals"); } }

        [Association("BusinessQuestionPerformanceMetric", typeof(PerformanceMetric))]
        public XPCollection<PerformanceMetric> RelatedPerformanceMetrics
        { get { return GetCollection<PerformanceMetric>("RelatedPerformanceMetrics"); } }

        [Association("BusinessFunctionBusinessQuestion", typeof(BusinessFunction))]
        public XPCollection<BusinessFunction> AssociatedBusinessFunctions
        { get { return GetCollection<BusinessFunction>("AssociatedBusinessFunctions"); } }

        private string questionDefinition;
        [Size(SizeAttribute.Unlimited)]
        public string QuestionDefinition
        {
            get { return questionDefinition; }
            set
            {
                string oldValue = QuestionDefinition;
                if (oldValue == value) return;
                questionDefinition = value;
                OnChanged("QuestionDefinition", oldValue, value);
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

        private string relatedSubjectArea;
        [Size(SizeAttribute.Unlimited)]
        public string RelatedSubjectArea
        {
            get { return relatedSubjectArea; }
            set
            {
                string oldValue = RelatedSubjectArea;
                if (oldValue == value) return;
                relatedSubjectArea = value;
                OnChanged("RelatedSubjectArea", oldValue, value);
            }
        }
        
        
        
    }
}
