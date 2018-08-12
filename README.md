# LINQ-Language-Intergrated-Query
LINQ is a Micro ORM used to query different data types, Microsoft SQl Server, Arrays of data, and XML documents.

LINQ's benefits a developer alot because it enables me to work with different data sources using a similar coding style, without having the need to know the syntax specific to the data source. 

Also LINQ has good intellisense and compile time error checking. 

Why use LINQ?

My ASP.Net App can connect to the three below:

1. ADO.Net SQL, uses Databases.
2. XPATH XSLT, uses XML documents.
3. Arrays Generics, uses In Memory Objects.


//----------------------------------------------
//Use this class to do your LINQ expressions on:

		public DataClasses1DataContext() : 

				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["CRUDDBConnectionString"].ConnectionString, mappingSource)
//----------------------------------------------
