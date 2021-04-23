USE [PromoCode]
GO
SET IDENTITY_INSERT [dbo].[BonusActivated] ON 
GO
INSERT [dbo].[BonusActivated] ([Id], [UserId], [ProductId], [ActiveFlag], [PromoCodeListId]) VALUES (1, 1, 1, 1, 1)
GO
INSERT [dbo].[BonusActivated] ([Id], [UserId], [ProductId], [ActiveFlag], [PromoCodeListId]) VALUES (2, 1, 2, 1, 2)
GO
INSERT [dbo].[BonusActivated] ([Id], [UserId], [ProductId], [ActiveFlag], [PromoCodeListId]) VALUES (3, 1, 3, 1, 3)
GO
INSERT [dbo].[BonusActivated] ([Id], [UserId], [ProductId], [ActiveFlag], [PromoCodeListId]) VALUES (4, 1, 4, 1, 4)
GO
INSERT [dbo].[BonusActivated] ([Id], [UserId], [ProductId], [ActiveFlag], [PromoCodeListId]) VALUES (5, 2, 1, 1, 5)
GO
INSERT [dbo].[BonusActivated] ([Id], [UserId], [ProductId], [ActiveFlag], [PromoCodeListId]) VALUES (6, 2, 2, 1, 6)
GO
INSERT [dbo].[BonusActivated] ([Id], [UserId], [ProductId], [ActiveFlag], [PromoCodeListId]) VALUES (7, 1, 5, 1, 9)
GO
SET IDENTITY_INSERT [dbo].[BonusActivated] OFF
GO
SET IDENTITY_INSERT [dbo].[PromoCodeList] ON 
GO
INSERT [dbo].[PromoCodeList] ([Id], [PromoCode]) VALUES (1, N'SPIDERCOLA ')
GO
INSERT [dbo].[PromoCodeList] ([Id], [PromoCode]) VALUES (2, N'ITPROMOS')
GO
INSERT [dbo].[PromoCodeList] ([Id], [PromoCode]) VALUES (3, N'DERCOLA2')
GO
INSERT [dbo].[PromoCodeList] ([Id], [PromoCode]) VALUES (4, N'SPIDERCOLA ')
GO
INSERT [dbo].[PromoCodeList] ([Id], [PromoCode]) VALUES (5, N'SPIDERCOLA ')
GO
INSERT [dbo].[PromoCodeList] ([Id], [PromoCode]) VALUES (6, N'SPIDERCOLA ')
GO
INSERT [dbo].[PromoCodeList] ([Id], [PromoCode]) VALUES (7, N'SPIDERCOLA ')
GO
INSERT [dbo].[PromoCodeList] ([Id], [PromoCode]) VALUES (8, N'SJKERCOLA ')
GO
INSERT [dbo].[PromoCodeList] ([Id], [PromoCode]) VALUES (9, N'PROMOTCS')
GO
SET IDENTITY_INSERT [dbo].[PromoCodeList] OFF
GO
SET IDENTITY_INSERT [dbo].[PromoCodeProduct] ON 
GO
INSERT [dbo].[PromoCodeProduct] ([ProductId], [ProductDescription], [ProductName]) VALUES (1, N'Udemy Course', N'Udemy.com')
GO
INSERT [dbo].[PromoCodeProduct] ([ProductId], [ProductDescription], [ProductName]) VALUES (2, N'Appvision', N'Appvision.com')
GO
INSERT [dbo].[PromoCodeProduct] ([ProductId], [ProductDescription], [ProductName]) VALUES (3, N'Logo type ', N'Logotype.com')
GO
INSERT [dbo].[PromoCodeProduct] ([ProductId], [ProductDescription], [ProductName]) VALUES (4, N'Analytics Info', N'Analytics.com')
GO
INSERT [dbo].[PromoCodeProduct] ([ProductId], [ProductDescription], [ProductName]) VALUES (5, N'Lynda course', N'Lynda.com')
GO
INSERT [dbo].[PromoCodeProduct] ([ProductId], [ProductDescription], [ProductName]) VALUES (6, N'Site constructor', N'Siteconstructor.io')
GO
SET IDENTITY_INSERT [dbo].[PromoCodeProduct] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([Id], [Name], [Email], [PasswordHash], [PasswordSalt], [IsActive], [CreationTime]) VALUES (1, N'Antony', N'antony@gmail.com', 0x673C2272C7DC98646F37734365EF0C8FEE4321FBA968B15A992CB68B9D720A38362AB0D9C733738DFA10446AD2C7A6431BDAE272A969FFB7DC9B9A1EF0C6CEA3, 0x43BD5B13A8EEF29694CF5CA94E1D1B32813832211B7FC4FEBAB4B29E9DAFD5837135190AECBF5D727AB9E94F22EFB494F4B61DEC472FF6DB62748C6F422C18B6163751726DA38C1644846B5EB61FCF50D6EFF433DB6D51F537B9C3290784F002153BD7BD1F3A6E4AE6DFD44DE993C27D96C0B17685C05F1376CC9A2F824B3669, 1, CAST(N'2021-04-20T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Users] ([Id], [Name], [Email], [PasswordHash], [PasswordSalt], [IsActive], [CreationTime]) VALUES (2, N'Admin', N'admin@gmail.com', 0x673C2272C7DC98646F37734365EF0C8FEE4321FBA968B15A992CB68B9D720A38362AB0D9C733738DFA10446AD2C7A6431BDAE272A969FFB7DC9B9A1EF0C6CEA3, 0x43BD5B13A8EEF29694CF5CA94E1D1B32813832211B7FC4FEBAB4B29E9DAFD5837135190AECBF5D727AB9E94F22EFB494F4B61DEC472FF6DB62748C6F422C18B6163751726DA38C1644846B5EB61FCF50D6EFF433DB6D51F537B9C3290784F002153BD7BD1F3A6E4AE6DFD44DE993C27D96C0B17685C05F1376CC9A2F824B3669, 1, CAST(N'2021-04-20T00:00:00.0000000' AS DateTime2))
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
