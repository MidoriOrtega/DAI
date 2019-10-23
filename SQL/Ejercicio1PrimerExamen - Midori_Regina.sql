--1.  [0.7] Listar toda la información de los hoteles con número de cuartos mayor a 8.
select * from hotel where hotel.numCuartos > 8

-- 2. [0.7] Mostrar el nombre y la cantidad de viajes de cada cliente.
select cliente.nomCliente, count(viaje.idViaje) as numViajes from cliente, viaje where cliente.idCliente = viaje.idCliente
group by cliente.nomCliente

-- 3. [0.8] Listar el nombre de los clientes que visitan a dos ciudades como mínimo.
select Cliente.nomCliente from Cliente
inner join viaje on Viaje.idCliente = Cliente.idCliente
inner join viajeDestino on viajeDestino.idViaje = viaje.idViaje
inner join destino on destino.idDestino = viajeDestino.idDestino
group by Cliente.nomCliente having count(distinct destino.idDestino) >= 2

-- 4. [0.8] Listar el nombre y el teléfono de todos los clientes que tuvieron una cantidad de viajes superior a 2.
select Cliente.nomCliente, Cliente.telefono, count(viaje.idCliente) as numViajes from Cliente, viaje where Cliente.idCliente = viaje.idCliente
group by Cliente.nomCliente, Cliente.telefono having count(viaje.idCliente) > 2

-- 5. [1.0] Mostrar el nombre de los clientes que estuvieron en hoteles con playa o que visitaron Oaxaca.
select distinct Cliente.nomCliente from Cliente
inner join viaje on Viaje.idCliente = Cliente.idCliente
inner join viajeDestino on viajeDestino.idViaje = viaje.idViaje
inner join destino on destino.idDestino = viajeDestino.idDestino
where destino.nombreCiudad = 'Oaxaca'
union
select distinct Cliente.nomCliente from Cliente
inner join viaje on viaje.idCliente = Cliente.idCliente
inner join hotel on hotel.idHotel = viaje.idHotel 
where hotel.descripcion = 'con playa'
 
-- 6.  [1.0] Mostrar el nombre de los clientes que visitaron Acapulco, pero no Cancún.
select Cliente.nomCliente from Cliente
inner join viaje on Viaje.idCliente = Cliente.idCliente
inner join viajeDestino on viajeDestino.idViaje = viaje.idViaje
inner join destino on destino.idDestino = viajeDestino.idDestino
where destino.nombreCiudad = 'Acapulco'
except
select Cliente.nomCliente from Cliente
inner join viaje on Viaje.idCliente = Cliente.idCliente
inner join viajeDestino on viajeDestino.idViaje = viaje.idViaje
inner join destino on destino.idDestino = viajeDestino.idDestino
where destino.nombreCiudad = 'Cancún'


