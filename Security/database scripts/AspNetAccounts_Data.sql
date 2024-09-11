USE [AspNetAccounts]
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'253577d2-8ebd-49fd-9eea-879b97634ea2', N'francis@email.com', N'FRANCIS@EMAIL.COM', N'francis@email.com', N'FRANCIS@EMAIL.COM', 1, N'AQAAAAIAAYagAAAAEAQ1a54vikCqpBR7Xcucop9HKYfud7yznUJsYAkr8PsGH3xZn8W/q6LI7QRMqrOLDA==', N'NRNQLVUFJNPBOZZTVORPFSJR2Z3FV2L4', N'b7c78d10-d33b-4545-917e-41907a53f9ab', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'9173232b-fec6-4da7-a26a-dda3a2974234', N'fkhoury@bn.com', N'FKHOURY@BN.COM', N'fkhoury@bn.com', N'FKHOURY@BN.COM', 0, N'AQAAAAIAAYagAAAAEMMBIqSfwSg85mrca5JRZfl37zal+zr/bKzAr7JI7nUsZRu7yrlBzkQPavHqjwyXxg==', N'OVXUMFWNNXNOORRBCNDVRL23WZ54IHQT', N'eeb5646a-2510-4258-bb15-2df2d5c46ef4', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'f7bc0d89-50fd-4708-b406-30a31d771a7a', N'testaccount1@gmail.com', N'TESTACCOUNT1@GMAIL.COM', N'testaccount1@gmail.com', N'TESTACCOUNT1@GMAIL.COM', 0, N'AQAAAAIAAYagAAAAEN73CofRi1MeKGe5MGu/OhWZ1evbLoWb0MpyWBIZS6AUyY36pW681O1h0MKGef7zjA==', N'V6H3OLVYXBBPVMRHPZGWZZOUVR6GVGOE', N'98246042-b129-43da-b0f9-d664cfb52431', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] ON 

INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (1, N'253577d2-8ebd-49fd-9eea-879b97634ea2', N'Department', N'Software Development')
INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (2, N'253577d2-8ebd-49fd-9eea-879b97634ea2', N'Role', N'Code Bitch')
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] OFF
GO
