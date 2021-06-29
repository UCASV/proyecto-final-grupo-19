--********************************************************************************************************
-- Final Project OOP and Database: HAPA Covid-19 "Health Aid Program Against Covid-19"
-- Authors: 
				--Tito Erick Carpio Guerra          00226620
				--Oswaldo Enrique Guevara Berrio	00222320
				--Kevin Bryan Hernandez Lopez		00057720
				--Jonathann Ariel Cabrera Galdamez	00003120

--Correspondence: 
				--00226620@uca.edu.sv
				--00222320@uca.edu.sv
				--00057720@uca.edu.sv
				--00003120@uca.edu.sv

-- Version: 1.0
--********************************************************************************************************


--CREATING AND CONFIGURING THE DATABASE LANGUAGE

CREATE DATABASE PROYECTOF;
USE PROYECTOF;
SET LANGUAGE us_english;

--1.0 CREATING TABLES OF ENTITIES

CREATE TABLE MANAGER (						
	id INT PRIMARY KEY IDENTITY,	
	username VARCHAR (60),			
	passwordUser VARCHAR (20),		
	nameUser VARCHAR(50),		
	mail VARCHAR (50),			  
	addres VARCHAR(100),			
	idTypeEmployed INT		
);

CREATE TABLE TYPE_OF_EMPLOYEES (
	id INT PRIMARY KEY IDENTITY,
	typeEmployed VARCHAR (50)	
);



CREATE TABLE REGISTRATION (
	id INT PRIMARY KEY IDENTITY,		
	dateHour DATETIME,				    
	idCabin INT,
	idManager INT 
);


CREATE TABLE CABIN (
	id INT PRIMARY KEY IDENTITY,		
	addres VARCHAR(100),				
	phone INT,						    
	nameManager VARCHAR(50),			
	mail VARCHAR (50)					
);

CREATE TABLE CITIZEN(
	dui VARCHAR(10) PRIMARY KEY, 
	addres VARCHAR (100),		
	nameCitizen VARCHAR(50),	
	age INT,					
	mail VARCHAR (50),			
	phone INT,					
	idCabin INT,				
	idVaccinationP1 INT,
	idVaccinationP2 INT,
	idIdentifier INT			
);


CREATE TABLE DISEASES (
	id INT PRIMARY KEY IDENTITY,			
	diseases VARCHAR (50),	    
	idCitizen VARCHAR(10)	    
);

CREATE TABLE IDENTIFIER (
	id INT PRIMARY KEY IDENTITY,	
	identifier VARCHAR(50)			
);

CREATE TABLE VACCINATION_PROCESS (
	id INT PRIMARY KEY IDENTITY,	
	dateHourVaccination DATETIME,	
	dateHourStart DATETIME,			
	dateHourVaccinated DATETIME,	
	numberMinutes INT,				
	place VARCHAR(40) NOT NULL		
);



CREATE TABLE EFFECTS (
	id INT PRIMARY KEY IDENTITY,		
	sideEffects VARCHAR (30),			
	idProcess INT						 
);

--2.0 CREATION OF FOREIGN KEYS

--2.1 FOREIGN MANAGER KEYS
ALTER TABLE MANAGER ADD FOREIGN KEY (idTypeEmployed) REFERENCES TYPE_OF_EMPLOYEES (id);



--2.3 FOREIGN REGISTRATION KEYS
ALTER TABLE REGISTRATION ADD FOREIGN KEY (idCabin) REFERENCES CABIN (id);
ALTER TABLE REGISTRATION ADD FOREIGN KEY (idManager) REFERENCES MANAGER (id);

--2.4 FOREIGN CITIZEN KEYS
ALTER TABLE CITIZEN ADD FOREIGN KEY (idCabin) REFERENCES CABIN (id);
ALTER TABLE CITIZEN ADD FOREIGN KEY (idVaccinationP1) REFERENCES VACCINATION_PROCESS (id);
ALTER TABLE CITIZEN ADD FOREIGN KEY (idVaccinationP2) REFERENCES VACCINATION_PROCESS (id);
ALTER TABLE CITIZEN ADD FOREIGN KEY (idIdentifier) REFERENCES IDENTIFIER (id);

--2.5 FOREIGN DISEASES KEYS
ALTER TABLE DISEASES ADD FOREIGN KEY (idCitizen) REFERENCES CITIZEN (dui);

--2.6 FOREIGN EFFECTS KEYS
ALTER TABLE EFFECTS ADD FOREIGN KEY (idProcess) REFERENCES VACCINATION_PROCESS (id);

--3.0 FILLING OUT IMPORTANT TABLES
--3.1 FILLING TYPE_OF_EMPLOYEES TABLE
INSERT INTO TYPE_OF_EMPLOYEES
	VALUES ('Nurse');
INSERT INTO TYPE_OF_EMPLOYEES
	VALUES ('Secretary');
INSERT INTO TYPE_OF_EMPLOYEES
	VALUES ('Doctor');
INSERT INTO TYPE_OF_EMPLOYEES
	VALUES ('Administrator');

--3.2 FILLING MANAGER TABLE

INSERT INTO MANAGER
	VALUES ('TitoCarpio', 'T123456789', 'Tito Erick Carpio Guerra', '00226620@uca.edu.sv', 'Bo San Martín Av Central Sur No 36, Cara Sucia', 1 );
INSERT INTO MANAGER
	VALUES ('OswanoGB', 'O123456789', 'Oswaldo Enrique Guevara Berríos ', '00222320@uca.edu.sv', 'Bo San Nicolás Av San Nicolás No 3-A, Cuscatlán', 2 );
INSERT INTO MANAGER
	VALUES ('Sirenoman', 'J123456789', ' Jonathan Ariel Cabrera Galdamez', '00003120@uca.edu.sv', ' Bo San Sebastián 31 Cl Pte No 9347', 3 );
INSERT INTO MANAGER
	VALUES ('Bryaan159', 'B123456789', 'Kevin Bryan Hernandez Lopez', '00057720@uca.edu.sv', 'Ps Gral Escalón Col Escalón No 3618', 4 );

--3.3 FILLING IDENTIFIER TABLE

INSERT INTO IDENTIFIER (identifier) 
		VALUES  ('Teacher'), 
				('PNC'),	
				('Nurse'),	
				('Doctor'), 
				('Relief corps'),	
				('Armed force'),	
				('Border personnel and penal centers'), 
				('Government employee'), 
				('Reporter'),			
				('None');				 

--3.4 FILLING CABIN TABLE
INSERT INTO CABIN (addres, phone, nameManager, mail)
			VALUES ('Plaza Salvador del mundo, San salvador', 22322333, 'Kevin Bryan Hernandez Lopez', 'cabin01@vacunacionCovid.gob.sv'), 
				('Barrio San Jacinto, San Salvador', 22503455, 'Kevin Bryan Hernandez Lopez','cabin02@vacunacionCovid.gob.sv'),
				('Colonia Miramonte, San Salvador', 23450033, 'Tito Erick Carpio Guerra', 'cabin03@vacunacionCovid.gob.sv'),
				('Popotlan, Apopa', 25345050, 'Tito Erick Carpio Guerra', 'cabin04@vacunacionCovid.gob.sv'),
				('Mejicanos, San salvador', 22550404, 'Tito Erick Carpio Guerra', 'cabin05@vacunacionCovid.gob.sv'),
				('Ciudad Arce, La libertad', 22332455, 'Oswaldo Enrique Guevara Berríos', 'cabin06@vacunacionCovid.gob.sv'),
				('ciudad Barrios, San miguel', 24578969, 'Oswaldo Enrique Guevara Berríos', 'cabin07@vacunacionCovid.gob.sv'),
				('Sonsonate, Sonsonate', 22342123, 'Jonathan Ariel Cabrera Galdamez', 'cabin08@vacunacionCovid.gob.sv'),
				('Santa Ana, Santa Ana', 25660808, 'Jonathan Ariel Cabrera Galdamez', 'cabin09@vacunacionCovid.gob.sv');





