using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
    public partial class Inicio : Form
    {
        public List<Local> Locales= new List<Local>();

        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        //Boton del nuevo local
        private void Btn_crear_Click(object sender, EventArgs e)
        {
            panel_Nuevo_Local.Visible = true;
            panel_Nuevo_Local.Dock = DockStyle.Fill;
        }
        //Panel del nuevo local
        private void panel_Nuevo_Local_Paint(object sender, PaintEventArgs e)
        {
            
            
            
        }
        private void btn_Atras_1_Click(object sender, EventArgs e)
        {
            panel_Nuevo_Local.Visible = false;
            panel_Nuevo_Local.Dock = DockStyle.None;
        }

        private void Eleccion_Local_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Eleccion_Local.Text == "Restaurante")
            {
                Numero_de_salas.Visible = false;
                Categorias.Visible = false;
                Exclusividad.Visible = true;
                txt_tipo.Text = "Mesas Exclusivas?";
            }
            else if (Eleccion_Local.Text == "Tienda")
            {
                Numero_de_salas.Visible = false;
                Exclusividad.Visible = false;
                Categorias.Visible = true;
                txt_tipo.Text = "Categorias";
            }
            else if (Eleccion_Local.Text == "Cine")
            {
                Categorias.Visible = false;
                Exclusividad.Visible = false;
                Numero_de_salas.Visible = true;
                txt_tipo.Text = "N de Salas:";
            }
            else if (Eleccion_Local.Text == "Recreacional")
            {
                Numero_de_salas.Visible = false;
                Categorias.Visible = false;
                Exclusividad.Visible = false;
                txt_tipo.Text = "";
            }

        }

        private void Nombre_Dueño_TextChanged(object sender, EventArgs e)
        {

        }

        private void Id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Horario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if (Eleccion_Local.Text== "Restaurante")
            {
                try
                {
                    if (Nombre_Dueño.Text!="")
                    {
                        if (Id.Text!="")
                        {
                            string existe = "no";
                            for (int i = 0; i < Locales.Count; i++)
                            {
                                if (Locales[i].id== Id.Text)
                                {
                                    existe = "si";
                                }
                            }
                            if (existe!="si")
                            {
                                if (Horario.Text != "")
                                {
                                    if (Exclusividad.Text != "")
                                    {
                                        bool x = false;
                                        if (Exclusividad.Text == "SI")
                                        {
                                            x = true;
                                        }
                                        else
                                        {
                                            x = false;
                                        }
                                        Locales.Add(new Restaurante(Nombre_Dueño.Text, Id.Text, Horario.Text,"Restaurante", x));
                                        panel_Nuevo_Local.Visible = false;
                                        panel_Nuevo_Local.Dock = DockStyle.None;
                                        MessageBox.Show("Restaurante guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Eleccion_Local.Text = "";
                                        Nombre_Dueño.Text = "";
                                        Id.Text = "";
                                        Horario.Text = "";
                                        Numero_de_salas.Visible = false;
                                        Categorias.Visible = false;
                                        Exclusividad.Visible = false;
                                        txt_tipo.Text = "";

                                    }
                                    else
                                    {
                                        MessageBox.Show("Debes seleccionar la exclusividad", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Horario Vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ese ID ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }

                        }
                        else
                        {
                            MessageBox.Show("ID Vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nombre Dueño Vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    //Locales.Add(new Restaurante());
                }
                catch
                {

                }
            }
            else if (Eleccion_Local.Text == "Tienda")
            {
                try
                {
                    if (Nombre_Dueño.Text != "")
                    {
                        if (Id.Text != "")
                        {
                            string existe = "no";
                            for (int i = 0; i < Locales.Count; i++)
                            {
                                if (Locales[i].id == Id.Text)
                                {
                                    existe = "si";
                                }
                            }
                            if (existe != "si")
                            {
                                if (Horario.Text != "")
                                {
                                    List < string > seleccionados= new List<string>();
                                    for (int i = 0; i < Categorias.Items.Count; i++)
                                    {
                                        if(Categorias.GetItemChecked(i)==true)
                                        {
                                            seleccionados.Add(Categorias.Items[i].ToString());
                                        }
                                    }
                                    if(seleccionados.Count>0)
                                    {
                                        Locales.Add(new Tienda(Nombre_Dueño.Text, Id.Text, Horario.Text,"Tienda", seleccionados));
                                        panel_Nuevo_Local.Visible = false;
                                        panel_Nuevo_Local.Dock = DockStyle.None;
                                        MessageBox.Show("Tienda guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Eleccion_Local.Text = "";
                                        Nombre_Dueño.Text = "";
                                        Id.Text = "";
                                        Horario.Text = "";
                                        Numero_de_salas.Visible = false;
                                        Categorias.Visible = false;
                                        Exclusividad.Visible = false;
                                        txt_tipo.Text = "";
                                        seleccionados.Clear();
                                    }
                                        
                                    else
                                    {
                                        MessageBox.Show("Debes seleccionar Categorias", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Horario Vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ese ID ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }

                        }
                        else
                        {
                            MessageBox.Show("ID Vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nombre Dueño Vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    //Locales.Add(new Restaurante());
                }
                catch
                {

                }
            }
            else if (Eleccion_Local.Text == "Cine")
            {
                try
                {
                    if (Nombre_Dueño.Text != "")
                    {
                        if (Id.Text != "")
                        {
                            string existe = "no";
                            for (int i = 0; i < Locales.Count; i++)
                            {
                                if (Locales[i].id == Id.Text)
                                {
                                    existe = "si";
                                }
                            }
                            if (existe != "si")
                            {
                                if (Horario.Text != "")
                                {
                                    if (Numero_de_salas.Value!=0)
                                    {
                                        Locales.Add(new Cine(Nombre_Dueño.Text, Id.Text, Horario.Text,"Cine", Numero_de_salas.Value.ToString()));
                                        panel_Nuevo_Local.Visible = false;
                                        panel_Nuevo_Local.Dock = DockStyle.None;
                                        MessageBox.Show("Cine guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Eleccion_Local.Text = "";
                                        Nombre_Dueño.Text = "";
                                        Id.Text = "";
                                        Horario.Text = "";
                                        Numero_de_salas.Visible = false;
                                        Categorias.Visible = false;
                                        Exclusividad.Visible = false;
                                        txt_tipo.Text = "";
                                    }
                                    else
                                    {
                                        MessageBox.Show("Seleccione cantidad de Salas", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Horario Vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ese ID ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }

                        }
                        else
                        {
                            MessageBox.Show("ID Vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nombre Dueño Vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    //Locales.Add(new Restaurante());
                }
                catch
                {

                }
            }
            else if (Eleccion_Local.Text == "Recreacional")
            {
                try
                {
                    if (Nombre_Dueño.Text != "")
                    {
                        if (Id.Text != "")
                        {
                            string existe = "no";
                            for (int i = 0; i < Locales.Count; i++)
                            {
                                if (Locales[i].id == Id.Text)
                                {
                                    existe = "si";
                                }
                            }
                            if (existe != "si")
                            {
                                if (Horario.Text != "")
                                {
                                    Locales.Add(new Recreacional(Nombre_Dueño.Text, Id.Text, Horario.Text,"Recreacional"));
                                    panel_Nuevo_Local.Visible = false;
                                    panel_Nuevo_Local.Dock = DockStyle.None;
                                    MessageBox.Show("Local Recreacional guardado con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Eleccion_Local.Text = "";
                                    Nombre_Dueño.Text = "";
                                    Id.Text = "";
                                    Horario.Text = "";
                                    Numero_de_salas.Visible = false;
                                    Categorias.Visible = false;
                                    Exclusividad.Visible = false;
                                    txt_tipo.Text = "";
                                }
                                else
                                {
                                    MessageBox.Show("Horario Vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ese ID ya existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }

                        }
                        else
                        {
                            MessageBox.Show("ID Vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nombre Dueño Vacio", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    //Locales.Add(new Restaurante());
                }
                catch
                {

                }
            }
        }

        private void txt_tipo_Click(object sender, EventArgs e)
        {

        }





        //Boton de revisar locales
        private void btn_revisar_Click(object sender, EventArgs e)
        {
            panel_Revisar_Local.Visible = true;
            panel_Revisar_Local.Dock = DockStyle.Fill;
        }
        //Panel de revisar locales
        private void panel_Revisar_Local_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btn_Atras_2_Click(object sender, EventArgs e)
        {
            panel_Revisar_Local.Visible = false;
            panel_Revisar_Local.Dock = DockStyle.None;
        }

        private void Id_Ver_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nombre_Dueno_Click(object sender, EventArgs e)
        {

        }

        private void Tipo_Click(object sender, EventArgs e)
        {

        }

        private void Horario_Local_Click(object sender, EventArgs e)
        {

        }

        private void Texto_Segun_tipo_Click(object sender, EventArgs e)
        {

        }
        private void Valor_segun_tipo_Click(object sender, EventArgs e)
        {

        }
        private void Texto_clave_Click(object sender, EventArgs e)
        {

        }

        private void clave_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string existe = "no";
            List<string> parametros = new List<string>();
            for (int i = 0; i < Locales.Count; i++)
            {
                if (Locales[i].id== Id_Ver.Text)
                {
                    existe = "si";
                    parametros.Add(Locales[i].tipo);
                    parametros.Add(Locales[i].dueno);
                    parametros.Add(Locales[i].id);
                    parametros.Add(Locales[i].horario);
                    parametros.Add(Locales[i].Verinformacion());

                }
            }
            if (existe=="si")
            {
                if(parametros[0]=="Restaurante")
                {
                    Nombre_Dueno.Text = parametros[1];
                    Tipo.Text = parametros[0];
                    Horario_Local.Text = parametros[3];
                    Id_Buscado.Text = parametros[2];
                    Texto_clave.Text = "Mesas Exclusivas:";
                    clave.Text = parametros[4];
                }
                else if (parametros[0] == "Tienda")
                {
                    Nombre_Dueno.Text = parametros[1];
                    Tipo.Text = parametros[0];
                    Horario_Local.Text = parametros[3];
                    Id_Buscado.Text = parametros[2];
                    Texto_clave.Text = "Categorias:";
                    clave.Text = parametros[4];
                }
                else if (parametros[0] == "Cine")
                {
                    Nombre_Dueno.Text = parametros[1];
                    Tipo.Text = parametros[0];
                    Horario_Local.Text = parametros[3];
                    Id_Buscado.Text = parametros[2];
                    Texto_clave.Text = "N de Salas:";
                    clave.Text = parametros[4];
                }
                else if (parametros[0] == "Recreacional")
                {
                    Nombre_Dueno.Text = parametros[1];
                    Tipo.Text = parametros[0];
                    Horario_Local.Text = parametros[3];
                    Id_Buscado.Text = parametros[2];
                    Texto_clave.Text = "";
                    clave.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Ese ID no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                Nombre_Dueno.Text = "";
                Tipo.Text = "";
                Horario_Local.Text = "";
                Id_Buscado.Text = "";
                Id_Ver.Text = "";
            }
        }






        //Boton de ver todos los locales
        private void btn_Ver_Click(object sender, EventArgs e)
        {
            panel_Ver_Todos_Los_Locales.Visible = true;
            panel_Ver_Todos_Los_Locales.Dock = DockStyle.Fill;
            Ver_todo.Items.Clear();

            for (int i = 0; i < Locales.Count; i++)
            {
                //Ver_todo.Items.Add(new ListViewItem(Locales[i].id, Ids));
                //Ver_todo.Items.SubItems.Add(new ListViewItem(Locales[i].dueno, 1));
                //Ver_todo.Items.Add(new ListViewItem(Locales[i].horario, 3));
                ListViewItem item = new ListViewItem(Locales[i].tipo);
                item.SubItems.Add(Locales[i].dueno);
                item.SubItems.Add(Locales[i].id);
                item.SubItems.Add(Locales[i].horario);
                Ver_todo.Items.Add(item);
                
            }

            //Ver_todo.Columns.Insert

        }
        //Panel de ver todos los locales
        private void panel_Ver_Todos_Los_Locales_Paint(object sender, PaintEventArgs e)
        {
            
        }
        private void btn_atras_3_Click(object sender, EventArgs e)
        {
            panel_Ver_Todos_Los_Locales.Visible = false;
            panel_Ver_Todos_Los_Locales.Dock = DockStyle.None;
        }

        //
        private void label2_Click(object sender, EventArgs e)
        {

        }

        
        //


    }
}
