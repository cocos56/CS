//MySql code

create database mostone;

use mostone;

create table buyer(
	id INT auto_increment primary key,
	name VARCHAR(20) unique,
	pass VARCHAR(40),
	saves DOUBLE(10,2)
);

create table seller(
	id INT auto_increment primary key,
	name VARCHAR(20) unique,
	pass VARCHAR(40),
	saves DOUBLE(10, 2)
);

create table orderlist(
	id INT auto_increment primary key,
	datestamp DATETIME not null,
	summary DOUBLE(10, 2) default 0

);

create table goods(
	id INT auto_increment primary key,
	name varchar(40) not null,
	price DOUBLE(10,2) not null,
	nums INT,
	s_id INT,
	isSale TINYINT,
	foreign key (s_id) references seller(id)
);

create table purchaseMess(
	g_id INT,
	g_name VARCHAR(40),
	price DOUBLE(10, 2),
	nums INT,
	bu_id INT,
	su_id INT,
	o_id INT,
	purstate ENUM('0', '1'),
	foreign key (g_id) references goods(id),
	foreign key (bu_id) references buyer(id),
	foreign key (su_id) references seller(id),
	foreign key (o_id) references orderlist(id)
);