--1. De cada pedido queremos saber su número de pedido, idfab, idProducto, cantidad
select Pedidos$.idPedido, Pedidos$.idFab, Pedidos$.IdProducto, Pedidos$.cantidad from Pedidos$

--2. Obtener una lista de todos los productos indicando para cada uno su idfab, idproducto, descripción, precio, IVA y precio con IVA (el IVA es del 16%).
select Productos$.idFab, Productos$.idProducto, Productos$.Descripcion, Productos$.precio, Productos$.precio*.16 as IVA, Productos$.precio*1.16 as precioIVA from Productos$

--3. Obtener la lista de los clientes agrupados por código de representante asignado, visualizar todas las columnas de la tabla.
select * from Cliente$ order by Cliente$.NumRepresentante

--4. Obtener las oficinas ordenadas por orden alfabético de cada estado, si hay más de una oficina en la misma ciudad, aparecerá primero la que tenga el número de oficina mayor.
select * from Oficinas$ order by Oficinas$.Estado, Oficinas$.numOficina

--5. Obtener los pedidos ordenados por fecha de pedido.
select * from Pedidos$ order by Pedidos$.Fecha

--6. Listar las cuatro líneas de pedido más caras (las de mayor importe).
select top 4 * from Pedidos$ order by cantidad desc
select top 4 * from Pedidos$, Productos$ where Pedidos$.IdProducto = Productos$.idProducto order by Productos$.precio desc
select top 4 * from Pedidos$, Productos$ where Pedidos$.IdProducto = Productos$.idProducto order by Productos$.precio * Pedidos$.cantidad desc

--7.  Obtener las mismas columnas que en el ejercicio anterior, pero sacando únicamente las 5 líneas de pedido de menor precio unitario.
select top 5 * from Pedidos$, Productos$ where Pedidos$.IdProducto = Productos$.idProducto order by Productos$.precio

--8.  Listar toda la información de los pedidos de septiembre 
select Pedidos$.* from Pedidos$ where MONTH(fecha) = 9

--9. Listar de cada empleado su nombre, nº de días que lleva trabajando en la empresa y su año de nacimiento (suponiendo que este año ya ha cumplido años).
select Empleado$.nombre, cast(GETDATE() - Empleado$.contrato as real) as diasTrabajados, year(GETDATE()) - edad as añoNac from Empleado$

--10. Listar los números de los empleados que tienen una oficina número 13
select Empleado$.numEmpleado from Empleado$ where Empleado$.oficina = 13

--11. Listar los números de los empleados que tienen una oficina asignada
select Empleado$.numEmpleado from Empleado$ where Empleado$.oficina is not null

--12.  Listar los números de las oficinas del estado de Colima


--13. listar la información de los empleados que tienen título de Dir. General y Dir. Ventas ordenadas por cuota en forma descendiente 


--14. Listar los empleados de nombre es igual a nombre1013


--15. Listar los códigos de los números de representante que tienen una línea de pedido superior o igual a 4  o que tengan una cuota superior a 2000


--16. ¿Cuál es la cuota media y el promedio de las edades de todos los empleados?


--17. Hallar el importe medio de pedidos y el importe total de pedidos


--18. Hallar cuántos pedidos hay de más de 3


--19. Listar las oficinas con clave 13 indicando para cada una de ellas el número del director de la oficina, estado, números y nombres de sus empleados. 


--20. Listar los pedidos mostrando su idPedido, cantidad, nombre del cliente y el límite de crédito del cliente correspondiente (todos los pedidos tienen cliente y representante).


--21. Listar los datos de cada uno de los empleados y el estado en donde trabaja.


--22. Listar las oficinas con cuota mayor a 30 indicando para cada una de ellas el nombre de su director.


--23. Listar los pedidos superiores a 25, incluyendo el nombre del empleado que tomó el pedido y el nombre del cliente que lo solicitó.

