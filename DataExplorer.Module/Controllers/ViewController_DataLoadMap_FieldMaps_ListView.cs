using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using System.Diagnostics;
using System.IO;
using DataExplorer.Module.BusinessObjects;
using DevExpress.ExpressApp.DC;
using Syncfusion.XlsIO;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Xpo;

namespace DataExplorer.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class ViewController_DataLoadMap_FieldMaps_ListView : ViewController
    {
        public ViewController_DataLoadMap_FieldMaps_ListView()
        {
            InitializeComponent();

            //TargetViewId = "DataLoadMap_DetailView";

            TargetViewId = "DataLoadMap_FieldMaps_ListView";
        }
        protected override void OnActivated()
        {
            base.OnActivated();

            object owner = View.ObjectSpace.Owner;

            //try
            //{
                DetailView detailView = (DetailView)owner;
                dlm = (DataLoadMap)detailView.CurrentObject;
            //}
            //catch (Exception exc) { }
                
            
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        DataLoadMap dlm = null;
        List<FieldMap> fieldMaps;

        FieldMap fm;
        static ITypeInfo targetBoType;
        Type myType;

        private void simpleActionImportFieldMaps_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            string timeStamp = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now);

            string fn = string.Format(dlm.FieldmapsImportFile.FileName);
            string targetFilePath = @"C:\DataExplorer\" + fn;
            Debug.Write("\n\n Target File Path:\t" + targetFilePath);
            dlm.ImportFileName = targetFilePath;
            FileStream myStream = new FileStream(targetFilePath, FileMode.OpenOrCreate);

            dlm.FieldmapsImportFile.SaveToStream(myStream);

            myStream.Close();
            ExcelEngine excelEngine = new ExcelEngine();
            IApplication application = excelEngine.Excel;


            dlm.Session.CommitTransaction();

            IWorkbook workbook = excelEngine.Excel.Workbooks.Open(targetFilePath, ExcelOpenType.Automatic);
            IWorksheet sheet = workbook.Worksheets[0];
            IRange range = sheet.UsedRange;
            int numberOfRows = range.Rows.Length;

            for (int i = 1; i < numberOfRows; i++) //for each excel tab
            {             
                FieldMap fieldMap = ObjectSpace.CreateObject<FieldMap>();

                if (sheet.Rows[i].Cells[0].Value != "")
                {
                    fieldMap.ExcelTabName = sheet.Rows[i].Cells[0].Value;
                }

                if (sheet.Rows[i].Cells[1].Value != "")
                {
                    fieldMap.ExcelColumnName = sheet.Rows[i].Cells[1].Value;
                }
                if (sheet.Rows[i].Cells[2].Value != "")
                {
                    fieldMap.ExcelColumnPosition = Convert.ToInt32(sheet.Rows[i].Cells[2].Value);
                }
                if (sheet.Rows[i].Cells[3].Value != "")
                {
                    fieldMap.BOType = Type.GetType(sheet.Rows[i].Cells[3].Value);
                }

                if (sheet.Rows[i].Cells[4].Value != "")
                {
                    ObjectFields objectFields = ObjectSpace.CreateObject<ObjectFields>();
                    objectFields.BOFieldName = sheet.Rows[i].Cells[4].Value;
                    objectFields.BOType = Type.GetType(sheet.Rows[i].Cells[3].Value);
                    objectFields.Session.CommitTransaction();
                    fieldMap.BOField = objectFields;
                    fieldMap.Session.CommitTransaction();
                }

                fieldMap.DataLoadMap = dlm;
                fieldMap.Session.CommitTransaction();
            }
            View.Refresh();
        }

        private void simpleActionLoadDataUsingSelectedFieldMaps_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            string timeStamp = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now);

            string fn = string.Format(dlm.InputFile.FileName);
            string targetFilePath = @"C:\DataExplorer\" + fn;
            dlm.FileName = targetFilePath;
            FileStream myStream = new FileStream(targetFilePath, FileMode.OpenOrCreate);

            dlm.InputFile.SaveToStream(myStream);

            var Maps = from maps in new XPQuery<FieldMap>(((XPObjectSpace)ObjectSpace).Session) select maps;

            foreach (FieldMap fm in Maps) //Assuming that we have a statis set of doad maps for each data maturity level, 
            //we could be creating BO records inside this loop
            {

            }

            myStream.Close();

            fieldMaps = new List<FieldMap>();
            if (View.SelectedObjects.Count > 0)
            {
                foreach (var currentObject in View.SelectedObjects)
                {
                    fieldMaps.Add((FieldMap)currentObject);
                }

                if (fieldMaps.Count > 0)
                {
                    ExcelEngine excelEngine = new ExcelEngine();
                    IApplication application = excelEngine.Excel;

                    IWorkbook workbook = excelEngine.Excel.Workbooks.Open(dlm.FileName, ExcelOpenType.Automatic);
                    IWorksheet sheet = workbook.Worksheets[0];
                    IRange range = sheet.UsedRange;
                    int numberOfRows = range.Rows.Length;
                    myType = fieldMaps[0].BOType;



                    //if (myType.Name == "Account")
                    //{

                        loadObjects();
                    //}

                    //else if (myType.Name == "Application" && sheet.Name == "Application")
                    //{
                    //    loadObjects();
                    //}
                   

                    //var deviceCollection = ObjectSpace.GetObjects<Device>(CriteriaOperator.Parse("IsNewRecord is null"));

                    //foreach (Device dev in deviceCollection)
                    //{
                    //    dev.IsNewRecord = "Y";
                    //}

                    ObjectSpace.CommitChanges();

                } View.Refresh();
            }
        }

        private void loadObjects()
        {
            ExcelEngine excelEngine = new ExcelEngine();
            IApplication application = excelEngine.Excel;

            IWorkbook workbook = excelEngine.Excel.Workbooks.Open(dlm.FileName, ExcelOpenType.Automatic);
            IWorksheet sheet = workbook.Worksheets[0];
            IRange range = sheet.UsedRange;
            int numberOfRows = range.Rows.Length;
            myType = fieldMaps[0].BOType;

            for (int i = 1; i < numberOfRows; i++) //For each row of the input document
            {
                Debug.Write("\n\n loadObjects()  -  Now Loading Tab Name\t\t" + sheet.Name + "\t\t Row #\t\t" + i);

                Debug.WriteLine("Now loading line " + i);

                object targetObject = ObjectSpace.CreateObject(myType);

                targetBoType = XafTypesInfo.Instance.FindTypeInfo(myType);
                foreach (FieldMap curentFieldMap in fieldMaps)  //Each currentFieldMap has a single mapping between the input document field and the target BO field
                {
                    foreach (var member in targetBoType.OwnMembers)  //for each BO public field
                    {
                        // Debug.Write("\n\n MEMBER NAME:\t\t" + member.Name + "\n");
                        if (member.IsPublic && curentFieldMap.BOField != null && member.Name == curentFieldMap.BOField.BOFieldName)  //If BO field is public and if it's name matches what is in the field map, then we set this fie;d's value to the one of the input cell
                        {
                            if (member.MemberTypeInfo.ToString() == "System.Int32")
                            {
                                if (!string.IsNullOrEmpty(sheet.Rows[i].Cells[curentFieldMap.ExcelColumnPosition].Value) && sheet.Rows[i].Cells[curentFieldMap.ExcelColumnPosition].Value != "NULL")
                                {
                                    object cellvalue = sheet.Rows[i].Cells[curentFieldMap.ExcelColumnPosition].Value;
                                    object value = null;
                                    try
                                    {
                                        value = Convert.ToInt32(cellvalue);
                                    }
                                    catch (Exception ex) { }

                                    if (value != null)
                                    {
                                        member.SetValue(targetObject, (int)Math.Round(Convert.ToDouble(sheet.Rows[i].Cells[curentFieldMap.ExcelColumnPosition].Value)));
                                    }
                                }
                            }

                            if (member.MemberTypeInfo.ToString() == "System.Double")
                            {
                                if (!string.IsNullOrEmpty(sheet.Rows[i].Cells[curentFieldMap.ExcelColumnPosition].Value))
                                {
                                    if (i > 1)
                                    {
                                        object cellvalue = sheet.Rows[i].Cells[curentFieldMap.ExcelColumnPosition].Value;
                                        object value = null;
                                        //try
                                        //{
                                            value = Convert.ToDouble(cellvalue);
                                        //}
                                        //catch (Exception ex) { }
                                        if (value != null)
                                        {
                                            member.SetValue(targetObject, Convert.ToDouble((sheet.Rows[i].Cells[curentFieldMap.ExcelColumnPosition].Value).Trim()));
                                        }
                                    }
                                }
                            }

                            if (member.MemberTypeInfo.ToString() == "System.Decimal")
                            {
                                if (!string.IsNullOrEmpty(sheet.Rows[i].Cells[curentFieldMap.ExcelColumnPosition].Value))
                                {
                                    if (i > 1)
                                    {
                                        object cellvalue = sheet.Rows[i].Cells[curentFieldMap.ExcelColumnPosition].Value;
                                        object value = null;
                                        try
                                        {
                                            value = Convert.ToDecimal(cellvalue);
                                        }
                                        catch (Exception ex) { }
                                        if (value != null)
                                        {
                                            member.SetValue(targetObject, Convert.ToDecimal((sheet.Rows[i].Cells[curentFieldMap.ExcelColumnPosition].Value).Trim()));
                                        }
                                    }
                                }
                            }

                            if (member.MemberTypeInfo.ToString() == "System.String")
                            {
                                if (!string.IsNullOrEmpty(sheet.Rows[i].Cells[curentFieldMap.ExcelColumnPosition].Value))
                                {
                                    member.SetValue(targetObject, sheet.Rows[i].Cells[curentFieldMap.ExcelColumnPosition].Value);
                                }
                            }

                            if (member.MemberTypeInfo.ToString() == "System.DateTime")
                            {
                                if (!string.IsNullOrEmpty(sheet.Rows[i].Cells[curentFieldMap.ExcelColumnPosition].Value))
                                {
                                    try
                                    {
                                        member.SetValue(targetObject, Convert.ToDateTime(sheet.Rows[i].Cells[curentFieldMap.ExcelColumnPosition].Value));
                                    }
                                    catch (Exception exc) { }
                                }
                            }

                            if (member.Name == "IsNewRecord")
                            {
                                member.SetValue(targetObject, "Y");
                            }

                            if (targetBoType == typeof(Account))
                            {
                                ((Account)targetObject).IsNewRecord = "Y";
                                ((Account)targetObject).Save();
                                ((Account)targetObject).Session.CommitTransaction();
                            }
                        
                        }
                    }

                }
                ObjectSpace.CommitChanges();
            }

        }
    }
}
