-- MySQL dump 10.13  Distrib 5.7.12, for Win64 (x86_64)
--
-- Host: localhost    Database: ais
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
-- Table structure for table `tblplants`
--

DROP TABLE IF EXISTS `tblplants`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tblplants` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  `SoilMoistureMin` int(11) DEFAULT NULL,
  `SoilMoistureMax` int(11) DEFAULT NULL,
  `SoilMoistureNow` int(11) DEFAULT NULL,
  `Category` varchar(45) DEFAULT NULL,
  `SunlightMin` int(11) DEFAULT NULL,
  `SunlightMax` int(11) DEFAULT NULL,
  `SunlightNow` int(11) DEFAULT NULL,
  `ID_Type` int(11) DEFAULT NULL,
  `StartDate` datetime DEFAULT NULL,
  `Updated` datetime DEFAULT NULL,
  `url` varchar(400) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=49 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tblplants`
--

LOCK TABLES `tblplants` WRITE;
/*!40000 ALTER TABLE `tblplants` DISABLE KEYS */;
INSERT INTO `tblplants` VALUES (1,'Basilka',15,20,13,'Plant',8,42,38,1,'2016-12-31 20:00:00','2017-04-02 00:01:54','https://media.mercola.com/assets/images/foodfacts/basil-fb.jpg'),(3,'Gurka',15,20,6,'Plant',8,42,38,3,'2016-12-31 20:00:00','2017-04-02 00:01:54','https://fthmb.tqn.com/rY4dxdwHD1M3DXQ7GJchPvOtgaY=/2121x1414/filters:no_upscale():fill(transparent,1)/about/Cucumber-plant-GettyImages-107690127-589511075f9b5874ee5f21ed.jpg'),(4,'Tomat',8,20,10,'Plant',8,42,38,2,'2016-12-31 12:00:00','2017-04-02 00:01:54','http://kingfisher.scene7.com/is/image/Kingfisher/verve_shutterstock_lifestyle_2016_35?crop=7,1052,3536,1948&anchor=1775,2026'),(16,'Timjan',10,40,4,'Plant',15,40,38,10,'2016-12-31 20:00:00','2017-04-02 00:01:54','http://upladdy.com/files/181/1658726/1283949.jpg'),(35,'Jordgubbar',14,25,18,'Plant',10,30,0,9,'0001-01-01 00:00:00','2017-04-02 00:01:54','http://www.nelsongarden.se/shop/assets/prod_images/p90418l.jpg'),(36,'Advokado',12,20,3,'Tree',15,40,0,6,'0001-01-01 00:00:00','2017-04-02 00:01:54','https://www.diggers.com.au/media/products/145363/m.jpg'),(47,'Rosmarin',4,20,9,'Plant',15,40,0,10,'0001-01-01 00:00:00','2017-04-02 00:01:54','https://www.dr-feil.com/wp-content/uploads/2016/08/AdobeStock_10068192.jpeg'),(48,'Majs',10,20,5,'Plant',20,40,0,12,'0001-01-01 00:00:00','2017-04-02 00:01:54','http://ravarumarknaden.se/wp-content/uploads/majs-kolvar-faller-i-pris.jpg');
/*!40000 ALTER TABLE `tblplants` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-04-02 19:51:25
