--create database buena_pata;

create table localidad(cod_postal int primary key, nombre varchar(60));
create table especie(codigo serial primary key, nombre varchar(40));
create table cliente(dni int primary key, nombres varchar(80), apellido varchar(90), domicilio varchar(120), telefono varchar(20),cod_postal int,  observaciones varchar(250));
create table profesional(dni int primary key, matricula varchar(10),nombres varchar(80), apellido varchar(90), domicilio varchar(120), telefono varchar(20),cod_postal int,  observaciones varchar(250));
create table mascota(codigo serial primary key, nombre varchar(80), fecha_nac Date, dni_cliente int, cod_especie int, vacunado boolean, observaciones varchar(250));
create table tratamiento(codigo serial primary key, descripcion varchar(100), cod_especie int);
create table medicamento(codigo serial primary key, descripcion varchar(100), cod_especie int, importe float, cantidad int);
create table diagnostico (codigo serial primary key, nombre varchar(60));
create table consulta(codigo serial primary key, fecha date, hora timestamp, dni_prof int, cod_mascota int, asistio boolean, cod_diag int, observaciones varchar(150));
create table mascota_tratamiento(codigo serial primary key,cod_consulta int, cod_tratamiento int, fecha_desde date, fecha_hasta date );
create table mascota_medicamento(codigo serial primary key, cod_tratamiento int, cod_medicamento int, cantidad float);

-- clave foranea de localidad para cliente y profesional --
alter table cliente add constraint fk_cliente_localidad foreign key(cod_postal) references localidad(cod_postal);
alter table profesional add constraint fk_profesional_localidad foreign key(cod_postal) references localidad(cod_postal);

-- clave foranea para mascota relacion con cliente y especie --
alter table mascota add constraint fk_mascota_especie foreign key(cod_especie) references especie(codigo);
alter table mascota add constraint fk_mascota_cliente foreign key(dni_cliente) references cliente(dni);
-- clave foranea con el tratamiento y la especie
alter table tratamiento add constraint fk_tratamiento_especie foreign key(cod_especie) references especie(codigo);

alter table medicamento add constraint fk_medicamento_especie foreign key(cod_especie) references especie(codigo);
--registra los tipos de enfermedades que puede tener una mascota.
alter table consulta add constraint fk_consulta_prof foreign key(dni_prof) references profesional(dni);
alter table consulta add constraint fk_consulta_mascota foreign key(cod_mascota) references mascota(codigo);
alter table consulta add constraint fk_consulta_diagnostico foreign key(cod_diag) references diagnostico(codigo);

alter table mascota_tratamiento add constraint fk_mascota_tratamiento_consulta foreign key(cod_consulta) references consulta(codigo);
alter table mascota_tratamiento add constraint fk_mascota_tratamiento_tratamiento foreign key(cod_tratamiento) references tratamiento(codigo);

-- insercion de informacion
insert into localidad(cod_postal,nombre) values(9100, 'Trelew'),(9103,'Rawson');
insert into especie(nombre) values('canino'),('felino'),('ave'),('reptil');

--ejemplo de insercion de cliente
INSERT INTO cliente(dni, nombres, apellido, domicilio, telefono, cod_postal, observaciones)
    VALUES (44321654,'Jose','Martinez','mitre 2334','44321654',9100,'');
------------------------------------------------------------------------------------------------------------------------------------------------
----  NUEVOS CAMBIOS EN LA BASE
------------------------------------------------------------------------------------------------------------------------------------------------
drop table mascota_medicamento;
create table mascota_medicamento(codigo serial primary key, cod_mascota_tratamiento int, cod_medicamento int, cantidad float);
alter table mascota_medicamento add constraint fk_mascota_medicamento_mascota_tratamiento foreign key(cod_mascota_tratamiento) references mascota_tratamiento(codigo);
alter table mascota_medicamento add constraint fk_mascota_medicamento_medicamento foreign key(cod_medicamento) references medicamento(codigo);
-- agregar el centro de atencion para incluir en el turno de consulta.
create table centro_atencion(codigo serial primary key, nombre varchar(60), domicilio varchar(120),telefono varchar(20),cod_postal int);
alter table centro_atencion add constraint fk_centro_at_localidad foreign key(cod_postal) references localidad(cod_postal);
alter table consulta add cod_centro int;
alter table consulta add constraint fk_consulta_centro_at foreign key(cod_centro) references centro_atencion(codigo);

-- tabla de usuarios del sistema - clave en texto claro, mejoras de este esquema tener la clave encriptada con algun algoritmo y para verificar, generar 
-- la clave con el texto que se ingresa desde la interfaz visual.
create table usuarios(id serial primary key, usuario varchar(90), clave varchar(120), fecha_login time, es_admin boolean default(false));
-- los roles de sistema permiten diferenciar accesos a funciones, por ejemplo
-- rol de consulta no podria acceder a operaciones de actualizacion de informacion
-- rol de operador -- algunas operaciones pueden ser restringidas segun rol.
-- rol de administrador.
create table roles(codigo int primary key, nombre varchar(40));

create table usuario_roles(codigo serial primary key, cod_usuario int, cod_rol int);

/* Mapeo de los permisos del usuario*/
/* Gestion de permiso administrador en el sistema, posee acceso a cada item del menu.*/
--- 

create table funciones(codigo serial primary key, nombre varchar(90));

create table funciones_rol(codigo serial primary key, cod_funcion int, cod_rol int, puede boolean default(false));

-- usuarios que se pueden conectar

insert into usuarios(usuario, clave,es_admin)
values
('msantander', 'lenguaje',true), --1
('operador','nascota',false), --2 
('admin', 'admin', false),		 --3
('consulta','consulta',false), 	 --4
('opProfesores','profesionales',false),--5
('opSocios','clientes',false),  --6
('opConsulta','consult',false);  --7

-- roles que pueden tomar los usuarios
insert into roles(codigo,nombre) values(1,'consulta'),(2,'operador'),(3,'responsable'), (4,'administrador'),(5,'operadorProfesores'),(6,'operadorSocios'),(7,'operadorConsulta');

-- funciones del sistema para dar permisos de acceso

insert into funciones(nombre) 
values
('AltaSocio'),('ModificaSocio'),('ConsultaSocio'), -- 1,2,3
('AltaProfesor'),('ModificaProfesor'),('ConsultaProfesor'), --4,5,6
('AltaTurnoConsulta'),('ModificaTurnoConsulta'),('ConsultaTurnoConsulta'), --7,8,9
('AltaCentroAtencion'),('ModificaCentroAtencion'),('ConsultaCentroAtencion'),--10,11,12
('AltaMascota'),('ModificaMascota'),('ConsultaMascota'), --13,14,15
('AltaMedicamento'),('ModificaMedicamento'),('ConsultaMedicamento'), -- 16,17,18
('AltaLocalidad'),('ModificaLocalidad'),('ConsultaLocalidad'), --19,20,21
('AltaTratamiento'),('ModificaTratamiento'),('ConsultaTratamiento'),--22,23,24
('Listados'),('RegistraAsistenciaTurno');--25,26

-- rol asignado a usuario
-- asignacion de roles a usuarios
/*
msantander -> administrador
operador -> operador
admin -> administrador
consulta -> consulta
opProfesores -> operadorProfesor
opSocios -> operadorSocio
opTurnos -> operadorTurno
*/
insert into usuario_roles(cod_usuario,cod_rol)values(1,4),(2,2),(3,4),(4,1),(5,5),(6,6),(7,7) ;

-- asignacion de funciones(todos) a rol administrador
insert into funciones_rol(cod_funcion, cod_rol, puede)values 
(1,4,true),(2,4,true),(3,4,true),(4,4,true),(5,4,true),(6,4,true),(7,4,true),(8,4,true),(9,4,true),(10,4,true),(11,4,true),(12,4,true),(13,4,true),(14,4,true),(15,4,true),(16,4,true),(17,4,true),(18,4,true),(19,4,true),(20,4,true),(21,4,true),(22,4,true),(23,4,true),(24,4,true),(25,4,true),(26,4,true);

-- asignacion de permisos a "consulta" --  todas funciones de consulta y listado
insert into funciones_rol(cod_funcion, cod_rol, puede)values 
(3,1,true),(6,1,true),(9,1,true),(12,1,true),(15,1,true),(18,1,true),(21,1,true),(22,1,true);

-- asignacion de permisos a "operadorProfesor" --  todas funciones de profesional, listado y estadisticas
insert into funciones_rol(cod_funcion, cod_rol, puede)values 
(4,5,true),(5,5,true),(6,5,true),(22,5,true),(23,5,true);

-- asignacion de permisos a "operadorSocio" --  todas funciones de cliente, listado y estadisticas
insert into funciones_rol(cod_funcion, cod_rol, puede)values 
(1,6,true),(2,6,true),(3,6,true),(22,6,true),(23,6,true);

-- permisos para "operador"
insert into funciones_rol(cod_funcion, cod_rol, puede)values 
(2,2,true),(3,2,true),(5,2,true),(6,2,true),(8,2,true),(9,2,true),(11,2,true),(12,2,true),(14,2,true),(17,2,true),(20,2,true),(21,2,true),(22,2,true),(23,2,true),(24,2,true),(25,2,true),(26,2,true);

-- permisos para operadorTurno
insert into funciones_rol(cod_funcion, cod_rol, puede)values 
(3,7,true),(6,7,true),(7,7,true),(8,7,true),(9,7,true),(12,7,true),(18,7,true),(21,7,true),(22,7,true),(23,7,true),(24,7,true),(25,7,true),(26,7,true);

--- tabla de auditoria.
create table logger(id serial primary key, usuario varchar(90), objeto varchar(90), fecha timestamp, operacion varchar(80), detalle varchar(8000));
