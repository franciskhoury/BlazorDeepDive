

  update [dbo].[Servers]
  set 
  --IsOnline = 1, UserCount = UserCount +1
  IsOnline = 0
  where City = 'Halifax';
  
  /****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [ServerId]
      ,[IsOnline]
      ,[Name]
      ,[City]
      ,[UserCount]
  FROM [ServerManagement].[dbo].[Servers];
