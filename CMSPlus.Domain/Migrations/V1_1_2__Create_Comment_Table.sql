USE [CMSPlus]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [TopicId] [int] NOT NULL,
    [Author] [nvarchar](256) NOT NULL,
    [Body] [nvarchar](max) NOT NULL,
    [CreatedOnUtc] [datetime] NOT NULL,
    [UpdatedOnUtc] [datetime] NOT NULL,
    CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED
(
[Id] ASC
) WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
    ) ON [PRIMARY]
    GO

ALTER TABLE [dbo].[Comments] ADD  DEFAULT (getdate()) FOR [CreatedOnUtc]
ALTER TABLE [dbo].[Comments] ADD  DEFAULT (getdate()) FOR [UpdatedOnUtc]
    GO

ALTER TABLE [dbo].[Comments] ADD CONSTRAINT [FK_Comments_Topics_TopicId] FOREIGN KEY([TopicId])
    REFERENCES [dbo].[Topics] ([Id])
    ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Topics_TopicId]
    GO
