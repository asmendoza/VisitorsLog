CREATE DATABASE  IF NOT EXISTS `visitors` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `visitors`;
-- MySQL dump 10.13  Distrib 8.0.12, for Win64 (x86_64)
--
-- Host: localhost    Database: visitors
-- ------------------------------------------------------
-- Server version	8.0.12

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
 SET NAMES utf8 ;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Temporary view structure for view `borrowed_keys`
--

DROP TABLE IF EXISTS `borrowed_keys`;
/*!50001 DROP VIEW IF EXISTS `borrowed_keys`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `borrowed_keys` AS SELECT 
 1 AS `id`,
 1 AS `key_desc`,
 1 AS `borrower_name`,
 1 AS `datetime_borrowed`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `car_visitors`
--

DROP TABLE IF EXISTS `car_visitors`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `car_visitors` (
  `carvisits_id` int(11) NOT NULL AUTO_INCREMENT,
  `car_plateno` varchar(10) NOT NULL,
  `car_drivername` varchar(50) NOT NULL,
  `car_driverID` varchar(50) DEFAULT NULL,
  `car_visitdatetime` datetime NOT NULL,
  `car_processedby` varchar(45) NOT NULL,
  `car_processedin` varchar(45) NOT NULL,
  `car_outdatetime` datetime DEFAULT NULL,
  PRIMARY KEY (`carvisits_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `car_visitors`
--

LOCK TABLES `car_visitors` WRITE;
/*!40000 ALTER TABLE `car_visitors` DISABLE KEYS */;
/*!40000 ALTER TABLE `car_visitors` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `current_events`
--

DROP TABLE IF EXISTS `current_events`;
/*!50001 DROP VIEW IF EXISTS `current_events`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `current_events` AS SELECT 
 1 AS `ID`,
 1 AS `Event`,
 1 AS `Date_From`,
 1 AS `Date_To`,
 1 AS `Time_From`,
 1 AS `Time_To`,
 1 AS `Host`,
 1 AS `Contact_Person`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `employees`
--

DROP TABLE IF EXISTS `employees`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `employees` (
  `employee_ID` varchar(15) NOT NULL,
  `employee_name` varchar(50) NOT NULL,
  `employee_dept` varchar(100) NOT NULL,
  `employee_rfid` varchar(100) DEFAULT NULL,
  `employee_designation` varchar(100) DEFAULT NULL,
  `updated_by` varchar(45) NOT NULL,
  `updated_datetime` datetime NOT NULL,
  `employee_remarks` longtext,
  `employee_contractor` tinyint(4) DEFAULT NULL,
  `employee_task` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`employee_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employees`
--

LOCK TABLES `employees` WRITE;
/*!40000 ALTER TABLE `employees` DISABLE KEYS */;
INSERT INTO `employees` VALUES ('ASM002201','ARIS GAIL MENDOZA','College of Computer Studies',NULL,NULL,'','0000-00-00 00:00:00',NULL,0,NULL);
/*!40000 ALTER TABLE `employees` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `events`
--

DROP TABLE IF EXISTS `events`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `events` (
  `eventid` int(11) NOT NULL AUTO_INCREMENT,
  `event_name` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `event_date_from` date NOT NULL,
  `event_date_to` date NOT NULL,
  `event_time_from` time NOT NULL,
  `event_time_to` time NOT NULL,
  `event_host` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `contact_person` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `processed_by` varchar(50) COLLATE utf8_general_mysql500_ci NOT NULL,
  `processed_datetime` datetime DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`eventid`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `events`
--

LOCK TABLES `events` WRITE;
/*!40000 ALTER TABLE `events` DISABLE KEYS */;
INSERT INTO `events` VALUES (1,'Flag Ceremony','2018-09-17','2018-09-17','07:00:00','08:00:00','Office of the Student Affairs','OSA Officers','','2018-09-16 13:55:17'),(2,'Ngayon Na!','2018-09-18','2018-09-18','12:00:00','17:00:00','College of Computer Studies','Aris Gail Mendoza','','2018-09-18 11:37:28'),(3,'Another one!','2018-09-18','2018-09-18','13:00:00','18:00:00','College of Education, Arts and Sciences','Gail See','','2018-09-18 11:39:22'),(4,'event of aris','2018-09-24','2018-09-24','17:00:00','18:00:00','College of Computer Studies','aris gail mendoza','','2018-09-24 15:10:08'),(5,'meeting','2018-09-24','2018-09-24','19:00:00','20:00:00','College of Nursing','JK Rowling','','2018-09-24 17:54:26');
/*!40000 ALTER TABLE `events` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gates`
--

DROP TABLE IF EXISTS `gates`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `gates` (
  `computer_name` varchar(50) NOT NULL,
  `gate` int(11) NOT NULL,
  PRIMARY KEY (`computer_name`,`gate`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gates`
--

LOCK TABLES `gates` WRITE;
/*!40000 ALTER TABLE `gates` DISABLE KEYS */;
INSERT INTO `gates` VALUES ('DESKTOP-E059K0L',1);
/*!40000 ALTER TABLE `gates` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `hosts`
--

DROP TABLE IF EXISTS `hosts`;
/*!50001 DROP VIEW IF EXISTS `hosts`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `hosts` AS SELECT 
 1 AS `department`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `in_out`
--

DROP TABLE IF EXISTS `in_out`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `in_out` (
  `txn_id` int(11) NOT NULL AUTO_INCREMENT,
  `mode` varchar(3) DEFAULT NULL,
  `id_no` varchar(15) NOT NULL,
  `mode_time` datetime DEFAULT NULL,
  `gate` int(11) NOT NULL,
  `usr` varchar(45) NOT NULL,
  `time_in` datetime DEFAULT NULL,
  `time_out` datetime DEFAULT NULL,
  PRIMARY KEY (`txn_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `in_out`
--

LOCK TABLES `in_out` WRITE;
/*!40000 ALTER TABLE `in_out` DISABLE KEYS */;
INSERT INTO `in_out` VALUES (1,'IN','ASM002201','2018-10-20 11:59:39',1,'aris',NULL,NULL),(2,'IN','03169136','2018-10-20 11:59:49',1,'aris',NULL,NULL),(3,'IN','ASM002201','2018-10-20 12:00:01',1,'aris',NULL,NULL);
/*!40000 ALTER TABLE `in_out` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `key_borrowing`
--

DROP TABLE IF EXISTS `key_borrowing`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `key_borrowing` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `key_id` int(11) NOT NULL,
  `key_desc` varchar(50) NOT NULL,
  `borrower_id` varchar(15) NOT NULL,
  `borrower_name` varchar(50) NOT NULL,
  `datetime_borrowed` datetime NOT NULL,
  `datetime_returned` datetime DEFAULT NULL,
  `remarks` longtext,
  `processed_by` varchar(45) DEFAULT NULL,
  `processed_gate` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `key_borrowing`
--

LOCK TABLES `key_borrowing` WRITE;
/*!40000 ALTER TABLE `key_borrowing` DISABLE KEYS */;
/*!40000 ALTER TABLE `key_borrowing` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `key_main`
--

DROP TABLE IF EXISTS `key_main`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `key_main` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `key_desc` varchar(50) NOT NULL,
  `key_rfid` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `key_main`
--

LOCK TABLES `key_main` WRITE;
/*!40000 ALTER TABLE `key_main` DISABLE KEYS */;
INSERT INTO `key_main` VALUES (1,'Registrar','1'),(2,'Cashier','2');
/*!40000 ALTER TABLE `key_main` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `person`
--

DROP TABLE IF EXISTS `person`;
/*!50001 DROP VIEW IF EXISTS `person`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `person` AS SELECT 
 1 AS `person_ID`,
 1 AS `person_name`,
 1 AS `person_dept`,
 1 AS `person_designation`,
 1 AS `person_rfid`,
 1 AS `person_remarks`,
 1 AS `person_task`,
 1 AS `person_type`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `person_in`
--

DROP TABLE IF EXISTS `person_in`;
/*!50001 DROP VIEW IF EXISTS `person_in`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `person_in` AS SELECT 
 1 AS `txn_id`,
 1 AS `id_no`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `persons_to_visit`
--

DROP TABLE IF EXISTS `persons_to_visit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `persons_to_visit` (
  `department` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `person_name` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  KEY `department` (`department`),
  KEY `person_name` (`person_name`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `persons_to_visit`
--

LOCK TABLES `persons_to_visit` WRITE;
/*!40000 ALTER TABLE `persons_to_visit` DISABLE KEYS */;
INSERT INTO `persons_to_visit` VALUES ('College of Computer Studies','Roselie B. Alday'),('College of Computer Studies','Gemma Maniebo'),('College of Education, Arts and Sciences','Arnie Christian Villena'),('College of Nursing','Cecilia Pring');
/*!40000 ALTER TABLE `persons_to_visit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `reasons_of_visit`
--

DROP TABLE IF EXISTS `reasons_of_visit`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `reasons_of_visit` (
  `reason` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  PRIMARY KEY (`reason`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `reasons_of_visit`
--

LOCK TABLES `reasons_of_visit` WRITE;
/*!40000 ALTER TABLE `reasons_of_visit` DISABLE KEYS */;
INSERT INTO `reasons_of_visit` VALUES ('CLEARANCE'),('CONSULTATION'),('EMPLOYMENT APPLICATION'),('ENROLMENT'),('ENTRANCE EXAM'),('INQUIRY'),('INTERVIEW'),('MEETING'),('RESEARCH'),('TUITION PAYMENT');
/*!40000 ALTER TABLE `reasons_of_visit` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rfid`
--

DROP TABLE IF EXISTS `rfid`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `rfid` (
  `rfid_no` int(11) NOT NULL AUTO_INCREMENT,
  `rfid_sn` varchar(100) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `in_use` tinyint(1) NOT NULL,
  PRIMARY KEY (`rfid_no`),
  UNIQUE KEY `rfid_sn_in` (`rfid_sn`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rfid`
--

LOCK TABLES `rfid` WRITE;
/*!40000 ALTER TABLE `rfid` DISABLE KEYS */;
INSERT INTO `rfid` VALUES (1,'1234567890',0),(2,'0987654321',0),(3,'9876543210',0);
/*!40000 ALTER TABLE `rfid` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `rpt_carvisitors`
--

DROP TABLE IF EXISTS `rpt_carvisitors`;
/*!50001 DROP VIEW IF EXISTS `rpt_carvisitors`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `rpt_carvisitors` AS SELECT 
 1 AS `car_visitdatetime`,
 1 AS `car_plateno`,
 1 AS `car_drivername`,
 1 AS `car_outdatetime`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `rpt_contractual_auto`
--

DROP TABLE IF EXISTS `rpt_contractual_auto`;
/*!50001 DROP VIEW IF EXISTS `rpt_contractual_auto`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `rpt_contractual_auto` AS SELECT 
 1 AS `id_no`,
 1 AS `fullname`,
 1 AS `person_type`,
 1 AS `time_in`,
 1 AS `time_out`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `rpt_contractual_mode`
--

DROP TABLE IF EXISTS `rpt_contractual_mode`;
/*!50001 DROP VIEW IF EXISTS `rpt_contractual_mode`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `rpt_contractual_mode` AS SELECT 
 1 AS `id_no`,
 1 AS `fullname`,
 1 AS `person_type`,
 1 AS `mode`,
 1 AS `mode_date`,
 1 AS `mode_time`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `rpt_keycontrol`
--

DROP TABLE IF EXISTS `rpt_keycontrol`;
/*!50001 DROP VIEW IF EXISTS `rpt_keycontrol`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `rpt_keycontrol` AS SELECT 
 1 AS `datetime_borrowed`,
 1 AS `datetime_returned`,
 1 AS `key_desc`,
 1 AS `borrower_name`,
 1 AS `remarks`,
 1 AS `processed_by`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `rpt_studentviolation`
--

DROP TABLE IF EXISTS `rpt_studentviolation`;
/*!50001 DROP VIEW IF EXISTS `rpt_studentviolation`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `rpt_studentviolation` AS SELECT 
 1 AS `violation_datetime`,
 1 AS `id_no`,
 1 AS `fullname`,
 1 AS `violation`,
 1 AS `department`,
 1 AS `course`,
 1 AS `processed`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `rpt_visitorlogs`
--

DROP TABLE IF EXISTS `rpt_visitorlogs`;
/*!50001 DROP VIEW IF EXISTS `rpt_visitorlogs`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `rpt_visitorlogs` AS SELECT 
 1 AS `date_visit`,
 1 AS `FullName`,
 1 AS `address`,
 1 AS `company`,
 1 AS `department`,
 1 AS `person_to_visit`,
 1 AS `reason_to_visit`,
 1 AS `PassNo`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `student_violations`
--

DROP TABLE IF EXISTS `student_violations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `student_violations` (
  `txn_id` int(11) NOT NULL AUTO_INCREMENT,
  `violation_datetime` datetime NOT NULL,
  `id_no` varchar(15) NOT NULL,
  `violation` varchar(45) NOT NULL,
  `gate` int(11) NOT NULL,
  `usr` varchar(45) NOT NULL,
  `is_settled` tinyint(4) NOT NULL DEFAULT '0',
  `settled_datetime` datetime DEFAULT NULL,
  `settled_usr` varchar(45) DEFAULT NULL,
  `settled_gate` int(11) DEFAULT NULL,
  PRIMARY KEY (`txn_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `student_violations`
--

LOCK TABLES `student_violations` WRITE;
/*!40000 ALTER TABLE `student_violations` DISABLE KEYS */;
/*!40000 ALTER TABLE `student_violations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `students`
--

DROP TABLE IF EXISTS `students`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `students` (
  `student_id` varchar(15) NOT NULL,
  `student_name` varchar(50) NOT NULL,
  `student_dept` varchar(100) NOT NULL,
  `student_rfid` varchar(100) DEFAULT NULL,
  `student_designation` varchar(100) NOT NULL,
  `updated_by` varchar(45) NOT NULL,
  `updated_datetime` datetime NOT NULL,
  `student_remarks` longtext,
  PRIMARY KEY (`student_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `students`
--

LOCK TABLES `students` WRITE;
/*!40000 ALTER TABLE `students` DISABLE KEYS */;
INSERT INTO `students` VALUES ('03169136','ARIS GAIL S. MENDOZA','College of Computer Studies',NULL,'','','0000-00-00 00:00:00',NULL);
/*!40000 ALTER TABLE `students` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `v_users`
--

DROP TABLE IF EXISTS `v_users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `v_users` (
  `username` varchar(25) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL COMMENT 'user name of user',
  `fullname` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL COMMENT 'full name of user',
  `password` varchar(25) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL COMMENT 'password of user',
  `isadmin` tinyint(1) NOT NULL COMMENT 'is user an admin?',
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `v_users`
--

LOCK TABLES `v_users` WRITE;
/*!40000 ALTER TABLE `v_users` DISABLE KEYS */;
INSERT INTO `v_users` VALUES ('admin','Moderator','admin',1),('aris','Aris Gail Mendoza','aris',0),('gail','Gail See','gail',1);
/*!40000 ALTER TABLE `v_users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `violations`
--

DROP TABLE IF EXISTS `violations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `violations` (
  `violation_id` int(11) NOT NULL,
  `violation_name` varchar(45) NOT NULL,
  PRIMARY KEY (`violation_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `violations`
--

LOCK TABLES `violations` WRITE;
/*!40000 ALTER TABLE `violations` DISABLE KEYS */;
/*!40000 ALTER TABLE `violations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `visitor`
--

DROP TABLE IF EXISTS `visitor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `visitor` (
  `visitorNo` int(11) NOT NULL AUTO_INCREMENT,
  `date_visit` date NOT NULL,
  `firstName` varchar(25) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `lastName` varchar(25) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `address` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `company` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci DEFAULT NULL,
  `person_to_visit` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `department` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci DEFAULT NULL,
  `reason_to_visit` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `id_type` varchar(25) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci DEFAULT NULL,
  `id_no` varchar(25) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci DEFAULT NULL,
  `rfid_no` int(11) DEFAULT NULL,
  `event_id` int(11) DEFAULT NULL,
  `logINdatetime` datetime DEFAULT NULL,
  `logOUTdatetime` datetime DEFAULT NULL,
  `photo` longblob,
  `gate_processed` varchar(20) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  `processed_by` varchar(25) CHARACTER SET utf8 COLLATE utf8_general_mysql500_ci NOT NULL,
  PRIMARY KEY (`visitorNo`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_general_mysql500_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `visitor`
--

LOCK TABLES `visitor` WRITE;
/*!40000 ALTER TABLE `visitor` DISABLE KEYS */;
INSERT INTO `visitor` VALUES (1,'2018-09-09','ARIS GAIL','MENDOZA','SAN JOSE, BATANGAS','ATENEO DE MANILA UNIVERSITY','Roselie B. Alday','College of Computer Studies','CONSULTATION','SSS','03169136',1,NULL,'2018-09-09 00:35:58','2018-09-09 04:59:24',_binary 'ÿ\Øÿ\à\0JFIF\0\0`\0`\0\0ÿ\Û\0C\0		\n\r\Z\Z $.\' \",#(7),01444\'9=82<.342ÿ\Û\0C			\r\r2!!22222222222222222222222222222222222222222222222222ÿÀ\0\à€\"\0ÿ\Ä\0\0\0\0\0\0\0\0\0\0\0	\nÿ\Ä\0µ\0\0\0}\0!1AQa\"q2‘¡#B±ÁR\Ñð$3br‚	\n\Z%&\'()*456789:CDEFGHIJSTUVWXYZcdefghijstuvwxyzƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹º\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\á\â\ã\ä\å\æ\ç\è\é\êñòóôõö÷øùúÿ\Ä\0\0\0\0\0\0\0\0	\nÿ\Ä\0µ\0\0w\0!1AQaq\"2B‘¡±Á	#3Rðbr\Ñ\n$4\á%ñ\Z&\'()*56789:CDEFGHIJSTUVWXYZcdefghijstuvwxyz‚ƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹º\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\â\ã\ä\å\æ\ç\è\é\êòóôõö÷øùúÿ\Ú\0\0\0?\0ùþŠ( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( ÿ\Ù','DevPC','admin'),(2,'2018-09-09','ARIS GAIL','MENDOZA','SAN JOSE, BATANGAS','LPU-BATANGAS','Arnie Christian Villena','College of Education, Arts and Sciences','INQUIRY','SSS','03169136',3,NULL,'2018-09-09 10:26:17','2018-09-09 10:29:55',_binary 'ÿ\Øÿ\à\0JFIF\0\0`\0`\0\0ÿ\Û\0C\0		\n\r\Z\Z $.\' \",#(7),01444\'9=82<.342ÿ\Û\0C			\r\r2!!22222222222222222222222222222222222222222222222222ÿÀ\0\à€\"\0ÿ\Ä\0\0\0\0\0\0\0\0\0\0\0	\nÿ\Ä\0µ\0\0\0}\0!1AQa\"q2‘¡#B±ÁR\Ñð$3br‚	\n\Z%&\'()*456789:CDEFGHIJSTUVWXYZcdefghijstuvwxyzƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹º\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\á\â\ã\ä\å\æ\ç\è\é\êñòóôõö÷øùúÿ\Ä\0\0\0\0\0\0\0\0	\nÿ\Ä\0µ\0\0w\0!1AQaq\"2B‘¡±Á	#3Rðbr\Ñ\n$4\á%ñ\Z&\'()*56789:CDEFGHIJSTUVWXYZcdefghijstuvwxyz‚ƒ„…†‡ˆ‰Š’“”•–—˜™š¢£¤¥¦§¨©ª²³´µ¶·¸¹º\Â\Ã\Ä\Å\Æ\Ç\È\É\Ê\Ò\Ó\Ô\Õ\Ö\×\Ø\Ù\Ú\â\ã\ä\å\æ\ç\è\é\êòóôõö÷øùúÿ\Ú\0\0\0?\0ùþŠ( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( Š( ÿ\Ù','DevPC','admin'),(3,'0001-01-01','Aris Gail','Mendoza','San Jose, Batangas','AdMu','Aris Gail Mendoza','College of Computer Studies','Ngayon Na!',NULL,NULL,NULL,2,NULL,NULL,NULL,'DESKTOP-E059K0L',''),(4,'2018-09-18','Aris Gail','Mendoza','SJ','KK','Gail See','College of Education, Arts and Sciences','Another one!',NULL,NULL,NULL,3,NULL,NULL,NULL,'DESKTOP-E059K0L',''),(5,'2018-09-24','ARIS GAIL','MENDOZA','LOYOLA HEIGHTS QUEZON CITY','ATENEO DE MANILA UNIVERSITY','aris gail mendoza','College of Computer Studies','event of aris',NULL,NULL,NULL,4,NULL,NULL,NULL,'1',''),(6,'2018-09-24','GAIL ','SEE','ALANGILAN, BATANGAS CITY','BATANGAS STATE UNIVERSITY','aris gail mendoza','College of Computer Studies','event of aris',NULL,NULL,NULL,4,NULL,NULL,NULL,'1',''),(7,'2018-09-24','AUBREY','SEE','ANONAS, QUEZON CITY','TECHNOLOGICAL INSTITUTE OF THE PHILIPPINES','aris gail mendoza','College of Computer Studies','event of aris',NULL,NULL,NULL,4,NULL,NULL,NULL,'1',''),(8,'2018-09-24','ANGELIKA','SEE','IBAAN, BATANGAS','HYPERMARKET','aris gail mendoza','College of Computer Studies','event of aris',NULL,NULL,NULL,4,NULL,NULL,NULL,'DESKTOP-E059K0L',''),(9,'2018-09-24','Aris','Mendoza','san jose batangas','lpu','JK Rowling','College of Nursing','meeting',NULL,NULL,NULL,5,NULL,NULL,NULL,'DESKTOP-E059K0L',''),(10,'2018-09-24','gail','see','qc','ateneo','JK Rowling','College of Nursing','meeting',NULL,NULL,NULL,5,NULL,NULL,NULL,'1',''),(11,'2018-09-24','gilbert','ylagan','qc','montessori','JK Rowling','College of Nursing','meeting',NULL,NULL,NULL,5,NULL,NULL,NULL,'1','');
/*!40000 ALTER TABLE `visitor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `visitors_count`
--

DROP TABLE IF EXISTS `visitors_count`;
/*!50001 DROP VIEW IF EXISTS `visitors_count`*/;
SET @saved_cs_client     = @@character_set_client;
SET character_set_client = utf8mb4;
/*!50001 CREATE VIEW `visitors_count` AS SELECT 
 1 AS `VisitorsInside`,
 1 AS `VisitorsExpected`,
 1 AS `VisitorsVisited`*/;
SET character_set_client = @saved_cs_client;

--
-- Dumping events for database 'visitors'
--

--
-- Dumping routines for database 'visitors'
--

--
-- Final view structure for view `borrowed_keys`
--

/*!50001 DROP VIEW IF EXISTS `borrowed_keys`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `borrowed_keys` AS select `key_borrowing`.`id` AS `id`,`key_borrowing`.`key_desc` AS `key_desc`,`key_borrowing`.`borrower_name` AS `borrower_name`,`key_borrowing`.`datetime_borrowed` AS `datetime_borrowed` from `key_borrowing` where isnull(`key_borrowing`.`datetime_returned`) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `current_events`
--

/*!50001 DROP VIEW IF EXISTS `current_events`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `current_events` AS select `events`.`eventid` AS `ID`,`events`.`event_name` AS `Event`,`events`.`event_date_from` AS `Date_From`,`events`.`event_date_to` AS `Date_To`,`events`.`event_time_from` AS `Time_From`,`events`.`event_time_to` AS `Time_To`,`events`.`event_host` AS `Host`,`events`.`contact_person` AS `Contact_Person` from `events` where ((`events`.`event_date_from` >= curdate()) or (`events`.`event_date_to` >= curdate())) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `hosts`
--

/*!50001 DROP VIEW IF EXISTS `hosts`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `hosts` AS select distinct `persons_to_visit`.`department` AS `department` from `persons_to_visit` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `person`
--

/*!50001 DROP VIEW IF EXISTS `person`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `person` AS select `employees`.`employee_ID` AS `person_ID`,`employees`.`employee_name` AS `person_name`,`employees`.`employee_dept` AS `person_dept`,if((`employees`.`employee_contractor` = 0),if(isnull(`employees`.`employee_designation`),'',`employees`.`employee_designation`),'contractual') AS `person_designation`,`employees`.`employee_rfid` AS `person_rfid`,`employees`.`employee_remarks` AS `person_remarks`,if((`employees`.`employee_contractor` = 0),'regular',`employees`.`employee_task`) AS `person_task`,if((`employees`.`employee_contractor` = 0),'employee','contractual') AS `person_type` from `employees` union select `students`.`student_id` AS `person_ID`,`students`.`student_name` AS `person_name`,`students`.`student_dept` AS `person_dept`,if(isnull(`students`.`student_designation`),'',`students`.`student_designation`) AS `person_designation`,`students`.`student_rfid` AS `person_rfid`,`students`.`student_remarks` AS `person_remarks`,'student' AS `person_task`,'student' AS `person_type` from `students` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `person_in`
--

/*!50001 DROP VIEW IF EXISTS `person_in`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `person_in` AS select `in_out`.`txn_id` AS `txn_id`,`in_out`.`id_no` AS `id_no` from `in_out` where ((`in_out`.`time_in` is not null) and isnull(`in_out`.`time_out`)) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `rpt_carvisitors`
--

/*!50001 DROP VIEW IF EXISTS `rpt_carvisitors`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `rpt_carvisitors` AS select `car_visitors`.`car_visitdatetime` AS `car_visitdatetime`,`car_visitors`.`car_plateno` AS `car_plateno`,`car_visitors`.`car_drivername` AS `car_drivername`,`car_visitors`.`car_outdatetime` AS `car_outdatetime` from `car_visitors` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `rpt_contractual_auto`
--

/*!50001 DROP VIEW IF EXISTS `rpt_contractual_auto`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `rpt_contractual_auto` AS select `in_out`.`id_no` AS `id_no`,(select `person`.`person_name` from `person` where (`person`.`person_ID` = `in_out`.`id_no`)) AS `fullname`,(select `person`.`person_type` from `person` where (`person`.`person_ID` = `in_out`.`id_no`)) AS `person_type`,`in_out`.`time_in` AS `time_in`,`in_out`.`time_out` AS `time_out` from `in_out` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `rpt_contractual_mode`
--

/*!50001 DROP VIEW IF EXISTS `rpt_contractual_mode`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `rpt_contractual_mode` AS select `in_out`.`id_no` AS `id_no`,(select `person`.`person_name` from `person` where (`person`.`person_ID` = `in_out`.`id_no`)) AS `fullname`,(select `person`.`person_type` from `person` where (`person`.`person_ID` = `in_out`.`id_no`)) AS `person_type`,`in_out`.`mode` AS `mode`,date_format(`in_out`.`mode_time`,'%Y-%m-%d') AS `mode_date`,`in_out`.`mode_time` AS `mode_time` from `in_out` order by `in_out`.`id_no`,`in_out`.`mode_time` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `rpt_keycontrol`
--

/*!50001 DROP VIEW IF EXISTS `rpt_keycontrol`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `rpt_keycontrol` AS select `key_borrowing`.`datetime_borrowed` AS `datetime_borrowed`,if(isnull(`key_borrowing`.`datetime_returned`),'',`key_borrowing`.`datetime_returned`) AS `datetime_returned`,`key_borrowing`.`key_desc` AS `key_desc`,`key_borrowing`.`borrower_name` AS `borrower_name`,`key_borrowing`.`remarks` AS `remarks`,`key_borrowing`.`processed_by` AS `processed_by` from `key_borrowing` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `rpt_studentviolation`
--

/*!50001 DROP VIEW IF EXISTS `rpt_studentviolation`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `rpt_studentviolation` AS select `student_violations`.`violation_datetime` AS `violation_datetime`,`student_violations`.`id_no` AS `id_no`,(select `person`.`person_name` from `person` where (`person`.`person_ID` = `student_violations`.`id_no`)) AS `fullname`,`student_violations`.`violation` AS `violation`,(select `person`.`person_dept` from `person` where (`person`.`person_ID` = `student_violations`.`id_no`)) AS `department`,(select `person`.`person_designation` from `person` where (`person`.`person_ID` = `student_violations`.`id_no`)) AS `course`,concat('Gate: ',`student_violations`.`gate`,'; Processed: ',`student_violations`.`usr`) AS `processed` from `student_violations` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `rpt_visitorlogs`
--

/*!50001 DROP VIEW IF EXISTS `rpt_visitorlogs`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `rpt_visitorlogs` AS select `visitor`.`date_visit` AS `date_visit`,concat(`visitor`.`firstName`,' ',`visitor`.`lastName`) AS `FullName`,`visitor`.`address` AS `address`,`visitor`.`company` AS `company`,`visitor`.`department` AS `department`,`visitor`.`person_to_visit` AS `person_to_visit`,`visitor`.`reason_to_visit` AS `reason_to_visit`,if(isnull(`visitor`.`rfid_no`),'EVENT REASON',`visitor`.`rfid_no`) AS `PassNo` from `visitor` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `visitors_count`
--

/*!50001 DROP VIEW IF EXISTS `visitors_count`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`root`@`localhost` SQL SECURITY DEFINER */
/*!50001 VIEW `visitors_count` AS select (select count(`visitor`.`visitorNo`) from `visitor` where ((`visitor`.`date_visit` = curdate()) and (`visitor`.`logINdatetime` is not null) and isnull(`visitor`.`logOUTdatetime`))) AS `VisitorsInside`,(select count(`visitor`.`visitorNo`) from `visitor` where ((`visitor`.`date_visit` = curdate()) and isnull(`visitor`.`logINdatetime`) and isnull(`visitor`.`logOUTdatetime`))) AS `VisitorsExpected`,(select count(`visitor`.`visitorNo`) from `visitor` where ((`visitor`.`date_visit` = curdate()) and (`visitor`.`logINdatetime` is not null) and (`visitor`.`logOUTdatetime` is not null))) AS `VisitorsVisited` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-11-09 21:16:52
