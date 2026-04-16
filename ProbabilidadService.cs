using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Web_API_Oracle_19c_ODP.NET
{
    public class ProbabilidadService
    {
        private readonly string _connectionString;

        public ProbabilidadService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("OracleDb");
        }

        public void Insertar(ProbabilidadEvento p)
        {
            using (var con = new OracleConnection(_connectionString))
            {
                con.Open();

                string sql = @"INSERT INTO PROBABILIDAD_EVENTO 
                (EVENTO, DESCRIPCION, VALOR_A, VALOR_B, TOTAL_CASOS, CASOS_FAVORABLES, 
                PROBABILIDAD, FECHA_CALCULO, USUARIO_CREACION, ESTADO, METODO, 
                VARIABLE1, VARIABLE2, VARIABLE3, VARIABLE4, VARIABLE5, 
                RESULTADO_TEXTO, OBSERVACIONES)
                VALUES (:EVENTO, :DESCRIPCION, :VALOR_A, :VALOR_B, :TOTAL_CASOS, :CASOS_FAVORABLES, :PROBABILIDAD, :FECHA_CALCULO, :USUARIO_CREACION, :ESTADO, :METODO, 
                :VARIABLE_1, :VARIABLE_2, :VARIABLE_3, :VARIABLE_4, :VARIABLE_5, 
                :RESULTADO_TEXTO, :OBSERVACIONES)";

                using (var cmd = new OracleCommand(sql, con))
                {
                    cmd.BindByName = true;

                    cmd.Parameters.Add(":EVENTO", p.Evento);
                    cmd.Parameters.Add(":DESCRIPCION", p.Descripcion);
                    cmd.Parameters.Add(":VALOR_A", p.ValorA);
                    cmd.Parameters.Add(":VALOR_B", p.ValorB);
                    cmd.Parameters.Add(":TOTAL_CASOS", p.TotalCasos);
                    cmd.Parameters.Add(":CASOS_FAVORABLES", p.CasosFavorables);
                    cmd.Parameters.Add(":PROBABILIDAD", p.Probabilidad);
                    cmd.Parameters.Add(":FECHA_CALCULO", p.FechaCalculo);
                    cmd.Parameters.Add(":USUARIO_CREACION", p.UsuarioCreacion);
                    cmd.Parameters.Add(":ESTADO", p.Estado);
                    cmd.Parameters.Add(":METODO", p.Metodo);
                    cmd.Parameters.Add(":VARIABLE_1", p.Variable1);
                    cmd.Parameters.Add(":VARIABLE_2", p.Variable2);
                    cmd.Parameters.Add(":VARIABLE_3", p.Variable3);
                    cmd.Parameters.Add(":VARIABLE_4", p.Variable4);
                    cmd.Parameters.Add(":VARIABLE_5", p.Variable5);
                    cmd.Parameters.Add(":RESULTADO_TEXTO", p.ResultadoTexto);
                    cmd.Parameters.Add(":OBSERVACIONES", p.Observaciones);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}   
