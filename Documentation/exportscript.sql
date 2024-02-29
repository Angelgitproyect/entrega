-- MySQL dump 10.13  Distrib 8.0.32, for Win64 (x86_64)
--
-- Host: localhost    Database: pruebatecnica
-- ------------------------------------------------------
-- Server version	8.0.32

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cars`
--

DROP TABLE IF EXISTS `cars`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `cars` (
  `idcar` int NOT NULL AUTO_INCREMENT,
  `brand` varchar(50) DEFAULT NULL,
  `plate` varchar(6) DEFAULT NULL,
  `platecity` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`idcar`),
  UNIQUE KEY `idcar` (`idcar`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cars`
--

LOCK TABLES `cars` WRITE;
/*!40000 ALTER TABLE `cars` DISABLE KEYS */;
INSERT INTO `cars` VALUES (1,'Mazda','OFG123','Bogota'),(2,'Toyota','OGO852','Bogota');
/*!40000 ALTER TABLE `cars` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `city`
--

DROP TABLE IF EXISTS `city`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `city` (
  `idcity` int NOT NULL AUTO_INCREMENT,
  `namecity` varchar(30) DEFAULT NULL,
  PRIMARY KEY (`idcity`),
  UNIQUE KEY `idcity` (`idcity`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `city`
--

LOCK TABLES `city` WRITE;
/*!40000 ALTER TABLE `city` DISABLE KEYS */;
INSERT INTO `city` VALUES (1,'Bogotá');
/*!40000 ALTER TABLE `city` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `locationrental`
--

DROP TABLE IF EXISTS `locationrental`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `locationrental` (
  `idlocationrental` int NOT NULL AUTO_INCREMENT,
  `idvehiclerental` int DEFAULT NULL,
  `idlocations` int DEFAULT NULL,
  PRIMARY KEY (`idlocationrental`),
  UNIQUE KEY `idlocationrental` (`idlocationrental`),
  KEY `fk_lore_vere` (`idvehiclerental`),
  KEY `fk_lore_loca` (`idlocations`),
  CONSTRAINT `fk_lore_loca` FOREIGN KEY (`idlocations`) REFERENCES `locations` (`idlocations`),
  CONSTRAINT `fk_lore_vere` FOREIGN KEY (`idvehiclerental`) REFERENCES `vehiclerental` (`idvehiclerental`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `locationrental`
--

LOCK TABLES `locationrental` WRITE;
/*!40000 ALTER TABLE `locationrental` DISABLE KEYS */;
INSERT INTO `locationrental` VALUES (1,1,1),(2,2,2);
/*!40000 ALTER TABLE `locationrental` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `locations`
--

DROP TABLE IF EXISTS `locations`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `locations` (
  `idlocations` int NOT NULL AUTO_INCREMENT,
  `idcity` int DEFAULT NULL,
  `namelocations` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`idlocations`),
  UNIQUE KEY `idlocations` (`idlocations`),
  KEY `fk_loca_city` (`idcity`),
  CONSTRAINT `fk_loca_city` FOREIGN KEY (`idcity`) REFERENCES `city` (`idcity`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `locations`
--

LOCK TABLES `locations` WRITE;
/*!40000 ALTER TABLE `locations` DISABLE KEYS */;
INSERT INTO `locations` VALUES (1,1,'Localidad Antonio Nariño'),(2,1,'Localidad Los Mártires');
/*!40000 ALTER TABLE `locations` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `logsystem`
--

DROP TABLE IF EXISTS `logsystem`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `logsystem` (
  `idlogsystem` int NOT NULL AUTO_INCREMENT,
  `statuslogsystem` int DEFAULT NULL,
  `title` varchar(100) DEFAULT NULL,
  `detail` varchar(200) DEFAULT NULL,
  `logdate` datetime DEFAULT NULL,
  PRIMARY KEY (`idlogsystem`),
  UNIQUE KEY `idlogsystem` (`idlogsystem`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `logsystem`
--

LOCK TABLES `logsystem` WRITE;
/*!40000 ALTER TABLE `logsystem` DISABLE KEYS */;
/*!40000 ALTER TABLE `logsystem` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `iduser` int NOT NULL AUTO_INCREMENT,
  `nameuser` varchar(60) DEFAULT NULL,
  `dni` bigint DEFAULT NULL,
  PRIMARY KEY (`iduser`),
  UNIQUE KEY `iduser` (`iduser`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Pablo',1250356),(2,'Maria',856412);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehiclerental`
--

DROP TABLE IF EXISTS `vehiclerental`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehiclerental` (
  `idvehiclerental` int NOT NULL AUTO_INCREMENT,
  `iduser` int DEFAULT NULL,
  `idcar` int DEFAULT NULL,
  `rented` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`idvehiclerental`),
  UNIQUE KEY `idvehiclerental` (`idvehiclerental`),
  KEY `fk_vere_user` (`iduser`),
  KEY `fk_vere_car` (`idcar`),
  CONSTRAINT `fk_vere_car` FOREIGN KEY (`idcar`) REFERENCES `cars` (`idcar`),
  CONSTRAINT `fk_vere_user` FOREIGN KEY (`iduser`) REFERENCES `user` (`iduser`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehiclerental`
--

LOCK TABLES `vehiclerental` WRITE;
/*!40000 ALTER TABLE `vehiclerental` DISABLE KEYS */;
INSERT INTO `vehiclerental` VALUES (1,1,1,1),(2,2,2,0);
/*!40000 ALTER TABLE `vehiclerental` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-02-29 10:23:54
