USE AdoNetDB

CREATE TABLE [dbo]. [Book](
[ID] [int] IDENTITY (1,1) NOT NULL,
[Title] [nvarchar] (80) NOT NULL,
[Genre] [nvarchar] (20) NOT NULL,
[AuthorID] [int] NULL,
CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED
(
[ID] ASC
))

GO

SELECT * FROM Book