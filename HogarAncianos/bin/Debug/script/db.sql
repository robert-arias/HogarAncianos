CREATE TABLE 'Empleados'
('cedula' TEXT,
'nombre' TEXT,
'apellidos' TEXT,
'fecha_nacimiento' TEXT,
'telefono' TEXT,
'direccion' TEXT,
'puesto_trabajo' TEXT,
'horario_trabajo' TEXT,
'salario_base_mensual' REAL,
'fecha_contratacion' TEXT,
'estado_laboral' TEXT,
PRIMARY KEY(cedula));

CREATE TABLE 'Correos_Empleados'
('cedula' TEXT,
'correo' TEXT,
PRIMARY KEY(cedula, correo),
FOREIGN KEY (cedula) REFERENCES Empleados(cedula));

CREATE TABLE 'Medicamentos'(
'codigo_medicamento' TEXT,
'nombre_medicamento' TEXT,
'unidad_medida'TEXT,
'categoria' TEXT,
'cantidad_disponible' INTEGER,
'cantidad_prescrita' INTEGER,
 PRIMARY KEY (codigo_medicamento));

CREATE TABLE 'Pacientes'
('cedula' TEXT,
 'nombre' TEXT,
 'apellidos' TEXT,
 'fecha_nacimiento' TEXT,
 'edad' INTEGER,
 'sexo' TEXT,
PRIMARY KEY(cedula));

CREATE TABLE 'Prescripcion'(
'num' INTEGER,
'fecha_caducidad' TEXT,
'cedula_paciente'TEXT,
PRIMARY KEY(num));
FOREIGN KEY (cedula_paciente) REFERENCES Pacientes(cedula);
)


CREATE TABLE 'Prescripcion_Medicamentos'(
'num' INTEGER,
'codigo_medicamento' TEXT,
PRIMARY KEY(num,'codigo_medicamento');
FOREIGN KEY (codigo_medicamento) REFERENCES Medicamentos(codigo_medicamento);
)




CREATE TABLE "Usuarios" (
	'usuario'	TEXT,
	'contrasenia'	TEXT,
	'rol'	TEXT,
	PRIMARY KEY("usuario"));

CREATE TABLE 'Productos_Higiene'
(
'identificador_producto' TEXT,
'nombre_producto' TEXT,
'tipo_producto' TEXT,
'descripcion' TEXT,
 'cantidad' INTEGER,
 PRIMARY KEY(identificador_producto));
 
CREATE TABLE "Inventario_Productos" (
	"num"	INTEGER PRIMARY KEY AUTOINCREMENT,
	"identificador_producto"	TEXT,
	"cantidad"	INTEGER,
	"fecha_ingreso"	TEXT,
	FOREIGN KEY (identificador_producto) REFERENCES Productos_Higiene(identificador_producto)
);

CREATE TABLE "Salida_Productos"(
"num" INTEGER PRIMARY KEY AUTOINCREMENT,
"identificador_producto" TEXT,
"cantidad_sustraer" INTEGER,
"fecha_salida" TEXT, 
"cedula_empleado" TEXT,
FOREIGN KEY (identificador_producto) REFERENCES Productos_Higiene(identificador_producto),
FOREIGN KEY (cedula_empleado) REFERENCES Empleados(cedula));

