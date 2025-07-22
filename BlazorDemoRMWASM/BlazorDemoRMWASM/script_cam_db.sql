USE [cam]
GO
SET IDENTITY_INSERT [dbo].[Menus] ON 
GO
INSERT [dbo].[Menus] ([Id], [Name], [Url], [Image], [MenuParentId], [Sort], [ShowHeader], [ShowFooter], [Active]) VALUES (1, N'Giới thiệu', N'gioi-thieu', NULL, 0, 1, 1, 1, 1)
GO
INSERT [dbo].[Menus] ([Id], [Name], [Url], [Image], [MenuParentId], [Sort], [ShowHeader], [ShowFooter], [Active]) VALUES (2, N'Sản phẩm', N'san-pham', NULL, 0, 2, 1, 1, 1)
GO
INSERT [dbo].[Menus] ([Id], [Name], [Url], [Image], [MenuParentId], [Sort], [ShowHeader], [ShowFooter], [Active]) VALUES (3, N'Tin tức', N'tin-tuc', NULL, 0, 3, 1, 1, 1)
GO
INSERT [dbo].[Menus] ([Id], [Name], [Url], [Image], [MenuParentId], [Sort], [ShowHeader], [ShowFooter], [Active]) VALUES (4, N'Liên hệ', N'lien-he', NULL, 0, 4, 1, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[Menus] OFF
GO


SET IDENTITY_INSERT [dbo].[ConfigSites] ON 
GO
INSERT [dbo].[ConfigSites] ([Id], [Facebook], [Image], [Favicon], [GoogleMap], [GoogleAnalytics], [Address], [Title], [Description], [Hotline], [Zalo], [Email],  [InfoFooter]) 
VALUES (1, N'https://www.facebook.com/profile.php?id=61577265336269',  N'2025/07/03/logo-web-597.png', N'2025/07/03/logo-app-663.png', NULL, NULL, N'[Address]', N'[Title]', N'[Description]', N'[Hotline]', N'[[Zalo]]', N'[[Email]]', N'<h2 class="font-bold uppercase"><img alt="" height="60" src="/images/upload/images/logo-web-597(1).png" width="149" /></h2>

<h2 class="font-bold uppercase"><br />
C&Ocirc;NG TY C&Ocirc;̉ PH&Acirc;̀N COKYVINA - CHI NHÁNH THĂNG LONG</h2>

<p>Trụ sở: Số 110 - Đường Nguyễn Ho&agrave;ng T&ocirc;n - Phường Xu&acirc;n La - Quận T&acirc;y Hồ - H&agrave; Nội</p>

<p>Địa chỉ giao dịch: Tầng 6, T&ograve;a nh&agrave; Trần Ph&uacute;, Số 6 Dương Đ&igrave;nh Nghệ, Y&ecirc;n H&ograve;a, H&agrave; Nội</p>

<p>Hotline: 0967763568</p>

<p>Email: <a data-z-element-type="email" href="mailto:cokyvinatl@gmail.com" target="_blank">cokyvinatl@gmail.com</a></p>
')
GO
SET IDENTITY_INSERT [dbo].[ConfigSites] OFF
GO

