using access_windows_form.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using access_windows_form.Modelo;
using System.Data.OleDb;

namespace access_windows_form
{
    public partial class Form1 : Form
    {
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();


        }

       
        

        #region "Mis variable"
        int nestadoguadar = 0;
        int ncodigo_ar = 0;
        int ncodigo_me = 0;
        int ncodigo_ca = 0;

        #endregion







        #region mis metodos
        private void formatova()
        {
            data.Columns[0].Width = 90;
            data.Columns[0].HeaderText = "Codigo_ar";
            data.Columns[1].Width = 200;
            data.Columns[1].HeaderText = "articulo";
            data.Columns[2].Width = 120;
            data.Columns[2].HeaderText = "marca";
            data.Columns[3].Width = 120;
            data.Columns[3].HeaderText = "medida";
            data.Columns[4].Width = 120;
            data.Columns[4].HeaderText = "categoria";
            data.Columns[5].Visible = false;
            data.Columns[6].Visible = false;


        }

        private void Listadoar(string ctext)
        {
            L_articulos Datos = new L_articulos();
            data.DataSource = Datos.Listado_ar(ctext);
            this.formatova();


        }
        private void estadotexto(bool lestado)
        {
            txtdescar.ReadOnly = !lestado;
            txtmar.ReadOnly = !lestado;


        }
        private void Estado_botones(bool lestado)
        {
            btncancela.Visible = lestado;
            btnsave.Visible = lestado;

            btnca.Visible = lestado;
            btnmedidas.Visible = lestado;




            txtbuscar.Enabled = !lestado;
            data.Enabled = !lestado;








        }
        private void limpiartext()
        {
            txtdescar.Clear();
            txtmar.Clear();
            txtcat.Clear();
            txtmedida.Clear();

        }
        private void estado_botonespincipal(bool lestado)
        {
            btnsave.Enabled = lestado;
            btnup.Enabled = lestado;
            btndrop.Enabled = lestado;
            btncancela.Enabled = lestado;

            btnexit.Enabled = lestado;





        }
        private void selecionaitem()
        {
            if (string.IsNullOrEmpty(Convert.ToString(data.CurrentRow.Cells["codigo_ar"].Value)))
            {
                MessageBox.Show("Seleciona un registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ncodigo_ar = Convert.ToInt32(data.CurrentRow.Cells["codigo_ar"].Value);

                txtdescar.Text = Convert.ToString(data.CurrentRow.Cells["desc_ar"].Value);
                txtmar.Text = Convert.ToString(data.CurrentRow.Cells["marca_ar"].Value);
                txtmedida.Text = Convert.ToString(data.CurrentRow.Cells["desc_me"].Value);

                txtcat.Text = Convert.ToString(data.CurrentRow.Cells["desc_ca"].Value);



                ncodigo_me = Convert.ToInt32(data.CurrentRow.Cells["codigo_me"].Value);
                ncodigo_ca = Convert.ToInt32(data.CurrentRow.Cells["codigo_ca"].Value);



            }
        }


        private void formatome()
        {


            dgv_me.Columns[0].Width = 180;
            dgv_me.Columns[0].HeaderText = "Medida";
            dgv_me.Columns[1].Visible = false;



        }


        private void Listado_me()
        {
            L_articulos Datos = new L_articulos();
            dgv_me.DataSource = Datos.Listado_me();
            this.formatome();


        }
        #endregion

        private void selecionaitemme()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dgv_me.CurrentRow.Cells["codigo_me"].Value)))
            {
                MessageBox.Show("Seleciona un registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ncodigo_me = Convert.ToInt32(dgv_me.CurrentRow.Cells["codigo_me"].Value);
                txtmedida.Text = Convert.ToString(dgv_me.CurrentRow.Cells["desc_me"].Value);






            }
        }




        private void formatoca()
        {


            dvgcat.Columns[0].Width = 180;
            dvgcat.Columns[0].HeaderText = "Categoria";
            dvgcat.Columns[1].Visible = false;



        }


        private void Listado_ca()
        {
            L_articulos Datos = new L_articulos();
            dvgcat.DataSource = Datos.Listado_ca();
            this.formatoca();


        }


        private void selecionaitemca()
        {
            if (string.IsNullOrEmpty(Convert.ToString(dvgcat.CurrentRow.Cells["codigo_ca"].Value)))
            {
                MessageBox.Show("Seleciona un registro", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ncodigo_ca = Convert.ToInt32(dvgcat.CurrentRow.Cells["codigo_ca"].Value);
                txtcat.Text = Convert.ToString(dvgcat.CurrentRow.Cells["desc_ca"].Value);






            }
        }










        private void Form1_Load(object sender, EventArgs e)
        {
            this.Listadoar("%");
            this.Listado_me();
            this.Listado_ca();

            OleDbDataReader Resultado;
            DataTable tabla = new DataTable();
            OleDbConnection SqlCon = new OleDbConnection();
            string Sqltarea = "SELECT * from tb_articulo";
            SqlCon = conexion.getInstancia().crearcon();



           
            sqlcommand = new SqlCommand(Query, sqlconnection);

            sqladapter = new SqlDataAdapter();

            datatable = new DataTable();

            sqladapter.SelectCommand = sqlcommand;

            sqladapter.Fill(datatable);

            dataGridView1.DataSource = datatable;









        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            nestadoguadar = 1;
            this.limpiartext();
            this.estado_botonespincipal(true);

            this.Estado_botones(true);
            txtdescar.Focus();

        }

        private void btncancela_Click(object sender, EventArgs e)
        {
            nestadoguadar = 0;
            this.estadotexto(true);
            this.limpiartext();
            this.estado_botonespincipal(false);
            this.Estado_botones(true);





        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (txtdescar.Text == String.Empty || txtmar.Text == String.Empty)

            {
                MessageBox.Show("Ingrese datos requeridos (*)", "Aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }
            else
            {
                m_articulo oros = new m_articulo();
                oros.codigo_ar = ncodigo_ar;
                oros.desc_ar = txtdescar.Text.Trim();
                oros.marca_ar = txtmar.Text.Trim();
                oros.codigo_me = ncodigo_me;
                oros.codigo_ca = ncodigo_ca;

                string rtpa = "";
                L_articulos datos = new L_articulos();
                rtpa = datos.Guardar_ar(nestadoguadar, oros);
                if (rtpa.Equals("Ok"))

                {
                    this.estadotexto(false);
                    this.Estado_botones(false);
                    this.estado_botonespincipal(true);
                    this.Listadoar("%");
                    nestadoguadar = 0;
                    ncodigo_ar = 0;
                    ncodigo_me = 0;
                    ncodigo_ca = 0;



                    MessageBox.Show("Los datos has sido guardo corretamente ", "aviso del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);




                }
                else
                {
                    MessageBox.Show(rtpa);
                }
            }
        }

        private void btnup_Click(object sender, EventArgs e)
        {
            nestadoguadar = 2;
            this.estadotexto(true);
            this.estado_botonespincipal(true);

            this.Estado_botones(true);
            txtdescar.Focus();






















        }

        private void data_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.selecionaitem();
        }

        private void txtmar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndrop_Click(object sender, EventArgs e)
        {
            if (data.Rows.Count > 0)
            {
                string rpta = "";
                L_articulos Datos = new L_articulos();

                rpta = Datos.liminar_ar(ncodigo_ar);
                if (rpta.Equals("OK"))
                {
                    this.Listadoar("%");
                    ncodigo_ar = 0;
                    ncodigo_me = 0;
                    ncodigo_ca = 0;
                    this.limpiartext();
                    MessageBox.Show("El registro ha sidp eliminado", "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(rpta);
                }
            }

        }

        private void btnreporte_Click(object sender, EventArgs e)
        {
            Reportes1 orept = new Reportes1();
            orept.ShowDialog();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmedidas_Click(object sender, EventArgs e)
        {
            pan_me.Location = txtmedida.Location;
            pan_me.Visible = true;
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            pan_me.Location = txtmedida.Location;
            pan_me.Visible = true;
        }

        private void btnCam_Click(object sender, EventArgs e)
        {
            pan_me.Visible = false;

        }

        private void dgv_me_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_me_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selecionaitemme();
            pan_me.Visible = false;
        }

        private void btncat_Click(object sender, EventArgs e)
        {
            pnlcat.Visible = false;

        }

        private void btnca_Click(object sender, EventArgs e)
        {
            pnlcat.Location = txtcat.Location;
            pnlcat.Visible = true;


        }

        private void pnlcat_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void dvgcat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selecionaitemca();
            pnlcat.Visible = false;
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {




            DataView DV = new DataView(tabla);

            DV.RowFilter = string.Format("codigo_ar LIKE '%{0}%'", txtbuscar.Text);

            data.DataSource = DV;




        
    }




    

        private void pnl_titulo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
