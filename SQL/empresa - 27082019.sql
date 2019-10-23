--create database empresa
/*
varchar: alfanumérico
as promedio: pone nombre a la columna
*: todo
select XXX, ... group by XXX
,: separa campos
*/
--use empresa
/*
create table productos (codigo varchar(3), nombre varchar(30), precio decimal(6,2), fechaAlta date, primary key (codigo))
insert into productos values ('c01', 'cuchillo', 5.50, '2019-08-27')
insert into productos values ('m01', 'mesa redonda', 115.50, '2019-08-27')
insert into productos values ('m02', 'mesa cuadrada', 205.50, '2019-08-27')
select * from productos
select * from productos where nombre = 'cuchillo'
select * from productos where nombre like 'mesa%'
select * from productos where precio < 100
select avg(precio) as promedio from productos where left(nombre, 4) = 'mesa'

alter table productos add categoria varchar(10)
update productos set categoria = 'casa'
update productos set categoria = 'comedor' where left(nombre, 4) = 'mesa'
select distinct categoria from productos
select categoria, count(*) as total from productos group by categoria
*/

