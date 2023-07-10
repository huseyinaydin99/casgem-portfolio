USE CasgemPortfolio;



INSERT INTO [dbo].[tbl_service]
           ([SERVICE_TITLE]
           ,[SERVICE_ICON]
           ,[SERVICE_NUMBER]
           ,[SERVICE_CONTENT])
			VALUES ('WEB GELISTIRME', 'TEST', '01', 'LOREM IPSOM');
INSERT INTO [dbo].[tbl_service]
           ([SERVICE_TITLE]
           ,[SERVICE_ICON]
           ,[SERVICE_NUMBER]
           ,[SERVICE_CONTENT])
		   VALUES ('OYUN GELISTIRME', 'TEST', '02', 'LOREM IPSOM');
INSERT INTO [dbo].[tbl_service]
           ([SERVICE_TITLE]
           ,[SERVICE_ICON]
           ,[SERVICE_NUMBER]
           ,[SERVICE_CONTENT])
		   VALUES ('MOBIL PROGRAMLAMA', 'TEST', '03', 'LOREM IPSOM');
INSERT INTO [dbo].[tbl_service]
           ([SERVICE_TITLE]
           ,[SERVICE_ICON]
           ,[SERVICE_NUMBER]
           ,[SERVICE_CONTENT])
		   VALUES ('VERI TABANI YONETIMI', 'TEST', '04', 'LOREM IPSOM');





INSERT INTO [dbo].[tbl_service]
           ([SERVICE_TITLE]
           ,[SERVICE_ICON]
           ,[SERVICE_NUMBER]
           ,[SERVICE_CONTENT])
		   VALUES ('Ahmet', 'ahmet99@gmail.com', 'Selam', 'Merhaba merhaba merhaba');

INSERT INTO [dbo].[tbl_service]
           ([SERVICE_TITLE]
           ,[SERVICE_ICON]
           ,[SERVICE_NUMBER]
           ,[SERVICE_CONTENT])
		   VALUES ('Mustafa', 'mustafa98@gmail.com', 'Merhaba', 'Selam selam selam');





INSERT INTO [dbo].[tbl_feature]
           ([FEATURE_TITLE]
           ,[FEATURE_DESCRIPTION]
           ,[FEATURE_IMAGE_URL])
     VALUES
           ('Baslik1','Aciklama1','C:\\Images1\\image1.jpg');
INSERT INTO [dbo].[tbl_feature]
           ([FEATURE_TITLE]
           ,[FEATURE_DESCRIPTION]
           ,[FEATURE_IMAGE_URL])
     VALUES
           ('Baslik2','Aciklama2','C:\\Images2\\image2.jpg');




INSERT INTO [dbo].[tbl_message]
           ([NAME_SURNAME]
           ,[SENDER_MAIL]
           ,[MESSAGE_SUBJECT]
           ,[CONTENT])
     VALUES
           ('Hasan Aydýn', 'hasanabi97@gmail.com', 'Selamun Aleykum', 'Nasýlsýn bilader?');
INSERT INTO [dbo].[tbl_message]
           ([NAME_SURNAME]
           ,[SENDER_MAIL]
           ,[MESSAGE_SUBJECT]
           ,[CONTENT])
     VALUES
           ('Ziya Aydýn', 'ziyaa87@gmail.com', 'Selamun Aleykum', 'Nasýlsýn bilader?');
INSERT INTO [dbo].[tbl_message]
           ([NAME_SURNAME]
           ,[SENDER_MAIL]
           ,[MESSAGE_SUBJECT]
           ,[CONTENT])
     VALUES
           ('Emine Ucyuz', 'emine88@gmail.com', 'Selamun Aleykum', 'Nasýlsýn bilader?');






INSERT INTO [dbo].[tbl_referance]
           ([NAME_SURNAME]
           ,[EMAIL]
           ,[PHONE_NUMBER])
     VALUES
           ('Mimar Aslan', 'mimaraslan@gmail.com', '05888887766');
INSERT INTO [dbo].[tbl_referance]
           ([NAME_SURNAME]
           ,[EMAIL]
           ,[PHONE_NUMBER])
     VALUES
           ('Zafer Cömert', 'zcomert@gmail.com', '05778881166');
INSERT INTO [dbo].[tbl_referance]
           ([NAME_SURNAME]
           ,[EMAIL]
           ,[PHONE_NUMBER])
     VALUES
           ('Uður Ata', 'aliatabak99@gmail.com', '05448883366');




INSERT INTO [dbo].[tbl_projects]
           ([NAME_]
           ,[PURPOSE]
           ,[DESCRIPTION]
           ,[PROJECT_TYPE])
     VALUES
           ('Çýlgýn Proje', 'Yapay zeka ile ilerlemek', 'Her þey çok güzel olacak.! :D', 'Backend Yazýlým');

INSERT INTO [dbo].[tbl_projects]
           ([NAME_]
           ,[PURPOSE]
           ,[DESCRIPTION]
           ,[PROJECT_TYPE])
     VALUES
           ('Bluesoft Oto Galeri Programý', 'Oto galericilerin ihtiyacýný karþýlamak.', 'Masaüstü program. JavaFX ile yazýldý.', 'Masaüstü Yazýlým');




CREATE TABLE [dbo].[tbl_service](
  SERVICE_ID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
  SERVICE_TITLE NVARCHAR(100) NULL,
  SERVICE_ICON NVARCHAR(100) NULL,
  SERVICE_NUMBER NVARCHAR(50) NULL,
  SERVICE_CONTENT NVARCHAR(1000) NULL
);

CREATE TABLE [dbo].[tbl_service](
  FEATURE_ID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
  FEATURE_TITLE NVARCHAR(100) NULL,
  FEATURE_DESCRIPTION NVARCHAR(1000) NULL,
  FEATURE_IMAGE_URL NVARCHAR(1000) NULL
);

CREATE TABLE [dbo].[tbl_service](
  MESSAGE_ID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
  NAME_SURNAME NVARCHAR(100) NULL,
  SENDER_MAIL NVARCHAR(100) NULL,
  MESSAGE_SUBJECT NVARCHAR(100) NULL,
  CONTENT NVARCHAR(1000) NULL
);

CREATE TABLE [dbo].[tbl_referance]
(
	[REFERANCE_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NAME_SURNAME] NVARCHAR(100) NULL, 
    [EMAIL] NVARCHAR(100) NULL, 
    [PHONE_NUMBER] NVARCHAR(20) NULL
);

CREATE TABLE [dbo].[tbl_projects]
(
	[PROJE_ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [NAME_] NVARCHAR(100) NULL, 
    [PURPOSE] NVARCHAR(100) NULL, 
    [DESCRIPTION] NVARCHAR(1000) NULL, 
    [PROJECT_TYPE] NVARCHAR(100) NULL
);

--DROP TABLE Projects;
--TRUNCATE TABLE TABLE_NAME;

-- MYSQL ICIN > FOR MYSQL >

USE huseyin_aydin_db;
SELECT * FROM huseyin_aydin_db.tbl_servýce;

INSERT INTO `huseyin_aydin_db`.`tbl_servýce` (`SERVICE_TITLE`, `SERVICE_ICON`, `SERVICE_NUMBER`, `SERVICE_CONTENT`) VALUES ('WEB GELISTIRME', 'TEST', '01', 'LOREM IPSOM');
INSERT INTO `huseyin_aydin_db`.`tbl_servýce` (`SERVICE_TITLE`, `SERVICE_ICON`, `SERVICE_NUMBER`, `SERVICE_CONTENT`) VALUES ('OYUN GELISTIRME', 'TEST', '02', 'LOREM IPSOM');
INSERT INTO `huseyin_aydin_db`.`tbl_servýce` (`SERVICE_TITLE`, `SERVICE_ICON`, `SERVICE_NUMBER`, `SERVICE_CONTENT`) VALUES ('MOBIL PROGRAMLAMA', 'TEST', '03', 'LOREM IPSOM');
INSERT INTO `huseyin_aydin_db`.`tbl_servýce` (`SERVICE_TITLE`, `SERVICE_ICON`, `SERVICE_NUMBER`, `SERVICE_CONTENT`) VALUES ('VERI TABANI YONETIMI', 'TEST', '04', 'LOREM IPSOM');
SELECT * FROM huseyin_aydin_db.tbl_servýce WHERE SERVICE_ID = 4;
SELECT * FROM huseyin_aydin_db.tbl_servýce WHERE SERVICE_ID = 4 OR SERVICE_ID = 2;
SELECT * FROM huseyin_aydin_db.tbl_servýce WHERE SERVICE_ID >= 1;
SELECT * FROM huseyin_aydin_db.tbl_servýce WHERE SERVICE_ID = 4 AND SERVICE_NUMBER = '03';

UPDATE huseyin_aydin_db.tbl_servýce SET SERVICE_ICON = 'HOME ICON' WHERE SERVICE_ID = '1';
SELECT * FROM huseyin_aydin_db.tbl_servýce WHERE SERVICE_ID = 1;
SELECT * FROM huseyin_aydin_db.tbl_servýce WHERE SERVICE_TITLE LIKE '%A%';
SELECT * FROM huseyin_aydin_db.tbl_servýce WHERE SERVICE_TITLE NOT LIKE '%A%';
SELECT * FROM huseyin_aydin_db.tbl_servýce WHERE SERVICE_TITLE NOT LIKE '%A';
SELECT * FROM huseyin_aydin_db.tbl_servýce WHERE SERVICE_TITLE NOT LIKE '%A%' AND SERVICE_ICON LIKE '%R%';

-- AGGREGATE 
SELECT COUNT(*) FROM huseyin_aydin_db.tbl_servýce;
SELECT COUNT(*) FROM huseyin_aydin_db.tbl_servýce WHERE SERVICE_TITLE LIKE '%A';


DELETE FROM huseyin_aydin_db.tbl_servýce WHERE SERVICE_ID = 800;
TRUNCATE TABLE huseyin_aydin_db.tbl_servýce;



-- CREATE TABLE
CREATE TABLE `huseyin_aydin_db`.`TBL_FEATURE` (
  `FEATURE_ID` INT NOT NULL AUTO_INCREMENT,
  `FEATURE_TITLE` NVARCHAR(100) NULL,
  `FEATURE_DESCRIPTION` NVARCHAR(1000) NULL,
  `FEATURE_IMAGE_URL` NVARCHAR(1000) NULL,
  PRIMARY KEY (`FEATURE_ID`)
);

CREATE TABLE `huseyin_aydin_db`.`tbl_message` (
  `MESSAGE_ID` INT NOT NULL AUTO_INCREMENT,
  `NAME_SURNAME` NVARCHAR(100) NULL,
  `SENDER_MAIL` NVARCHAR(100) NULL,
  `MESSAGE_SUBJECT` NVARCHAR(100) NULL,
  `CONTENT` NVARCHAR(1000) NULL,
  PRIMARY KEY (`MESSAGE_ID`));
  
INSERT INTO `huseyin_aydin_db`.`tbl_message` (`NAME_SURNAME`, `SENDER_MAIL`, `MESSAGE_SUBJECT`, `CONTENT`) VALUES ('Ahmet', 'zimzim@gmail.com', 'Selam', 'Merhaba merhaba merhaba');
INSERT INTO `huseyin_aydin_db`.`tbl_message` (`NAME_SURNAME`, `SENDER_MAIL`, `MESSAGE_SUBJECT`, `CONTENT`) VALUES ('Mustafa', 'amet99@gmail.com', 'Merhaba', 'Selam selam selam');




