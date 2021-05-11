Imports DevExpress.DataAccess.ConnectionParameters
Imports DevExpress.DataAccess.MongoDB
Imports DevExpress.XtraReports.UI

Imports System
Imports System.Windows.Forms

Namespace Bind_a_Report_to_a_MongoDB_Instance
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			' Create a MongoDBCustomConnectionParameters object and assign
			' a connection string to a MongoDB instance to the object's
			' ConnectionString property.
			Dim connectionString = New MongoDBCustomConnectionParameters() With {.ConnectionString = "mongodb://localhost:27017"}

			' Specify data queries to the MongoDB instance.
			Dim queryCategories = New MongoDBQuery() With {
				.DatabaseName = "Northwind",
				.CollectionName = "Categories"
			}

			Dim queryProducts = New MongoDBQuery() With {
				.DatabaseName = "Northwind",
				.CollectionName = "Products"
			}

			' Create a MongoDBDataSource object. Assign the created connection
			' string to the object's ConnectionParameters property. Add the
			' queries to the object's Queries collection.
			Dim mongoDBDataSource = New MongoDBDataSource() With {
				.ConnectionParameters = connectionString,
				.Queries = { queryCategories, queryProducts }
			}

			' Create a report. Set the report's DataSource property
			' to the created mongoDBDataSource object.
			Dim report = New XtraReport() With {
				.DataSource = mongoDBDataSource,
				.DataMember = "Categories"
			}

			' Configure the report layout.
			' ...

			'mongoDBDataSource.RebuildResultSchema();
			report.ShowDesigner()
		End Sub
	End Class
End Namespace
