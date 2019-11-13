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
'cantidad_disponible' TEXT,
'cantidad_prescrita' TEXT,
 PRIMARY KEY (codigo_medicamento));

CREATE TABLE 'Pacientes'
('cedula' TEXT,
 'nombre' TEXT,
 'apellidos' TEXT,
 'fecha_nacimiento' TEXT,
 'edad' INTEGER,
 'sexo' TEXT,
PRIMARY KEY(cedula));
