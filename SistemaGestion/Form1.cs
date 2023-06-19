using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaGestion
{
    public partial class Form1 : Form
    {
        private List<Producto> productos;
        private ListBox listBoxProductos;
        private Button btnAgregar;
        private Button btnEliminar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnTeslaMasKm;
        private Button button2;

        public Form1()
        {
            InitializeComponent();
            productos = new List<Producto>();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Agregar productos a la lista
            productos.Add(new TeslaModelX() { Año = 2022, Color = "Rojo", Dueño = "John Doe", UnidadDeUso = 616 });
            productos.Add(new TeslaModelS() { Año = 2021, Color = "Azul", Dueño = "Jane Smith", UnidadDeUso = 1230 });
            productos.Add(new Cybertruck() { Año = 2023, Color = "Negro", Dueño = "Bob Johnson", UnidadDeUso = 450 });
            productos.Add(new SpaceXStarship() { Año = 2023, Color = "Blanco", Dueño = "SpaceX", UnidadDeUso = 1984 });
            productos.Add(new Falcon9() { Año = 2022, Color = "Gris", Dueño = "Microsoft", UnidadDeUso = 1000 });

            // Mostrar los productos en el ListBox
            MostrarProductosEnLista();
        }

        private void MostrarProductosEnLista()
        {
            listBoxProductos.Items.Clear();

            foreach (Producto producto in productos)
            {
                listBoxProductos.Items.Add(producto.ObtenerInformacion());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Lógica para agregar un nuevo producto a la lista
            // Puedes mostrar un cuadro de diálogo para que el usuario ingrese los detalles del producto
            // y luego agregar el nuevo producto a la lista

            // Ejemplo:
            Producto nuevoProducto = new TeslaModelX()
            {
                Año = 2023,
                Color = "Verde",
                Dueño = "Alice Johnson"
            };

            productos.Add(nuevoProducto);

            // Mostrar la lista actualizada de productos
            MostrarProductosEnLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verificar si hay un producto seleccionado en la lista
            if (listBoxProductos.SelectedIndex >= 0)
            {
                // Eliminar el producto de la lista según el índice seleccionado
                productos.RemoveAt(listBoxProductos.SelectedIndex);

                // Mostrar la lista actualizada de productos
                MostrarProductosEnLista();
            }
        }

        private void btnTeslaMasKm_Click(object sender, EventArgs e)
        {
            ResaltarTeslaConMasKm();
        }

        private void ResaltarTeslaConMasKm()
        {
            Producto teslaConMasKm = ObtenerTeslaConMasKilometros();
            if (teslaConMasKm != null)
            {
                // Buscar el índice del producto en la ListBox
                int indice = listBoxProductos.Items.IndexOf(teslaConMasKm.ObtenerInformacion());

                // Verificar si se encontró el producto
                if (indice >= 0)
                {
                    // Seleccionar el producto y resaltarlo en la ListBox
                    listBoxProductos.SetSelected(indice, true);
                }
            }
        }

        private Producto ObtenerTeslaConMasKilometros()
        {
            Producto teslaConMasKm = null;
            int maxKilometros = 0;

            foreach (Producto producto in productos)
            {
                if (producto is TeslaModelX || producto is TeslaModelS || producto is Cybertruck)
                {
                    if (producto.UnidadDeUso > maxKilometros)
                    {
                        maxKilometros = producto.UnidadDeUso;
                        teslaConMasKm = producto;
                    }
                }
            }

            return teslaConMasKm;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBoxProductos=new ListBox();
            btnAgregar=new Button();
            btnEliminar=new Button();
            pictureBox1=new PictureBox();
            pictureBox2=new PictureBox();
            btnTeslaMasKm=new Button();
            button2=new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // listBoxProductos
            // 
            listBoxProductos.FormattingEnabled=true;
            listBoxProductos.ItemHeight=20;
            listBoxProductos.Location=new Point(12, 203);
            listBoxProductos.Name="listBoxProductos";
            listBoxProductos.Size=new Size(973, 184);
            listBoxProductos.TabIndex=0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location=new Point(348, 59);
            btnAgregar.Name="btnAgregar";
            btnAgregar.Size=new Size(163, 29);
            btnAgregar.TabIndex=1;
            btnAgregar.Text="Agregar Producto";
            btnAgregar.UseVisualStyleBackColor=true;
            btnAgregar.Click+=btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location=new Point(348, 104);
            btnEliminar.Name="btnEliminar";
            btnEliminar.Size=new Size(163, 29);
            btnEliminar.TabIndex=2;
            btnEliminar.Text="Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor=true;
            btnEliminar.Click+=btnEliminar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image=(Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location=new Point(23, 21);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(249, 63);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=3;
            pictureBox1.TabStop=false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image=(Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location=new Point(23, 104);
            pictureBox2.Name="pictureBox2";
            pictureBox2.Size=new Size(207, 42);
            pictureBox2.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex=4;
            pictureBox2.TabStop=false;
            // 
            // btnTeslaMasKm
            // 
            btnTeslaMasKm.Location=new Point(595, 59);
            btnTeslaMasKm.Name="btnTeslaMasKm";
            btnTeslaMasKm.Size=new Size(157, 29);
            btnTeslaMasKm.TabIndex=5;
            btnTeslaMasKm.Text="Tesla más Km";
            btnTeslaMasKm.UseVisualStyleBackColor=true;
            btnTeslaMasKm.Click+=btnTeslaMasKm_Click;
            // 
            // button2
            // 
            button2.Location=new Point(595, 108);
            button2.Name="button2";
            button2.Size=new Size(157, 29);
            button2.TabIndex=6;
            button2.Text="Escanear Vehículo";
            button2.UseVisualStyleBackColor=true;
            // 
            // Form1
            // 
            ClientSize=new Size(997, 407);
            Controls.Add(button2);
            Controls.Add(btnTeslaMasKm);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(listBoxProductos);
            Name="Form1";
            Text="Sistema de Gestión SpaceX/Tesla";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            btnTeslaMasKm.Click += btnTeslaMasKm_Click;
        }
    }
}
