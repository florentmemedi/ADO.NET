USE AdoNetDB

CREATE TABLE [dbo]. [Author](
[ID] [int] IDENTITY (1,1) NOT NULL,
[FirstName] [nvarchar] (30) NOT NULL,
[LastName] [nvarchar] (30) NOT NULL,
CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED
(
[ID] ASC
))

GO