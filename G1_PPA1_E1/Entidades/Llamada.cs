using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace G1_PPA1_E1.Entidades
{
    public class Llamada
    {
        //Atributos 
        private string duracion;
        private bool encuestaEnviada;
        private Cliente cliente;
        private List<RespuestaDeCliente> respuestasDeEncuesta;
        private List<CambioDeEstado> cambioDeEstado;
        private string descripcionOperador;
        private string detalleAccionRequerida;
        private string observacionAuditor;


        //Constructor
        public Llamada(string duracion, bool encuestaEnviada, Cliente cliente, List<CambioDeEstado> cambioDeEstado, List<RespuestaDeCliente> respuestasDeEncuesta,
             string descripcionOperador, string detalleAccionRequerida, string observacionAuditor)
        {
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.cliente = cliente;
            this.cambioDeEstado = cambioDeEstado;
            this.respuestasDeEncuesta = respuestasDeEncuesta;
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.observacionAuditor = observacionAuditor;
        }

        //Metodos


        public bool EsDePeriodo(DateTime fechaInicio, DateTime fechaFin)
        {
            DateTime? fechaEstadoInicial = cambioDeEstado.Min(c => c.getFechaHoraInicio());
            DateTime? fechaEstadoFinal = cambioDeEstado.Max(c => c.getFechaHoraInicio());

            return fechaEstadoInicial > fechaInicio && fechaEstadoFinal < fechaFin;
        }



        public bool esDePeriodo(DateTime fechaInicio, DateTime fechaFin)
        {

            DateTime? fechaEstadoInicial = null;
            DateTime? fechaEstadoFinal = null;

            foreach (CambioDeEstado cambioEstado in cambioDeEstado)
            {
                if (fechaEstadoInicial >= cambioEstado.getFechaHoraInicio() || fechaEstadoInicial == null)
                {
                    fechaEstadoInicial = cambioEstado.getFechaHoraInicio();
                }

                if (fechaEstadoFinal <= cambioEstado.getFechaHoraInicio() || fechaEstadoFinal == null)
                {
                    fechaEstadoFinal = cambioEstado.getFechaHoraInicio();
                }
            }

            if (fechaEstadoInicial > fechaInicio && fechaEstadoFinal < fechaFin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool tieneRespuestaDeCliente()
        {
            if (this.respuestasDeEncuesta.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DateTime getFechaLlamada()
        {
            CambioDeEstado cambioMasAntiguo = null;

            foreach (CambioDeEstado cambioEstado in cambioDeEstado)
            {
                if (cambioMasAntiguo == null || cambioEstado.getFechaHoraInicio() < cambioMasAntiguo.getFechaHoraInicio())
                {
                    cambioMasAntiguo = cambioEstado;
                }
            }
            return cambioMasAntiguo.getFechaHoraInicio();
        }
        public bool tieneEncuestaEnviada()
        {
            return encuestaEnviada;
        }



        public string DeterminarFechaHoraUltimoEstado => cambioDeEstado.LastOrDefault().getFechaHoraInicio().ToString(); // Esta habria q borrar?

        public string DescripcionOperador => descripcionOperador;
        public string DeterminarUltimoEstado
        {
            get
            {
                CambioDeEstado estadoFinal = null;

                foreach (CambioDeEstado cambioEstado in cambioDeEstado)
                {
                    if (estadoFinal == null || estadoFinal.getFechaHoraInicio() <= cambioEstado.getFechaHoraInicio())
                    {
                        estadoFinal = cambioEstado;
                    }
                }

                if (estadoFinal != null)
                {
                    return estadoFinal.GetNombreEstado();
                }

                return string.Empty; // Devuelve una cadena vacía en lugar de null si no se encuentra ningún estado.
            }
        }

        public string getNombreClienteDeLlamada()
        {
            return cliente.getNombre();
        }
        public string getDuracion()
        {
            return duracion;
        }

        public List<RespuestaDeCliente> GetRespuestas()
        {
            return respuestasDeEncuesta;
        }


        public List<string> getDescripcionRespuestaDeEncuesta()
        {
            List<string> arrayDescripcionesRta = new List<string>();

            foreach (RespuestaDeCliente respuesta in respuestasDeEncuesta)
            {
                arrayDescripcionesRta.Add(respuesta.getDescripcionRespuestaSeleccionada());
            }

            return arrayDescripcionesRta;
        }


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
