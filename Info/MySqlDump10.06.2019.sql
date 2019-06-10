-- MySQL dump 10.13  Distrib 8.0.16, for Win64 (x86_64)
--
-- Host: localhost    Database: spearshop
-- ------------------------------------------------------
-- Server version	8.0.16

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
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `categories` (
  `category_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(32) DEFAULT NULL,
  `description` varchar(512) DEFAULT NULL,
  `parent_id` int(11) DEFAULT NULL,
  `level` int(11) DEFAULT NULL,
  PRIMARY KEY (`category_id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` VALUES (1,'Boys','',0,0),(2,'TShirts','',1,1),(3,'Pants','',1,1),(4,'Girls','',0,0),(5,'Dresses','',4,1),(6,'Acessories','',4,1),(7,'Shoes','',0,0),(8,'Crosses','',7,1);
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categories_goods`
--

DROP TABLE IF EXISTS `categories_goods`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `categories_goods` (
  `category_id` int(11) NOT NULL,
  `good_id` int(11) NOT NULL,
  PRIMARY KEY (`category_id`,`good_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories_goods`
--

LOCK TABLES `categories_goods` WRITE;
/*!40000 ALTER TABLE `categories_goods` DISABLE KEYS */;
INSERT INTO `categories_goods` VALUES (1,1),(1,3),(1,41),(2,1),(3,3),(3,41),(4,2),(4,4),(5,2),(6,4),(7,5),(8,5);
/*!40000 ALTER TABLE `categories_goods` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `customers` (
  `customer_id` int(11) NOT NULL AUTO_INCREMENT,
  `mail` varchar(64) DEFAULT NULL,
  `phone` varchar(32) DEFAULT NULL,
  `ip` varchar(64) DEFAULT NULL,
  `name` varchar(64) DEFAULT NULL,
  `zone` int(11) DEFAULT NULL,
  PRIMARY KEY (`customer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customers`
--

LOCK TABLES `customers` WRITE;
/*!40000 ALTER TABLE `customers` DISABLE KEYS */;
INSERT INTO `customers` VALUES (1,'ww@gmail.com','0999999999','::1','Vladymyrov Ivan',-180),(2,'sd@gmail.com','0999999999','::1','Vladymyrov Ivan',-180),(3,'ww@gmail.com','0999999999','::1','Vladymyrov Ivan',-180),(4,'ww@gmail.com','0999999999','::1','Vladymyrov Ivan',-180),(5,'ww@gmail.com','0999999999','::1','Vladymyrov Ivan',-180),(7,'ww@gmail.com','09932456714','::1','Vladymyrov Ivan',-180),(8,'sd@gmail.com','09932456714','::1','Kolya Krajinuk',-180),(9,'sd@gmail.com','0999999999','::1','Ddd',-180),(10,'ww@gmail.com','09932456714','::1','Ddd',-180),(11,'ww@gmail.com','0999999999','::1','Ddd',-180),(12,'ww@gmail.com','0999999999','::1','Kolya Krajinuk',-180),(13,'abcvd@gmail.com','0999999999','::1','Vladymyrov Ivan',-180);
/*!40000 ALTER TABLE `customers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `delivery_types`
--

DROP TABLE IF EXISTS `delivery_types`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `delivery_types` (
  `delivery_type_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY (`delivery_type_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `delivery_types`
--

LOCK TABLES `delivery_types` WRITE;
/*!40000 ALTER TABLE `delivery_types` DISABLE KEYS */;
INSERT INTO `delivery_types` VALUES (1,'NovaPoshta'),(2,'UkrPoshta');
/*!40000 ALTER TABLE `delivery_types` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `goods`
--

DROP TABLE IF EXISTS `goods`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `goods` (
  `good_id` int(11) NOT NULL AUTO_INCREMENT,
  `manufacturer_id` int(11) DEFAULT NULL,
  `name` varchar(64) NOT NULL,
  `description` varchar(1024) DEFAULT NULL,
  `price` double NOT NULL,
  `available` int(11) NOT NULL DEFAULT '0',
  PRIMARY KEY (`good_id`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `goods`
--

LOCK TABLES `goods` WRITE;
/*!40000 ALTER TABLE `goods` DISABLE KEYS */;
INSERT INTO `goods` VALUES (1,1,'SuperTShirt','Very good for regular wear',200,2),(2,2,'My lovely dress','Myau',2999,3),(4,2,'WeddingRing','Gold925',9999,6),(5,3,'Crosses','Full leather',1300,4),(31,NULL,'newGood',NULL,9999999,0),(32,NULL,'newGood',NULL,9999999,0),(33,NULL,'newGood',NULL,9999999,0),(34,NULL,'newGood',NULL,9999999,0),(35,NULL,'newGood',NULL,9999999,0),(36,NULL,'newGood',NULL,9999999,0),(37,NULL,'newGood',NULL,9999999,0),(38,NULL,'newGood',NULL,9999999,0),(39,NULL,'newGood',NULL,9999999,0),(40,NULL,'newGood',NULL,9999999,0),(42,NULL,'newGood',NULL,9999999,0);
/*!40000 ALTER TABLE `goods` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `imgs`
--

DROP TABLE IF EXISTS `imgs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `imgs` (
  `img_id` int(11) NOT NULL AUTO_INCREMENT,
  `img_path` varchar(1024) DEFAULT NULL,
  `good_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`img_id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `imgs`
--

LOCK TABLES `imgs` WRITE;
/*!40000 ALTER TABLE `imgs` DISABLE KEYS */;
INSERT INTO `imgs` VALUES (1,'C:\\Users\\Pinky\\source\\repos\\SpearShopDesktop\\SpearShopWeb\\wwwroot\\images\\g1i1.jpg',1),(2,'C:\\Users\\Pinky\\source\\repos\\SpearShopDesktop\\SpearShopWeb\\wwwroot\\images\\g2i2.jpg',2),(3,'C:\\Users\\Pinky\\source\\repos\\SpearShopDesktop\\SpearShopWeb\\wwwroot\\images\\g3i3.jpg',3),(4,'C:\\Users\\Pinky\\source\\repos\\SpearShopDesktop\\SpearShopWeb\\wwwroot\\images\\g4i4.jpg',4),(6,'C:\\Users\\Pinky\\source\\repos\\SpearShopDesktop\\SpearShopWeb\\wwwroot\\images\\g5i6.jpg',5),(7,'C:\\Users\\Pinky\\source\\repos\\SpearShopDesktop\\SpearShopWeb\\wwwroot\\images\\g41i7.jpg',41);
/*!40000 ALTER TABLE `imgs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `manufacturers`
--

DROP TABLE IF EXISTS `manufacturers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `manufacturers` (
  `manufacturer_id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(32) DEFAULT NULL,
  `description` varchar(512) DEFAULT NULL,
  `logo` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`manufacturer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `manufacturers`
--

LOCK TABLES `manufacturers` WRITE;
/*!40000 ALTER TABLE `manufacturers` DISABLE KEYS */;
INSERT INTO `manufacturers` VALUES (1,'Cropp','Underground',NULL),(2,'Odji','',NULL),(3,'Bershka','',NULL);
/*!40000 ALTER TABLE `manufacturers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `orders` (
  `order_id` int(11) NOT NULL AUTO_INCREMENT,
  `customer_id` int(11) NOT NULL,
  `full_price` double NOT NULL,
  `status` varchar(32) NOT NULL,
  `description` varchar(64) DEFAULT NULL,
  `delivery_type_id` int(11) DEFAULT '0',
  PRIMARY KEY (`order_id`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,1,0,'Processed','#46',1),(2,2,0,'Ready','#46',1),(3,3,0,'Ready','#46',1),(4,4,0,'Ready','#46',1),(5,5,0,'Ready','#46',2),(7,7,0,'Ready','#46',2),(8,8,0,'Ready','#466',1),(9,9,0,'Ready','#466',1),(10,10,0,'Ready','#46',1),(11,11,0,'Ready','#46',1),(12,12,0,'Ready','#46',1),(13,13,0,'New order','#46',1);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders_goods`
--

DROP TABLE IF EXISTS `orders_goods`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `orders_goods` (
  `order_id` int(11) NOT NULL,
  `good_id` int(11) NOT NULL,
  `count` int(11) NOT NULL,
  PRIMARY KEY (`order_id`,`good_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders_goods`
--

LOCK TABLES `orders_goods` WRITE;
/*!40000 ALTER TABLE `orders_goods` DISABLE KEYS */;
INSERT INTO `orders_goods` VALUES (1,3,1),(2,2,2),(3,1,4),(4,5,3),(5,1,1),(6,41,1),(7,1,1),(8,3,1),(9,1,1),(10,1,1),(11,1,1),(12,1,1),(13,1,1);
/*!40000 ALTER TABLE `orders_goods` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `videos`
--

DROP TABLE IF EXISTS `videos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
 SET character_set_client = utf8mb4 ;
CREATE TABLE `videos` (
  `video_id` int(11) NOT NULL AUTO_INCREMENT,
  `video_path` varchar(1024) DEFAULT NULL,
  `good_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`video_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `videos`
--

LOCK TABLES `videos` WRITE;
/*!40000 ALTER TABLE `videos` DISABLE KEYS */;
INSERT INTO `videos` VALUES (1,'C:\\Users\\Pinky\\source\\repos\\SpearShopDesktop\\SpearShopWeb\\wwwroot\\videos\\v1i1.mp4',1);
/*!40000 ALTER TABLE `videos` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2019-06-10  2:03:52
