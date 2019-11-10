CREATE TABLE 'Empleados'
('cedula' TEXT,
'nombre' TEXT,
'apellidos' TEXT,
'fecha_nacimiento' TEXT,
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