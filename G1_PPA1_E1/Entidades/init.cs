using System;
using System.Collections.Generic;

namespace G1_PPA1_E1.Entidades
{
    internal class init
    {
        //CREA ENCUESTAS
        public static List<RespuestaPosible> crearRespuestasPosibles()
        {
            List<RespuestaPosible> respuestasPosibles = new List<RespuestaPosible>
            {
                new RespuestaPosible("SI", "1"),
                new RespuestaPosible("NO", "2"),

                new RespuestaPosible("HORNO", "3"),
                new RespuestaPosible("MICROONDAS", "4"),
                new RespuestaPosible("HELADERA", "5"),

                new RespuestaPosible("DISCONFORME", "6"),
                new RespuestaPosible("POCO CONFORME", "7"),
                new RespuestaPosible("CONFORME", "8"),
                new RespuestaPosible("MUY CONFORME", "9"),

                new RespuestaPosible("BARATO", "1"),
                new RespuestaPosible("MUY CARO!!", "2"),

                new RespuestaPosible("VIERNES", "1"),
                new RespuestaPosible("SABADO", "2")
            };
            return respuestasPosibles;
        }

        public static List<Encuesta> crearListaEncuestas()
        {
            List<RespuestaPosible> respuestas = crearRespuestasPosibles();
            List<Pregunta> preguntas = new List<Pregunta>
            {
                new Pregunta("¿COMPRO EN LOS ULTIMOS 3 MESES?", new List<RespuestaPosible> {respuestas[0], respuestas[1] } ),
                new Pregunta("¿QUE ELECTRODOMESTICO LE INTERESA MAS?", new List<RespuestaPosible> { respuestas[2], respuestas[3], respuestas[4] } ),
                new Pregunta("¿QUE TAN CONFORME SE ENCUENTRA CON SU COMPRA?", new List<RespuestaPosible> { respuestas[5], respuestas[6], respuestas[7], respuestas[8] } ),

                new Pregunta("¿QUE LE PARECIO EL PRECIO?", new List<RespuestaPosible> { respuestas[9], respuestas[10]} ),
                new Pregunta("¿VOLVERIA A PROBAR NUESTROS HELADOS?", new List<RespuestaPosible> { respuestas[0], respuestas[1] } ),

             new Pregunta("¿El personal de atención al cliente fue capaz de resolver tus dudas o inquietudes?",new List<RespuestaPosible> { respuestas[0], respuestas[1] }),

            new Pregunta("¿La solución proporcionada a tu consulta/problema fue satisfactoria?", new List < RespuestaPosible > { respuestas[0], respuestas[1] }),

           new Pregunta("¿La atención al cliente que recibiste fue amable y cordial?", new List < RespuestaPosible > { respuestas[0], respuestas[1] }),

            new Pregunta("¿Recomendarías nuestros productos/servicios a otros?", new List < RespuestaPosible > { respuestas[0], respuestas[1] }),

        };
            List<Encuesta> encuestas = new List<Encuesta>
            {
                new Encuesta ("Encuesta Electrodomesticos", new List<Pregunta> {preguntas[0], preguntas[1] } ),
                new Encuesta ("Encuesta Heladeria", new List<Pregunta> {preguntas[3], preguntas[4]} ),
                new Encuesta ("Encuesta 2", new List<Pregunta> {preguntas[5], preguntas[6]} ),
                new Encuesta ("Encuesta 3", new List<Pregunta> {preguntas[7], preguntas[8]} )
            };
            return encuestas;
        }

        //CREA LLAMADAS

        public static List<Llamada> crearListaLlamadas()
        {
            List<Cliente> listaClientes = new List<Cliente>
            {
                new Cliente("12345678", "John Doe", "1234567890"),
                new Cliente("98765432", "Jane Smith", "876543210"),
                new Cliente("12345678", "Michael Johnson", "1234567890"),
                new Cliente ("John Doe","33999999","351678911" ),
            new Cliente("Jane Smith", "44888888", "351234567"),
            new Cliente("Bob Johnson", "55666666", "351987654"),
            new Cliente("Alice Williams", "66777777", "351111111"),
            new Cliente("Mike Davis", "77444444", "351222222"),
            new Cliente( "44240562","Juan Mateo Blencio", "3885325413"),
            new Cliente( "47248442","Zoi Lypnik", "351263987"),
            new Cliente("44489654", "Mari Gonzales", "351182233"),
            new Cliente("Agustina Sola", "43654897", "0115346798"),
            new Cliente("Valentin Ruiz", "46987531", "3875349784"),


        };
            List<Estado> estados = new List<Estado>
            {
                new Estado("Iniciada"),
                new Estado("Cancelada"),
                new Estado("Finalizada"),
            };
            List<CambioDeEstado> CambiosDeEstado = new List<CambioDeEstado>
            {
                //4 junio
                new CambioDeEstado(new DateTime(2022, 6, 4, 10, 30, 0), estados[0]),
                new CambioDeEstado(new DateTime(2022, 6, 4, 10, 45, 0), estados[1]),

                //1 junio esta anda mal
                new CambioDeEstado(new DateTime(2023, 4, 3, 18, 0, 0), estados[0]),
                new CambioDeEstado(new DateTime(2023, 4, 3, 19, 0, 0), estados[2]),
                //10 junio anda ok
                new CambioDeEstado(new DateTime(2023, 10, 10, 10, 0, 0), estados[0]),
                new CambioDeEstado(new DateTime(2023, 10, 10, 10, 30, 0), estados[2]),
                //25 junio 6-7
                new CambioDeEstado(new DateTime(2023, 12, 25, 10, 0, 0), estados[0]),
                new CambioDeEstado(new DateTime(2023, 12, 25, 10, 30, 0), estados[2]),
                //cambio estado nuevo 8-9 ok
                new CambioDeEstado(new DateTime(2022, 6, 15, 12, 40, 0), estados[0]),
                new CambioDeEstado(new DateTime(2022, 6, 15, 12, 50, 0), estados[1]),
                //cambio estado nuevo 10-11 ok
                new CambioDeEstado(new DateTime(2022, 11, 10, 12, 30, 0), estados[1]),
                new CambioDeEstado(new DateTime(2022, 11, 10, 12, 50, 0), estados[2]),


        };




            List<RespuestaPosible> respuestasPosibles = crearRespuestasPosibles();

            List<RespuestaDeCliente> respuestasCliente = new List<RespuestaDeCliente>

            {
                new RespuestaDeCliente(new DateTime(2023, 6, 1, 12, 30, 0), respuestasPosibles[0]),
                new RespuestaDeCliente(new DateTime(2023, 6, 1, 12, 30, 0), respuestasPosibles[2]),
                new RespuestaDeCliente(new DateTime(2023, 6, 1, 12, 30, 0), respuestasPosibles[5]),

                new RespuestaDeCliente(new DateTime(2024, 6, 10, 12, 30, 0), respuestasPosibles[10]),
                new RespuestaDeCliente(new DateTime(2024, 6, 10, 12, 30, 0), respuestasPosibles[1]),

                new RespuestaDeCliente(new DateTime(2022, 6, 15, 12, 30, 0), respuestasPosibles[0]),
                new RespuestaDeCliente(new DateTime(2022, 6, 15, 12, 40, 0), respuestasPosibles[4]),

                new RespuestaDeCliente(new DateTime(2022, 11, 10, 12, 30, 0), respuestasPosibles[0]),
                new RespuestaDeCliente(new DateTime(2022, 11, 10, 12, 40, 0), respuestasPosibles[4]),


            };
            List<Llamada> llamadas = new List<Llamada>
            {
                new Llamada("200", true, listaClientes[1], new List<CambioDeEstado>{ CambiosDeEstado[6], CambiosDeEstado[7] } , new List<RespuestaDeCliente>{respuestasCliente[0], respuestasCliente[1]},"Desc", "20", "observacion Auditor"),
                new Llamada("150", true, listaClientes[2], new List<CambioDeEstado>{ CambiosDeEstado[4], CambiosDeEstado[5]}, new List<RespuestaDeCliente>{ respuestasCliente[3], respuestasCliente[4]},"Desc", "20", "observacion Auditor"),
                 new Llamada("200", true, listaClientes[10], new List<CambioDeEstado>{ CambiosDeEstado[8], CambiosDeEstado[9] } , new List<RespuestaDeCliente>{respuestasCliente[5], respuestasCliente[6]},"Desc", "20", "observacion Auditor"),
                new Llamada("150", true, listaClientes[8], new List<CambioDeEstado>{ CambiosDeEstado[10], CambiosDeEstado[11]}, new List<RespuestaDeCliente>{respuestasCliente[7], respuestasCliente[8]},"Desc", "20", "observacion Auditor")               
            };

            return llamadas;
        }
    }
}