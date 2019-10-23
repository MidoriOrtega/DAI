--1.	Mostrar los nombres (ordenados Z .. A) de los conductores sin repeticiones y la columna se debe llamar nombreCond.
select distinct conductor.NomCond as nombreConductor from conductor order by nombreConductor desc

--2.	Obtener el id del conductor, su nombre y los id de las rutas en las que trabaja.
select conductor.idCond, conductor.nomCond, ruta.idRuta from conductor inner join ruta on conductor.idCond = ruta.idCond

select conductor.idCond, conductor.nomCond, ruta.idRuta from conductor, ruta where conductor.idCond = ruta.idCond

--3.	Listar el (o los) id del conductor (es) que trabaja (n) en Perisur.
select conductor.idCond from viaje
inner join ruta_viaje on viaje.idViaje = ruta_viaje.idViaje
inner join ruta on ruta.idRuta = ruta_viaje.idRuta
inner join conductor on ruta.idCond = conductor.idCond
where viaje.direccion = 'perisur'

select conductor.idCond from viaje, ruta_viaje, ruta, conductor
where viaje.idViaje = ruta_viaje.idViaje
and ruta.idRuta = ruta_viaje.idRuta
and ruta.idCond = conductor.idCond
and viaje.direccion = 'perisur'

--4.	Los Ids de las rutas con el mayor número de viajes.
select top 1 ruta.idRuta from ruta order by numeroViajes desc

select ruta.idRuta from ruta where ruta.numeroViajes = (select max(ruta.numeroViajes) from ruta)

--5.	Obtener el promedio de viajes del conductor PEPE.
select avg(ruta.numeroViajes) from ruta inner join conductor on ruta.idCond = conductor.idCond where conductor.nomCond = 'PEPE'

select avg(ruta.numeroViajes) from ruta, conductor where ruta.idCond = conductor.idCond and conductor.nomCond = 'PEPE'

--6.	Listar el modelo de los autos que tengan viajes en Chapultepec o reforma, pero no en lomas.
select coche.modelo from coche
inner join ruta on ruta.idCoche = coche.id_coche
inner join ruta_viaje on ruta.idRuta = ruta_viaje.idRuta
inner join viaje on viaje.idViaje = ruta_viaje.idViaje
where viaje.direccion = 'chapultepec'
or viaje.direccion = 'reforma'
and viaje.direccion != 'lomas'

select coche.modelo from coche, ruta, ruta_viaje, viaje
where ruta.idCoche = coche.id_coche
and ruta.idRuta = ruta_viaje.idRuta
and viaje.idViaje = ruta_viaje.idViaje
and (viaje.direccion = 'chapultepec'
or viaje.direccion = 'reforma')
and viaje.direccion != 'lomas'

--7.	Mostrar el id de las rutas que tienen más de un viaje registrado.
select ruta.idRuta from ruta where ruta.numeroViajes > 1

--8.	Obtener el nombre de los conductores que tienen viajes tanto a Perisur como a barranca (a ambos, no sólo a uno u otro).
select conductor.nomCond from conductor
inner join ruta on conductor.idCond = ruta.idCond
inner join ruta_viaje on ruta.idRuta = ruta_viaje.idRuta
inner join viaje on ruta_viaje.idViaje = viaje.idViaje
where viaje.direccion = 'perisur'
intersect
select conductor.nomCond from conductor
inner join ruta on conductor.idCond = ruta.idCond
inner join ruta_viaje on ruta.idRuta = ruta_viaje.idRuta
inner join viaje on ruta_viaje.idViaje = viaje.idViaje
where viaje.direccion = 'barranca'

