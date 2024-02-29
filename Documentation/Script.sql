use pruebatecnica;
CREATE TABLE cars (
    idcar int NOT NULL AUTO_INCREMENT UNIQUE,
    brand Varchar(50),
    plate varchar(6),
    platecity varchar(20),
    PRIMARY KEY (`idcar`)
); 

CREATE TABLE user (
    iduser int NOT NULL AUTO_INCREMENT UNIQUE,
    nameuser Varchar(60),
    dni BIGINT,
    PRIMARY KEY (`iduser`)
); 

CREATE TABLE vehiclerental (
    idvehiclerental int NOT NULL AUTO_INCREMENT UNIQUE,
    iduser int,
    idcar int,
    rented tinyint(1),
    PRIMARY KEY (`idvehiclerental`),
	CONSTRAINT `fk_vere_user` FOREIGN KEY (`iduser`) REFERENCES `user` (`iduser`),
	CONSTRAINT `fk_vere_car` FOREIGN KEY (`idcar`) REFERENCES `cars` (`idcar`)
); 

CREATE TABLE city (
    idcity int NOT NULL AUTO_INCREMENT UNIQUE,
	namecity varchar(30),
    PRIMARY KEY (`idcity`)
); 

CREATE TABLE locations (
    idlocations int NOT NULL AUTO_INCREMENT UNIQUE,
	idcity int,
    namelocations varchar(25),
    lat Varchar(20),
    lon Varchar(20),
    PRIMARY KEY (`idlocations`),
    CONSTRAINT `fk_loca_city` FOREIGN KEY (`idcity`) REFERENCES `City` (`idcity`)
); 


CREATE TABLE locationrental (
    idlocationrental int NOT NULL AUTO_INCREMENT UNIQUE,
    idvehiclerental int,
    idlocations int,
    PRIMARY KEY (`idlocationrental`),
    CONSTRAINT `fk_lore_vere` FOREIGN KEY (`idvehiclerental`) REFERENCES `vehiclerental` (`idvehiclerental`),
    CONSTRAINT `fk_lore_loca` FOREIGN KEY (`idlocations`) REFERENCES `locations` (`idlocations`)
); 


CREATE TABLE logsystem (
    idlogsystem int NOT NULL AUTO_INCREMENT UNIQUE,
    statuslogsystem int,
    title varchar(100),
    detail varchar(200),
    logdate datetime,
    PRIMARY KEY (`idlogsystem`)
); 

