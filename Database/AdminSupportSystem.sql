USE [AdminSupportSystem]
GO
/****** Object:  Table [dbo].[CredentialType]    Script Date: 2020-05-12 9:55:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CredentialType](
	[Id] [int] NOT NULL,
	[Type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CredentialType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 2020-05-12 9:55:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Description] [varchar](max) NOT NULL,
	[InvocationDate] [datetime] NOT NULL,
	[TimeStamp] [timestamp] NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 2020-05-12 9:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Id] [int] NOT NULL,
	[Supervisor] [int] NOT NULL,
	[Department] [int] NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[MiddleInitial] [varchar](1) NULL,
	[DOB] [datetime] NOT NULL,
	[StreetAddress] [nvarchar](max) NOT NULL,
	[City] [varchar](50) NOT NULL,
	[PostalZip] [nvarchar](6) NULL,
	[SIN] [int] NULL,
	[SeniorityDate] [datetime] NOT NULL,
	[JobAssignment] [int] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[WorkPhoneNumber] [nvarchar](16) NOT NULL,
	[CellPhoneNumber] [nvarchar](16) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Status] [int] NOT NULL,
	[TimeStamp] [timestamp] NULL,
	[ProvState] [varchar](2) NULL,
	[Country] [varchar](50) NOT NULL,
	[IsSupervisor] [bit] NOT NULL,
	[EndDate] [datetime] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeStatusType]    Script Date: 2020-05-12 9:55:20 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeStatusType](
	[Id] [int] NOT NULL,
	[Type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_EmployeeStatusType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 2020-05-12 9:55:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[POId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[UnitPrice] [money] NOT NULL,
	[Location] [nvarchar](max) NOT NULL,
	[Justification] [nvarchar](max) NOT NULL,
	[Quantity] [int] NOT NULL,
	[ItemTotal] [money] NOT NULL,
	[ItemStatus] [int] NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ItemStatusType]    Script Date: 2020-05-12 9:55:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemStatusType](
	[Id] [int] NOT NULL,
	[Type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ItemStatusType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 2020-05-12 9:55:21 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Department] [int] NOT NULL,
 CONSTRAINT [PK_Job] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[EmployeeId] [int] NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Credential] [int] NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[POStatusType]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[POStatusType](
	[Id] [int] NOT NULL,
	[Type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_POStatusType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchaseOrder]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchaseOrder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[Supervisor] [int] NOT NULL,
	[CreationDate] [datetime] NOT NULL,
	[ApprovalStatus] [int] NOT NULL,
	[Subtotal] [money] NOT NULL,
	[Tax] [money] NOT NULL,
	[GrandTotal] [money] NOT NULL,
	[ModificationDate] [datetime] NULL,
	[ModificationReason] [nvarchar](max) NULL,
	[TimeStamp] [timestamp] NULL,
	[PoNumber] [varchar](8) NULL,
 CONSTRAINT [PK_PurchaseOrder] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Review]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Review](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[SupervisorId] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Rating] [int] NOT NULL,
	[Comments] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Review] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReviewRatingType]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReviewRatingType](
	[Id] [int] NOT NULL,
	[Type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ReviewRatingType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CredentialType] ([Id], [Type]) VALUES (1, N'HRSup')
INSERT [dbo].[CredentialType] ([Id], [Type]) VALUES (2, N'RegSup')
INSERT [dbo].[CredentialType] ([Id], [Type]) VALUES (3, N'HREmp')
INSERT [dbo].[CredentialType] ([Id], [Type]) VALUES (4, N'RegEmp')
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([Id], [Name], [Description], [InvocationDate]) VALUES (1, N'Executive', N'All executive level assets.', CAST(N'2012-03-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Department] ([Id], [Name], [Description], [InvocationDate]) VALUES (2, N'Production', N'All activities necessary to provide products and services', CAST(N'2012-03-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Department] ([Id], [Name], [Description], [InvocationDate]) VALUES (3, N'Research and Development', N'All activities ncessary to develope new products or processes, as well as improving existing products and processes. ', CAST(N'2012-03-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Department] ([Id], [Name], [Description], [InvocationDate]) VALUES (4, N'Purchasing', N'All activites related to acquiring goods and services. ', CAST(N'2012-03-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Department] ([Id], [Name], [Description], [InvocationDate]) VALUES (5, N'Marketing', N'All activites related to identifying and satisfying customers needs, and testing for price tolerance. ', CAST(N'2012-03-14T00:00:00.000' AS DateTime))
INSERT [dbo].[Department] ([Id], [Name], [Description], [InvocationDate]) VALUES (6, N'Human Resources', N'Activities include recruitment and selection, training and development, employee relations, grievance procedures and disciplinary matters, healthy and safety and redundancy procedures. ', CAST(N'2012-03-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Department] ([Id], [Name], [Description], [InvocationDate]) VALUES (7, N'Accounting and Finance', N'Activities include financial record keeping, preperation of financial documentation, payroll administration financial analysis and tax compliance.', CAST(N'2012-03-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Department] ([Id], [Name], [Description], [InvocationDate]) VALUES (8, N'Legal', N'All activites related to company legal compliance and legal protection.', CAST(N'2012-03-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Department] ([Id], [Name], [Description], [InvocationDate]) VALUES (9, N'Information Technology', N'All activities related to technological asset development and technological asset maintenance. ', CAST(N'2012-03-15T00:00:00.000' AS DateTime))
INSERT [dbo].[Department] ([Id], [Name], [Description], [InvocationDate]) VALUES (10, N'Sales', N'All activites related to client acquisition', CAST(N'2012-03-15T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Department] OFF
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (13874404, 94428947, 6, N'Hopper', N'Grace', N'M', CAST(N'1906-12-09T09:24:03.000' AS DateTime), N'1959 Cobol Lane', N'Moncton', N'E1Z1R1', 774848998, CAST(N'2013-06-11T09:24:03.000' AS DateTime), 28, CAST(N'2013-06-11T09:24:03.000' AS DateTime), N'5067784441', N'5067778145', N'sean.gillis.nbcc@gmail.com', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (14067324, 32492919, 9, N'Gillis', N'Sean', NULL, CAST(N'1982-12-12T12:31:18.000' AS DateTime), N'198 Humphrey Street', N'Moncton', N'E1C1T1', 445787777, CAST(N'2015-05-05T12:31:18.000' AS DateTime), 50, CAST(N'2020-01-01T00:00:00.000' AS DateTime), N'5069991999', N'5069991111', N'seanfwgillis@gmail.com', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (15168688, 32492919, 9, N'Williams', N'Alma', N'A', CAST(N'1974-04-17T00:00:00.000' AS DateTime), N'18 Smythe Street ', N'Fredericton', N'E3B1Z1', 392826590, CAST(N'2012-01-15T00:00:00.000' AS DateTime), 49, CAST(N'2013-04-03T00:00:00.000' AS DateTime), N'5064718900', N'5064718901', N'alma.williams@systemking.ca', 2, N'NB', N'Canada', 1, CAST(N'2020-05-14T12:18:00.000' AS DateTime))
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (17383263, 32492919, 9, N'Crawford', N'Paul', NULL, CAST(N'1989-05-05T00:00:00.000' AS DateTime), N'8 Wilmot Court', N'Fredericton', N'E3B1W1', 112555944, CAST(N'2014-01-15T00:00:00.000' AS DateTime), 44, CAST(N'2017-08-01T00:00:00.000' AS DateTime), N'5069997477', N'5069991122', N'paul.crawford@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (19472219, 49374114, 3, N'Watson', N'Maria', N'C', CAST(N'1960-03-31T00:00:00.000' AS DateTime), N'950 Mountain Road', N'Moncton', N'E1C1H6', 440932622, CAST(N'2012-03-15T00:00:00.000' AS DateTime), 15, CAST(N'2015-08-16T00:00:00.000' AS DateTime), N'5069613616', N'5069614444', N'maria.watson@systemking.ca', 1, N'NB', N'Canada', 1, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (22881826, 49374114, 1, N'Senior', N'Etta', NULL, CAST(N'1994-05-11T00:00:00.000' AS DateTime), N'7704 Hickory Street', N'Moncton', N'E1C5Y5', 118777445, CAST(N'2019-01-30T00:00:00.000' AS DateTime), 6, CAST(N'2019-01-30T00:00:00.000' AS DateTime), N'5066675544', N'5066671122', N'etta.senior@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (23358794, 88681443, 2, N'Barnhill', N'John', N'B', CAST(N'1971-11-17T00:00:00.000' AS DateTime), N'1283 Chemin Saint-Igance', N'Shediac', N'E0A3G0', 154119614, CAST(N'2012-03-15T00:00:00.000' AS DateTime), 8, CAST(N'2012-03-15T00:00:00.000' AS DateTime), N'5063121960', N'5063121961', N'john.barnhill@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (25123231, 32492919, 9, N'Rojas', N'Joe', N'M', CAST(N'1965-04-19T00:00:00.000' AS DateTime), N'1 First Avenue', N'Fredericton', N'E3B2R4', 589601426, CAST(N'2012-01-15T00:00:00.000' AS DateTime), 58, CAST(N'2019-01-15T00:00:00.000' AS DateTime), N'5062596899', N'5062591774', N'joe.rojas@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (27103458, 88681443, 2, N'Whitehouse', N'Elyas', N'Y', CAST(N'1987-02-20T00:00:00.000' AS DateTime), N'45 Lawson Avenue', N'Moncton', N'E1B3R1', 975435561, CAST(N'2016-01-30T00:00:00.000' AS DateTime), 8, CAST(N'2016-01-30T00:00:00.000' AS DateTime), N'5068606578', N'5068304160', N'elyas.whitehouse.@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (28677315, 57726038, 1, N'Carty', N'Nasir', N'W', CAST(N'1990-06-17T00:00:00.000' AS DateTime), N'394 Glen Ridge Street', N'Moncton', N'E1P4R5', 171445656, CAST(N'2015-07-04T00:00:00.000' AS DateTime), 6, CAST(N'2015-07-04T00:00:00.000' AS DateTime), N'5066612244', N'5066614422', N'nasir.carty@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (31720165, 32492919, 9, N'Morrow', N'Jason', N'', CAST(N'1984-06-14T12:35:25.000' AS DateTime), N'774 Twinkle Drive', N'Moncton', N'E1P5T5', 113646778, CAST(N'2020-04-30T12:35:25.067' AS DateTime), 54, CAST(N'2020-04-30T12:35:25.067' AS DateTime), N'5064478787', N'5064478899', N'jason.morrow@systemking.ca', 1, N'NB', N'Canada', 1, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (32492919, 40448160, 9, N'Tuttle', N'Marianne', N'K', CAST(N'1992-02-07T00:00:00.000' AS DateTime), N'1400 Regent Street', N'Fredericton', N'E3B5R5', 156392755, CAST(N'2012-01-15T00:00:00.000' AS DateTime), 58, CAST(N'2019-01-15T00:00:00.000' AS DateTime), N'5064719020', N'5064719000', N'marianne.tuttle@systemking.ca', 1, N'NB', N'Canada', 1, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (32731975, 19472219, 3, N'Wilder', N'Sydney', N'C', CAST(N'1993-04-03T00:00:00.000' AS DateTime), N'4379 Wandering Lane', N'Moncton', N'E1C1H4', 365084417, CAST(N'2017-03-15T00:00:00.000' AS DateTime), 17, CAST(N'2017-03-05T00:00:00.000' AS DateTime), N'5068719172', N'5068719177', N'sydney.wilder@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (33935816, 88681443, 2, N'Pearson', N'Roxie', NULL, CAST(N'1989-07-21T00:00:00.000' AS DateTime), N'822 Coverdale Road', N'Moncton', N'E1B4V5', 350433561, CAST(N'2013-02-15T00:00:00.000' AS DateTime), 13, CAST(N'2013-02-15T00:00:00.000' AS DateTime), N'5062326693', N'5062335778', N'roxie.pearson@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (37877569, 97385687, 7, N'Demoss', N'Amanda', N'J', CAST(N'1990-02-14T00:00:00.000' AS DateTime), N'4449 Prince William Street', N'Saint John', N'E1L4V1', 593964141, CAST(N'2016-01-15T00:00:00.000' AS DateTime), 37, CAST(N'2016-01-15T00:00:00.000' AS DateTime), N'5067212817', N'5067219111', N'amanada.demoss@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (39311377, 88681443, 2, N'Hirst', N'Esha', N'O', CAST(N'1962-10-14T00:00:00.000' AS DateTime), N'60 Power Drive', N'Moncton', N'E1J1X4', 388955858, CAST(N'2012-03-15T00:00:00.000' AS DateTime), 14, CAST(N'2012-03-15T00:00:00.000' AS DateTime), N'5062348467', N'5062357117', N'esha.hirst@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (40448160, 47630486, 1, N'Al-Hassan', N'Mahmood', NULL, CAST(N'1962-04-04T00:00:00.000' AS DateTime), N'461 Machester Avenue', N'Moncton', N'E1C5P5', 771448949, CAST(N'2015-05-09T00:00:00.000' AS DateTime), 5, CAST(N'2018-01-15T00:00:00.000' AS DateTime), N'5067781818', N'5067781919', N'hassan.mahmood@systemking.ca', 1, N'NB', N'Canada', 1, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (41665454, 94428947, 6, N'Lagos', N'Utunbu', NULL, CAST(N'1954-08-22T00:00:00.000' AS DateTime), N'78 Lancewood Lane', N'Moncton', N'E1B1T1', 947787444, CAST(N'2012-03-15T00:00:00.000' AS DateTime), 34, CAST(N'2012-03-15T00:00:00.000' AS DateTime), N'5062127747', N'5062137747', N'utunbu.lagos@systemking.ca', 2, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (41885096, 50144201, 8, N'Wadkins', N'Robert', N'C', CAST(N'1990-06-16T00:00:00.000' AS DateTime), N'814 West Street', N'Saint John', N'E2L5T5', 278080312, CAST(N'2015-08-01T00:00:00.000' AS DateTime), 40, CAST(N'2015-08-01T00:00:00.000' AS DateTime), N'5065126121', N'5065126122', N'robert.wadkins@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (45221402, 88681443, 2, N'Laborde', N'Daniel', NULL, CAST(N'1964-04-18T00:00:00.000' AS DateTime), N'2298 Mountain Road', N'Moncton', N'E1C1H7', 251398277, CAST(N'2012-03-15T00:00:00.000' AS DateTime), 8, CAST(N'2012-03-15T00:00:00.000' AS DateTime), N'5069612874', N'5069612876', N'daniel.laborde@system.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (47630486, 47630486, 1, N'Hurst', N'Lizzie', NULL, CAST(N'1971-05-14T00:00:00.000' AS DateTime), N'8248 Sprint Avenue', N'Moncton', N'E1C2P2', 530778979, CAST(N'2012-03-15T00:00:00.000' AS DateTime), 1, CAST(N'2012-03-15T00:00:00.000' AS DateTime), N'5062568858', N'5062568857', N'lizzie.hurst@systemking.ca', 1, N'NB', N'Canada', 1, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (47789551, 88681443, 2, N'Maguire', N'Samiya', NULL, CAST(N'1986-06-04T00:00:00.000' AS DateTime), N'17 Avondale Dr', N'Moncton', N'E1B1C1', 609231717, CAST(N'2014-01-31T00:00:00.000' AS DateTime), 11, CAST(N'2015-06-14T00:00:00.000' AS DateTime), N'5062139267', N'5062063830', N'samiya.maguire@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (47821745, 90327765, 4, N'Eldridge', N'Shirley', N'J', CAST(N'1974-06-25T00:00:00.000' AS DateTime), N'11 Humphrey Road', N'Moncton', N'E1C6Y6', 634648984, CAST(N'2012-03-15T00:00:00.000' AS DateTime), 18, CAST(N'2013-07-06T00:00:00.000' AS DateTime), N'5069618130', N'5069618111', N'shirley.eldridge@systemking.ca', 1, N'NB', N'Canada', 1, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (49155942, 94428947, 6, N'Brooks', N'Roy', N'V', CAST(N'1977-12-21T00:00:00.000' AS DateTime), N'900 Diamond Court', N'Moncton', N'E1C5R4', 777687591, CAST(N'2017-01-15T00:00:00.000' AS DateTime), 31, CAST(N'2017-01-15T00:00:00.000' AS DateTime), N'5069614391', N'5069711391', N'roy.brooks@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (49346191, 40448160, 9, N'Joshi', N'Sheetal', N'U', CAST(N'1971-12-14T00:00:00.000' AS DateTime), N'97 Chitranjan Street', N'Mumbai', N'', 999999999, CAST(N'2018-01-15T00:00:00.000' AS DateTime), 56, CAST(N'2018-01-15T00:00:00.000' AS DateTime), N'+912267494474', N'+91267494444', N'sheetal.joshi@systemking.ca', 1, NULL, N'India', 1, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (49374114, 47630486, 1, N'Brock', N'Lyle', N'M', CAST(N'1973-05-29T00:00:00.000' AS DateTime), N'852 Beechwood Avenue', N'Moncton', N'E1C3P3', 152445989, CAST(N'2012-03-15T00:00:00.000' AS DateTime), 3, CAST(N'2012-03-15T00:00:00.000' AS DateTime), N'5062291949', N'5062291848', N'lyle.brock@systemking.com', 1, N'NB', N'Canada', 1, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (50023709, 49346191, 9, N'Masunur', N'Aditi', NULL, CAST(N'1982-04-07T00:00:00.000' AS DateTime), N'101 Chhatriwala Building', N'Mumbai', N'', 999999999, CAST(N'2018-01-15T00:00:00.000' AS DateTime), 56, CAST(N'2018-01-15T00:00:00.000' AS DateTime), N'+912267491121', N'+912267491111', N'aditi.masunur@systemking.ca', 1, NULL, N'India', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (50144201, 57726038, 8, N'Colvin', N'Paul', N'U', CAST(N'1962-10-17T00:00:00.000' AS DateTime), N'45 Mana Street', N'Saint John', N'E2L4V1', 619654601, CAST(N'2013-04-03T00:00:00.000' AS DateTime), 39, CAST(N'2013-04-03T00:00:00.000' AS DateTime), N'5067781828', N'5067781844', N'paul.colvin@systemking.ca', 1, N'NB', N'Canada', 1, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (50645952, 32492919, 9, N'Pool', N'Leonard', N'', CAST(N'1989-11-22T12:31:02.000' AS DateTime), N'895 Switch Road', N'Moncton', N'E1C5V5', 545778474, CAST(N'2020-04-30T12:31:02.357' AS DateTime), 50, CAST(N'2020-04-30T12:31:02.357' AS DateTime), N'5064548848', N'5064547744', N'leonard.pool@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (51097682, 88681443, 2, N'Brown', N'Joseph', N'E', CAST(N'1992-07-23T00:00:00.000' AS DateTime), N'86 Chemin Stain-Igance', N'Shediac', N'E0A3G0', 325995900, CAST(N'2014-03-15T00:00:00.000' AS DateTime), 8, CAST(N'2014-03-15T00:00:00.000' AS DateTime), N'5063128581', N'5063128580', N'joseph.brown@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (52671208, 49374114, 5, N'Jordan', N'Diana', N'M', CAST(N'1977-12-26T00:00:00.000' AS DateTime), N'91 Main Street', N'Moncton', N'E1C6E3', 360083604, CAST(N'2012-03-15T00:00:00.000' AS DateTime), 22, CAST(N'2016-01-15T00:00:00.000' AS DateTime), N'5069618347', N'5069618344', N'diana.jordan@systemking.ca', 1, N'NB', N'Canada', 1, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (57726038, 47630486, 1, N'Washington', N'Lylah', NULL, CAST(N'1990-11-11T00:00:00.000' AS DateTime), N'49 Holly Drive', N'Moncton', N'E1C4P4', 119454778, CAST(N'2012-03-15T00:00:00.000' AS DateTime), 4, CAST(N'2017-12-01T00:00:00.000' AS DateTime), N'5069197777', N'5069198888', N'lylah.washington@systemking.ca', 1, N'NB', N'Canada', 1, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (63454690, 47630486, 1, N'Klein', N'Luke', N'M', CAST(N'1978-12-12T00:00:00.000' AS DateTime), N'296 Gates Street', N'Moncton', N'E4F3W2', 533441114, CAST(N'2012-03-15T00:00:00.000' AS DateTime), 6, CAST(N'2012-03-15T00:00:00.000' AS DateTime), N'5062591646', N'5062593344', N'luke.klein@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (65310260, 94428947, 6, N'McCain', N'Alyssa', N'', CAST(N'1979-03-14T12:37:05.000' AS DateTime), N'77474 Jason Road', N'Moncton', N'E1C5Y5', 447878998, CAST(N'2020-04-30T12:37:05.923' AS DateTime), 31, CAST(N'2020-04-30T12:37:05.923' AS DateTime), N'5067789494', N'5067786666', N'alyssa.mccain@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (74224378, 88681443, 2, N'Molloy', N'Sam', N'F', CAST(N'1982-11-12T00:00:00.000' AS DateTime), N'141 Windston Street', N'Moncton', N'E1B1K1', 525509717, CAST(N'2014-01-31T00:00:00.000' AS DateTime), 9, CAST(N'2016-01-15T00:00:00.000' AS DateTime), N'5062036844', N'5062027650', N'sam.malloy@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (76573935, 32492919, 9, N'Frazier', N'Michael', N'C', CAST(N'1985-04-08T00:00:00.000' AS DateTime), N'52 Winter Court', N'Fredericton', N'E3C1R4', 235408846, CAST(N'2012-01-15T00:00:00.000' AS DateTime), 47, CAST(N'2013-04-03T00:00:00.000' AS DateTime), N'5064710015', N'5064710018', N'michael.frazier@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (81976352, 52671208, 5, N'Robinson', N'Armando', N'R', CAST(N'1981-12-12T00:00:00.000' AS DateTime), N'17747 Main Road', N'Shediac', N'E0A3G2', 632853636, CAST(N'2014-07-07T00:00:00.000' AS DateTime), 25, CAST(N'2016-01-15T00:00:00.000' AS DateTime), N'5063128088', N'5063128099', N'aromando.robinson@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (84014197, 47630486, 1, N'Whittaker', N'Jennifer', N'K', CAST(N'1997-09-01T00:00:00.000' AS DateTime), N'34 Sycamore Street', N'Moncton', N'E1R5T5', 161445332, CAST(N'2020-01-30T00:00:00.000' AS DateTime), 6, CAST(N'2020-01-30T00:00:00.000' AS DateTime), N'5066641717', N'5066648844', N'jennifer.whittaker@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (88681443, 90327765, 2, N'Baird', N'Marissa', N'H', CAST(N'1981-06-18T00:00:00.000' AS DateTime), N'10 Edgemont Crescent', N'Moncton', N'E3E5T5', 114774656, CAST(N'2012-03-15T00:00:00.000' AS DateTime), 7, CAST(N'2016-01-30T00:00:00.000' AS DateTime), N'5064475454', N'5064476699', N'marissa.baird@systemking.ca', 1, N'NB', N'Canada', 1, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (89863937, 88681443, 2, N'Macleaod', N'Tyreese', N'F', CAST(N'1992-11-01T00:00:00.000' AS DateTime), N'30 Welland Street', N'Moncton', N'E1B4L8', 211416797, CAST(N'2018-05-01T00:00:00.000' AS DateTime), 12, CAST(N'2020-02-15T00:00:00.000' AS DateTime), N'5062626350', N'5062646379', N'tyreese.macleod@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (90327765, 47630486, 1, N'Vazquez', N'Tayah', N'P', CAST(N'1982-07-13T00:00:00.000' AS DateTime), N'685 Stanely River Street', N'Moncton', N'E1C2P1', 151774959, CAST(N'2012-03-15T00:00:00.000' AS DateTime), 2, CAST(N'2012-03-15T00:00:00.000' AS DateTime), N'5062529799', N'5062529899', N'tayah.vazquez@systemking.ca', 1, N'NB', N'Canada', 1, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (90867649, 88681443, 2, N'Potts', N'Alena', N'N', CAST(N'1991-03-19T00:00:00.000' AS DateTime), N'3700 Mountain Road', N'Moncton', N'E1C1H6', 625720404, CAST(N'2015-03-04T00:00:00.000' AS DateTime), 8, CAST(N'2015-03-04T00:00:00.000' AS DateTime), N'5069613573', N'5069613574', N'alena.potts@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (93585408, 90327765, 2, N'Askew', N'Gloria', N'J', CAST(N'1975-05-06T00:00:00.000' AS DateTime), N'3235 Ross Terrace ', N'Fredericton', N'E3B5W5', 515247583, CAST(N'2012-03-15T00:00:00.000' AS DateTime), 7, CAST(N'2012-03-15T00:00:00.000' AS DateTime), N'5064710478', N'5064710878', N'glorai.askew@systemking.ca', 1, N'NB', N'Canada', 1, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (94428947, 57726038, 6, N'Mattson', N'Paul', N'L', CAST(N'1986-02-14T00:00:00.000' AS DateTime), N'29 Mountain Road', N'Moncton', N'E1C5T5', 449855980, CAST(N'2016-01-15T00:00:00.000' AS DateTime), 28, CAST(N'2016-01-15T00:00:00.000' AS DateTime), N'5068776878', N'5068771111', N'paul.mattson@systemking.ca', 1, N'NB', N'Canada', 1, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (97317779, 90327765, 1, N'Carrillo', N'Jan', N'J', CAST(N'1997-08-18T00:00:00.000' AS DateTime), N'66 Forest Drive', N'Moncton', N'E1C7P7', 142556777, CAST(N'2020-01-30T00:00:00.000' AS DateTime), 6, CAST(N'2020-01-30T00:00:00.000' AS DateTime), N'5066634545', N'5066635454', N'jan.carrillo@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (97385687, 57726038, 7, N'Demoss', N'Nick', N'M', CAST(N'1992-10-21T00:00:00.000' AS DateTime), N'4449 Prince William Street', N'Saint John', N'E1L4V1', 139332960, CAST(N'2015-01-15T00:00:00.000' AS DateTime), 35, CAST(N'2016-07-01T00:00:00.000' AS DateTime), N'5067212819', N'5067212888', N'nick.demoss@systemking.ca', 1, N'NB', N'Canada', 1, NULL)
INSERT [dbo].[Employee] ([Id], [Supervisor], [Department], [LastName], [FirstName], [MiddleInitial], [DOB], [StreetAddress], [City], [PostalZip], [SIN], [SeniorityDate], [JobAssignment], [StartDate], [WorkPhoneNumber], [CellPhoneNumber], [Email], [Status], [ProvState], [Country], [IsSupervisor], [EndDate]) VALUES (98756300, 47821745, 4, N'White', N'Patrick', N'L', CAST(N'1967-02-15T00:00:00.000' AS DateTime), N'47 Rosewood Cresc', N'Moncton', N'E1C4T4', 160767943, CAST(N'2012-03-15T00:00:00.000' AS DateTime), 19, CAST(N'2012-03-15T00:00:00.000' AS DateTime), N'5068713998', N'5068713991', N'patrick.white@systemking.ca', 1, N'NB', N'Canada', 0, NULL)
INSERT [dbo].[EmployeeStatusType] ([Id], [Type]) VALUES (1, N'Active')
INSERT [dbo].[EmployeeStatusType] ([Id], [Type]) VALUES (2, N'Terminated')
INSERT [dbo].[EmployeeStatusType] ([Id], [Type]) VALUES (3, N'Retired')
INSERT [dbo].[ItemStatusType] ([Id], [Type]) VALUES (1, N'Pending')
INSERT [dbo].[ItemStatusType] ([Id], [Type]) VALUES (2, N'Approved')
INSERT [dbo].[ItemStatusType] ([Id], [Type]) VALUES (3, N'Denied')
SET IDENTITY_INSERT [dbo].[Job] ON 

INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (1, N'Chief Executive Officer', 1)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (2, N'Vice President of Production and Purchasing', 1)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (3, N'Vice President of Marketing and R&D', 1)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (4, N'Vice President of Legal, Finance and Human Resources', 1)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (5, N'Vice President of Technology', 1)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (6, N'Executive Assistant', 1)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (7, N'Production Officer', 2)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (8, N'Production Analyst', 2)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (9, N'Supply Chain Coordinator', 2)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (10, N'Supply Services Representative', 2)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (11, N'Inventory Controller', 2)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (12, N'Inventory Planner', 2)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (13, N'Production Quality Controller', 2)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (14, N'Logistics Coordinator', 2)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (15, N'Research and Development Officer', 3)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (17, N'Research and Development Analyst', 3)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (18, N'Purchasing Officer', 4)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (19, N'Purchasing Agent', 4)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (20, N'Buyer', 4)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (21, N'Sourcer', 4)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (22, N'Marketing Officer', 5)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (23, N'Public Relations Officer', 5)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (24, N'Brand Officer', 5)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (25, N'Market Research Analyst', 5)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (26, N'Digital Marketing Specialist', 5)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (27, N'Content Marketing Specialist ', 5)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (28, N'Human Resources Officer', 6)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (29, N'Staffing Coordinator', 6)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (30, N'Staffing Specialist', 6)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (31, N'Human Resources Analyst', 6)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (32, N'Human Resources Administrator', 6)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (33, N'Benefits Administrator', 6)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (34, N'Trainer', 6)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (35, N'Finance Officer', 7)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (36, N'Accounting Officer', 7)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (37, N'Financial Analyst', 7)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (38, N'Accounting Analyst', 7)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (39, N'Compliance Officer', 8)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (40, N'Compliance Analyst', 8)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (41, N'Litigation Officer', 8)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (42, N'Litigation Assistant', 8)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (43, N'Paralegal', 8)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (44, N'Senior DevOps Engineer', 9)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (45, N'Junior DevOps Engineer', 9)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (47, N'Senior Front-End Developer', 9)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (48, N'Junior Font-End Developer', 9)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (49, N'Senior Back-End Developer', 9)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (50, N'Junior Back-End Developer', 9)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (51, N'Data Analyst', 9)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (52, N'Senior QA Tester', 9)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (53, N'Junior QA Tester', 9)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (54, N'Senior Database Administrator', 9)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (55, N'Junior Database Administrator', 9)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (56, N'Senior Database Developer', 9)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (57, N'Junior Database Developer', 9)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (58, N'Information Security Officer', 9)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (59, N'Information Security Analyst', 9)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (60, N'Technical Support Representative ', 9)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (61, N'Senior Network Administrator', 9)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (62, N'Junior Network Administrator', 9)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (63, N'Buisness Sales Officer', 10)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (64, N'Buisness Sales Representative', 10)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (65, N'Consumer Sales Officer', 10)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (66, N'Consumer Sales Representative', 10)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (67, N'Senior Lead Generator', 10)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (68, N'Lead Generator', 10)
INSERT [dbo].[Job] ([Id], [Name], [Department]) VALUES (69, N'General Sales Officer', 10)
SET IDENTITY_INSERT [dbo].[Job] OFF
INSERT [dbo].[Login] ([EmployeeId], [Password], [Credential]) VALUES (94428947, N'f6af7afd01d4eb0dc5fe0a342cd6cee7', 1)
INSERT [dbo].[Login] ([EmployeeId], [Password], [Credential]) VALUES (50645952, N'F6AF7AFD01D4EB0DC5FE0A342CD6CEE7', 4)
INSERT [dbo].[Login] ([EmployeeId], [Password], [Credential]) VALUES (31720165, N'F6AF7AFD01D4EB0DC5FE0A342CD6CEE7', 2)
INSERT [dbo].[Login] ([EmployeeId], [Password], [Credential]) VALUES (65310260, N'F6AF7AFD01D4EB0DC5FE0A342CD6CEE7', 3)
INSERT [dbo].[Login] ([EmployeeId], [Password], [Credential]) VALUES (14067324, N'F6AF7AFD01D4EB0DC5FE0A342CD6CEE7', 4)
INSERT [dbo].[Login] ([EmployeeId], [Password], [Credential]) VALUES (94428947, N'f6af7afd01d4eb0dc5fe0a342cd6cee7', 1)
INSERT [dbo].[Login] ([EmployeeId], [Password], [Credential]) VALUES (88681443, N'F6AF7AFD01D4EB0DC5FE0A342CD6CEE7', 2)
INSERT [dbo].[Login] ([EmployeeId], [Password], [Credential]) VALUES (32492919, N'F6AF7AFD01D4EB0DC5FE0A342CD6CEE7', 2)
INSERT [dbo].[Login] ([EmployeeId], [Password], [Credential]) VALUES (13874404, N'F6AF7AFD01D4EB0DC5FE0A342CD6CEE7', 3)
INSERT [dbo].[POStatusType] ([Id], [Type]) VALUES (1, N'Pending')
INSERT [dbo].[POStatusType] ([Id], [Type]) VALUES (2, N'Under Review')
INSERT [dbo].[POStatusType] ([Id], [Type]) VALUES (3, N'Closed')
SET IDENTITY_INSERT [dbo].[Review] ON 

INSERT [dbo].[Review] ([Id], [EmployeeId], [SupervisorId], [Date], [Rating], [Comments]) VALUES (1, 14067324, 32492919, CAST(N'2015-07-01T00:00:00.000' AS DateTime), 1, N'Excellent people skills')
INSERT [dbo].[Review] ([Id], [EmployeeId], [SupervisorId], [Date], [Rating], [Comments]) VALUES (2, 14067324, 32492919, CAST(N'2015-11-08T00:00:00.000' AS DateTime), 1, N'Great initiative, excellent people skills and takes the time to understand concepts')
INSERT [dbo].[Review] ([Id], [EmployeeId], [SupervisorId], [Date], [Rating], [Comments]) VALUES (3, 14067324, 32492919, CAST(N'2016-02-11T00:00:00.000' AS DateTime), 2, N'Excellent employee but needs to stay within the parameters of assigned tasks. ')
INSERT [dbo].[Review] ([Id], [EmployeeId], [SupervisorId], [Date], [Rating], [Comments]) VALUES (4, 14067324, 32492919, CAST(N'2016-04-21T00:00:00.000' AS DateTime), 3, N'Needs to learn to abide by supervisor''s decision. When told not to do something, he will still do it if he believes it is wrong. ')
INSERT [dbo].[Review] ([Id], [EmployeeId], [SupervisorId], [Date], [Rating], [Comments]) VALUES (5, 14067324, 32492919, CAST(N'2016-07-15T00:00:00.000' AS DateTime), 3, N'Recommending for termination')
INSERT [dbo].[Review] ([Id], [EmployeeId], [SupervisorId], [Date], [Rating], [Comments]) VALUES (6, 14067324, 32492919, CAST(N'2020-02-01T00:00:00.000' AS DateTime), 1, N'Excellent people skills. Listens very well.')
INSERT [dbo].[Review] ([Id], [EmployeeId], [SupervisorId], [Date], [Rating], [Comments]) VALUES (7, 14067324, 32492919, CAST(N'2020-04-15T00:00:00.000' AS DateTime), 1, N'Delligent worker. Listens to criticism very well. Shows leadership qualities. ')
SET IDENTITY_INSERT [dbo].[Review] OFF
INSERT [dbo].[ReviewRatingType] ([Id], [Type]) VALUES (1, N'Above')
INSERT [dbo].[ReviewRatingType] ([Id], [Type]) VALUES (2, N'Meets')
INSERT [dbo].[ReviewRatingType] ([Id], [Type]) VALUES (3, N'Below')
ALTER TABLE [dbo].[PurchaseOrder] ADD  CONSTRAINT [DF_PurchaseOrder_CreationDate]  DEFAULT (getdate()) FOR [CreationDate]
GO
ALTER TABLE [dbo].[PurchaseOrder] ADD  CONSTRAINT [DF_PurchaseOrder_ModificationDate]  DEFAULT (getdate()) FOR [ModificationDate]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Department] FOREIGN KEY([Department])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Department]
GO
ALTER TABLE [dbo].[Employee]  WITH NOCHECK ADD  CONSTRAINT [FK_Employee_Employee] FOREIGN KEY([Supervisor])
REFERENCES [dbo].[Employee] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Employee]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_EmployeeStatusType] FOREIGN KEY([Status])
REFERENCES [dbo].[EmployeeStatusType] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_EmployeeStatusType]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Job] FOREIGN KEY([JobAssignment])
REFERENCES [dbo].[Job] ([Id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Job]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_ItemStatusType] FOREIGN KEY([ItemStatus])
REFERENCES [dbo].[ItemStatusType] ([Id])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_ItemStatusType]
GO
ALTER TABLE [dbo].[Item]  WITH CHECK ADD  CONSTRAINT [FK_Item_PurchaseOrder] FOREIGN KEY([POId])
REFERENCES [dbo].[PurchaseOrder] ([Id])
GO
ALTER TABLE [dbo].[Item] CHECK CONSTRAINT [FK_Item_PurchaseOrder]
GO
ALTER TABLE [dbo].[Job]  WITH CHECK ADD  CONSTRAINT [FK_Job_Department] FOREIGN KEY([Department])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[Job] CHECK CONSTRAINT [FK_Job_Department]
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [FK_Login_CredentialType] FOREIGN KEY([Credential])
REFERENCES [dbo].[CredentialType] ([Id])
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [FK_Login_CredentialType]
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [FK_Login_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([Id])
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [FK_Login_Employee]
GO
ALTER TABLE [dbo].[PurchaseOrder]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrder_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([Id])
GO
ALTER TABLE [dbo].[PurchaseOrder] CHECK CONSTRAINT [FK_PurchaseOrder_Employee]
GO
ALTER TABLE [dbo].[PurchaseOrder]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrder_Employee1] FOREIGN KEY([Supervisor])
REFERENCES [dbo].[Employee] ([Id])
GO
ALTER TABLE [dbo].[PurchaseOrder] CHECK CONSTRAINT [FK_PurchaseOrder_Employee1]
GO
ALTER TABLE [dbo].[PurchaseOrder]  WITH CHECK ADD  CONSTRAINT [FK_PurchaseOrder_POStatusType] FOREIGN KEY([ApprovalStatus])
REFERENCES [dbo].[POStatusType] ([Id])
GO
ALTER TABLE [dbo].[PurchaseOrder] CHECK CONSTRAINT [FK_PurchaseOrder_POStatusType]
GO
ALTER TABLE [dbo].[Review]  WITH CHECK ADD  CONSTRAINT [FK_Review_Employee] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([Id])
GO
ALTER TABLE [dbo].[Review] CHECK CONSTRAINT [FK_Review_Employee]
GO
ALTER TABLE [dbo].[Review]  WITH CHECK ADD  CONSTRAINT [FK_Review_Employee1] FOREIGN KEY([SupervisorId])
REFERENCES [dbo].[Employee] ([Id])
GO
ALTER TABLE [dbo].[Review] CHECK CONSTRAINT [FK_Review_Employee1]
GO
ALTER TABLE [dbo].[Review]  WITH CHECK ADD  CONSTRAINT [FK_Review_ReviewRatingType] FOREIGN KEY([Rating])
REFERENCES [dbo].[ReviewRatingType] ([Id])
GO
ALTER TABLE [dbo].[Review] CHECK CONSTRAINT [FK_Review_ReviewRatingType]
GO
/****** Object:  StoredProcedure [dbo].[Department_Add]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE   PROC [dbo].[Department_Add] 
	@Name VARCHAR(50),
	@Description VARCHAR(255),
	@InvocationDate DATETIME

AS

BEGIN 
	BEGIN TRY 
		IF EXISTS 
		(SELECT * FROM Department WHERE Name = @Name)
			THROW 51000, 'That Department already exists', 1

		INSERT INTO Department(Name, Description, InvocationDate)
		VALUES (@Name, @Description, @InvocationDate)

	END TRY
	BEGIN CATCH
		;THROW
	END CATCH
END 
GO
/****** Object:  StoredProcedure [dbo].[Department_Delete]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Department_Delete]
	@DepartmentId INT
AS

BEGIN 
	BEGIN TRY
		IF NOT EXISTS
			(SELECT * FROM Department WHERE Id = @DepartmentId)
			THROW 51000, 'Department not selected. Please choose a department.', 1

		DELETE FROM Department WHERE Id = @DepartmentId

	END TRY
	BEGIN CATCH
		;THROW
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Department_Get_BySupId]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Department_Get_BySupId]
	@EmployeeId INT

AS

BEGIN
	SELECT Department.* FROM Department
		INNER JOIN Employee ON Employee.Department = Department.Id
		WHERE Employee.Id = @EmployeeId AND Employee.IsSupervisor = 1
END
GO
/****** Object:  StoredProcedure [dbo].[Department_Get_Id]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Department_Get_Id]
	@DepartmentId INT

AS

BEGIN
	BEGIN TRY 
	IF NOT EXISTS 
	(SELECT * FROM Department WHERE Id = @DepartmentId)
		THROW 51000, 'No Departments match provided ID', 1

	SELECT * FROM Department WHERE Id = @DepartmentId
		END TRY
	BEGIN CATCH
		;THROW
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Department_Lookup_BySupId]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Department_Lookup_BySupId]
	@EmployeeId INT

AS

BEGIN
	SELECT Department.Name, Department.Id FROM Department
		INNER JOIN Employee ON Employee.Department = Department.Id
		WHERE Employee.Id = @EmployeeId AND Employee.IsSupervisor = 1
END
GO
/****** Object:  StoredProcedure [dbo].[Department_Modify]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Department_Modify]
	@TimeStamp TIMESTAMP OUTPUT,
	@Id INT,
	@Name VARCHAR(50),
	@Description VARCHAR(255),
	@InvocationDate DATETIME

AS
BEGIN
	BEGIN TRY
		IF (SELECT TimeStamp FROM Department WHERE Id = @Id) <> @TimeStamp
			THROW 51005, 'The record has been updated by someone since you last retrieved it. 
			Retrieve the record again before you make updates.', 1;
		
		UPDATE Department SET
			Name = @Name,
			Description = @Description,
			InvocationDate = @InvocationDate
		WHERE Id = @Id

		SET @TimeStamp = (SELECT TimeStamp FROM Department WHERE Id = @Id)
			
	END TRY
	BEGIN CATCH
		;THROW
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Departments_Get]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Departments_Get]

AS 

BEGIN
	SELECT Id, Name FROM Department
	ORDER BY Name
END
GO
/****** Object:  StoredProcedure [dbo].[Departments_Get_AllInfo]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROC [dbo].[Departments_Get_AllInfo]

AS 

BEGIN
	SELECT * FROM Department
	ORDER BY Name
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_Add]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Employee_Add]
	@Id INT,
	@SupervisorId INT,
	@DepartmentId INT, 
	@LastName VARCHAR(50),
	@FirstName VARCHAR(50),
	@MiddleInitial VARCHAR(1) = null,
	@DOB DATETIME,
	@StreetAddress NVARCHAR(255),
	@City VARCHAR(50),
	@PostalZip NVARCHAR(6) = null,
	@SIN INT = null,
	@SeniorityDate DATETIME,
	@JobAssignment INT,
	@StartDate DATETIME,
	@WorkPhoneNumber NVARCHAR(16),
	@CellPhoneNumber NVARCHAR(16),
	@Email NVARCHAR(50),
	@Status INT,
	@ProvState VARCHAR(2) = null,
	@Country VARCHAR(50),
	@IsSupervisor BIT ,
	@EndDate DATETIME = null
AS

BEGIN
	INSERT INTO Employee(Id, Supervisor, Department, LastName, FirstName, MiddleInitial, DOB, StreetAddress,
	City, PostalZip, SIN, SeniorityDate, JobAssignment, StartDate, WorkPhoneNumber, CellPhoneNumber,
	Email, Status, ProvState, Country, IsSupervisor, EndDate)
	VALUES (@Id, @SupervisorId, @DepartmentId, @LastName, @FirstName, @MiddleInitial, @DOB, @StreetAddress,
	@City, @PostalZip, @SIN, @SeniorityDate, @JobAssignment, @StartDate, @WorkPhoneNumber, @CellPhoneNumber,
	@Email, @Status, @ProvState, @Country, @IsSupervisor, @EndDate)
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_Get_Id]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[Employee_Get_Id]
	@EmployeeId INT

AS

BEGIN
	BEGIN TRY 
	IF NOT EXISTS 
	(SELECT * FROM Employee WHERE Id = @EmployeeId)
		THROW 51000, 'No Employee matches provided ID', 1

	SELECT * FROM Employee WHERE Id = @EmployeeId
		END TRY
	BEGIN CATCH
		;THROW
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Employee_GetAllSupervisors]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Employee_GetAllSupervisors]

AS
BEGIN

SELECT * FROM Employee WHERE IsSupervisor = 1;

END 
GO
/****** Object:  StoredProcedure [dbo].[Employee_Lookup_Id_AllInfo]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE   PROCEDURE [dbo].[Employee_Lookup_Id_AllInfo]
	@Id INT

AS

BEGIN
	SELECT * FROM Employee WHERE Id = @Id
END 
GO
/****** Object:  StoredProcedure [dbo].[Employee_Lookup_Name]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE   PROCEDURE [dbo].[Employee_Lookup_Name]
	@Name VARCHAR(50)

AS

BEGIN
	SELECT Id, LastName + ', ' + FirstName as [Name] FROM Employee WHERE LastName LIKE @Name + '%'
	ORDER BY [Name]
END 
GO
/****** Object:  StoredProcedure [dbo].[Employee_Lookup_Name_AllInfo]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE   PROCEDURE [dbo].[Employee_Lookup_Name_AllInfo]
	@Name VARCHAR(50)

AS

BEGIN
	SELECT * FROM Employee WHERE LastName LIKE @Name + '%'
	ORDER BY LastName
END 
GO
/****** Object:  StoredProcedure [dbo].[Employee_Modify]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Employee_Modify]
	@TimeStamp TIMESTAMP OUTPUT,
	@EmployeeId INT,
	@SupervisorId INT,
	@DepartmentId INT, 
	@LastName VARCHAR(50),
	@FirstName VARCHAR(50),
	@MiddleInitial VARCHAR(1) = null,
	@DOB DATETIME,
	@StreetAddress NVARCHAR(255),
	@City VARCHAR(50),
	@PostalZip NVARCHAR(6) = null,
	@SIN INT = null,
	@SeniorityDate DATETIME,
	@JobAssignment INT,
	@StartDate DATETIME,
	@WorkPhoneNumber NVARCHAR(16),
	@CellPhoneNumber NVARCHAR(16),
	@Email NVARCHAR(50),
	@Status INT,
	@ProvState VARCHAR(2) = null,
	@Country VARCHAR(50),
	@IsSupervisor BIT,
	@EndDate DATETIME = null
AS

BEGIN
	BEGIN TRY
		IF (SELECT TimeStamp FROM Employee WHERE Id = @EmployeeId) <> @TimeStamp
		THROW 51005, 'The record has been updated by someone since you last retrieved it. 
		Retrieve the record again before you make updates.', 1;

		UPDATE Employee SET
			Supervisor = @SupervisorId,
			Department = @DepartmentId,
			FirstName = @FirstName,
			MiddleInitial = @MiddleInitial,
			LastName = @LastName,
			DOB = @DOB,
			StreetAddress = @StreetAddress,
			City = @City,
			PostalZip = @PostalZip,
			SIN = @SIN,
			SeniorityDate = @SeniorityDate,
			JobAssignment = @JobAssignment,
			StartDate = @StartDate,
			WorkPhoneNumber = @WorkPhoneNumber,
			CellPhoneNumber = @CellPhoneNumber,
			Email = @Email,
			Status = @Status,
			ProvState = @ProvState,
			Country = @Country,
			IsSupervisor = @IsSupervisor,
			EndDate = @EndDate
		WHERE
		Id = @EmployeeId
	
		SET @TimeStamp = (SELECT TimeStamp FROM Employee WHERE Id = @EmployeeId)

		END TRY
	BEGIN CATCH
		;THROW
	END CATCH

END
GO
/****** Object:  StoredProcedure [dbo].[Employees_GET]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Employees_GET]

AS

BEGIN
	SELECT * FROM Employee;
END
GO
/****** Object:  StoredProcedure [dbo].[Employees_GetAll]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Employees_GetAll]

AS

BEGIN
	SELECT * FROM Employee
END
GO
/****** Object:  StoredProcedure [dbo].[Employees_GetBySupervisorId]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Employees_GetBySupervisorId]
	@SupervisorId INT
AS

BEGIN
	SELECT * FROM Employee
	WHERE Supervisor = @SupervisorId
END
GO
/****** Object:  StoredProcedure [dbo].[Item_Add]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE   PROC [dbo].[Item_Add] 
    @Id INT,
	@Name NVARCHAR(50),
	@Description NVARCHAR(255),
	@UnitPrice MONEY,
	@Location NVARCHAR(255),
	@Justification NVARCHAR(255),
    @Quantity INT

AS

BEGIN 
	BEGIN TRY 
		IF EXISTS 
		(SELECT * FROM Item WHERE Id = @Id)
			THROW 51000, 'That Item already exists', 1

		INSERT INTO Item(Name, Description, UnitPrice, Location, Justification, Quantity)
		VALUES (@Name, @Description, @UnitPrice, @Location, @Justification, @Quantity)

	END TRY
	BEGIN CATCH
		;THROW
	END CATCH
END 
GO
/****** Object:  StoredProcedure [dbo].[Job_GetByDepartment]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Job_GetByDepartment]
	@DepartmentId INT

AS

BEGIN
	SELECT Id, Name FROM Job WHERE Department = @DepartmentId
END
GO
/****** Object:  StoredProcedure [dbo].[Login_Create]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Login_Create]
	@Id INT,
	@Password NVARCHAR(255), 
	@Credential INT

AS

BEGIN
	INSERT INTO Login (EmployeeId,Password,Credential)
	VALUES ((SELECT Id FROM Employee WHERE Id = @Id), @Password, @Credential) 
END 
GO
/****** Object:  StoredProcedure [dbo].[PurchaseOrder_Add]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[PurchaseOrder_Add] 
    @Id INT,
	@EmployeeId INT,
	@Supervisor INT,
	@ApprovalStatus INT,
	@CreationDate DATETIME,
	@Subtotal MONEY,
	@Tax MONEY,
	@GrandTotal MONEY,
	@ModificationDate DATETIME,
	@ModificationReason NVARCHAR(100),
    @TimeStamp TIMESTAMP OUTPUT

AS

BEGIN 
	BEGIN TRY 
		IF EXISTS 
		(SELECT * FROM PurchaseOrder WHERE Id = @Id)
			THROW 5100, 'That Order already exists', 1

		INSERT INTO PurchaseOrder(Id, EmployeeId, Supervisor, ApprovalStatus, CreationDate, Subtotal, Tax, GrandTotal, ModificationDate, ModificationReason)
		VALUES (@Id, @EmployeeId, @Supervisor, @ApprovalStatus, @CreationDate, @Subtotal, @Tax, @GrandTotal, @ModificationDate, @ModificationReason)

		SET @TimeStamp = (SELECT TimeStamp FROM PurchaseOrder WHERE Id = @Id)
	END TRY
	BEGIN CATCH
		;THROW
	END CATCH
END 
GO
/****** Object:  StoredProcedure [dbo].[PurchaseOrder_DeleteById]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[PurchaseOrder_DeleteById] 
@Id int
AS 
BEGIN
DELETE FROM PurchaseOrder WHERE Id = @Id;
END 

GO
/****** Object:  StoredProcedure [dbo].[PurchaseOrder_SearchById]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[PurchaseOrder_SearchById] 
@Id int
AS 
BEGIN
SELECT * FROM PurchaseOrder
WHERE Id = @Id;
END 
GO
/****** Object:  StoredProcedure [dbo].[PurchaseOrder_Update]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[PurchaseOrder_Update] 

    @Id INT,
	@EmployeeId INT,
	@Supervisor INT,
	@ApprovalStatus INT,
	@CreationDate DATETIME,
	@Subtotal MONEY,
	@Tax MONEY,
	@GrandTotal MONEY,
	@ModificationDate DATETIME,
	@ModificationReason NVARCHAR(100),
    @TimeStamp TIMESTAMP OUTPUT

AS

BEGIN 
		UPDATE PurchaseOrder
		SET
        EmployeeId = @EmployeeId, Supervisor = @Supervisor, ApprovalStatus = @ApprovalStatus,
		CreationDate = @CreationDate, Subtotal = @Subtotal, Tax = @Tax, GrandTotal = @GrandTotal, 
		ModificationDate = @ModificationDate, ModificationReason = @ModificationReason,
		@TimeStamp = (SELECT TimeStamp FROM PurchaseOrder WHERE Id = @Id)
		WHERE Id = @Id;
END 
GO
/****** Object:  StoredProcedure [dbo].[Review_Add]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROCEDURE [dbo].[Review_Add]
	@EmployeeId INT,
	@SupervisorId INT,
	@Date DATETIME,
	@Rating INT,
	@Comments VARCHAR(255)

AS

BEGIN
	INSERT INTO Review (EmployeeId, SupervisorId, Date, Rating, Comments)
	VALUES(@EmployeeId, @SupervisorId, @Date, @Rating, @Comments)
END
GO
/****** Object:  StoredProcedure [dbo].[Review_GetById]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Review_GetById]
	@Id INT
AS 

BEGIN 
	SELECT * FROM Review WHERE Id = @Id
END
GO
/****** Object:  StoredProcedure [dbo].[Reviews_GetByEmployeeId]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Reviews_GetByEmployeeId]
	@EmployeeId INT

AS

BEGIN
	BEGIN TRY

		SELECT * FROM Review WHERE EmployeeId = @EmployeeId
		ORDER BY Date DESC

	END TRY
	BEGIN CATCH
		;THROW
	END CATCH
END
GO
/****** Object:  StoredProcedure [dbo].[Reviews_GetBySupervisor]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Reviews_GetBySupervisor]
	@SupervisorId INT

AS

BEGIN

SELECT * FROM Review WHERE SupervisorId = @SupervisorId

END 
GO
/****** Object:  StoredProcedure [dbo].[Supervisor_GetByDepartment]    Script Date: 2020-05-12 9:55:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE   PROC [dbo].[Supervisor_GetByDepartment]
	@DepartmentId INT

AS

BEGIN
	BEGIN TRY
	IF NOT EXISTS
	(SELECT * FROM Employee WHERE Department = @DepartmentId AND IsSupervisor = 1)
		THROW 51000, 'There are no supervisors for that department', 1

	SELECT Id, LastName +', '+ FirstName AS [Name] FROM Employee WHERE Department = @DepartmentId AND IsSupervisor = 1;

		END TRY
	BEGIN CATCH
		;THROW
	END CATCH
END
GO
