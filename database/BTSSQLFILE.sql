/*
SQLyog Ultimate v11.11 (64 bit)
MySQL - 5.6.38 : Database - nscommun_BugTrackingSystem
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`nscommun_BugTrackingSystem` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `nscommun_BugTrackingSystem`;

/*Table structure for table `Account` */

DROP TABLE IF EXISTS `Account`;

CREATE TABLE `Account` (
  `Username` char(30) NOT NULL,
  `Password` char(10) NOT NULL,
  `Roles` char(10) NOT NULL,
  `DateOfCreation` varchar(50) DEFAULT NULL,
  `AccountNo` int(10) NOT NULL,
  PRIMARY KEY (`AccountNo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `Account` */

insert  into `Account`(`Username`,`Password`,`Roles`,`DateOfCreation`,`AccountNo`) values ('taha098','taha123','user','11-22-2017 10:42PM',0),('tester','tester123','tester','11-22-2017 10:43PM',1),('asda','asdas','tester',NULL,30),('user1','user1','user','11-24-2017 4:05PM',3),('developer1','developer1','developer','abc',51),('admin','admin123','admin',NULL,20),('ak','ak','user','11-25-2017 7:22AM',6),('x','z','Tester',NULL,8),('asdasd','asdad','admin',NULL,9),('asdasd','asda','user',NULL,10),('asdad','asdad','User',NULL,11),('z','z','User',NULL,2),('c','c','user','11-27-2017 7:26PM',12),('x','x','user','11-27-2017 8:44PM',13),('s','s','user',NULL,17),('d','d','admin',NULL,16),('q','q','admin',NULL,15),('s','','user',NULL,18),('z','z','admin',NULL,19),('developer2','developer1','developer',NULL,50),('x','x','user',NULL,99),('fff','fff','tester',NULL,48),('xa','xa','user','12-01-2017 6:16PM',22),('w','w','user','12-17-2017 1:33PM',23),('example','example','user','12-19-2017 8:54AM',24),('','','user','12-22-2017 4:04PM',25);

/*Table structure for table `Admin` */

DROP TABLE IF EXISTS `Admin`;

CREATE TABLE `Admin` (
  `NAME` char(20) NOT NULL,
  `AccountNo` int(10) NOT NULL,
  `DOB` char(10) NOT NULL,
  `AdminId` varchar(10) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`AccountNo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `Admin` */

insert  into `Admin`(`NAME`,`AccountNo`,`DOB`,`AdminId`,`Email`) values ('aasdas',20,'a','ADM-29','a'),('q',15,'q','ADM-15','q'),('d',16,'d','ADM-16','d'),('z',19,'z','ADM-19','z');

/*Table structure for table `AssignDeveloper` */

DROP TABLE IF EXISTS `AssignDeveloper`;

CREATE TABLE `AssignDeveloper` (
  `AssignedBy` varchar(10) NOT NULL,
  `AssignedTo` varchar(10) NOT NULL,
  `BugId` varchar(10) NOT NULL,
  PRIMARY KEY (`BugId`),
  KEY `AssignedBy` (`AssignedBy`),
  KEY `AssignedTo` (`AssignedTo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `AssignDeveloper` */

insert  into `AssignDeveloper`(`AssignedBy`,`AssignedTo`,`BugId`) values ('asda','asd','0'),('asda','asd','1'),('','1','6'),('ADM-29','DEV-50','24'),('ADM-29','DEV-50','5'),('ADM-29','DEV-50','3'),('Dev','Test1','8'),('Dev-MySql.','Test-33','13'),('Dev-50','Test-33','31'),('ADM-29','DEV-50','4'),('ADM-29','DEV-50','36'),('ADM-29','DEV-51','37'),('ADM-29','DEV-51','38'),('ADM-29','DEV-51','40'),('ADM-29','DEV-50','10'),('ADM-29','DEV-51','42'),('ADM-29','DEV-50','44'),('ADM-29','DEV-51','2');

/*Table structure for table `AssignTester` */

DROP TABLE IF EXISTS `AssignTester`;

CREATE TABLE `AssignTester` (
  `AssignedBy` varchar(10) NOT NULL,
  `AssignedTo` varchar(10) NOT NULL,
  `BugId` int(10) NOT NULL,
  `ProjectFiles` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`BugId`),
  KEY `AssignedBy` (`AssignedBy`),
  KEY `AssignedTo` (`AssignedTo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `AssignTester` */

insert  into `AssignTester`(`AssignedBy`,`AssignedTo`,`BugId`,`ProjectFiles`) values ('Dev-50','TST-1',4,NULL),('Dev-50','TST-1',3,NULL),('Dev-50','TST-1',5,NULL),('Dev-50','TST-48',6,NULL),('DEV-50','TST-1',24,'asdasd'),('Dev-50','Test-33',7,NULL),('DEV-50','TST-1',36,'https://example2.com/files'),('DEV-51','TST-1',38,'http://resolvedReport/file2'),('DEV-51','TST-1',40,'URLFIXED'),('DEV-51','TST-1',37,'URL99'),('DEV-51','TST-1',2,'URL');

/*Table structure for table `Bug_Report` */

DROP TABLE IF EXISTS `Bug_Report`;

CREATE TABLE `Bug_Report` (
  `BugId` int(10) NOT NULL AUTO_INCREMENT,
  `Title` varchar(1000) NOT NULL,
  `Detail` varchar(1000) NOT NULL,
  `Severity` enum('Blocker','Major','Moderate','Low') NOT NULL,
  `Priority` enum('Critical','High','Medium','Low') NOT NULL,
  `ProjectFile` varchar(100) NOT NULL,
  `AddedBy` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`BugId`)
) ENGINE=MyISAM AUTO_INCREMENT=45 DEFAULT CHARSET=latin1;

/*Data for the table `Bug_Report` */

insert  into `Bug_Report`(`BugId`,`Title`,`Detail`,`Severity`,`Priority`,`ProjectFile`,`AddedBy`) values (1,'BugRepot33','gfv','Low','Critical','jhsssasd','USR-12'),(2,'BugRepot18','bbbbb','Low','High','bbbbbbbbbbb','USR-4'),(3,'BugRepot3','asdasdaasdas','Low','Critical','eeeeeeeee','USR-3'),(4,'BugRepot35','TESTING123','Blocker','High','FILES','USR-3'),(5,'BugRepot31','asd','Moderate','Low','asdasd','USR-3'),(6,'BugRepot30','Done','Major','High','ABC','USR-3'),(7,'BugRepot5','wdqw','Blocker','Critical','sdasdas','USR-3'),(8,'BugRepot6','asd','Blocker','Critical','adad','USR-12'),(9,'BugRepot22','check123','Low','Low','check123',NULL),(10,'BugRepot23','check123','Low','Low','check123',NULL),(11,'BugRepot21','asdasd','','','aasdas',NULL),(12,'BugRepot7','asdasd','','','asdasdasdas',NULL),(13,'BugRepot27','asdadadasdas','Major','Critical','asdasdas213','USR-3'),(14,'BugRepot1','','','','','ak'),(15,'BugRepot19','oh it may be complex','','High','http://www.google.com','ak'),(16,'BugRepot4','asd2','','','asd2','ak'),(17,'BugRepot32','pppp','','','ppp',NULL),(18,'BugRepot24','jjjjj','Low','High','asd2sd',NULL),(19,'BugRepot36','yyyy','Low','High','yyyy',NULL),(20,'BugRepot20','dsdsd','Low','High','sdsddd',NULL),(21,'BugRepot2','asdasda','Low','Low','asdsa',NULL),(22,'BugRepot28','asdasdadasdasd','Major','Critical','asdasdas','USR-3'),(23,'BugRepot29','NEWREP','Blocker','Critical','abcasd','USR-3'),(24,'BugRepot14','asdasd','','Low','asdasd',''),(25,'BugRepot15','asdada','','','asda','USR-2'),(26,'BugRepot16','asdasd','','','asdas',''),(27,'BugRepot8','asdasdd','','','asdasd',''),(28,'BugRepot17','asdasda','','','asdasd',''),(29,'BugRepot10','asdasd','','','asdas',''),(30,'BugRepot11','asdasd','','','asdas',''),(31,'BugRepot12','asdasd','','','asdas',''),(32,'BugRepot13','asdasd','Blocker','Low','asdasd',''),(33,'BugRepot34','asdasd','Blocker','Critical','asda',''),(34,'BugRepot25','NEWREP','Major','High','NEWREP','USR-3'),(35,'BugRepot26','NEWREP','Moderate','High','NEWREP','USR-3'),(36,'BugReport99','Bugs','Moderate','High','https://example.com/files','USR-3'),(37,'MyBugReport','Bugs in software','Moderate','Medium','https://example8/files','USR-3'),(38,'MyBugReport2','bugs in software','Major','Medium','https://example10/files','USR-3'),(39,'asdasd','asdasd','Major','High','asdas','USR-23'),(40,'NEW REPORT','abc','Major','Medium','URL1','USR-3'),(41,'BugReport110','bugs','Blocker','Critical','http://www.txt.com','USR-3'),(42,'BugReport1000','Detail1','Moderate','Medium','URL1000','USR-24'),(43,'wpl project','timming 2 .10','Blocker','Critical','http://www.txt2.com','USR-3'),(44,'shayan khan','tayyab gul ','Blocker','Critical','http://www.txt3.com','USR-3');

/*Table structure for table `Developer` */

DROP TABLE IF EXISTS `Developer`;

CREATE TABLE `Developer` (
  `AccountNo` int(10) NOT NULL,
  `DeveloperId` varchar(10) NOT NULL,
  `Name` char(10) NOT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `DOB` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`DeveloperId`),
  KEY `AccountNo` (`AccountNo`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `Developer` */

insert  into `Developer`(`AccountNo`,`DeveloperId`,`Name`,`Email`,`DOB`) values (30,'1','Hamza',NULL,NULL),(51,'DEV-51','aasd','Developer1@gmail','1312'),(50,'DEV-50','Sa','Developer2@gmail','150'),(0,'','Ammar','Ammarsdsddsd@gmail.com','1997'),(0,'3','Ammar1','Ammarsdsddsd@gmails.com','1998');

/*Table structure for table `ReassignDeveloper` */

DROP TABLE IF EXISTS `ReassignDeveloper`;

CREATE TABLE `ReassignDeveloper` (
  `AssignedBy` varchar(10) DEFAULT NULL,
  `AssignTo` varchar(10) DEFAULT NULL,
  `BugId` int(11) DEFAULT NULL,
  `Comment` varchar(100) DEFAULT NULL,
  `ProjectFiles` varchar(100) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `ReassignDeveloper` */

insert  into `ReassignDeveloper`(`AssignedBy`,`AssignTo`,`BugId`,`Comment`,`ProjectFiles`) values ('6','TST-9',0,'as8da',NULL),('Dev-50','TST-1',4,'asdasdsdasdasd','asdasd'),('Dev-50','TST-1',4,'asdasdsdasdasd','asdasd'),('Dev-50','TST-1',4,'asdasdsdasdasdasdasd','asdasd'),('DEV-50','TST-1',36,'Report still have some issues','http://filesisNotOkay/files5');

/*Table structure for table `Reassigned` */

DROP TABLE IF EXISTS `Reassigned`;

CREATE TABLE `Reassigned` (
  `AssignedBy` int(10) NOT NULL,
  `AssignedTo` int(10) NOT NULL,
  KEY `AssignedBy` (`AssignedBy`),
  KEY `AssignedTo` (`AssignedTo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `Reassigned` */

insert  into `Reassigned`(`AssignedBy`,`AssignedTo`) values (50,0),(0,0),(0,0);

/*Table structure for table `Solved_Reports` */

DROP TABLE IF EXISTS `Solved_Reports`;

CREATE TABLE `Solved_Reports` (
  `BugId` int(10) NOT NULL,
  `Solved_By` varchar(10) NOT NULL,
  `Tested_By` varchar(10) NOT NULL,
  `Project_Files` varchar(50) NOT NULL,
  `Comments` varchar(50) NOT NULL,
  PRIMARY KEY (`BugId`),
  KEY `Tested_By` (`Tested_By`),
  KEY `Solved_By` (`Solved_By`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `Solved_Reports` */

insert  into `Solved_Reports`(`BugId`,`Solved_By`,`Tested_By`,`Project_Files`,`Comments`) values (3,'0','0','','this is the comment on the dummy report from me'),(2,'0','0','','this is the comment on the dummy report from QWERT'),(1,'0','0','asdasd','asdasd'),(6,'TST-9','aosda','as8da','as8da'),(5,'Dev-50','TST-1','as','dasdasd'),(38,'DEV-51','TST-1','http://filesisokay/files4','Report is okay');

/*Table structure for table `Status` */

DROP TABLE IF EXISTS `Status`;

CREATE TABLE `Status` (
  `BugId` int(10) NOT NULL,
  `LastDevelopedBy` int(10) DEFAULT NULL,
  `LastTestedBy` int(10) DEFAULT NULL,
  `LastAssignedBy` int(10) DEFAULT NULL,
  `Status` enum('NEW','ASSIGNED','RESOLVED','CLOSED') DEFAULT 'NEW',
  PRIMARY KEY (`BugId`),
  KEY `LastDevelopedBy` (`LastDevelopedBy`),
  KEY `LastTestedBy` (`LastTestedBy`),
  KEY `LastAssignedBy` (`LastAssignedBy`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `Status` */

insert  into `Status`(`BugId`,`LastDevelopedBy`,`LastTestedBy`,`LastAssignedBy`,`Status`) values (1,0,NULL,NULL,'NEW'),(2,NULL,NULL,NULL,'RESOLVED'),(3,NULL,NULL,NULL,'RESOLVED'),(4,NULL,NULL,NULL,'RESOLVED'),(5,NULL,NULL,NULL,'RESOLVED'),(6,NULL,NULL,NULL,'ASSIGNED'),(7,NULL,NULL,NULL,'ASSIGNED'),(8,NULL,NULL,NULL,'ASSIGNED'),(10,NULL,NULL,NULL,'ASSIGNED'),(12,NULL,NULL,NULL,'RESOLVED'),(13,NULL,NULL,NULL,'CLOSED'),(22,NULL,NULL,NULL,'NEW'),(23,NULL,NULL,NULL,'NEW'),(24,NULL,NULL,NULL,'RESOLVED'),(25,NULL,NULL,NULL,'NEW'),(26,NULL,NULL,NULL,'NEW'),(27,NULL,NULL,NULL,'NEW'),(28,NULL,NULL,NULL,'NEW'),(29,NULL,NULL,NULL,'NEW'),(30,NULL,NULL,NULL,'NEW'),(31,NULL,NULL,NULL,'NEW'),(32,NULL,NULL,NULL,'NEW'),(33,NULL,NULL,NULL,'NEW'),(34,NULL,NULL,NULL,'NEW'),(35,NULL,NULL,NULL,'NEW'),(36,NULL,NULL,NULL,'RESOLVED'),(37,NULL,NULL,NULL,'RESOLVED'),(38,NULL,NULL,NULL,'RESOLVED'),(39,NULL,NULL,NULL,'NEW'),(40,NULL,NULL,NULL,'RESOLVED'),(41,NULL,NULL,NULL,'NEW'),(42,NULL,NULL,NULL,'ASSIGNED'),(43,NULL,NULL,NULL,'NEW'),(44,NULL,NULL,NULL,'ASSIGNED');

/*Table structure for table `Tester` */

DROP TABLE IF EXISTS `Tester`;

CREATE TABLE `Tester` (
  `AccountNo` int(10) NOT NULL,
  `TesterId` varchar(10) NOT NULL,
  `NAME` char(10) NOT NULL,
  `DOB` varchar(100) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`TesterId`),
  KEY `AccountNo` (`AccountNo`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

/*Data for the table `Tester` */

insert  into `Tester`(`AccountNo`,`TesterId`,`NAME`,`DOB`,`Email`) values (1,'TST-1','Tester1','1997','zeeshan1234'),(33,'2','Tester2','asdas','asdas'),(48,'TST-48','Tester3',NULL,NULL);

/*Table structure for table `User` */

DROP TABLE IF EXISTS `User`;

CREATE TABLE `User` (
  `Name` char(20) NOT NULL,
  `AccountNo` int(10) NOT NULL,
  `DOB` char(10) NOT NULL,
  `UserId` varchar(10) DEFAULT NULL,
  `Email` varchar(20) DEFAULT NULL,
  KEY `AccountNo` (`AccountNo`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

/*Data for the table `User` */

insert  into `User`(`Name`,`AccountNo`,`DOB`,`UserId`,`Email`) values ('taha',0,'1235',NULL,'sadasd'),('m.zeeshan',1,'2000',NULL,'asda'),('MyProfile',3,'2017','USR-3','asdahbd@hotmail.com'),('ak',123,'1997',NULL,NULL),('asdas',8,'asdas','USR-8','System.Web.UI.WebCon'),('asdas',11,'asdas','USR-10','System.Web.UI.WebCon'),('asdasd',11,'asdasd','USR-11','System.Web.UI.WebCon'),('z',13,'z','USR-2','System.Web.UI.WebCon'),('a',12,'b','USR-12','c'),('asd',23,'adasdas','USR-23','w'),('asdddd',50,'1997','DEV-50','sdsdsdd'),('asaax',22,'xa','USR-22','xa'),('adsasd',23,'adssad','ADM-23','asdas'),('example',24,'2000','USR-24','example@yahoo.com'),('',25,'','USR-25','');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
