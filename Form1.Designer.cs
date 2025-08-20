namespace MyCRUD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            imie = new Label();
            nazwisko = new Label();
            koszt_biletu = new Label();
            nazwa_pociagu = new Label();
            nr_wagonu = new Label();
            start = new Label();
            koniec = new Label();
            tx_imie = new TextBox();
            tx_nazwisko = new TextBox();
            tx_koszt = new TextBox();
            tx_pociag = new TextBox();
            tx_wagon = new TextBox();
            tx_start = new TextBox();
            tx_koniec = new TextBox();
            dodaj = new Button();
            usun = new Button();
            zmien = new Button();
            dataGridView1 = new DataGridView();
            bindingSource1 = new BindingSource(components);
            label1 = new Label();
            tx_miejsce = new TextBox();
            tx_id = new TextBox();
            label2 = new Label();
            wyszukaj = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // imie
            // 
            imie.AutoSize = true;
            imie.Location = new Point(39, 33);
            imie.Name = "imie";
            imie.Size = new Size(30, 15);
            imie.TabIndex = 0;
            imie.Text = "Imie";
            // 
            // nazwisko
            // 
            nazwisko.AutoSize = true;
            nazwisko.Location = new Point(39, 63);
            nazwisko.Name = "nazwisko";
            nazwisko.Size = new Size(57, 15);
            nazwisko.TabIndex = 1;
            nazwisko.Text = "Nazwisko";
            // 
            // koszt_biletu
            // 
            koszt_biletu.AutoSize = true;
            koszt_biletu.Location = new Point(39, 93);
            koszt_biletu.Name = "koszt_biletu";
            koszt_biletu.Size = new Size(68, 15);
            koszt_biletu.TabIndex = 2;
            koszt_biletu.Text = "Koszt biletu";
            // 
            // nazwa_pociagu
            // 
            nazwa_pociagu.AutoSize = true;
            nazwa_pociagu.Location = new Point(39, 120);
            nazwa_pociagu.Name = "nazwa_pociagu";
            nazwa_pociagu.Size = new Size(88, 15);
            nazwa_pociagu.TabIndex = 3;
            nazwa_pociagu.Text = "Nazwa pociągu";
            // 
            // nr_wagonu
            // 
            nr_wagonu.AutoSize = true;
            nr_wagonu.Location = new Point(39, 148);
            nr_wagonu.Name = "nr_wagonu";
            nr_wagonu.Size = new Size(69, 15);
            nr_wagonu.TabIndex = 4;
            nr_wagonu.Text = "Nr. wagonu";
            // 
            // start
            // 
            start.AutoSize = true;
            start.Location = new Point(39, 204);
            start.Name = "start";
            start.Size = new Size(31, 15);
            start.TabIndex = 5;
            start.Text = "Start";
            // 
            // koniec
            // 
            koniec.AutoSize = true;
            koniec.Location = new Point(39, 230);
            koniec.Name = "koniec";
            koniec.Size = new Size(43, 15);
            koniec.TabIndex = 6;
            koniec.Text = "Koniec";
            // 
            // tx_imie
            // 
            tx_imie.Location = new Point(164, 25);
            tx_imie.Name = "tx_imie";
            tx_imie.Size = new Size(181, 23);
            tx_imie.TabIndex = 7;
            // 
            // tx_nazwisko
            // 
            tx_nazwisko.Location = new Point(164, 54);
            tx_nazwisko.Name = "tx_nazwisko";
            tx_nazwisko.Size = new Size(181, 23);
            tx_nazwisko.TabIndex = 8;
            // 
            // tx_koszt
            // 
            tx_koszt.Location = new Point(164, 83);
            tx_koszt.Name = "tx_koszt";
            tx_koszt.Size = new Size(181, 23);
            tx_koszt.TabIndex = 9;
            // 
            // tx_pociag
            // 
            tx_pociag.Location = new Point(164, 112);
            tx_pociag.Name = "tx_pociag";
            tx_pociag.Size = new Size(181, 23);
            tx_pociag.TabIndex = 10;
            // 
            // tx_wagon
            // 
            tx_wagon.Location = new Point(164, 140);
            tx_wagon.Name = "tx_wagon";
            tx_wagon.Size = new Size(181, 23);
            tx_wagon.TabIndex = 11;
            // 
            // tx_start
            // 
            tx_start.Location = new Point(164, 196);
            tx_start.Name = "tx_start";
            tx_start.Size = new Size(181, 23);
            tx_start.TabIndex = 12;
            // 
            // tx_koniec
            // 
            tx_koniec.Location = new Point(164, 225);
            tx_koniec.Name = "tx_koniec";
            tx_koniec.Size = new Size(181, 23);
            tx_koniec.TabIndex = 13;
            // 
            // dodaj
            // 
            dodaj.Location = new Point(164, 393);
            dodaj.Name = "dodaj";
            dodaj.Size = new Size(75, 23);
            dodaj.TabIndex = 14;
            dodaj.Text = "Dodaj";
            dodaj.UseVisualStyleBackColor = true;
            dodaj.Click += dodaj_Click;
            // 
            // usun
            // 
            usun.Location = new Point(164, 448);
            usun.Name = "usun";
            usun.Size = new Size(75, 23);
            usun.TabIndex = 15;
            usun.Text = "Usuń";
            usun.UseVisualStyleBackColor = true;
            usun.Click += usun_Click;
            // 
            // zmien
            // 
            zmien.Location = new Point(270, 393);
            zmien.Name = "zmien";
            zmien.Size = new Size(75, 23);
            zmien.TabIndex = 16;
            zmien.Text = "Zmień";
            zmien.UseVisualStyleBackColor = true;
            zmien.Click += zmien_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(404, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(676, 623);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 176);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 18;
            label1.Text = "Nr. miejsca";
            // 
            // tx_miejsce
            // 
            tx_miejsce.Location = new Point(164, 169);
            tx_miejsce.Name = "tx_miejsce";
            tx_miejsce.Size = new Size(181, 23);
            tx_miejsce.TabIndex = 19;
            // 
            // tx_id
            // 
            tx_id.Location = new Point(164, 254);
            tx_id.Name = "tx_id";
            tx_id.Size = new Size(181, 23);
            tx_id.TabIndex = 20;
            tx_id.TextChanged += tx_id_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 257);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 21;
            label2.Text = "ID";
            // 
            // wyszukaj
            // 
            wyszukaj.Location = new Point(270, 448);
            wyszukaj.Name = "wyszukaj";
            wyszukaj.Size = new Size(75, 23);
            wyszukaj.TabIndex = 22;
            wyszukaj.Text = "Wyszukaj";
            wyszukaj.UseVisualStyleBackColor = true;
            wyszukaj.Click += wyszukaj_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(164, 295);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 295);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 24;
            label3.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 648);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(wyszukaj);
            Controls.Add(label2);
            Controls.Add(tx_id);
            Controls.Add(tx_miejsce);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(zmien);
            Controls.Add(usun);
            Controls.Add(dodaj);
            Controls.Add(tx_koniec);
            Controls.Add(tx_start);
            Controls.Add(tx_wagon);
            Controls.Add(tx_pociag);
            Controls.Add(tx_koszt);
            Controls.Add(tx_nazwisko);
            Controls.Add(tx_imie);
            Controls.Add(koniec);
            Controls.Add(start);
            Controls.Add(nr_wagonu);
            Controls.Add(nazwa_pociagu);
            Controls.Add(koszt_biletu);
            Controls.Add(nazwisko);
            Controls.Add(imie);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label imie;
        private Label nazwisko;
        private Label koszt_biletu;
        private Label nazwa_pociagu;
        private Label nr_wagonu;
        private Label start;
        private Label koniec;
        private TextBox tx_imie;
        private TextBox tx_nazwisko;
        private TextBox tx_koszt;
        private TextBox tx_pociag;
        private TextBox tx_wagon;
        private TextBox tx_start;
        private TextBox tx_koniec;
        private Button dodaj;
        private Button usun;
        private Button zmien;
        private DataGridView dataGridView1;
        private BindingSource bindingSource1;
        private Label label1;
        private TextBox tx_miejsce;
        private TextBox tx_id;
        private Label label2;
        private Button wyszukaj;
        private TextBox textBox1;
        private Label label3;
    }
}