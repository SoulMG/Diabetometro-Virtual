-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: paciente
-- ------------------------------------------------------
-- Server version	5.7.17-log

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
-- Table structure for table `paciente`
--

create database paciente;
use paciente;
DROP TABLE IF EXISTS `paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paciente` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `bajo` int(11) DEFAULT NULL,
  `normal` int(11) DEFAULT NULL,
  `sobrepeso` int(11) DEFAULT NULL,
  `obesidad` int(11) DEFAULT NULL,
  `fisicabaja` int(11) DEFAULT NULL,
  `fisicamedia` int(11) DEFAULT NULL,
  `fisicaalta` int(11) DEFAULT NULL,
  `mamadia` int(11) DEFAULT NULL,
  `papadia` int(11) DEFAULT NULL,
  `abuelapater` int(11) DEFAULT NULL,
  `abuelamater` int(11) DEFAULT NULL,
  `abuelopater` int(11) DEFAULT NULL,
  `abuelomater` int(11) DEFAULT NULL,
  `sexo` int(11) DEFAULT NULL,
  `glucemia` int(11) DEFAULT NULL,
  `propenso` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=128 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente`
--

LOCK TABLES `paciente` WRITE;
/*!40000 ALTER TABLE `paciente` DISABLE KEYS */;
INSERT INTO `paciente` VALUES (109,0,1,0,0,1,0,0,0,0,0,0,0,0,1,0,0),(110,0,0,0,1,1,0,0,0,0,0,1,0,0,0,0,1),(111,0,1,0,0,0,1,0,0,0,0,0,0,0,1,0,0),(112,0,0,1,0,1,0,0,0,0,0,0,0,0,1,1,1),(113,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0),(114,0,1,0,0,1,0,0,0,0,0,1,0,0,1,0,0),(115,0,1,0,0,0,1,0,0,1,0,0,0,0,1,1,1),(116,0,0,0,1,1,0,0,0,0,0,0,0,0,1,0,1),(117,0,1,0,0,1,0,0,0,0,0,1,0,1,1,0,1),(118,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0),(119,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0),(120,0,0,1,0,1,0,0,0,0,0,0,0,0,1,1,1),(121,0,0,1,0,1,0,0,0,0,0,1,0,0,0,1,1),(122,0,0,1,0,1,0,0,0,1,0,0,1,0,1,1,1),(123,0,0,0,1,1,0,0,0,0,0,1,0,0,0,0,1),(124,0,1,0,0,1,0,0,0,0,0,0,0,0,1,1,1),(125,0,1,0,0,1,0,0,0,0,0,1,0,0,1,1,1),(126,0,0,1,0,1,0,0,1,0,0,0,0,1,1,0,0),(127,0,0,1,0,0,1,0,0,0,0,0,0,0,1,0,0);
/*!40000 ALTER TABLE `paciente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `red`
--

DROP TABLE IF EXISTS `red`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `red` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `bajo` int(11) DEFAULT NULL,
  `normal` int(11) DEFAULT NULL,
  `sobrepeso` int(11) DEFAULT NULL,
  `obesidad` int(11) DEFAULT NULL,
  `fisicabaja` int(11) DEFAULT NULL,
  `fisicamedia` int(11) DEFAULT NULL,
  `fisicaalta` int(11) DEFAULT NULL,
  `mamadia` int(11) DEFAULT NULL,
  `papadia` int(11) DEFAULT NULL,
  `abuelapater` int(11) DEFAULT NULL,
  `abuelamater` int(11) DEFAULT NULL,
  `abuelopater` int(11) DEFAULT NULL,
  `abuelomater` int(11) DEFAULT NULL,
  `sexo` int(11) DEFAULT NULL,
  `glucemia` int(11) DEFAULT NULL,
  `propenso` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=81 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `red`
--

LOCK TABLES `red` WRITE;
/*!40000 ALTER TABLE `red` DISABLE KEYS */;
INSERT INTO `red` VALUES (66,0,1,0,0,1,0,0,0,0,0,0,0,0,1,0,0),(67,0,0,0,1,1,0,0,0,0,0,1,0,0,0,0,1),(68,0,1,0,0,0,1,0,0,0,0,0,0,0,1,0,0),(69,0,0,1,0,1,0,0,0,0,0,0,0,0,1,1,1),(70,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0),(71,0,1,0,0,1,0,0,0,0,0,1,0,0,1,0,0),(72,0,1,0,0,0,1,0,0,1,0,0,0,0,1,1,1),(73,0,0,0,1,1,0,0,0,0,0,0,0,0,1,0,1),(74,0,1,0,0,1,0,0,0,0,0,1,0,1,1,0,1),(75,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0),(76,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0),(77,0,0,1,0,1,0,0,0,0,0,0,0,0,1,1,1),(78,0,0,1,0,1,0,0,0,0,0,1,0,0,0,1,1),(79,0,0,1,0,1,0,0,0,1,0,0,1,0,1,1,1),(80,0,0,0,1,1,0,0,0,0,0,1,0,0,0,0,1);
/*!40000 ALTER TABLE `red` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-12-18 23:51:51
