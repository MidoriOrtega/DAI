--Consultas que involucran una relación

--1. Obtener la clave y el nombre de cada profesor.
select prof.idProf, prof.nomProf from prof

--2. Obtener todos los datos de los profesores.
select * from prof

--3. Obtener el nombre y el promedio de los alumnos de la carrera de Negocios con promedio mayor o igual a 8.
select alum.nomAl, alum.prom from alum where alum.carr = 'neg' and alum.prom >= 8

--4. Obtener el nombre de las carreras registradas.
select distinct alum.carr from alum

--5. Obtener el nombre de las carreras registradas sin duplicados ordenando descendentemente por el nombre.
select distinct alum.carr from alum order by alum.carr desc

--6. Obtener el nombre de los alumnos, su carrera y su promedio, ordenados ascendentemente por carrera y descendentemente por promedio.
select alum.nomAl, alum.carr, alum.prom from alum order by alum.carr, prom desc



--Consultas que involucran varias relaciones

--7. Para cada profesor obtener su nombre, el nombre de las materias y la clave de los grupos que imparte. Ordenar por nombre del profesor.
select prof.nomprof, mater.nomMat, grupo.claveG from prof 
inner join grupo on grupo.idProf = prof.idProf
inner join mater on grupo.claveM = mater.claveM
order by prof.nomProf

select prof.nomprof, mater.nomMat, grupo.claveG from prof, grupo, mater
where grupo.idProf = prof.idProf and grupo.claveM = mater.claveM
order by prof.nomProf

--8. Mostrar el nombre de los alumnos, el nombre de las materias, la calificación obtenida y la fecha, para aquellos alumnos que cursaron alguna materia en el 2010.
select alum.nomAl, mater.nomMat, historial.calif, historial.fecha from alum
inner join historial on alum.CU = historial.CU
inner join mater on historial.claveM = mater.claveM
where year(historial.fecha) = 2010

select alum.nomAl, mater.nomMat, historial.calif, historial.fecha from alum
inner join historial on alum.CU = historial.CU
inner join mater on historial.claveM = mater.claveM
where year(SYSDATETIME()) - year(historial.fecha) = 9

--9. Para cada curso impartido mostrar el nombre de la materia, el número de grupo y el nombre de los alumnos inscritos.
select mater.nomMat, grupo.claveG, alum.nomAl from alum
inner join inscrito on inscrito.CU = alum.CU
inner join grupo on inscrito.claveG = grupo.claveG
inner join mater on grupo.claveM = mater.claveM
order by mater.nomMat

--10. Obtener el nombre y la carrera de todos los alumnos que actualmente cursan alguna materia.
select distinct alum.nomAl, alum.carr from alum, inscrito where alum.CU = inscrito.CU

--11. Obtener el nombre y el promedio de todos los alumnos que actualmente no cursan materia alguna.
select distinct alum.nomAl, alum.prom from alum
except
select distinct alum.nomAl, alum.prom from alum, inscrito where alum.CU = inscrito.CU

--12. Obtener el promedio general, y la cantidad, de todos los alumnos de Negocios.
select avg(alum.prom) as promedio, count(*) as alum from alum where alum.carr = 'neg'

select avg(historial.calif), count(alum.nomAl) from alum
inner join historial on alum.CU = historial.CU
where alum.carr = 'neg'

--13. Contar todas las materias registradas.
select distinct count(*) as cantidad from mater

--14. Contar todas las carreras registradas.
select count(distinct Alum.Carr) as cantidad from alum

--Uso de group by y having

--15.	Para cada alumno mostrar su nombre y contar cuántos cursos está llevando.
select alum.nomAl, count(inscrito.CU) as cursos from alum, inscrito
where alum.CU = inscrito.CU group by alum.nomAl

--16.	Igual a la anterior, pero sólo para los alumnos que al menos están llevando dos cursos.
select alum.nomAl, count(inscrito.CU) as cursos from alum, inscrito
where alum.CU = inscrito.CU group by alum.nomAl having count(inscrito.CU) >= 2

--17.	Obtener para cada materia el promedio de las calificaciones aprobatorias del año pasado.
select mater.nomMat, avg(historial.calif) from mater, historial where mater.claveM = historial.claveM
group by mater.nomMat having avg(historial.calif) >= 6

