using System;
using System.Windows.Forms;

namespace Proyecto_Vacuna
{
    public partial class FrmPrincipal : Form
    {

        int tipousuario;
        public FrmPrincipal()
        {
            InitializeComponent();

            tipousuario = clsSession.id_tipoUsuario;

            if (tipousuario == 1)
            {
                this.lote.Visible = true;
                this.usuario.Visible = true;
                this.nuevaunidad.Visible = true;
                this.estadisticas.Visible = true;
                this.lotesilais.Visible = true;
                this.vacuna.Visible = true;
                this.pacientes.Visible = true;
                this.distribucion.Visible = true;
                this.loteunidades.Visible = true;
                this.jornada.Visible = true;
                

            }
            else if (tipousuario == 2)
            {


                this.loteunidades.Visible = true;
                this.lotesilais.Visible = true;
                this.datoslotes.Visible = true;
                this.jornada.Visible = true;
                this.usuario.Visible = true;
                this.nuevaunidad.Visible = true;
                this.pacientes.Visible = true;
                this.usuario.Visible = true;
                this.vacuna.Visible = false;
                this.estadisticas.Visible = false;
                
                this.vacunacion.Visible = true;
                
                this.lote.Visible = false;

            }

            else if (tipousuario == 3)
            {
                this.lote.Visible = false;
                this.usuario.Visible = true;
                this.nuevaunidad.Visible = false;
                this.estadisticas.Visible = false;
                this.lotesilais.Visible = false;
                this.vacuna.Visible = false;
                this.pacientes.Visible = true;
                
                this.loteunidades.Visible = true;
                this.datoslotes.Visible = true;
                this.jornada.Visible = false;
                this.vacunacion.Visible = false;
                
                

            }

            else
            {
                this.lote.Visible = false;
                this.vacuna.Visible = false;
                this.jornada.Visible = false;
                this.estadisticas.Visible = false;
                this.usuario.Visible = false;
                this.nuevaunidad.Visible = false;
                this.pacientes.Visible = false;
                this.estadisticas.Visible = false;
                this.pacientes.Visible = true;
                this.vacunacion.Visible = true;

            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();

            FrmLogin login = new FrmLogin();
            login.Visible = true;
        }

        private void vacuna_Click(object sender, EventArgs e)
        {
            FrmAgregarVacuna agregarVacuna = new FrmAgregarVacuna();
            agregarVacuna.Visible = true;
        }

        private void estadisticas_Click(object sender, EventArgs e)
        {
            FrmGenerarInforme informe = new FrmGenerarInforme();
            informe.Visible = true;
        }

        private void lote_Click(object sender, EventArgs e)
        {
            FrmAgregarLote agregarLote = new FrmAgregarLote();
            agregarLote.Visible = true;
        }

        private void lotesilais_CheckedChanged(object sender, EventArgs e)
        {
            FrmDistribucionSilais frm = new FrmDistribucionSilais();
            frm.Visible = true;
        }

        private void loteunidades_CheckedChanged(object sender, EventArgs e)
        {
            FrmDistribucionSilais datoslu = new FrmDistribucionSilais();
            datoslu.Visible = true;
        }

        private void datoslotes_CheckedChanged(object sender, EventArgs e)
        {
            FrmDatosDeUnidades datoslu = new FrmDatosDeUnidades();
            datoslu.Visible = true;
        }

        private void pacientes_Click(object sender, EventArgs e)
        {
            FrmAgregarPaciente Paciente = new FrmAgregarPaciente();
            Paciente.Visible = true;
        }

        private void nuevaunidad_Click(object sender, EventArgs e)
        {
            FrmAgregarUnidadVacunacion centrosalud = new FrmAgregarUnidadVacunacion();
            centrosalud.Visible = true;
        }

        private void jornada_Click(object sender, EventArgs e)
        {
            FrmAgregarJornada agregarJornada = new FrmAgregarJornada();
            agregarJornada.Visible = true;
        }

        private void vacunacion_Click(object sender, EventArgs e)
        {
            FrmAgregarVacunacion vacunacion = new FrmAgregarVacunacion();
            vacunacion.Visible = true;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void lote_DoubleClick(object sender, EventArgs e)
        {

        }

        private void vacuna_DoubleClick(object sender, EventArgs e)
        {

        }
    }

    
    }

