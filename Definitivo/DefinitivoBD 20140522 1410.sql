-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.5.27


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema emps
--

CREATE DATABASE IF NOT EXISTS emps;
USE emps;

--
-- Definition of table `senha`
--

DROP TABLE IF EXISTS `senha`;
CREATE TABLE `senha` (
  `Codigo` int(3) unsigned NOT NULL AUTO_INCREMENT,
  `Usuario` varchar(40) NOT NULL,
  `Senha` varchar(40) NOT NULL,
  PRIMARY KEY (`Codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `senha`
--

/*!40000 ALTER TABLE `senha` DISABLE KEYS */;
INSERT INTO `senha` (`Codigo`,`Usuario`,`Senha`) VALUES 
 (1,'a','1'),
 (2,'b','2');
/*!40000 ALTER TABLE `senha` ENABLE KEYS */;


--
-- Definition of table `tbex`
--

DROP TABLE IF EXISTS `tbex`;
CREATE TABLE `tbex` (
  `Codigo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nome` varchar(45) NOT NULL,
  `Email` varchar(45) NOT NULL,
  PRIMARY KEY (`Codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbex`
--

/*!40000 ALTER TABLE `tbex` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbex` ENABLE KEYS */;


--
-- Definition of table `tbgerente`
--

DROP TABLE IF EXISTS `tbgerente`;
CREATE TABLE `tbgerente` (
  `Codigo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) NOT NULL,
  `Cidade` varchar(50) NOT NULL,
  `Estado` varchar(2) NOT NULL,
  PRIMARY KEY (`Codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbgerente`
--

/*!40000 ALTER TABLE `tbgerente` DISABLE KEYS */;
/*!40000 ALTER TABLE `tbgerente` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
