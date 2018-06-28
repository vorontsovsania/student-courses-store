CREATE TABLE [dbo].[Courses] (
    [CourseId]          INT            IDENTITY (1, 1) NOT NULL,
    [Title]             NVARCHAR (100) NOT NULL,
    [CourseDirectionId] INT            NOT NULL,
    CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED ([CourseId] ASC),
    CONSTRAINT [FK_Courses_CourseDirections] FOREIGN KEY ([CourseDirectionId]) REFERENCES [dbo].[CourseDirections] ([CourseDirectionId])
);

