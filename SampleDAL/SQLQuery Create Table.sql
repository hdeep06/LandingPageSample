/****** SQL Query to create 'Subscribers' table in the Database *******/
/**** Run the query to create a table and select appropriate database (Please make sure sleected database is same as in 'SampleDbContext.cs') ****/

CREATE TABLE [dbo].[Subscribers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Subscribers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]



