using Aplicacion.Servicio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo.Entidades;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddCita()
        {
            // Arrange
            tb_citas cita = new tb_citas
            {
                ClienteId = 1,
                HorarioId = 1,
                Fecha = DateTime.Now,
                Motivo = "Consulta",
                Estado = "Pendiente"
            };

            CitasService citasService = new CitasService();

            // Act
            citasService.Add(cita);

            // Assert
            var citas = citasService.GetAll();
            Assert.IsNotNull(citas);
            foreach (var c in citas)
            {
                Console.WriteLine($"ID: {c.Id}, ClienteId: {c.ClienteId}, HorarioId: {c.HorarioId}, Fecha: {c.Fecha}, Motivo: {c.Motivo}, Estado: {c.Estado}");
            }
        }

        [TestMethod]
        public void TestAddReserva()
        {
            // Arrange
            tb_reservas reserva = new tb_reservas
            {
                ClienteId = 1,
                ServicioId = 1,
                Fecha = DateTime.Now,
                Hora = new TimeSpan(10, 0, 0),
                Estado = "Pendiente"
            };

            ReservasService reservasService = new ReservasService();

            // Act
            reservasService.Add(reserva);

            // Assert
            var reservas = reservasService.GetAll();
            Assert.IsNotNull(reservas);
            foreach (var r in reservas)
            {
                Console.WriteLine($"ID: {r.Id}, ClienteId: {r.ClienteId}, ServicioId: {r.ServicioId}, Fecha: {r.Fecha}, Hora: {r.Hora}, Estado: {r.Estado}");
            }
        }

      
        [TestMethod]
        public void TestAddHorario()
        {
            // Arrange
            tb_horarios horario = new tb_horarios
            {
                TerapeutaId = 1,
                SalonId = 1,
                DiaSemana = "Lunes",
                HoraInicio = new TimeSpan(9, 0, 0),
                HoraFin = new TimeSpan(17, 0, 0)
            };

            HorariosService horariosService = new HorariosService();

            // Act
            horariosService.Add(horario);

            // Assert
            var horarios = horariosService.GetAll();
            Assert.IsNotNull(horarios);
            foreach (var h in horarios)
            {
                Console.WriteLine($"ID: {h.Id}, TerapeutaId: {h.TerapeutaId}, SalonId: {h.SalonId}, DiaSemana: {h.DiaSemana}, HoraInicio: {h.HoraInicio}, HoraFin: {h.HoraFin}");
            }
        }

        [TestClass]
        public class TerapeutasServiceTests
        {
            [TestMethod]
            public void TestAddTerapeuta()
            {
                // Arrange
                tb_terapeutas terapeuta = new tb_terapeutas
                {
                    Nombre = "Ana",
                    Apellido = "Gómez",
                    UsuarioId = 1,
                    EspecialidadId = 1
                };

                TerapeutasService terapeutasService = new TerapeutasService();

                // Act
                terapeutasService.Add(terapeuta);

                // Assert
                var terapeutas = terapeutasService.GetAll();
                Assert.IsNotNull(terapeutas);
                foreach (var t in terapeutas)
                {
                    Console.WriteLine($"ID: {t.Id}, Nombre: {t.Nombre}, Apellido: {t.Apellido}");
                }
            }
        }

        [TestMethod]
        public void TestAddSalon()
        {
            // Arrange
            tb_salones salon = new tb_salones
            {
                Nombre = "Salon Principal",
                Direccion = "Av. Principal 123",
                Telefono = "987654321"
            };

            SalonesService salonesService = new SalonesService();

            // Act
            salonesService.Add(salon);

            // Assert
            var salones = salonesService.GetAll();
            Assert.IsNotNull(salones);
            foreach (var s in salones)
            {
                Console.WriteLine($"ID: {s.Id}, Nombre: {s.Nombre}, Direccion: {s.Direccion}, Telefono: {s.Telefono}");
            }
        }

        [TestMethod]
        public void TestAddServicio()
        {
            // Arrange
            tb_servicios servicio = new tb_servicios
            {
                Nombre = "Masaje Relajante",
                Descripcion = "Un masaje para aliviar el estrés."
            };

            ServiciosService serviciosService = new ServiciosService();

            // Act
            serviciosService.Add(servicio);

            // Assert
            var servicios = serviciosService.GetAll();
            Assert.IsNotNull(servicios);
            foreach (var s in servicios)
            {
                Console.WriteLine($"ID: {s.Id}, Nombre: {s.Nombre}, Descripcion: {s.Descripcion}");
            }
        }

        [TestMethod]
        public void TestAddEspecialidad()
        {
            // Arrange
            tb_especialidades especialidad = new tb_especialidades
            {
                Nombre = "Fisioterapia"
            };

            EspecialidadesService especialidadesService = new EspecialidadesService();

            // Act
            especialidadesService.Add(especialidad);

            // Assert
            var especialidades = especialidadesService.GetAll();
            Assert.IsNotNull(especialidades);
            foreach (var e in especialidades)
            {
                Console.WriteLine($"ID: {e.Id}, Nombre: {e.Nombre}");
            }
        }
        [TestMethod]
        public void TestAddUsuario()
        {
            // Arrange
            tb_usuarios usuario = new tb_usuarios
            {
                Usuario = "doctor.1",
                Email = "mail@mimail.com",
                Contraseña = "esunacontra",
                Rol = "DOCTOR"
            };

            UsuariosService usuariosService = new UsuariosService();

            // Act
            usuariosService.Add(usuario);

            // Assert
            var usuarios = usuariosService.GetAll();
            Assert.IsNotNull(usuarios);
            foreach (var u in usuarios)
            {
                Console.WriteLine($"ID: {u.Id}, Usuario: {u.Usuario}, Email: {u.Email}, Rol: {u.Rol}");
            }
        }

        [TestMethod]
        public void TestAddCliente()
            {
                tb_clientes cli = new tb_clientes
                {
                    Nombre = "Juan",
                    Apellido = "Pérez",
                    Direccion = "Direccion",
                    Telefono = "123456789",
                    FechaNacimiento = new DateTime(),
                    Identificacion = "1234567890",
                    UsuarioId = 1

                };

                ClienteService clienteService = new ClienteService();

                clienteService.Add(cli);

                var clientes = clienteService.GetAll();

                Assert.IsNotNull(clientes);
                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"ID: {cliente.Id}, Nombre: {cliente.Nombre}, Apellido: {cliente.Apellido}, Identificacion: {cliente.Identificacion}, Telefono: {cliente.Telefono}");
                }
            }
    }
}

