-- Create the database if it doesn't exist
CREATE DATABASE IF NOT EXISTS todo_list;

-- Switch to the 'todo_list' database
USE todo_list;

-- Create the tasks table
CREATE TABLE IF NOT EXISTS tasks (
    id INT AUTO_INCREMENT PRIMARY KEY,
    task VARCHAR(255) NOT NULL
);
