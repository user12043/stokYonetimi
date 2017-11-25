/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.1601)
    Source Database Engine Edition : Microsoft SQL Server Enterprise Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2016
    Target Database Engine Edition : Microsoft SQL Server Enterprise Edition
    Target Database Engine Type : Standalone SQL Server
*/

USE [stokyonetimi]
GO

USE [stokyonetimi]
GO

/****** Object:  Sequence [dbo].[SEQ_musteriler_musteriNo]    Script Date: 25.11.2017 12:02:38 ******/
CREATE SEQUENCE [dbo].[SEQ_musteriler_musteriNo] 
 AS [int]
 START WITH 1000
 INCREMENT BY 1
 MINVALUE 1000
 MAXVALUE 2147483647
 CACHE 
GO

/****** Object:  Sequence [dbo].[SEQ_personeller_sicilNo]    Script Date: 25.11.2017 12:03:57 ******/
CREATE SEQUENCE [dbo].[SEQ_personeller_sicilNo] 
 AS [int]
 START WITH 1000
 INCREMENT BY 1
 MINVALUE 1000
 MAXVALUE 2147483647
 CACHE 
GO
