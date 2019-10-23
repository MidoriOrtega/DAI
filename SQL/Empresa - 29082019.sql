-- 1. Mostrar los nombres de los empleados ordenados alfabéticamente en orden descendiente (z..a)
select nombre from empleado$ order by nombre desc

--2. Listar los nombres de los empleados cuyo nombre termine con la letra "o"
select nombre from empleado$ where nombre like '%o'

--3. Seleccionar el nombre, el oficio y salario de los empleados que trabajan en León.
select nombre, oficio, salario from empleado$ where dir = 'Leon'

--4. Nombre de los empleados que trabajan en León y cuyo oficio sea vendedor o empleado 
select nombre from empleado$ where dir = 'Leon' AND (oficio = 'vendedor' OR oficio = 'empleado')
select nombre from empleado$ where dir = 'Leon' AND oficio in ('vendedor', 'empleado')

--5. Calcular el salario medio de todos los empleados
select avg(salario) as promedio from empleado$

--6. ¿Cuál es el máximo salario de los empleados del departamento 10?
select max(salario) as maximo from empleado$ where deptoNo = 10

--7. Calcula el número de empleados que no tienen comisión
select count(*) as comision from empleado$ where comision = 0

--8. Mostrar cuántos nombres de los empleados empiezan con la letra C
select count(*) from empleado$ where nombre like 'C%'
select count(*) from empleado$ where left(nombre, 1) = 'C'

--9. ¿Cuántos empleados hay en el departamento número 10?
select count(*) from empleado$ where deptoNo = 10

--10. Para cada oficio obtener la suma de salarios
select oficio, sum(salario) from empleado$ group by oficio

--11. Seleccionar el nombre, el oficio y la localidad de los departamentos donde trabajan los vendedores
select nombre, oficio, localizacion from empleado$, departamento$ where empleado$.deptoNo = departamento$.deptoNo and oficio = 'vendedor'

--12. Seleccionar el nombre, salario y localidad donde trabaja los empleados que tengan un salario entre 10,000 y 13,000
select nombre, salario, localizacion from empleado$, departamento$ where empleado$.deptoNo = departamento$.deptoNo and salario between 10000 and 13000
select nombre, salario, localizacion from empleado$, departamento$ where empleado$.deptoNo = departamento$.deptoNo and salario >= 10000 and salario <=13000

--13. Mostrar los datos de los empleados que trabajan en el departamento de desarrollo de software, ordenados por nombre
select empleado$.* from empleado$, departamento$ where empleado$.deptoNo = departamento$.deptoNo and nombreDepto = 'desarrollo de software' order by nombre

--14. Calcula el salario mínimo de los empleados del departamento de ventas
select min(salario) from empleado$, departamento$ where empleado$.deptoNo = departamento$.deptoNo and nombreDepto = 'ventas'

--15. Calcula el promedio del salario de los empleados del departamento de desarrollo de software
select avg(salario) from empleado$, departamento$ where empleado$.deptoNo = departamento$.deptoNo and nombreDepto = 'desarrollo de software'

--16. ¿Cuántos empleados hay en el departamento de ventas?
select count(*) from empleado$, departamento$ where nombreDepto = 'ventas'

--17. Mostrar el número de empleados de cada departamento
select nombreDepto, count(*) from empleado$, departamento$ group by nombreDepto

--18. Mostrar los departamentos con más de 5 empleados
select nombreDepto, count(*) from empleado$, departamento$ group by nombreDepto having count(*) > 5

--19. Mostrar el nombre, salario y nombre del departamento de los empleados que tengan el mismo oficio que Castillo Pedro 
select nombre, salario, nombreDepto from empleado$, departamento$ where empleado$.deptoNo = departamento$.deptoNo and oficio = (select oficio from empleado$ where nombre = 'Castillo Pedro')

--20. Mostrar el nombre, salario y nombre del departamento de los empleados que tengan el mismo oficio que Castillo Pedro y que no tengan comisión
select nombre, salario, nombreDepto from empleado$, departamento$ where empleado$.deptoNo = departamento$.deptoNo and oficio = (select oficio from empleado$ where nombre = 'Castillo Pedro') and comision = NULL


