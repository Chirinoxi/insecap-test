namespace SGC.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<SGC.Models.InsecapContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SGC.Models.InsecapContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // ------------------------------ Opciones URL Menu ------------------------------------

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/AdminRoles/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/AdminRoles/Create/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/AdminUsers/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/AdminUsers/Create/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/Bloques/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Bloques/Create/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/Bloques/List/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Bloques/PizarraAeropuerto/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Bloques/PizarraTriangular/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/CalendarizacionAbiertas/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Calendarizacions/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/Calendarizacions/Calendario/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Calendarizacions/Create/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/CategoriaItems/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/CategoriaR11/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/CategoriaR11/Create" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Checklists/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Checklists/Create/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Cliente/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Cliente/Create/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/ClienteContacto/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/ClienteContacto/Comercializaciones/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/ClienteContacto/Cotizaciones/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/ClienteContacto/CrearAutoCotizacion/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Comercializacions/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/Comercializacions/Create/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/ComponentCategory/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/ConfiguracionUsuarioParticipante/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Contacto/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Contacto/Create/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/CostoParticularCurso/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Cotizacion_R13/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Cotizacion_R13/Create/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Curso/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Curso/Create/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/Document/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/DocumentoCompromiso/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/EstadoComercial/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/Evaluacion/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Factura/Facturable/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/FileAzures/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/FormatoDocumento/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/FormatoDocumentoR50/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Formularios/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Formularios/Create/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Giro/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Giro/Create/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Home/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/Item/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/ListaDetalleCosto/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/ListaDetalleCosto/Create/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/LugarAlmuerzoes/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/LugarAlmuerzoes/Create/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Mandante/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Mandante/Create/" });

            // no debe estar en el menu
            // context.Url.AddOrUpdate(x => x.url,
            //     new Models.Url { url = "/Notificacion/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Otics/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Otics/Create/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/ParametrosMoodles/Create/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/Participante/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Permissions/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Permissions/MenuCreate/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Permissions/MenuIndex/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/R11/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/R19/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/R19Participantes/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/R51/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/R52/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Relator/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Relator/Perfil/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Relator/Create/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/RelatorCurso/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/RelatorCurso/Create/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/RelatorCurso/Solicitudes/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/RelatorCursoSolicitado/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Salas/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Salas/Create/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/SalidaTerreno/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/SalidaTerreno/MisSalidas/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/SalidaTerreno/SalidasCliente/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/SalidaTerreno/Calendario/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Templates/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Templates/Create/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/TipoDocCompromisoes/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/TipoFormatoDocumento/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/TiposDocumentosPago/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/TiposDocumentosPago/Create/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/Upload/" });

            //context.Url.AddOrUpdate(x => x.url,
            //    new Models.Url { url = "/UsuarioMoodles/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/PanelGerencia/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/MetasSucursal/Sucursales/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/MetasVendedor/Vendedores/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Reportes/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/ValidarCredenciales/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Sucursal/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/AporteCapacitacion/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/AporteCapacitacion/Create/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/ConfiguracionUsuarioRelator/" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/LandingPageParticipante/" });

            // ------------------------------ INSECAP-TEST ------------------------------------

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Categoria" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/Inventario" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/InventarioDetalle" });

            context.Url.AddOrUpdate(x => x.url,
                new Models.Url { url = "/InventarioCaracteristicas" });

            // ------------------------------ Notificaciones ------------------------------------

            //context.NotificacionConfig.AddOrUpdate(x => x.nombre,
            //    new Models.NotificacionConfig {
            //        nombre = "Alerta de Cliente Deudor",
            //        titulo = "Comercializaci�n Modificada",
            //        mensaje = "Se ha modificado la comercializaci�n {0}.",
            //        url = "/Comercializacions/Details/{0}",
            //        tipo = "Alerta",
            //        color = Models.ColorNotificacion.white
            //    });

            //context.NotificacionConfig.AddOrUpdate(x => x.nombre,
            //    new Models.NotificacionConfig { 
            //        nombre = "Alerta de Cliente sin OC",
            //    });

            context.NotificacionConfig.AddOrUpdate(x => x.nombre,
                new Models.NotificacionConfig
                {
                    nombre = "Alerta de Cliente Post Venta", // Rol: Lider Comercial, Administrador
                    titulo = "Cliente Post Venta",
                    mensaje = "El Cliente {0} lleva mas de 3 meses sin realizar algun curso.",
                    url = "/Cliente/Details/{0}",
                    tipo = "Alerta",
                    color = Models.ColorNotificacion.white
                });

            context.NotificacionConfig.AddOrUpdate(x => x.nombre,
                new Models.NotificacionConfig
                {
                    nombre = "Alerta Comercializaci�n Terminada", // Rol: Facturacion
                    titulo = "Comercializaci�n Terminada",
                    mensaje = "Se ha terminado la comercializaci�n {0}.",
                    url = "/Comercializacions/Details/{0}",
                    tipo = "Alerta",
                    color = Models.ColorNotificacion.white
                });

            context.NotificacionConfig.AddOrUpdate(x => x.nombre,
                new Models.NotificacionConfig
                {
                    nombre = "Alerta Comercializaci�n Cancelada", // Rol: Facturacion
                    titulo = "Comercializaci�n Cancelada",
                    mensaje = "Se ha cancelado la comercializaci�n {0}.",
                    url = "/Comercializacions/Details/{0}",
                    tipo = "Alerta",
                    color = Models.ColorNotificacion.white
                });

            context.NotificacionConfig.AddOrUpdate(x => x.nombre,
                new Models.NotificacionConfig
                {
                    nombre = "Alerta Comercializaci�n Terminada SENCE", // Rol: Facturacion
                    titulo = "Comercializaci�n Terminada SENCE",
                    mensaje = "Se ha terminado SENCE en la comercializaci�n {0}.",
                    url = "/Comercializacions/Details/{0}",
                    tipo = "Alerta",
                    color = Models.ColorNotificacion.white
                });

            context.NotificacionConfig.AddOrUpdate(x => x.nombre,
                new Models.NotificacionConfig
                {
                    nombre = "Alerta Comercializaci�n Modificada", // Rol: Facturacion
                    titulo = "Comercializaci�n Modificada",
                    mensaje = "Se ha modificado la comercializaci�n {0}.",
                    url = "/Comercializacions/Details/{0}",
                    tipo = "Alerta",
                    color = Models.ColorNotificacion.white
                });

            context.NotificacionConfig.AddOrUpdate(x => x.nombre,
                new Models.NotificacionConfig
                {
                    nombre = "Alerta Instructor No vinculado a sence",
                    titulo = "Instructor No vinculado a sence",
                    mensaje = "La comercializaci�n {0} tiene un instructor no vinculado a sence.",
                    url = "/Comercializacions/Details/{0}",
                    tipo = "Alerta",
                    color = Models.ColorNotificacion.red
                });

            context.NotificacionConfig.AddOrUpdate(x => x.nombre,
                new Models.NotificacionConfig
                {
                    nombre = "Alerta Falta Orden de Compra", // Rol: Lider Comercial, Administrador
                    titulo = "Falta Orden de Compra",
                    mensaje = "La comercializaci�n {0} tiene pendiente la Orden de Compra.",
                    url = "/Comercializacions/Details/{0}",
                    tipo = "Alerta",
                    color = Models.ColorNotificacion.red
                });

            context.NotificacionConfig.AddOrUpdate(x => x.nombre,
                new Models.NotificacionConfig
                {
                    nombre = "Alerta Nueva Auto Cotizaci�n", // Rol: Lider Comercial
                    titulo = "Nueva Auto Cotizaci�n",
                    mensaje = "Se ha creado la auto cotizaci�n {0}.",
                    url = "/Cotizacion_R13/Details/{0}",
                    tipo = "Alerta",
                    color = Models.ColorNotificacion.white
                });

            context.NotificacionConfig.AddOrUpdate(x => x.nombre,
                new Models.NotificacionConfig
                {
                    nombre = "Alerta 95% R52", // Rol: Administrador
                    titulo = "Monitoreo de Cursos",
                    mensaje = "El relator {0} obtuvo menos de 95% en su evaluaci�n.",
                    url = "/R52/Relatores/{0}",
                    tipo = "Alerta",
                    color = Models.ColorNotificacion.red
                });

            context.NotificacionConfig.AddOrUpdate(x => x.nombre,
                new Models.NotificacionConfig
                {
                    nombre = "Notificacion Curso Aceptado", // Usuario
                    titulo = "Curso Aceptado",
                    mensaje = "Se ha aceptado su solicitud para el curso {0}.",
                    url = "/Relator/CursosHablitados/{0}",
                    tipo = "Aviso",
                    color = Models.ColorNotificacion.white
                });

            context.NotificacionConfig.AddOrUpdate(x => x.nombre,
                new Models.NotificacionConfig
                {
                    nombre = "Notificacion Curso Rechazado", // Usuario
                    titulo = "Curso Rechazado",
                    mensaje = "Se ha rechazado su solicitud para el curso {0}.",
                    url = "/RelatorCursoSolicitado/SolicitarCursos/{0}",
                    tipo = "Aviso",
                    color = Models.ColorNotificacion.white
                });

            context.NotificacionConfig.AddOrUpdate(x => x.nombre,
                new Models.NotificacionConfig
                {
                    nombre = "Alerta de Encuesta de Satisfacci�n Cliente", // Rol: Lider Comercial, Administrador
                    titulo = "Encuesta de Satisfacci�n Cliente",
                    mensaje = "El Cliente {0} debe realizar una Ecuesta de Satisfacci�n.",
                    url = "/Cliente/Details/{0}",
                    tipo = "Alerta",
                    color = Models.ColorNotificacion.white
                });

            context.NotificacionConfig.AddOrUpdate(x => x.nombre,
                new Models.NotificacionConfig
                {
                    nombre = "Alerta de Encuesta de Satisfacci�n para Cliente", // Usuario
                    titulo = "Encuesta de Satisfacci�n",
                    mensaje = "Existe una encuesta de satisfacci�n.",
                    url = "/ClienteContacto/LandingPage",
                    tipo = "Alerta",
                    color = Models.ColorNotificacion.white
                });

            context.NotificacionConfig.AddOrUpdate(x => x.nombre,
                new Models.NotificacionConfig
                {
                    nombre = "Alerta de Confirmacion de Curso Relator", // Usuario
                    titulo = "Confirmaci�n de Curso",
                    mensaje = "Debe confirmar que realizara el curso {0}.",
                    url = "/Comercializacions/ConfirmarCurso/{0}",
                    tipo = "Alerta",
                    color = Models.ColorNotificacion.white
                });

            context.NotificacionConfig.AddOrUpdate(x => x.nombre,
                new Models.NotificacionConfig
                {
                    nombre = "Alerta 95% R25 Resultados", //Rol: Dise�o y desarrollo, lider comercial, administrador
                    titulo = "Resultados R25 menor a 95%",
                    mensaje = "El resultado del R25 de la comercializaci�n {0} fue menor a 95%.",
                    url = "/Comercializacions/Details/{0}",
                    tipo = "Alerta",
                    color = Models.ColorNotificacion.red
                });

            context.NotificacionConfig.AddOrUpdate(x => x.nombre,
                new Models.NotificacionConfig
                {
                    nombre = "Alerta Participante no Respondio R19", //Rol: Dise�o y desarrollo, lider comercial, administrador
                    titulo = "Falto Responder R19",
                    mensaje = "Uno o varios participantes no respondieron el R19 en la comercializaci�n {0}.",
                    url = "/Comercializacions/Details/{0}",
                    tipo = "Alerta",
                    color = Models.ColorNotificacion.red
                });

            context.NotificacionConfig.AddOrUpdate(x => x.nombre,
                new Models.NotificacionConfig
                {
                    nombre = "Alerta R53 Encuesta Aplicación Metodología", //Rol: Diseño y desarrollo, administrador
                    titulo = "Nuevo R53",
                    mensaje = "Se ha creado un R53 para la comercialización {0}.",
                    url = "/Comercializacions/Details/{0}",
                    tipo = "Alerta",
                    color = Models.ColorNotificacion.white
                });

            // emails

            context.TextoEmail.AddOrUpdate(x => x.email,
                new Models.TextoEmail
                {
                    email = "Confirmación Curso Relator",
                    motivo = "Confirmación Curso Insecap",
                    texto = "Estimado/a {1},{0}{0}Para confirmar que realizara el curso {2}, ingrese aquí {3}.{0}{0}Atte.{0}{0}Insecap"
                });

            context.TextoEmail.AddOrUpdate(x => x.email,
                new Models.TextoEmail
                {
                    email = "Comercialización Terminada",
                    motivo = "Comercializacón Terminada",
                    texto = "Estimado/a {1},{0}{0}Se ha terminado la comercialización {2}, ingrese aquí para ver los detalles {3}.{0}{0}Atte.{0}{0}Insecap"
                });
        }
    }
}
