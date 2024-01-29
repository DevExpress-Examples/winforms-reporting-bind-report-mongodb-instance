<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T997274)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
Files to look at:

* [Form1.cs](./CS/Form1.cs) ([Form1.vb](./VB/Form1.vb))

# Bind a Report to a MongoDB Instance

You should create and set up a [MongoDBDataSource](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.MongoDB.MongoDBDataSource?v=21.1) object to bind a report to a MongoDB instance in code. 

* Specify connection parameters to connect to a MongoDB instance. You can create a [MongoDBConnectionParameters](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.ConnectionParameters.MongoDBConnectionParameters?v=21.1)
class instance and specify connection parameters individually, such as a hostname and port. If you want to use a [connection string](https://www.mongodb.com/docs/manual/reference/connection-string/), you can create a [MongoDBCustomConnectionParameters](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.ConnectionParameters.MongoDBCustomConnectionParameters?v=21.1) object
and assign this string to the object's [ConnectionString](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.ConnectionParameters.MongoDBCustomConnectionParameters.ConnectionString?v=21.1) property.
Assign the created connection parameters to the MongoDB data source's [ConnectionParameter](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.MongoDB.MongoDBDataSourceBase.ConnectionParameters?v=21.1) property.

* Create queries to retrieve data from database collections of a MongoDB instance. An object of a [MongoDBQuery](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.MongoDB.MongoDBQuery?v=21.1) class corresponds to one query. Set
the query's [DatabaseName](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.MongoDB.MongoDBQuery.DatabaseName?v=21.1) and [CollectionName](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.MongoDB.MongoDBQuery.CollectionName?v=21.1)
properties to the name of a database and collection from which you want to load data. You can also filter the collection's items. For this, assign a filter condition to the query's [FilterString](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.MongoDB.MongoDBQuery.FilterString?v=21.1) property.
Add the created queries to the MongoDB data source's [Queries](https://docs.devexpress.com/CoreLibraries/DevExpress.DataAccess.MongoDB.MongoDBDataSourceBase.Queries?v=21.1) collection.

---
**NOTE**

This example [uses](./CS/Form1.cs#L19) the following connection string to connect to a MongoDB instance: `mongodb://localhost:27017`. The example also [specifies](./CS/Form1.cs#L22) queries to load data from the collections of the *Northwind* database. Before you run this example, specify a connection string and data queries to a configured MongoDB instance.

---

# See also

[Bind Reports to Data: MongoDB Instance](https://docs.devexpress.com/XtraReports/403044/detailed-guide-to-devexpress-reporting/bind-reports-to-data/mongodb-instance?v=21.1)
