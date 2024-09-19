use AspNetAccounts;

SELECT *
  FROM dbo.AspNetUsers;


--insert into dbo.AspNetUserClaims
--(UserId,ClaimType,ClaimValue)
--values
--('85ae204b-dcad-4b4c-ae38-31252b34c16a','Department','Software Development'),
--('85ae204b-dcad-4b4c-ae38-31252b34c16a','Role','General Manager')
--;

SELECT Id,UserId,ClaimType,ClaimValue
  FROM dbo.AspNetUserClaims;