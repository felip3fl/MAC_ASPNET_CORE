using Microsoft.Extensions.Configuration;
using Mvc_BO.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc_BO.Models
{
    public class AlunoBLL : IAlunoBLL
    {
        public List<Aluno> GetAlunos()
        {
            var configuraton = ConfigurationHelper.GetConfiguration(Directory.GetCurrentDirectory());
            var conexaoString = configuraton.GetConnectionString("DefaultConnection");

            List<Aluno> alunos = new List<Aluno>();

            try
            {
                using (SqlConnection con = new SqlConnection(conexaoString))
                {
                    SqlCommand cmd = new SqlCommand("GetAlunos", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Aluno aluno = new Aluno();
                        aluno.Id = Convert.ToInt32(rdr["Id"]);
                        aluno.Nome = rdr["Nome"].ToString();
                        aluno.Sexo = rdr["Sexo"].ToString();
                        aluno.Email = rdr["Email"].ToString();
                        aluno.Nascimento = Convert.ToDateTime(rdr["Nascimento"]);
                        alunos.Add(aluno);
                    }
                }
                return alunos;
            }
            catch
            {
                throw;
            }

        }
    }
}
