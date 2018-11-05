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
-- Create schema dbexemplo
--

CREATE DATABASE IF NOT EXISTS dbexemplo;
USE dbexemplo;

--
-- Definition of table `senha`
--

DROP TABLE IF EXISTS `senha`;
CREATE TABLE `senha` (
  `Codigo` int(11) NOT NULL AUTO_INCREMENT,
  `Usuario` varchar(50) DEFAULT NULL,
  `Senha` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`Codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `senha`
--

/*!40000 ALTER TABLE `senha` DISABLE KEYS */;
INSERT INTO `senha` (`Codigo`,`Usuario`,`Senha`) VALUES 
 (1,'Eduardo','gabi1341'),
 (2,'MariaHelena','veneno'),
 (3,'Gabriela','gabirecado'),
 (4,'rafael','123');
/*!40000 ALTER TABLE `senha` ENABLE KEYS */;


--
-- Definition of table `tbcidade`
--

DROP TABLE IF EXISTS `tbcidade`;
CREATE TABLE `tbcidade` (
  `Codigo` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) NOT NULL DEFAULT '',
  `Cidade` varchar(50) DEFAULT NULL,
  `Estado` varchar(2) DEFAULT NULL,
  PRIMARY KEY (`Codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbcidade`
--

/*!40000 ALTER TABLE `tbcidade` DISABLE KEYS */;
INSERT INTO `tbcidade` (`Codigo`,`Nome`,`Cidade`,`Estado`) VALUES 
 (1,'Eduardo José Chinaglia','Maceió','AL'),
 (2,'Maria Helena','Araras','SP'),
 (3,'Gabriela Chinaglia','Rio Claro','SP'),
 (4,'Maria Ignes','Limeira','SP'),
 (6,'Frederico','Rio de Janeiro','RJ'),
 (7,'Odilia Martins','Salvador','BA'),
 (8,'Luis Carlos','São Paulo','SP'),
 (9,'Carlos Zulatto','Rio Claro','SP');
/*!40000 ALTER TABLE `tbcidade` ENABLE KEYS */;


--
-- Definition of table `tbexemplo`
--

DROP TABLE IF EXISTS `tbexemplo`;
CREATE TABLE `tbexemplo` (
  `Codigo` int(11) NOT NULL AUTO_INCREMENT,
  `Nome` varchar(50) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`Codigo`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbexemplo`
--

/*!40000 ALTER TABLE `tbexemplo` DISABLE KEYS */;
INSERT INTO `tbexemplo` (`Codigo`,`Nome`,`Email`) VALUES 
 (1,'Eduardo','eduardo1341@yahoo.com.br'),
 (2,'Gabriela','gabirecado@hotmail.com'),
 (3,'Maria Helena','marihelemartins@hotmail.com'),
 (4,'Frederico','fred@ig.com.br'),
 (5,'Maria Ignes Rimerio Chinaglia','mariaignes@hotmai.com'),
 (6,'Odilia Martins','odilia@yahoo.com.br'),
 (7,'Gabriela Chinaglia','naosei@seila.com'),
 (8,'Banze','banze@banze.com'),
 (9,'Luis Carlos','luiscarlos@luiscarlos.com.br'),
 (10,'Kellen','kellen@kellen.com'),
 (11,'Daneil','daniel@daniel.com.br'),
 (12,'Katia Borgi','kborgi@gmail.com');
/*!40000 ALTER TABLE `tbexemplo` ENABLE KEYS */;




/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
