drop database if exists campapp;
create database campapp;
use campapp;

create table site(
id int not null auto_increment primary key,
name varchar(100) character set utf8 not null ,
description text ,
coordinates varchar(100),
address varchar(100),
web text,
tag enum('restaurante','senderismo','camping')
);

insert into site values(null,'El Musgo','cerca de San Juan de los Dolores, Coahuila (Mexico)','','San Juan de Dolores','https://es.wikiloc.com/rutas-senderismo/el-musgo-por-san-juan-de-dolores-y-bajando-por-tarillal-10237619','senderismo');
insert into site values(null,'Cañón de San Lorenzo','cerca de Santa Emilia, Coahuila (Mexico)','','Santa Emilia','https://es.wikiloc.com/rutas-senderismo/canon-de-san-lorenzo-20162893','senderismo');
insert into site values(null,'La Catarina','cerca de Santa Rosa, Coahuila (Mexico)','','Santa Rosa','https://es.wikiloc.com/rutas-senderismo/la-catarina-10011313','senderismo');
insert into site values (null,'Las Nieves - Refugio - La Catarina','cerca de Los Aromos, Coahuila (Mexico)','','Los Aromos','https://es.wikiloc.com/rutas-senderismo/las-nieves-refugio-la-catarina-19449239','senderismo');
insert into site values(null,'La Viga por la Iglesia','cerca de La Maroma, Coahuila (Mexico)','',' Rancho La Escondida','https://es.wikiloc.com/rutas-senderismo/la-viga-por-la-iglesia-15318556','senderismo');
insert into site values(null,'Aguja Inferior en Mina NL. Bici desde Termas de San Joaquín','cerca de Sierra Hermosa, Coahuila (Mexico)','','La Azufrosa','https://es.wikiloc.com/rutas-senderismo/aguja-inferior-en-mina-nl-bici-desde-termas-de-san-joaquin-16386361','senderismo');
insert into site values(null,'El Penitente desde Sierra Hermosa (Arteaga, N.L.)','cerca de Sierra Hermosa, Coahuila (Mexico)','',' Sierra Hermosa','https://es.wikiloc.com/rutas-senderismo/el-penitente-desde-sierra-hermosa-arteaga-n-l-18560007','senderismo');
insert into site values(null,'La viga traverse - Jame a la Iglesia','cerca de Las Cumbres, Coahuila (Mexico)','','Las Cumbres ','https://es.wikiloc.com/rutas-senderismo/la-viga-traverse-jame-a-la-iglesia-16244596','senderismo');
insert into site values(null,'Las Alazanas... Circuito','cerca de San Antonio de las Alazanas, Coahuila (Mexico)','','San Antonio de las Alazanas ','https://es.wikiloc.com/rutas-senderismo/las-alazanas-circuito-13564109','senderismo');
insert into site values(null,'La Roja','cerca de Las Navajas, Coahuila (Mexico)','','Las Navajas ','https://es.wikiloc.com/rutas-senderismo/la-roja-14272962','senderismo');
insert into site values(null,'cañón de las mariposas - pasó de caballero','cerca de Los Muertos, Coahuila (Mexico)','','Los Muertos ','https://es.wikiloc.com/rutas-senderismo/canon-de-las-mariposas-paso-de-caballero-19163005','senderismo');
insert into site values(null,'viga desde la iglesia','cerca de La Escondida, Coahuila (Mexico)','','Rancho La Escondida ','https://es.wikiloc.com/rutas-senderismo/viga-desde-la-iglesia-19559242','senderismo');
insert into site values(null,'Camino del Cuatro','cerca de Las Tetillas, Coahuila (Mexico)','',' Las Tetillas ','https://es.wikiloc.com/rutas-senderismo/camino-del-cuatro-21127723','senderismo');
insert into site values(null,'Vereda Picacho el recreo','cerca de Santa Emilia, Coahuila (Mexico)','',' Santa Emilia','https://es.wikiloc.com/rutas-senderismo/vereda-picacho-el-recreo-18826745','senderismo');
insert into site values(null,'Los Muertos - Chupaderos (a.k.a El Domo)','cerca de Los Muertos, Coahuila (Mexico)','','Los Muertos ','https://es.wikiloc.com/rutas-senderismo/los-muertos-chupaderos-a-k-a-el-domo-14789335','senderismo');
insert into site values(null,'Sierra la Martha','cerca de La Carolina, Coahuila (Mexico)','','Rancho La Corolina ','https://es.wikiloc.com/rutas-senderismo/sierra-la-martha-19681588','senderismo');
insert into site values(null,'La Marta por Oyameles','cerca de La Carolina, Coahuila (Mexico)','','Los Oyameles ','https://es.wikiloc.com/rutas-senderismo/la-marta-desde-oyameles-21489060','senderismo');
insert into site values(null,'La viga con nieve - hielo','cerca de La Escondida, Coahuila (Mexico)','','Rancho La Escondida ','https://es.wikiloc.com/rutas-senderismo/la-viga-con-nieve-hielo-22078245','senderismo');
insert into site values(null,'San Lorenzo - 3 Caminos','cerca de Buenavista, Coahuila (Mexico)','',' Buenavista ','https://es.wikiloc.com/rutas-senderismo/san-lorenzo-3-caminos-409562','senderismo');
insert into site values(null,'La posada',null,'25,956590, -100.475669','Antiguo camino a Potrero chico #825, las pedreras 65600 Hidalgo NL.',null,'camping');
insert into site values(null,'Checo\'s Restaurante',null,'25.957405, -100.476183','Antiguo Camino a potrero chico #333',null,'restaurante');


select * from site where tag = 'senderismo';