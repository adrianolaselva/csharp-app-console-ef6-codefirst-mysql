create database example;

use example;

create table users(
Id int auto_increment,
Name varchar(90) not null,
Email varchar(90) not null,
primary key(Id)
);

