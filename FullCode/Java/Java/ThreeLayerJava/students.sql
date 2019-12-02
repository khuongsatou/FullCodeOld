SELECT * FROM web.students;CREATE TABLE `students` (
  `id` int(11) NOT NULL,
  `fname` varchar(1000) CHARACTER SET utf8 DEFAULT NULL,
  `lname` varchar(405) DEFAULT NULL,
  `classid` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
