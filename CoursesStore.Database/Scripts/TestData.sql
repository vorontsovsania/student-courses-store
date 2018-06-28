﻿
SET IDENTITY_INSERT [dbo].[CourseDirections] ON;

INSERT INTO [dbo].[CourseDirections]([CourseDirectionId], [Title])
VALUES (1, N'Databases'),
		(2, N'Programming'),
		(3, N'Management'),
		(4, N'Gardening')

SET IDENTITY_INSERT [dbo].[CourseDirections] OFF;


SET IDENTITY_INSERT [dbo].[Courses] ON;

INSERT INTO [dbo].[Courses]([CourseId], [Title], [CourseDirectionId])
VALUES (1, N'Create queries for MS SQL databases', 1),
		(2, N'Administration MS SQL databases', 1),
		(3, N'Web services using .Net techologies', 2)

SET IDENTITY_INSERT [dbo].[Courses] OFF;


INSERT INTO [dbo].[Students](FirstName, LastName, BirthDate)
VALUES ('Dan','Henderson','1989-01-07'),
		('David','Hill','1989-01-07'),
		('Dominic','Hodges','1989-01-07'),
		('Dylan','Howard','1989-01-07'),
		('Edward','Hudson','1989-01-07'),
		('Eric','Hughes','1989-01-07'),
		('Evan','Hunter','1989-01-07'),
		('Frank','Ince','1989-01-07'),
		('Gavin','Jackson','1989-01-07'),
		('Gordon','James','1989-01-07'),
		('Harry','Johnston','1989-01-07'),
		('Ian','Jones','1989-01-07'),
		('Isaac','Kelly','1989-01-07'),
		('Jack','Kerr','1989-01-07'),
		('Jacob','King','1989-01-07'),
		('Jake','Knox','1989-01-07'),
		('James','Lambert','1989-01-07'),
		('Jason','Langdon','1989-01-07'),
		('Joe','Lawrence','1989-01-07'),
		('John','Lee','1989-01-07'),
		('Jonathan','Lewis','1989-01-07'),
		('Joseph','Lyman','1989-01-07'),
		('Joshua','MacDonald','1989-01-07'),
		('Julian','Mackay','1989-01-07'),
		('Justin','Mackenzie','1989-01-07'),
		('Keith','MacLeod','1989-01-07'),
		('Kevin','Manning','1989-01-07'),
		('Leonard','Marshall','1989-01-07'),
		('Liam','Martin','1989-01-07'),
		('Lucas','Mathis','1989-01-07'),
		('Luke','May','1989-01-07'),
		('Matt','McDonald','1989-01-07'),
		('Max','McLean','1989-01-07'),
		('Michael','McGrath','1989-01-07'),
		('Nathan','Metcalfe','1989-01-07'),
		('Neil','Miller','1989-01-07'),
		('Nicholas','Mills','1989-01-07'),
		('Oliver','Mitchell','1989-01-07')

GO