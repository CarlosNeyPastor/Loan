create database loan;

use loan;

create table Dispositivo(
IDDispositivo    int not null AUTO_INCREMENT,
NroSeriedispositivo varchar(25),
Tipo             varchar(20),
Marca            varchar(20),
Modelo           varchar(10),
primary key (IDDispositivo)
);

create table Departamento(
IDDepartamento	int not null AUTO_INCREMENT,
NombreDepartamento	varchar	(25),
primary key (IDDepartamento)
);

create table Evento(
IDEvento int not null AUTO_INCREMENT,
Persona varchar(45),
FechaInicio	datetime,
FechaFin datetime,
primary key (IDEvento)
);

create table Prestamo(
IDPrestamo		int not null auto_increment,
IDDispositivo    int not null,
IDDepartamento	int not null,
primary key (IDPrestamo),
FOREIGN KEY (IDDispositivo) REFERENCES Dispositivo(IDDispositivo),
FOREIGN KEY (IDDepartamento) REFERENCES Departamento(IDDepartamento)
);

create table Historial(
IDHistorial		int not null auto_increment,
IDDispositivo    int not null,
IDDepartamento	int not null,
IDEvento int not null ,
primary key (IDHistorial),
FOREIGN KEY (IDDispositivo) REFERENCES Dispositivo(IDDispositivo),
FOREIGN KEY (IDDepartamento) REFERENCES Departamento(IDDepartamento),
FOREIGN KEY (IDEvento) REFERENCES Evento(IDEvento)
);