-- Host: localhost:3306
-- Generation Time: Sep 25, 2016 at 10:48 PM
-- Server version: 5.6.33
-- PHP Version: 5.6.20

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";

CREATE TABLE IF NOT EXISTS `tblTest` (
  `id` int(10) NOT NULL AUTO_INCREMENT,
  `rating` int(10),
  `firstName` varchar(100) ,
  `lastName` varchar(100) ,
  `comment` varchar(500) NOT NULL,
  `date` varchar(100) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=7 ;

--
-- Dumping data for table `tblGrades`
--


-- INSERT INTO `tblTest` (`id`, `rating`, `field2`) VALUES
-- (1, 2, 'test1'),
-- (2, 8, 'test2'),
-- (3, 3, 'test3');