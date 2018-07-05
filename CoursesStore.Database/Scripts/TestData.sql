
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
		(3, N'Web services using .Net technologies', 2)

SET IDENTITY_INSERT [dbo].[Courses] OFF;


SET IDENTITY_INSERT [dbo].[Students] ON;

INSERT INTO [dbo].[Students](StudentId, FirstName, LastName, BirthDate)
VALUES (1,'Alexander','Ferguson','1989-01-07'),
		(2,'Andrew','Fisher','1989-01-07'),
		(3,'Anthony','Forsyth','1989-01-07'),
		(4,'Austin','Fraser','1989-01-07'),
		(5,'Benjamin','Gibson','1989-01-07'),
		(6,'Blake','Gill','1989-01-07'),
		(7,'Boris','Glover','1989-01-07'),
		(8,'Brandon','Graham','1989-01-07'),
		(9,'Brian','Grant','1989-01-07'),
		(10,'Cameron','Gray','1989-01-07'),
		(11,'Carl','Greene','1989-01-07'),
		(12,'Charles','Hamilton','1989-01-07'),
		(13,'Christian','Hardacre','1989-01-07'),
		(14,'Christopher','Harris','1989-01-07'),
		(15,'Colin','Hart','1989-01-07'),
		(16,'Connor','Hemmings','1989-01-07'),
		(17,'Dan','Henderson','1989-01-07'),
		(18,'David','Hill','1989-01-07'),
		(19,'Dominic','Hodges','1989-01-07'),
		(20,'Dylan','Howard','1989-01-07'),
		(21,'Edward','Hudson','1989-01-07'),
		(22,'Eric','Hughes','1989-01-07'),
		(23,'Evan','Hunter','1989-01-07'),
		(24,'Frank','Ince','1989-01-07'),
		(25,'Gavin','Jackson','1989-01-07'),
		(26,'Gordon','James','1989-01-07'),
		(27,'Harry','Johnston','1989-01-07'),
		(28,'Ian','Jones','1989-01-07'),
		(29,'Isaac','Kelly','1989-01-07'),
		(30,'Jack','Kerr','1989-01-07'),
		(31,'Jacob','King','1989-01-07'),
		(32,'Jake','Knox','1989-01-07'),
		(33,'James','Lambert','1989-01-07'),
		(34,'Jason','Langdon','1989-01-07'),
		(35,'Joe','Lawrence','1989-01-07'),
		(36,'John','Lee','1989-01-07'),
		(37,'Jonathan','Lewis','1989-01-07'),
		(38,'Joseph','Lyman','1989-01-07'),
		(39,'Joshua','MacDonald','1989-01-07'),
		(40,'Julian','Mackay','1989-01-07'),
		(41,'Justin','Mackenzie','1989-01-07'),
		(42,'Keith','MacLeod','1989-01-07'),
		(43,'Kevin','Manning','1989-01-07'),
		(44,'Leonard','Marshall','1989-01-07'),
		(45,'Liam','Martin','1989-01-07'),
		(46,'Lucas','Mathis','1989-01-07'),
		(47,'Luke','May','1989-01-07'),
		(48,'Matt','McDonald','1989-01-07'),
		(49,'Max','McLean','1989-01-07'),
		(50,'Michael','McGrath','1989-01-07'),
		(51,'Nathan','Metcalfe','1989-01-07'),
		(52,'Neil','Miller','1989-01-07'),
		(53,'Nicholas','Mills','1989-01-07'),
		(54,'Oliver','Mitchell','1989-01-07')

SET IDENTITY_INSERT [dbo].[Students] OFF;

GO