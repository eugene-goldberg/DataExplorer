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
    public class DataLoadMap : BaseObject
    {
        public DataLoadMap(Session session)
            : base(session)
        {

        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        [Association("DataLoadMapFieldMapper", typeof(FieldMap))]
        public XPCollection<FieldMap> FieldMaps
        { get { return GetCollection<FieldMap>("FieldMaps"); } }




        private string dataLoadMapName;
        [Size(SizeAttribute.Unlimited)]
        public string DataLoadMapName
        {
            get { return dataLoadMapName; }
            set
            {

                string oldValue = DataLoadMapName;
                if (oldValue == value) return;
                dataLoadMapName = value;
                OnChanged("DataLoadMapName", oldValue, value);
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


        private string fileName;
        [Size(SizeAttribute.Unlimited)]
        public string FileName
        {
            get { return fileName; }
            set
            {

                string oldValue = FileName;
                if (oldValue == value) return;
                fileName = value;
                OnChanged("FileName", oldValue, value);
            }
        }

        private string importFileName;
        [Size(SizeAttribute.Unlimited)]
        public string ImportFileName
        {
            get { return importFileName; }
            set
            {

                string oldValue = ImportFileName;
                if (oldValue == value) return;
                importFileName = value;
                OnChanged("ImportFileName", oldValue, value);
            }
        }

        private FileData inputFile;

        public FileData InputFile
        {
            get { return inputFile; }
            set
            {

                FileData oldValue = InputFile;
                if (oldValue == value) return;
                inputFile = value;
                OnChanged("InputFile", oldValue, value);
            }

        }

        private FileData fieldmapsImportFile;

        public FileData FieldmapsImportFile
        {
            get { return fieldmapsImportFile; }
            set
            {

                FileData oldValue = FieldmapsImportFile;
                if (oldValue == value) return;
                fieldmapsImportFile = value;
                OnChanged("FieldmapsImportFile", oldValue, value);
            }

        }
    }

    [NavigationItem]
    public class FieldMap : XPObject
    {
        public FieldMap(Session s) : base(s) { }

        private int loadOrderOverall;

        public int LoadOrderOverall
        {
            get { return loadOrderOverall; }
            set
            {
                int oldValue = LoadOrderOverall;
                if (oldValue == value) return;
                loadOrderOverall = value;
                OnChanged("LoadOrderOverall", oldValue, value);
            }
        }

        private int loadOrderForThisBO;

        public int LoadOrderForThisBO
        {
            get { return loadOrderForThisBO; }
            set
            {
                int oldValue = LoadOrderForThisBO;
                if (oldValue == value) return;
                loadOrderForThisBO = value;
                OnChanged("LoadOrderForThisBO", oldValue, value);
            }
        }

        private string _ExcelTabName;
        public string ExcelTabName
        {
            get { return _ExcelTabName; }
            set { SetPropertyValue("ExcelTabName", ref _ExcelTabName, value); }
        }

        private string _ExcelColumnName;
        public string ExcelColumnName
        {
            get { return _ExcelColumnName; }
            set { SetPropertyValue("ExcelColumnName", ref _ExcelColumnName, value); }
        }

        private int _ExcelColumnPosition;
        public int ExcelColumnPosition
        {
            get { return _ExcelColumnPosition; }
            set { SetPropertyValue("ExcelColumnPosition", ref _ExcelColumnPosition, value); }
        }

        private Type _BOType;
        [NonPersistent]
        [ImmediatePostData]
        public Type BOType
        {
            get { return _BOType; }
            set
            {
                if (_BOType != value) BOField = null;
                SetPropertyValue("BOType", ref _BOType, value);
            }
        }
        private ObjectFields _BOField;
        [DataSourceCriteria("BOType='@This.BOType'")]
        public ObjectFields BOField { get { return _BOField; } set { SetPropertyValue("BOField", ref _BOField, value); } }

        private FileData inputFile;

        public FileData InputFile
        {
            get { return inputFile; }
            set
            {

                FileData oldValue = InputFile;
                if (oldValue == value) return;
                inputFile = value;
                OnChanged("InputFile", oldValue, value);
            }

        }

        protected override void OnLoaded()
        {
            base.OnLoaded();
            if (BOField != null)
            {
                _BOType = BOField.BOType;
            }
        }

        private DataLoadMap dataLoadMap;
        [Association("DataLoadMapFieldMapper")]
        public DataLoadMap DataLoadMap
        {
            get { return dataLoadMap; }
            set { SetPropertyValue("DataLoadMap", ref dataLoadMap, value); }
        }


    }

    [NavigationItem]
    public class ObjectFields : XPObject
    {
        public ObjectFields(Session s) : base(s) { }

        [Persistent]
        private string BOTypeName;
        public Type BOType
        {
            get { return (BOTypeName == null) ? null : ReflectionHelper.FindType(BOTypeName); }
            set { BOTypeName = (value == null) ? null : value.FullName; OnChanged("BOType"); }
        }



        private string _BOFieldName;
        public string BOFieldName
        {
            get { return _BOFieldName; }
            set { SetPropertyValue("BOFieldName", ref _BOFieldName, value); }
        }


    }
}
