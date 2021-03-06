USE [GestorDeApps]
GO
/****** Object:  Table [dbo].[CATEGORIA]    Script Date: 02/03/2017 18:07:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CATEGORIA](
	[CODCATEGORIA] [int] IDENTITY(1,1) NOT NULL,
	[NOMCATEGORIA] [varchar](50) NULL,
 CONSTRAINT [PK_CATEGORIA] PRIMARY KEY CLUSTERED 
(
	[CODCATEGORIA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PROGRAMA]    Script Date: 02/03/2017 18:07:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PROGRAMA](
	[CODIGO] [int] IDENTITY(1,1) NOT NULL,
	[CODIGOCAT] [int] NULL,
	[NOMBRE] [varchar](50) NULL,
	[PLATAFORMA] [varchar](50) NULL,
	[VERSION] [varchar](50) NULL,
	[DESCARGAS] [int] NULL,
	[HOST] [text] NULL,
	[INSTALADO] [bit] NULL,
 CONSTRAINT [PK_PROGRAMA] PRIMARY KEY CLUSTERED 
(
	[CODIGO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[CATEGORIA] ON 

INSERT [dbo].[CATEGORIA] ([CODCATEGORIA], [NOMCATEGORIA]) VALUES (1, N'Internet')
INSERT [dbo].[CATEGORIA] ([CODCATEGORIA], [NOMCATEGORIA]) VALUES (2, N'Ofimatica')
INSERT [dbo].[CATEGORIA] ([CODCATEGORIA], [NOMCATEGORIA]) VALUES (3, N'Antivirus')
INSERT [dbo].[CATEGORIA] ([CODCATEGORIA], [NOMCATEGORIA]) VALUES (4, N'Programacion')
INSERT [dbo].[CATEGORIA] ([CODCATEGORIA], [NOMCATEGORIA]) VALUES (5, N'Juegos')
SET IDENTITY_INSERT [dbo].[CATEGORIA] OFF
SET IDENTITY_INSERT [dbo].[PROGRAMA] ON 

INSERT [dbo].[PROGRAMA] ([CODIGO], [CODIGOCAT], [NOMBRE], [PLATAFORMA], [VERSION], [DESCARGAS], [HOST], [INSTALADO]) VALUES (1, 1, N'Google Chrome', N'Windows', N'123125', 12355, N'https://dl.google.com/tag/s/appguid%3D%7B8A69D345-D564-463C-AFF1-A69D9E530F96%7D%26iid%3D%7B715541E4-C4ED-0051-7499-4650426ACE55%7D%26lang%3Des%26browser%3D4%26usagestats%3D0%26appname%3DGoogle%2520Chrome%26needsadmin%3Dprefers%26ap%3Dx64-stable-statsdef_1%26installdataindex%3Ddefaultbrowser/update2/installers/ChromeSetup.exe', 1)
INSERT [dbo].[PROGRAMA] ([CODIGO], [CODIGOCAT], [NOMBRE], [PLATAFORMA], [VERSION], [DESCARGAS], [HOST], [INSTALADO]) VALUES (2, 1, N'Mozilla Firefox', N'Windows', N'123123', 12312, N'https://stubdownloader.cdn.mozilla.net/builds/firefox-stub/es-ES/win/1a0ea6e1034ded05fc3a0948f826574e58bbc474a69ba2e07b662a6b7b316e18/Firefox%20Setup%20Stub%2051.0.1.exe', 1)
INSERT [dbo].[PROGRAMA] ([CODIGO], [CODIGOCAT], [NOMBRE], [PLATAFORMA], [VERSION], [DESCARGAS], [HOST], [INSTALADO]) VALUES (3, 1, N'Opera', N'Windows', N'123124', 213241, N'http://net.geo.opera.com/opera/stable/windows?http_referrer=https://www.google.es/&utm_source=google_via_opera_com&utm_medium=ose&utm_campaign=google_ose_via_opera_com', 0)
INSERT [dbo].[PROGRAMA] ([CODIGO], [CODIGOCAT], [NOMBRE], [PLATAFORMA], [VERSION], [DESCARGAS], [HOST], [INSTALADO]) VALUES (4, 3, N'Avira', N'Windows', N'213434', 12341, N'https://package.avira.com/package/oeavira/win/int/avira_es_fass0_58b856bd9ac86__ws.exe', 0)
INSERT [dbo].[PROGRAMA] ([CODIGO], [CODIGOCAT], [NOMBRE], [PLATAFORMA], [VERSION], [DESCARGAS], [HOST], [INSTALADO]) VALUES (5, 3, N'AVG', N'Windows', N'123124', 12312, N'http://files-download.avg.com/inst/mp/AVG_Protection_Free_698.exe', 0)
INSERT [dbo].[PROGRAMA] ([CODIGO], [CODIGOCAT], [NOMBRE], [PLATAFORMA], [VERSION], [DESCARGAS], [HOST], [INSTALADO]) VALUES (6, 3, N'Avast', N'Windows', N'123124', 1231, N'http://files.avast.com/iavs9x/avast_free_antivirus_setup_online.exe', 1)
INSERT [dbo].[PROGRAMA] ([CODIGO], [CODIGOCAT], [NOMBRE], [PLATAFORMA], [VERSION], [DESCARGAS], [HOST], [INSTALADO]) VALUES (7, 2, N'Open Office', N'Windows', N'123415', 123531, N'https://netcologne.dl.sourceforge.net/project/openofficeorg.mirror/4.1.3/binaries/es/Apache_OpenOffice_4.1.3_Win_x86_install_es.exe', 1)
INSERT [dbo].[PROGRAMA] ([CODIGO], [CODIGOCAT], [NOMBRE], [PLATAFORMA], [VERSION], [DESCARGAS], [HOST], [INSTALADO]) VALUES (8, 2, N'Kingston Office', N'Windows', N'123', 12312, N'http://www.kingsoftstore.com/download/setup_wps_office_2016.exe', 0)
INSERT [dbo].[PROGRAMA] ([CODIGO], [CODIGOCAT], [NOMBRE], [PLATAFORMA], [VERSION], [DESCARGAS], [HOST], [INSTALADO]) VALUES (9, 2, N'Polaris Office', N'Windows', N'12341', 123124, N'http://install.polarisoffice.com/pcoffice/PolarisOfficeInstaller.exe', 1)
INSERT [dbo].[PROGRAMA] ([CODIGO], [CODIGOCAT], [NOMBRE], [PLATAFORMA], [VERSION], [DESCARGAS], [HOST], [INSTALADO]) VALUES (10, 4, N'Netbeans', N'Windows', N'21341', 12341, N'http://download.netbeans.org/netbeans/8.2/final/bundles/netbeans-8.2-windows.exe', 0)
INSERT [dbo].[PROGRAMA] ([CODIGO], [CODIGOCAT], [NOMBRE], [PLATAFORMA], [VERSION], [DESCARGAS], [HOST], [INSTALADO]) VALUES (11, 4, N'Sublime Text', N'Windows', N'12341', 123412, N'https://download.sublimetext.com/Sublime%20Text%20Build%203126%20x64%20Setup.exe', 1)
SET IDENTITY_INSERT [dbo].[PROGRAMA] OFF
ALTER TABLE [dbo].[PROGRAMA]  WITH CHECK ADD  CONSTRAINT [FK_PROGRAMA_CATEGORIA] FOREIGN KEY([CODIGOCAT])
REFERENCES [dbo].[CATEGORIA] ([CODCATEGORIA])
GO
ALTER TABLE [dbo].[PROGRAMA] CHECK CONSTRAINT [FK_PROGRAMA_CATEGORIA]
GO
