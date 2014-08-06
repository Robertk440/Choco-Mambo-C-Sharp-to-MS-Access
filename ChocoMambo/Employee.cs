using DBConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocoMambo
{
    class Employee:Person
    {
        #region Class Variables
        long _lngPKID = 0;
        string _strTableName = "tbl_Employee";
        string _strPKName = "ID";
        dbConnection _dbConn = new dbConnection("Database/ChocoMambo.accdb");
        DataSet _dataset = new DataSet();
        DataRow _drwRecord = null;
        #endregion

        #region Constructor
       /// <summary>
       ///Description: onstructor for creating an empty Employee
       /// </summary>
       public Employee()
        {
            loadDataSet();
            employeeDataset = _dataset;
        }
        /// <summary>
        ///Description: Constructor for an existing record
        /// </summary>
        /// <param name="pLongID"></param>
        public Employee(long pLongID)
        {
            _lngPKID = pLongID;
            loadDataSet();
            employeeDataset = _dataset;
            assignFields();
        }
        #endregion

        #region Properties
      

        public string Department { get; set; }

        public long Salary { get; set; }

        public DataSet employeeDataset { get; set; }
        #endregion

        #region Accessors
        /// <summary>
        ///Pre-Condition:An instance of a dataset, a string tableName and long ID.
        ///Post-Condition: Dataset is loaded with data relevant to the query.
        ///Description: Loads a dataset with data relevant  to the query.
        /// </summary>
        private void loadDataSet()
        {
            string strQuery = "SELECT * FROM " + _strTableName;

            if (_lngPKID > 0)
                strQuery += " WHERE " + _strPKName + " = " + _lngPKID;

            _dbConn.fillDataSet(_dataset, strQuery, _strTableName);
        }

        /// <summary>
        ///Pre-Condition:Dataset column names match the column names described
        ///Post-Condition: Properties in this class will be set to the values defined each specified column
        ///Description: assigns properties to dataset cell values.
        /// </summary>
        private void assignFields()
        {
            Name = _dataset.Tables[_strTableName].Rows[0]["EmployeeName"].ToString();
            PhoneNumber = _dataset.Tables[_strTableName].Rows[0]["PhoneNumber"].ToString();
            BuildingNumber = _dataset.Tables[_strTableName].Rows[0]["BuildingNumber"].ToString();
            StreetName = _dataset.Tables[_strTableName].Rows[0]["StreetName"].ToString();
            Suburb = _dataset.Tables[_strTableName].Rows[0]["Suburb"].ToString();
            State = _dataset.Tables[_strTableName].Rows[0]["State"].ToString();
            Postcode = _dataset.Tables[_strTableName].Rows[0]["Postcode"].ToString();
            Department = _dataset.Tables[_strTableName].Rows[0]["Department"].ToString();
            Salary = long.Parse(_dataset.Tables[_strTableName].Rows[0]["Salary"].ToString());
        }

        #endregion

        #region Mutators

        public void saveData()
        {
            if (_lngPKID == 0)
                addNewRecord();
            else
                updateRecord();
            _dbConn.SaveData(_dataset, _strTableName);
        }
        /// <summary>
        /// Pre-Condition: All properties have an assigned value
        /// Post-Condition: a new record is added to the table tbl_Employee
        /// Description:Adds a new record to the table tbl_Employee
        /// </summary>
        private void addNewRecord()
        {
            _drwRecord = _dataset.Tables[_strTableName].NewRow();
            _drwRecord.BeginEdit();
            _drwRecord["EmployeeName"] = Name;
            _drwRecord["PhoneNumber"] = PhoneNumber;
            _drwRecord["BuildingNumber"] = BuildingNumber;
            _drwRecord["StreetName"] = StreetName;
            _drwRecord["Suburb"] = Suburb;
            _drwRecord["State"] = State;
            _drwRecord["Postcode"] = Postcode;
            _drwRecord["Department"] = Department;
            _drwRecord["Salary"] = Salary;
            _drwRecord.EndEdit();
            _dataset.Tables[_strTableName].Rows.Add(_drwRecord);
        }
        /// <summary>
        /// Pre-Condition: All properties have an assigned value
        /// Post-Condition: The current record is updated 
        /// Description:Updates the current record to the table tbl_Employee
        /// </summary>
        private void updateRecord()
        {
            _drwRecord = _dataset.Tables[_strTableName].Rows.Find(_lngPKID);
            _drwRecord.BeginEdit();
            _drwRecord["EmployeeName"] = Name;
            _drwRecord["PhoneNumber"] = PhoneNumber;
            _drwRecord["BuildingNumber"] = BuildingNumber;
            _drwRecord["StreetName"] = StreetName;
            _drwRecord["Suburb"] = Suburb;
            _drwRecord["State"] = State;
            _drwRecord["Postcode"] = Postcode;
            _drwRecord["Department"] = Department;
            _drwRecord["Salary"] = Salary;
            _drwRecord.EndEdit();
        }
        /// <summary>
        /// Description:Sets the private dataset to one passed.
        /// </summary>
        /// <param name="pDataset"></param>
        public void refreshDataSet(DataSet pDataset)
        {
            _dataset = pDataset;
        }
        #endregion
    }
}
