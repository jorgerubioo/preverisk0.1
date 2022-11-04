using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using DataAccess;
using DataAccess.SqlServer;


namespace Presentation.Administrator
{
    public partial class ReporteGlobal : Form
    {


        SqlConnection Conexion = new SqlConnection("Server=LAPTOP-VTLJ41I5\\SQLEXPRESS;DataBase=PortafolioTest;Integrated Security=true");
        SqlCommand cmd;
        SqlDataReader dr;
        public ReporteGlobal()
        {
            InitializeComponent();
        }

        private void ReporteGlobal_Load(object sender, EventArgs e)
        {

            GrafCantSolicitudes();
            AccidentabilidadEmpresas();
            DashboardDatosAdmin();
            

        }

        ArrayList Empresa = new ArrayList();
        ArrayList CantSolicitudes = new ArrayList();



        private void GrafCantSolicitudes()
        {

            cmd = new SqlCommand("CantidadSolicitudesporEmpresa", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Empresa.Add(dr.GetString(0));
                CantSolicitudes.Add(dr.GetInt32(1));
            }
            chartCantidadSolicitudes.Series[0].Points.DataBindXY(Empresa, CantSolicitudes);
            dr.Close();
            Conexion.Close();


        }
        ArrayList NEmpresa = new ArrayList();
        ArrayList Accidentabilidad = new ArrayList();
        private void AccidentabilidadEmpresas()
        {
            cmd = new SqlCommand("indiceAccidentabilidad", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                NEmpresa.Add(dr.GetString(0));
                Accidentabilidad.Add(dr.GetInt32(1));
            }
            chartAccidentabilidad.Series[0].Points.DataBindXY(NEmpresa, Accidentabilidad);
            dr.Close();
            Conexion.Close();
        }
        private void DashboardDatosAdmin()
        {
            cmd = new SqlCommand("DashboardDatos", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter totalusers = new SqlParameter("@totusers", 0); totalusers.Direction = ParameterDirection.Output;
            SqlParameter totaladmin = new SqlParameter("@totadmin", 0); totaladmin.Direction = ParameterDirection.Output;
            SqlParameter totalclient = new SqlParameter("@totclient", 0); totalclient.Direction = ParameterDirection.Output;
            SqlParameter totalprof = new SqlParameter("@totprof", 0); totalprof.Direction = ParameterDirection.Output;
            SqlParameter totempresas = new SqlParameter("@totempresas", 0); totempresas.Direction = ParameterDirection.Output;
           
            
            cmd.Parameters.Add(totalusers);
            cmd.Parameters.Add(totaladmin);
            cmd.Parameters.Add(totalclient);
            cmd.Parameters.Add(totalprof);
            cmd.Parameters.Add(totempresas);
            
            Conexion.Open();
            cmd.ExecuteNonQuery();

            lblTotalUser.Text = cmd.Parameters["@totusers"].Value.ToString();
            lbltotaladmin.Text = cmd.Parameters["@totadmin"].Value.ToString();
            lbltotalclient.Text = cmd.Parameters["@totclient"].Value.ToString();
            lbltotalprof.Text = cmd.Parameters["@totprof"].Value.ToString();
            lblTotalempresas.Text = cmd.Parameters["@totempresas"].Value.ToString();
            
            Conexion.Close();
        }

      
    }
        }
    




