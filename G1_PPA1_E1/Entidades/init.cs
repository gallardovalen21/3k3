using G1_PPA1_E1.AdmPersistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace G1_PPA1_E1.Entidades
{
    internal class init
    {
        // CREA LLAMADAS
        public static List<Llamada> crearListaLlamadas()
        {
            List<Llamada> llamadas = new List<Llamada>();

            string connectionString = "Data Source=DESKTOP-DJC9I4E\\SQLEXPRESS;Initial Catalog=dsi_ppai_maui_db;Integrated Security=True";

            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT L.LlamadaId, L.DescripcionOperador, L.DetalleAccionRequerida, L.Duracion, L.EncuestaEnviada, L.ObservacionAuditor, C.Dni AS DniCliente, C.NombreCompleto AS NombreCliente, E.Nombre AS EstadoActual, CE.FechaHoraInicio AS FechaCambioEstado FROM Llamada AS L JOIN Cliente AS C ON L.DniCliente = C.Dni JOIN CambioEstado AS CE ON L.LlamadaId = CE.LlamadaId JOIN Estado AS E ON CE.EstadoId = E.EstadoId", cn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        List<object[]> resultadosConsulta = new List<object[]>();

                        while (reader.Read())
                        {
                            object[] resultado = new object[reader.FieldCount];
                            reader.GetValues(resultado);
                            resultadosConsulta.Add(resultado);
                        }

                        llamadas = LlamadaPersistencia.MaterializarDesdeConsulta(resultadosConsulta);
                    }
                }
            }

            return llamadas;
        }
    }
}
