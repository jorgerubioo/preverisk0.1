using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common1.Cache;
using System.Xml.Linq;

namespace DataAccess { 

    public class UserDao:ConnectionToSql
    {
        public bool Login(string user, string pass)
    {
        using (var connection = GetConnection())
        {
            connection.Open();
            using (var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandText = "select * from Users where LoginName=@user and password=@pass";
                command.Parameters.AddWithValue("@user", user);
                command.Parameters.AddWithValue("@pass", pass);
      
                    command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                        {
                            UserLoginCache.UserID = reader.GetInt32(0);
                            UserLoginCache.firstName = reader.GetString(3);
                            UserLoginCache.lastName = reader.GetString(4);
                            UserLoginCache.position = reader.GetString(5);
                            UserLoginCache.email = reader.GetString(6);

                        }
                    return true;
                }
                else
                    return false;
                }
            }
        }

        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select * from Users where LoginName=@user or email=@email";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@email", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + ", " + reader.GetString(4);
                        string userMail = reader.GetString(6);
                        string accountPassword = reader.GetString(2);


                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                          subject: "Sistema: Solicitud de recuperacion de contraseña",
                          body: "Hola, " + userName + "\nSolicitud de recuperacion de contraseña.\n" +
                          "Tu Contraseña es: " + accountPassword +
                          "\nLe recomendamos un cambio de contraseña una vez ingrese al sistema.",
                          recipientMail: new List<string> { userMail }
                          );
                        return "Hola, " + userName + "\nSolicitud de recuperacion de contraseña.\n" +
                          "Por favor revisa tu correo electronico: " + userMail +
                          "\nLe recomendamos un cambio de contraseña una vez ingrese al sistema.";

                    }
                    else
                        return "Lo sentimos, no tiene una cuenta con este nombre de usuario o correo electronico";
                }
            }

        }
    }
    }
