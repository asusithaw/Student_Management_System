CREATE DATABASE IF NOT EXISTS students;
USE students;

CREATE TABLE student (
  id INT NOT NULL AUTO_INCREMENT PRIMARY KEY,
  student_name VARCHAR(50),
  reg VARCHAR(50),
  class VARCHAR(50),
  section VARCHAR(50),
  create_at timestamp DEFAULT CURRENT_TIMESTAMP
);

select * from student;

