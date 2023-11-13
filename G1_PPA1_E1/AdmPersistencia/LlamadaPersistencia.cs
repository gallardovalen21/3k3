using G1_PPA1_E1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1_PPA1_E1.AdmPersistencia
{
    public class LlamadaPersistencia
    {

        // Método estático para construir una lista de objetos Llamada desde los resultados de la consulta SQL
        public static List<Llamada> MaterializarDesdeConsulta(List<object[]> resultadosConsulta)
        {
            List<Llamada> llamadas = new List<Llamada>();

            foreach (object[] resultado in resultadosConsulta)
            {
                // Crear Cliente
                Cliente cliente = new Cliente(resultado[6].ToString(), resultado[7].ToString(), resultado[8].ToString());

                // Crear CambioDeEstado
                CambioDeEstado cambioEstado = new CambioDeEstado(Convert.ToDateTime(resultado[9]), new Estado(resultado[8].ToString()));

                // Crear RespuestaDeCliente
                RespuestaDeCliente respuestaCliente = new RespuestaDeCliente(Convert.ToDateTime(resultado[9]), new RespuestaPosible(resultado[10].ToString()));

                // Crear Llamada
                Llamada llamada = new Llamada(
                    resultado[3].ToString(), // Duracion
                    Convert.ToBoolean(resultado[4]), // EncuestaEnviada
                    cliente,
                    new List<CambioDeEstado> { cambioEstado }, // Lista con un solo CambioDeEstado
                    new List<RespuestaDeCliente> { respuestaCliente }, // Lista con una sola RespuestaDeCliente
                    resultado[1].ToString(), // DescripcionOperador
                    resultado[2].ToString(), // DetalleAccionRequerida
                    resultado[5].ToString() // ObservacionAuditor
                );

                llamadas.Add(llamada);
            }

            return llamadas;
        }



    }
}
