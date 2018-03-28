drop database if exists campapp;
create database campApp;
use campApp;

create table site(
id int not null auto_increment primary key,
name varchar(100) not null,
description text ,
coordinates varchar(100),
address varchar(100),
web text,
tag enum('restaurante','senderismo','camping')
);

insert into site values(null,'Cafeteria UTE','Culera','24.98658,65.967576576','Salinas','www.UTE.com','restaurante');
insert into site values(null,'Monte','Culera2','24.98658,65.967576576','Salinas','','senderismo');
insert into site values(null,'Esta alv','Culera','24.98658,65.967576576','Salinas','www.campp.com','camping');

select * from site where tag = 'restaurante';