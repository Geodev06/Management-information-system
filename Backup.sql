-- MySqlBackup.NET 2.0.9.2
-- Dump Time: 2019-10-08 10:43:20
-- --------------------------------------
-- Server version 5.7.21 MySQL Community Server (GPL)


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES latin1 */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- 
-- Definition of tb_course
-- 

DROP TABLE IF EXISTS `tb_course`;
CREATE TABLE IF NOT EXISTS `tb_course` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `course` varchar(100) NOT NULL,
  `dept` varchar(100) NOT NULL,
  `description` varchar(100) NOT NULL,
  `s1` varchar(100) NOT NULL,
  `s2` varchar(100) NOT NULL,
  `s3` varchar(100) NOT NULL,
  `s4` varchar(100) NOT NULL,
  `s5` varchar(100) NOT NULL,
  `s6` varchar(100) NOT NULL,
  `s7` varchar(100) NOT NULL,
  `s8` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tb_course
-- 

/*!40000 ALTER TABLE `tb_course` DISABLE KEYS */;
INSERT INTO `tb_course`(`id`,`course`,`dept`,`description`,`s1`,`s2`,`s3`,`s4`,`s5`,`s6`,`s7`,`s8`) VALUES
(1,'Bachelor of Science in Computer Science','College of Computer Studies','More on back-end kame dito','Rizal 101','ITEC 101','ITEC 102','HISTORY 101','KOMFIL','P.E 1','UNDERSTANDING THE SELF','NSTP-CWTS');
/*!40000 ALTER TABLE `tb_course` ENABLE KEYS */;

-- 
-- Definition of tb_student
-- 

DROP TABLE IF EXISTS `tb_student`;
CREATE TABLE IF NOT EXISTS `tb_student` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fn` varchar(50) NOT NULL,
  `mn` varchar(60) NOT NULL,
  `ln` varchar(50) NOT NULL,
  `gender` varchar(50) NOT NULL,
  `Course` varchar(50) NOT NULL,
  `Student_No` varchar(11) NOT NULL,
  `address` varchar(60) NOT NULL,
  `bday` varchar(50) NOT NULL,
  `level` varchar(50) NOT NULL,
  `type` varchar(50) NOT NULL,
  `cell_no` varchar(50) NOT NULL,
  `email` varchar(60) NOT NULL,
  `dept` varchar(100) NOT NULL,
  `s1` varchar(100) NOT NULL,
  `s2` varchar(100) NOT NULL,
  `s3` varchar(100) NOT NULL,
  `s4` varchar(100) NOT NULL,
  `s5` varchar(100) NOT NULL,
  `s6` varchar(100) NOT NULL,
  `s7` varchar(100) NOT NULL,
  `s8` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tb_student
-- 

/*!40000 ALTER TABLE `tb_student` DISABLE KEYS */;
INSERT INTO `tb_student`(`id`,`fn`,`mn`,`ln`,`gender`,`Course`,`Student_No`,`address`,`bday`,`level`,`type`,`cell_no`,`email`,`dept`,`s1`,`s2`,`s3`,`s4`,`s5`,`s6`,`s7`,`s8`) VALUES
(1,'AGEO','VALLAR','AGNOTE','Male','Bachelor of Science in Computer Science','02000091084','BRGY DEL REMEDIO , SPC','August 06 1998','1st Year','Freshmen','09234619090','agnoteageo@yahoo.com','College of Computer Studies','Rizal 101','ITEC 101','ITEC 102','HISTORY 101','KOMFIL','P.E 1','UNDERSTANDING THE SELF','NSTP-CWTS'),
(2,'PAUL ANJELO','JUMBO BULADAS','YAMON','Male','Bachelor of Science in Computer Science','02000091823','BRGY SAN NICOLAS SM BULAHO','March 13 2019','1st Year','Freshmen','09231231231','YAMONZXC@GMAIL.COM','College of Computer Studies','Rizal 101','ITEC 101','ITEC 102','HISTORY 101','KOMFIL','P.E 1','UNDERSTANDING THE SELF','NSTP-CWTS');
/*!40000 ALTER TABLE `tb_student` ENABLE KEYS */;

-- 
-- Definition of tb_user
-- 

DROP TABLE IF EXISTS `tb_user`;
CREATE TABLE IF NOT EXISTS `tb_user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `user` varchar(50) NOT NULL,
  `pass` varchar(50) NOT NULL,
  `fname` varchar(50) NOT NULL,
  `lname` varchar(50) NOT NULL,
  `gender` varchar(60) NOT NULL,
  `Sec_Ques` varchar(100) NOT NULL,
  `Sec_Ans` varchar(100) NOT NULL,
  `profile_pic` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=latin1;

-- 
-- Dumping data for table tb_user
-- 

/*!40000 ALTER TABLE `tb_user` DISABLE KEYS */;
INSERT INTO `tb_user`(`id`,`user`,`pass`,`fname`,`lname`,`gender`,`Sec_Ques`,`Sec_Ans`,`profile_pic`) VALUES
(2,'ADMIN','123','AGEO','AGNOTE','Male','What is your pet''s name?','LARRY BIRDIE',NULL);
/*!40000 ALTER TABLE `tb_user` ENABLE KEYS */;


/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;


-- Dump completed on 2019-10-08 10:43:21
-- Total time: 0:0:0:0:442 (d:h:m:s:ms)
