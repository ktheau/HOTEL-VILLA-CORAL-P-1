namespace Hotel
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void lblITBIS_Click(object sender, EventArgs e)
        {

        }

        private void btnImperactivo_Click(object sender, EventArgs e)
        {
            //Mision 1 * IMPERATIVO: LA RECETA,

            string nombre = txtHuesped.Text;
            int noches = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(txtTarifa.Text);

            decimal subtotal = noches * tarifa;
            decimal descuento = 0m; 
            if (noches >= 7)
            {
                descuento = subtotal * 0.10m; 

            }
            decimal baseImponible = subtotal - descuento;
            decimal itbis = baseImponible * 0.18m;
            decimal servicio = baseImponible * 0.10m;
            decimal total = baseImponible + itbis + servicio;

            lstResultados.Items.Add($"[Imperativo] {nombre}: US$ {total:N2}"); 
;        }
    }
}
