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
    public class Employee : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public Employee(Session session)
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

        [Association("EntityOwner", typeof(Entity))]
        public XPCollection<Entity> OwnedEntities
        { get { return GetCollection<Entity>("OwnedEntities"); } }

        private string firstName;
        [Size(SizeAttribute.Unlimited)]
        public string FirstName
        {
            get { return firstName; }
            set
            {
                string oldValue = FirstName;
                if (oldValue == value) return;
                firstName = value;
                OnChanged("FirstName", oldValue, value);
            }
        }

        private string middleInitial;
        [Size(SizeAttribute.Unlimited)]
        public string MiddleInitial
        {
            get { return middleInitial; }
            set
            {
                string oldValue = MiddleInitial;
                if (oldValue == value) return;
                middleInitial = value;
                OnChanged("MiddleInitial", oldValue, value);
            }
        }

        private string lastName;
        [Size(SizeAttribute.Unlimited)]
        public string LastName
        {
            get { return lastName; }
            set
            {
                string oldValue = LastName;
                if (oldValue == value) return;
                lastName = value;
                OnChanged("LastName", oldValue, value);
            }
        }

        private string email;
        [Size(SizeAttribute.Unlimited)]
        public string Email
        {
            get { return email; }
            set
            {
                string oldValue = Email;
                if (oldValue == value) return;
                email = value;
                OnChanged("Email", oldValue, value);
            }
        }

        private string phoneNumber;
        [Size(SizeAttribute.Unlimited)]
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                string oldValue = PhoneNumber;
                if (oldValue == value) return;
                phoneNumber = value;
                OnChanged("PhoneNumber", oldValue, value);
            }
        }

        private string functionalRole;
        [Size(SizeAttribute.Unlimited)]
        public string FunctionalRole
        {
            get { return functionalRole; }
            set
            {
                string oldValue = FunctionalRole;
                if (oldValue == value) return;
                functionalRole = value;
                OnChanged("FunctionalRole", oldValue, value);
            }
        }
        
        
        
        
    }
}
