-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 10, 2021 at 06:01 PM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 7.4.15

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ems`
--

-- --------------------------------------------------------

--
-- Table structure for table `options`
--

CREATE TABLE `options` (
  `opid` int(11) NOT NULL,
  `qid` int(11) NOT NULL,
  `mcqoption` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `options`
--

INSERT INTO `options` (`opid`, `qid`, `mcqoption`) VALUES
(1, 6, 'thik'),
(2, 6, 'dami'),
(3, 6, 'majja'),
(4, 6, 'mast'),
(5, 7, 'Charles Babbage'),
(6, 7, 'Nelson Mandela'),
(7, 7, 'Denis Ritchie'),
(8, 7, 'Sir Issac Newton'),
(9, 8, '@{var i =10};'),
(10, 8, '@{var i = 10;}'),
(11, 8, '@(i = 10);'),
(12, 8, '@(int i = 10)'),
(13, 9, 'software developer'),
(14, 9, 'network programmer'),
(15, 9, 'cyber security'),
(16, 9, 'database engineer'),
(17, 10, 'Charles Babbage'),
(18, 10, 'jfkdsjkfkjsk'),
(19, 10, 'ksdjkfkj'),
(20, 10, 'kjdkfjdf');

-- --------------------------------------------------------

--
-- Table structure for table `question`
--

CREATE TABLE `question` (
  `qid` int(11) NOT NULL,
  `questions` varchar(200) NOT NULL,
  `subject` varchar(50) NOT NULL,
  `answer` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `question`
--

INSERT INTO `question` (`qid`, `questions`, `subject`, `answer`) VALUES
(6, 'wasuo?', 'CSIT', 'thik'),
(7, 'Who is the father of computer ?', 'BCA', 'Charles Babbage'),
(8, 'Which of the following is the correct syntax in razor page ?', 'BCA', '@{var i =10};'),
(9, 'what is your aim in IIT ?', 'BCA', 'software developer'),
(10, 'who is you hero ?', 'BCA', 'Charles Babbage');

-- --------------------------------------------------------

--
-- Table structure for table `userlogin`
--

CREATE TABLE `userlogin` (
  `uid` int(11) NOT NULL,
  `username` varchar(200) NOT NULL,
  `password` varchar(200) NOT NULL,
  `role` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `userlogin`
--

INSERT INTO `userlogin` (`uid`, `username`, `password`, `role`) VALUES
(1, 'teacher', 'teacher', 'Teacher'),
(2, 'student', 'student', 'Student'),
(3, 'ranjan', 'ranjan', 'Student'),
(4, 'Bhim', 'Bhim', 'Teacher');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `options`
--
ALTER TABLE `options`
  ADD PRIMARY KEY (`opid`);

--
-- Indexes for table `question`
--
ALTER TABLE `question`
  ADD PRIMARY KEY (`qid`);

--
-- Indexes for table `userlogin`
--
ALTER TABLE `userlogin`
  ADD PRIMARY KEY (`uid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `options`
--
ALTER TABLE `options`
  MODIFY `opid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `question`
--
ALTER TABLE `question`
  MODIFY `qid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `userlogin`
--
ALTER TABLE `userlogin`
  MODIFY `uid` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
