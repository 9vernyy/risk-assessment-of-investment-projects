CREATE DATABASE  IF NOT EXISTS `proinvestdb` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `proinvestdb`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: localhost    Database: proinvestdb
-- ------------------------------------------------------
-- Server version	5.7.11-enterprise-commercial-advanced-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `projects`
--

DROP TABLE IF EXISTS `projects`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `projects` (
  `projId` int(11) NOT NULL AUTO_INCREMENT,
  `userId` int(11) NOT NULL,
  `projName` varchar(45) NOT NULL,
  `projAuthor` varchar(45) NOT NULL,
  `projInvest` varchar(45) NOT NULL,
  `projDiscRate` varchar(45) NOT NULL,
  `incFirstY` varchar(45) NOT NULL,
  `incSecY` varchar(45) NOT NULL,
  `incThirdY` varchar(45) NOT NULL,
  `incFourthY` varchar(45) NOT NULL,
  `incFithY` varchar(45) NOT NULL,
  `paybPer` varchar(45) NOT NULL,
  `presInc` varchar(45) NOT NULL,
  `intRate` varchar(45) NOT NULL,
  `rentInc` varchar(45) NOT NULL,
  `m_1` varchar(45) NOT NULL,
  `m_2` varchar(45) NOT NULL,
  `m_3` varchar(45) NOT NULL,
  `m_4` varchar(45) NOT NULL,
  `m_5` varchar(45) NOT NULL,
  `o_1` varchar(45) NOT NULL,
  `o_2` varchar(45) NOT NULL,
  `o_3` varchar(45) NOT NULL,
  `o_4` varchar(45) NOT NULL,
  `o_5` varchar(45) NOT NULL,
  `sum_m` varchar(45) NOT NULL,
  `w_1` varchar(45) NOT NULL,
  `w_2` varchar(45) NOT NULL,
  `projCurr` varchar(45) NOT NULL,
  PRIMARY KEY (`projId`),
  UNIQUE KEY `projId_UNIQUE` (`projId`)
) ENGINE=InnoDB AUTO_INCREMENT=85 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `projects`
--

LOCK TABLES `projects` WRITE;
/*!40000 ALTER TABLE `projects` DISABLE KEYS */;
/*!40000 ALTER TABLE `projects` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `userId` int(11) NOT NULL AUTO_INCREMENT,
  `userName` varchar(13) NOT NULL,
  `userSurname` varchar(25) NOT NULL,
  `userEmail` varchar(60) NOT NULL,
  `userLogin` varchar(25) NOT NULL,
  `userPass` varchar(45) NOT NULL,
  PRIMARY KEY (`userId`),
  UNIQUE KEY `userId_UNIQUE` (`userId`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-03-25 16:59:24
