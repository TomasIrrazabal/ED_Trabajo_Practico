namespace ED_Trabajo_Practico
{
    public partial class frmGestorDeTurnos : Form
    {


        public frmGestorDeTurnos()
        {
            InitializeComponent();
            valoresPorDefecto();
            txtDniIngreso.KeyPress += txtDniIngreso_KeyPress;
            txtDniIngreso.TextChanged += txtDniIngreso_TextChanged;
            txtDniMesaIngreso.TextChanged += txtDniMesaIngreso_TextChanged;
        }


        //Declaracion de variables
        Cola cola = new Cola();
        Lista listacaja = new Lista();
        Lista listaAtencionPersonal = new Lista();
        Nodo nodoAuxiliar;
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDniIngreso.Text))
            {
                int dni = Convert.ToInt32(txtDniIngreso.Text);
                if (!cola.existeNodo(dni) && !listaAtencionPersonal.ExisteNodo(dni) && !listacaja.ExisteNodo(dni))
                {
                    Nodo nuevo = new Nodo();
                    nuevo.dni = dni;
                    cola.Ingresar(nuevo);
                    List<Nodo> nodos = cola.listar();
                    cargarListaDGV(nodos, dgvColaIngreso);
                    txtDniIngreso.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("El DNI ingresado ya posee un turno registrado", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtDniIngreso.Text = string.Empty;
                }
            }
        }

        private void btnSiguienteMesaIngreso_Click(object sender, EventArgs e)
        {
            nodoAuxiliar = cola.eliminar();
            if (nodoAuxiliar != null)
            {
                List<Nodo> nodos = cola.listar();
                cargarListaDGV(nodos, dgvColaIngreso);
                txtDniMesaIngreso.Text = nodoAuxiliar.dni.ToString();
                nodoAuxiliar.siguiente = null;
            }
            else
            {
                MessageBox.Show("No hay más nodos en la cola.", "Aviso", MessageBoxButtons.OK);
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            {
                if (nodoAuxiliar != null)
                {
                    nodoAuxiliar.esCliente = chkEsCliente.Checked ? true : false;
                    if (radAtencionPersonal.Checked)
                    {
                        listaAtencionPersonal.crear(nodoAuxiliar);
                        mostrarDGVListaEnlazada(listaAtencionPersonal.listar(), dgvAP);
                    }
                    else
                    {
                        listacaja.crear(nodoAuxiliar);
                        mostrarDGVListaEnlazada(listacaja.listar(), dgvCaja);
                    }

                    valoresPorDefectoPanelRecepcion();

                    nodoAuxiliar = null;
                }
                else
                {
                    MessageBox.Show("No hay un nodo seleccionado para procesar.");
                }
            }

        }
        private void btnIniciarCaja_Click(object sender, EventArgs e)
        {
            Nodo aux = new Nodo();
            aux = listacaja.EliminarDeCaja();
            if (aux != null)
            {
                txtAtendiendoCaja.Text = aux.dni.ToString();
                List<Nodo> lista = listacaja.listar();
                mostrarDGVListaEnlazada(lista,dgvCaja);
            }
        }

        private void btnIniciarAP_Click(object sender, EventArgs e)
        {
            Nodo aux = new Nodo();
            aux = listaAtencionPersonal.EliminarDeAtencionPersonal();
            if (aux != null)
            {
                txtAtendiendoAP.Text = aux.dni.ToString();
                List<Nodo> lista = listaAtencionPersonal.listar();
                mostrarDGVListaEnlazada(lista, dgvAP);
            }
        }
        //funcion estandar para cargar dgv con la cola 
        public void cargarListaDGV(List<Nodo> lista, DataGridView dgv)
        {
            if (lista != null)
            {
                dgv.Rows.Clear();
                foreach (Nodo n in lista)
                {
                    dgv.Rows.Add(n.turno, n.dni);
                }
            }
        }
        //funcion estandar para cargar dgv con las listas enlazadas
        public void mostrarDGVListaEnlazada(List<Nodo> lista, DataGridView dgv)
        {
            if (lista != null)
            {
                dgv.Rows.Clear();
                foreach (Nodo n in lista)
                {
                    string cliente;
                    if (n.esCliente)
                    {
                        cliente = "Si";
                    }
                    else
                    {
                        cliente = "No";
                    }
                    dgv.Rows.Add(n.turno, n.dni, cliente);
                }
            }
        }
        //Aplica los valores por defecto de los DataGridView
        private void valoresDefectoDGV(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            dgv.Columns.Add("turno", "Turno");
            dgv.Columns.Add("dni", "DNI");
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgv.Name != dgvColaIngreso.Name)
            {
                dgv.Columns.Add("cliente", "Es cliente");
            }
        }

        //Aplica los valores por defecto del gbRecepcion
        private void valoresPorDefectoPanelRecepcion()
        {
            radCaja.Checked = true;
            radAtencionPersonal.Checked = false;
            chkEsCliente.Checked = false;
            txtDniMesaIngreso.Text = string.Empty;
            txtDniMesaIngreso.Enabled = false;

        }
        //Aplica los valores por defecto del formulario
        private void valoresPorDefecto()
        {
            valoresDefectoDGV(dgvColaIngreso);
            valoresDefectoDGV(dgvCaja);
            valoresDefectoDGV(dgvAP);

            btnAceptar.Enabled = false;

            radCaja.Checked = true;
            radAtencionPersonal.Checked = false;
            chkEsCliente.Checked = false;

            //timer

        }
        //Controla que el txt acepte unicamente digitos y controles
        private void txtDniIngreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
        }
        //Controla el maximo de caracteres en el txt
        private void txtDniIngreso_TextChanged(object sender, EventArgs e)
        {
            if (txtDniIngreso.Text.Length > 8)
            {
                txtDniIngreso.Text = txtDniIngreso.Text.Substring(0, 8);
                txtDniIngreso.SelectionStart = txtDniIngreso.Text.Length;
            }

        }
        //controla si el txt recibio la informacion y habilita para ingresarla al siguiente sector
        private void txtDniMesaIngreso_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDniMesaIngreso.Text))
            {
                btnSiguienteMesaIngreso.Enabled = false;
                btnAceptar.Enabled = true;
            }
            else
            {
                btnSiguienteMesaIngreso.Enabled = true;
                btnAceptar.Enabled = false;
            }
        }
    }
}
