--- definición de las tablas de UBER
/*
create table viaje (
	idViaje		smallint not null primary key,
	direccion	char(30) )

create table conductor (
	idConductor	smallint not null primary key,	
	telefono	char(30),
	nomConductor	char(30) )

create table coche (
	idCoche		smallint not null primary key,
	modelo		char(30),
	placa		char(8) )

create table ruta (
	idRuta		smallint not null primary key,
	numViajes	smallint,
	idCoche		smallint references coche,
	idConductor	smallint references conductor )

create table ruta_viaje (
	idViaje		smallint references viaje,
	idRuta		smallint references ruta,
				primary key (idViaje, idRuta) )
*/

--Tuplas de la tabla viaje
insert into viaje values (11, 'san angel')
insert into viaje values (22, 'perisur')
insert into viaje values (33, 'barranca')
insert into viaje values (44, 'lomas')
insert into viaje values (55, 'reforma')
insert into viaje values (66, 'insurgentes')
insert into viaje values (77, 'chapultepec')

select * from viaje