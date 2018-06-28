CREATE TABLE [dbo].[CourseDirections] (
    [CourseDirectionId] INT            IDENTITY (1, 1) NOT NULL,
    [Title]             NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_CourseDirection] PRIMARY KEY CLUSTERED ([CourseDirectionId] ASC)
);



