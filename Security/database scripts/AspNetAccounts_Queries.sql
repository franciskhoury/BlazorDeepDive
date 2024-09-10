use AspNetAccounts;

SELECT *
  FROM dbo.AspNetUsers;


insert into dbo.AspNetUserClaims
(UserId,ClaimType,ClaimValue)
values
('253577d2-8ebd-49fd-9eea-879b97634ea2','Department','Software Development'),
('253577d2-8ebd-49fd-9eea-879b97634ea2','Role','Code Bitch')
;

SELECT Id,UserId,ClaimType,ClaimValue
  FROM dbo.AspNetUserClaims;