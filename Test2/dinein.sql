-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Feb 07, 2017 at 06:03 AM
-- Server version: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dinein`
--

-- --------------------------------------------------------

--
-- Table structure for table `foods`
--

CREATE TABLE `foods` (
  `food_id` int(11) NOT NULL,
  `type` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `price` double NOT NULL,
  `items_available` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `foods`
--

INSERT INTO `foods` (`food_id`, `type`, `name`, `price`, `items_available`) VALUES
(1, 1, 'Test', 10, 19),
(2, 2, 'THIS IS THE FOOD', 0, 9),
(3, 3, 'test 3', 0, -1),
(4, 3, 'test 4', 0, -1);

-- --------------------------------------------------------

--
-- Table structure for table `food_types`
--

CREATE TABLE `food_types` (
  `type_id` int(11) NOT NULL,
  `type` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `food_types`
--

INSERT INTO `food_types` (`type_id`, `type`) VALUES
(1, 'Bevarages'),
(2, 'Type 2'),
(3, 'Type 3');

-- --------------------------------------------------------

--
-- Table structure for table `orders`
--

CREATE TABLE `orders` (
  `order_id` int(11) NOT NULL,
  `order_type` varchar(20) NOT NULL,
  `customer_name` varchar(50) NOT NULL,
  `state` varchar(15) NOT NULL DEFAULT 'PENDING',
  `time_stamp` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `orders`
--

INSERT INTO `orders` (`order_id`, `order_type`, `customer_name`, `state`, `time_stamp`) VALUES
(14, 'In house dinning', 'Dinesh', 'PENDING', '2017-02-06 14:44:03'),
(15, 'In house dinning', 'Dinesh', 'KM_APPROVED', '2017-02-06 14:44:30'),
(16, 'In house dinning', 'resga', 'PENDING', '2017-02-06 14:45:40'),
(17, 'In house dinning', 'asd', 'PENDING', '2017-02-06 14:46:21'),
(18, 'In house dinning', 'a', 'KM_APPROVED', '2017-02-06 14:48:21'),
(19, 'In house dinning', 'asda', 'KM_REJECTED', '2017-02-06 14:50:51'),
(20, 'In house dinning', 'asf', 'PENDING', '2017-02-06 14:53:50');

--
-- Triggers `orders`
--
DELIMITER $$
CREATE TRIGGER `update_food_stock` AFTER UPDATE ON `orders` FOR EACH ROW BEGIN	
     DECLARE V_FINISHED INTEGER DEFAULT 0;
	 DECLARE V_FOOD_ID INTEGER;
     
     DEClARE FOOD_CURSER CURSOR FOR
     SELECT FOOD_ID FROM order_items WHERE order_id = NEW.ORDER_ID;
     
     DECLARE CONTINUE HANDLER FOR NOT FOUND SET V_FINISHED = 1;
    
	 IF NEW.STATE = "KM_APPROVED" THEN
    	BEGIN
			OPEN FOOD_CURSER;
            
            GET_FOOD : LOOP
            FETCH FOOD_CURSER INTO V_FOOD_ID;
            
            IF V_FINISHED = 1 THEN
            	LEAVE GET_FOOD;
            END IF;
            
            UPDATE foods
            SET items_available = items_available - 1;
			
			END LOOP GET_FOOD;
 
			CLOSE FOOD_CURSER;
    	END;
    END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Table structure for table `order_items`
--

CREATE TABLE `order_items` (
  `order_id` int(11) NOT NULL,
  `food_id` int(11) NOT NULL,
  `qty` int(11) NOT NULL,
  `price` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `order_items`
--

INSERT INTO `order_items` (`order_id`, `food_id`, `qty`, `price`) VALUES
(14, 1, 12, 10),
(15, 2, 4, 0),
(15, 3, 2, 0),
(16, 1, 234, 10),
(17, 2, 2, 0),
(18, 2, 2, 0),
(19, 1, 2, 10),
(20, 1, 23, 10);

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(11) NOT NULL,
  `name` varchar(50) NOT NULL,
  `user_name` varchar(10) NOT NULL,
  `pwd` varchar(10) NOT NULL,
  `role` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `name`, `user_name`, `pwd`, `role`) VALUES
(1, 'Dinesh Liyanage', 'a', 'a', 'KM');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `foods`
--
ALTER TABLE `foods`
  ADD PRIMARY KEY (`food_id`),
  ADD KEY `type` (`type`);

--
-- Indexes for table `food_types`
--
ALTER TABLE `food_types`
  ADD PRIMARY KEY (`type_id`);

--
-- Indexes for table `orders`
--
ALTER TABLE `orders`
  ADD PRIMARY KEY (`order_id`);

--
-- Indexes for table `order_items`
--
ALTER TABLE `order_items`
  ADD PRIMARY KEY (`order_id`,`food_id`),
  ADD KEY `food_id` (`food_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `foods`
--
ALTER TABLE `foods`
  MODIFY `food_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT for table `food_types`
--
ALTER TABLE `food_types`
  MODIFY `type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `orders`
--
ALTER TABLE `orders`
  MODIFY `order_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=22;
--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- Constraints for dumped tables
--

--
-- Constraints for table `foods`
--
ALTER TABLE `foods`
  ADD CONSTRAINT `foods_ibfk_1` FOREIGN KEY (`type`) REFERENCES `food_types` (`type_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `order_items`
--
ALTER TABLE `order_items`
  ADD CONSTRAINT `order_items_ibfk_1` FOREIGN KEY (`order_id`) REFERENCES `orders` (`order_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `order_items_ibfk_2` FOREIGN KEY (`food_id`) REFERENCES `foods` (`food_id`) ON DELETE CASCADE ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
