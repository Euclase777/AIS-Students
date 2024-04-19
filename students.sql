/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50525
Source Host           : localhost:3306
Source Database       : students

Target Server Type    : MYSQL
Target Server Version : 50525
File Encoding         : 65001

Date: 2024-04-18 18:57:19
*/

SET FOREIGN_KEY_CHECKS=0;
USE students;
-- ----------------------------
-- Table structure for assignments
-- ----------------------------
DROP TABLE IF EXISTS `assignments`;
CREATE TABLE `assignments` (
  `ID_Assign` int(255) unsigned NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  `MAX_Mark` int(255) unsigned NOT NULL,
  `ID_Subject` int(255) unsigned DEFAULT NULL,
  PRIMARY KEY (`ID_Assign`),
  KEY `FK_ID_Subject` (`ID_Subject`) USING BTREE,
  CONSTRAINT `subj-assign` FOREIGN KEY (`ID_Subject`) REFERENCES `subjects` (`ID_Subject`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of assignments
-- ----------------------------
INSERT INTO `assignments` VALUES ('1', 'Лабораторная 123', '25', '1');
INSERT INTO `assignments` VALUES ('2', 'Проектная работа', '40', '2');

-- ----------------------------
-- Table structure for auth
-- ----------------------------
DROP TABLE IF EXISTS `auth`;
CREATE TABLE `auth` (
  `Login` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `ID_User` int(255) unsigned NOT NULL AUTO_INCREMENT,
  `Access_level` int(255) NOT NULL,
  PRIMARY KEY (`Login`,`Password`),
  KEY `FK_ID_User` (`ID_User`),
  CONSTRAINT `FK_ID_User` FOREIGN KEY (`ID_User`) REFERENCES `users` (`ID_User`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of auth
-- ----------------------------
INSERT INTO `auth` VALUES ('Admin', 'Password', '1', '0');
INSERT INTO `auth` VALUES ('Teacher', 'Password', '2', '1');

-- ----------------------------
-- Table structure for groups
-- ----------------------------
DROP TABLE IF EXISTS `groups`;
CREATE TABLE `groups` (
  `ID_Group` int(255) unsigned NOT NULL AUTO_INCREMENT,
  `Class` int(255) NOT NULL,
  `Group` varchar(255) NOT NULL,
  `Faculty` varchar(255) NOT NULL,
  PRIMARY KEY (`ID_Group`),
  KEY `FK_ID_Group` (`ID_Group`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of groups
-- ----------------------------
INSERT INTO `groups` VALUES ('1', '4', '20-1', 'РИСб');
INSERT INTO `groups` VALUES ('2', '3', '21-1', 'РИСб');
INSERT INTO `groups` VALUES ('3', '2', '22-1', 'РИСб');
INSERT INTO `groups` VALUES ('4', '1', '23-1', 'РИСб');

-- ----------------------------
-- Table structure for student-assign
-- ----------------------------
DROP TABLE IF EXISTS `student-assign`;
CREATE TABLE `student-assign` (
  `ID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `ID_Student` int(10) unsigned NOT NULL,
  `ID_Assign` int(10) unsigned NOT NULL,
  `Mark` int(11) DEFAULT NULL,
  `Date` date NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_ID_Student` (`ID_Student`) USING BTREE,
  KEY `FK_ID_Assign` (`ID_Assign`) USING BTREE,
  CONSTRAINT `assign-student` FOREIGN KEY (`ID_Assign`) REFERENCES `assignments` (`ID_Assign`) ON DELETE CASCADE ON UPDATE CASCADE,
  CONSTRAINT `student-assign` FOREIGN KEY (`ID_Student`) REFERENCES `students` (`ID_Student`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of student-assign
-- ----------------------------
INSERT INTO `student-assign` VALUES ('5', '4', '2', '20', '2024-04-16');

-- ----------------------------
-- Table structure for students
-- ----------------------------
DROP TABLE IF EXISTS `students`;
CREATE TABLE `students` (
  `ID_Student` int(255) unsigned NOT NULL AUTO_INCREMENT,
  `FIO` varchar(255) NOT NULL,
  `ID_Group` int(255) unsigned NOT NULL,
  PRIMARY KEY (`ID_Student`),
  KEY `FK_ID_Student` (`ID_Student`) USING BTREE,
  KEY `group-student` (`ID_Group`),
  CONSTRAINT `group-student` FOREIGN KEY (`ID_Group`) REFERENCES `groups` (`ID_Group`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of students
-- ----------------------------
INSERT INTO `students` VALUES ('4', 'Иван Иванов', '1');
INSERT INTO `students` VALUES ('5', 'Сергей Сергеевич', '2');
INSERT INTO `students` VALUES ('6', 'Ольга Сергеевна', '2');

-- ----------------------------
-- Table structure for subjects
-- ----------------------------
DROP TABLE IF EXISTS `subjects`;
CREATE TABLE `subjects` (
  `ID_Subject` int(255) unsigned NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) NOT NULL,
  PRIMARY KEY (`ID_Subject`),
  KEY `FK_ID_Subject` (`ID_Subject`) USING BTREE
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of subjects
-- ----------------------------
INSERT INTO `subjects` VALUES ('1', 'Информационные технологии');
INSERT INTO `subjects` VALUES ('2', 'Проектная деятельность');
INSERT INTO `subjects` VALUES ('3', 'Облачные технологии и услуги');
INSERT INTO `subjects` VALUES ('4', 'Облачные базы данных');

-- ----------------------------
-- Table structure for sysadmins
-- ----------------------------
DROP TABLE IF EXISTS `sysadmins`;
CREATE TABLE `sysadmins` (
  `ID_Sysadmin` int(255) unsigned NOT NULL AUTO_INCREMENT,
  `FIO` varchar(255) NOT NULL,
  PRIMARY KEY (`ID_Sysadmin`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of sysadmins
-- ----------------------------
INSERT INTO `sysadmins` VALUES ('1', 'Герасимов Евгений');

-- ----------------------------
-- Table structure for teachers
-- ----------------------------
DROP TABLE IF EXISTS `teachers`;
CREATE TABLE `teachers` (
  `ID_Teacher` int(255) unsigned NOT NULL AUTO_INCREMENT,
  `FIO` varchar(255) NOT NULL,
  PRIMARY KEY (`ID_Teacher`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of teachers
-- ----------------------------
INSERT INTO `teachers` VALUES ('1', 'Максим Никитин');
INSERT INTO `teachers` VALUES ('2', 'Денис Жук');

-- ----------------------------
-- Table structure for users
-- ----------------------------
DROP TABLE IF EXISTS `users`;
CREATE TABLE `users` (
  `ID_User` int(255) unsigned NOT NULL AUTO_INCREMENT,
  `ID_Student` int(255) DEFAULT NULL,
  `ID_Teacher` int(255) DEFAULT NULL,
  `ID_Sysadmin` int(255) DEFAULT NULL,
  PRIMARY KEY (`ID_User`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of users
-- ----------------------------
INSERT INTO `users` VALUES ('1', null, null, '1');
INSERT INTO `users` VALUES ('2', null, '1', null);
INSERT INTO `users` VALUES ('5', null, '2', null);
INSERT INTO `users` VALUES ('6', '4', null, null);
INSERT INTO `users` VALUES ('7', '5', null, null);
INSERT INTO `users` VALUES ('8', '6', null, null);
INSERT INTO `users` VALUES ('9', null, null, null);
