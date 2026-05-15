using BLL;
using ETL.DataGen;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Image = iTextSharp.text.Image;

namespace Galio_UI.DataGestor
{
    public partial class Statistics : Form
    {
        List<Estudiante> Lst { get; set; }
        private DataStats data { get; set; }
        public Statistics()
        {
            InitializeComponent();
            CMB();
            Start();
            btnInformAsist.Enabled = false;
            rbID.Checked = true;
        }
        private void CMB()
        {
            cmbGrupo.Items.Add("7-1");
            cmbGrupo.Items.Add("8-1");
            cmbGrupo.Items.Add("9-1");
            cmbGrupo.Items.Add("10-1");
            cmbGrupo.Items.Add("11-1");
            cmbGrupo.SelectedItem = "7-1";
            cmbGrupo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void Start()
        {
            logic logic = new logic();
            Lst = logic.ListGroup(cmbGrupo.SelectedItem.ToString());
            dgvList.DataSource = Lst;
            dgvList.Refresh();
            dgvList.Columns["Grupo"].Visible = false;
            //AutoSize For Name Column Adjust to size Name
            dgvList.Columns["Nombre"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foreach (DataGridViewColumn item in dgvList.Columns)
            {
                item.ReadOnly = true;
            }
            lblTeacher.Text = logic.TotalAsistenciasPorGrupo(cmbGrupo.SelectedItem.ToString()).ToString();
        }
        private void Clean()
        {
            lblAtteStud.Text = string.Empty;
            lblAusStud.Text = string.Empty;
            lblPercent.Text = string.Empty;
            btnInformAsist.Enabled = false;
        }
        private void PDF(int Case, PdfReports PdfData)
        {
            logic logic = new logic();

            string nombreCarpeta = PdfData.FolderName;
            string rutaDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string rutaCarpeta = Path.Combine(rutaDocumentos, nombreCarpeta);

            if (!Directory.Exists(rutaCarpeta))
            {
                Directory.CreateDirectory(rutaCarpeta);
            }

            string nombrePDF = PdfData.FileName;
            string archivoPDF = Path.Combine(rutaCarpeta, nombrePDF);

            Document doc = new Document();
            PdfWriter pdfWriter = PdfWriter.GetInstance(doc, new FileStream(archivoPDF, FileMode.Create));
            pdfWriter.PageEvent = new Membrete();
            doc.Open();
            Paragraph space = new Paragraph("\n");
            doc.Add(space);

            // Añadir un párrafo antes de la cuadrícula para el texto antes de la tabla
            Paragraph antesDeLaTabla = new Paragraph("Profesor: Jairo Lopez Delgado.\n" +
                "Fecha: " + DateTime.Now.ToString("yyyy/MM/dd"));
            antesDeLaTabla.Alignment = Element.ALIGN_LEFT;

            doc.Add(antesDeLaTabla);
            doc.Add(space);

            if (Case == 1)
            {
                List<Asistencia> listaObjetos = logic.GetAsistencias(data.ID_Estudiante);
                DataStats dataStats = logic.Estadisticas(data.ID_Estudiante);

                Paragraph elements = new Paragraph("Cedula del Estudiante: " + dataStats.ID_Estudiante + "\n" +
                    "Total de Asistencias: " + dataStats.Ausencias + "\n\n" +
                    "Total de Ausencias: " + lblAusStud.Text.Trim());
                Paragraph elements1 = new Paragraph("Seccion: " + cmbGrupo.SelectedItem.ToString());
                elements1.Alignment = Element.ALIGN_RIGHT;
                doc.Add(elements);
                doc.Add(space);

                PdfPTable tabla = new PdfPTable(3);
                // Agregar encabezados de columna
                tabla.AddCell(new PdfPCell(new Phrase("Estado Asistencia")));
                tabla.AddCell(new PdfPCell(new Phrase("Descripcion")));
                tabla.AddCell(new PdfPCell(new Phrase("Fecha")));

                // Agregar datos de la lista a la tabla
                foreach (var objeto in listaObjetos)
                {
                    tabla.AddCell(new PdfPCell(new Phrase(objeto.Estado)));
                    tabla.AddCell(new PdfPCell(new Phrase(objeto.Observaciones)));
                    tabla.AddCell(new PdfPCell(new Phrase(objeto.FechaHora)));
                }

                // Añadir la tabla al documento
                doc.Add(tabla);
            }
            else
            {
                List<Estudiante> lst = new List<Estudiante>();
                foreach (DataGridViewRow fila in dgvList.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        lst.Add(new Estudiante
                        {
                            Cedula = fila.Cells["Cedula"].Value.ToString(),
                            Nombre = fila.Cells["Name"].Value.ToString(),
                            Grupo = fila.Cells["Grade"].Value.ToString()
                        });
                    }
                }
                PdfPTable Table = new PdfPTable(5);
                Table.AddCell(new PdfPCell(new Phrase("Cedula")));
                Table.AddCell(new PdfPCell(new Phrase("Estudiante")));
                Table.AddCell(new PdfPCell(new Phrase("Grupo")));
                Table.AddCell(new PdfPCell(new Phrase("Porcentaje (%)")));
                Table.AddCell(new PdfPCell(new Phrase("Inasistencias")));

                foreach (var objeto in lst)
                {
                    Table.AddCell(new PdfPCell(new Phrase(objeto.Cedula)));
                    Table.AddCell(new PdfPCell(new Phrase(objeto.Nombre)));
                    Table.AddCell(new PdfPCell(new Phrase(objeto.Grupo)));

                    //Trae los datos por alumno 
                    DataStats Stats = logic.Estadisticas(objeto.Cedula.ToString());
                    Table.AddCell(new PdfPCell(new Phrase((Stats.PorcentajeAsistencias / Convert.ToDouble(lblTeacher.Text) * 100).ToString() + "%")));
                    Table.AddCell(new PdfPCell(new Phrase((Stats.Asistencias - Stats.Ausencias).ToString())));
                }

                // Añadir la tabla de la segunda página al documento
                doc.Add(Table);
            }

            Paragraph firma = new Paragraph("\n_______________________________\nJairo Roger Lopez Delgado.\n 155802895202");
            firma.Alignment = Element.ALIGN_CENTER;
            doc.Add(firma);

            // Añadir un párrafo después de la cuadrícula para el texto después de la tabla
            Paragraph despuésDeLaTabla = new Paragraph("“Encendamos juntos la luz”");
            despuésDeLaTabla.Alignment = Element.ALIGN_RIGHT;
            doc.Add(despuésDeLaTabla);

            doc.Close();
            Clean();
            MessageBox.Show("Reporte generado.\n" + "Nombre: " + nombrePDF + "\n" + "Revise la carpeta " + PdfData.FolderName + " de sus documentos.", "Reporte Generado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            btnInformAsist.Enabled = false;
        }


        private void btnByGroup_Click(object sender, EventArgs e)
        {

        }

        private void btnInformAsist_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que desea Cerra la Asistencia?\n Si ha realizado modificaciones se perderan.", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void dgvList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvList.Rows[e.RowIndex].Cells[0].Value.ToString();
            logic logic = new logic();
            data = logic.Estadisticas(id);
            data.ID_Estudiante = id;
            data.PorcentajeAsistencias = (data.PorcentajeAsistencias / Convert.ToDouble(lblTeacher.Text)) * 100;
            lblPercent.Text = data.PorcentajeAsistencias + "%";
            lblAusStud.Text = (data.Asistencias - data.Asistencias).ToString();
            lblAtteStud.Text = data.Ausencias.ToString();
            btnInformAsist.Enabled = true;
        }

        private void cmbGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Start();
            btnInformAsist.Enabled = false;
        }

        class Membrete : PdfPageEventHelper
        {
            private bool AddHeader = false;
            public override void OnEndPage(PdfWriter writer, Document document)
            {
                base.OnEndPage(writer, document);
                if (!AddHeader)
                {
                    // Crear el encabezado
                    PdfPTable header = new PdfPTable(2); // Ahora tiene 2 columnas
                    header.TotalWidth = document.PageSize.Width - document.LeftMargin - document.RightMargin;
                    header.DefaultCell.Border = 0;

                    // Agregar la imagen
                    string imagePath1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "Picture1.png");
                    Image img1 = Image.GetInstance(imagePath1);
                    img1.ScaleAbsolute(220f, 70f); // Ajusta las dimensiones de la imagen según tus necesidades
                    PdfPCell imageCell1 = new PdfPCell(img1);
                    imageCell1.Border = 0;
                    header.AddCell(imageCell1);

                    // Agregar el texto
                    PdfPCell cell = new PdfPCell(new Phrase("Dirección Regional de Educación de Desamparados\nSupervisión Educativa Circuito 06\nLiceo Rural Las Ceibas"));
                    cell.HorizontalAlignment = Element.ALIGN_JUSTIFIED;
                    cell.VerticalAlignment = Element.ALIGN_MIDDLE;
                    cell.Border = 0;
                    header.AddCell(cell);

                    // Calcular la altura total del encabezado
                    float headerHeight = header.TotalHeight;

                    // Calcular la posición Y del encabezado
                    float headerYPosition = document.PageSize.Height - document.TopMargin - headerHeight + 85f; // Ajusta el valor +85f o según tus necesidades

                    // Agregar el encabezado a cada página con la nueva posición Y
                    header.WriteSelectedRows(0, -1, document.LeftMargin, headerYPosition, writer.DirectContent);
                    AddHeader = true;
                }
            }
        }
        //delete
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
