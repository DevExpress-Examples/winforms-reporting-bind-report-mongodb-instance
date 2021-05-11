using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.MongoDB;
using DevExpress.XtraReports.UI;

using System;
using System.Windows.Forms;

namespace Bind_a_Report_to_a_MongoDB_Instance {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a MongoDBCustomConnectionParameters object and assign
            // a connection string to a MongoDB instance to the object's
            // ConnectionString property.
            var connectionString = new MongoDBCustomConnectionParameters() {
                ConnectionString = "mongodb://localhost:27017"
            };

            // Specify data queries to the MongoDB instance.
            var queryCategories = new MongoDBQuery() {
                DatabaseName = "Northwind",
                CollectionName = "Categories",
            };

            var queryProducts = new MongoDBQuery() {
                DatabaseName = "Northwind",
                CollectionName = "Products",
            };

            // Create a MongoDBDataSource object. Assign the created connection
            // string to the object's ConnectionParameters property. Add the
            // queries to the object's Queries collection.
            var mongoDBDataSource = new MongoDBDataSource() {
                ConnectionParameters = connectionString,
                Queries = { queryCategories, queryProducts }
            };

            // Create a report. Set the report's DataSource property
            // to the created mongoDBDataSource object.
            var report = new XtraReport() {
                DataSource = mongoDBDataSource,
                DataMember = "Categories"
            };

            // Configure the report layout.
            // ...

            //mongoDBDataSource.RebuildResultSchema();
            report.ShowDesigner();
        }
    }
}
