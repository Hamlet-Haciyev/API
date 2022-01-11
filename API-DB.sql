USE [ApiStudentsDb]
GO
SET IDENTITY_INSERT [dbo].[Schools] ON 

INSERT [dbo].[Schools] ([Id], [Name], [DirectorName]) VALUES (1, N'100', N'Aysel Eliyev')
INSERT [dbo].[Schools] ([Id], [Name], [DirectorName]) VALUES (2, N'213', N'Fuad Elekberov')
SET IDENTITY_INSERT [dbo].[Schools] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [Name], [SurName], [Age], [Phone], [Email], [ClassNumber], [SchoolId]) VALUES (1, N'Hamlet', N'Haciyev', 20, N'055-324-23423-4', N'hamilet@gmail.com', N'10c', 1)
INSERT [dbo].[Students] ([Id], [Name], [SurName], [Age], [Phone], [Email], [ClassNumber], [SchoolId]) VALUES (2, N'Zeka', N'Askerov', 20, N'055-324-23423-4', N'hamilet@gmail.com', N'10c', 2)
INSERT [dbo].[Students] ([Id], [Name], [SurName], [Age], [Phone], [Email], [ClassNumber], [SchoolId]) VALUES (3, N'Abbas', N'Eliyev', 20, N'055-324-23423-4', N'hamilet@gmail.com', N'10c', 1)
INSERT [dbo].[Students] ([Id], [Name], [SurName], [Age], [Phone], [Email], [ClassNumber], [SchoolId]) VALUES (4, N'Omer', N'Eliyev', 30, N'055-324-23423-4', N'hamilet@gmail.com', N'11b', 1)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
