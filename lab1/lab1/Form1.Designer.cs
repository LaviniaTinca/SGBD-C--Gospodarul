namespace lab1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewParent = new System.Windows.Forms.DataGridView();
            this.dataGridViewChild = new System.Windows.Forms.DataGridView();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.labelParent = new System.Windows.Forms.Label();
            this.labelChild = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelAngajatId = new System.Windows.Forms.Label();
            this.labelPrenumeAngajat = new System.Windows.Forms.Label();
            this.labelNumeAngajat = new System.Windows.Forms.Label();
            this.textBoxNume = new System.Windows.Forms.TextBox();
            this.textBoxPrenume = new System.Windows.Forms.TextBox();
            this.textBoxFunctie = new System.Windows.Forms.TextBox();
            this.labelFunctie = new System.Windows.Forms.Label();
            this.labelMagazinId = new System.Windows.Forms.Label();
            this.labelSectieId = new System.Windows.Forms.Label();
            this.textBoxSectieId = new System.Windows.Forms.TextBox();
            this.textBoxMagazinId = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChild)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewParent
            // 
            this.dataGridViewParent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParent.Location = new System.Drawing.Point(12, 58);
            this.dataGridViewParent.Name = "dataGridViewParent";
            this.dataGridViewParent.Size = new System.Drawing.Size(243, 89);
            this.dataGridViewParent.TabIndex = 0;
            // 
            // dataGridViewChild
            // 
            this.dataGridViewChild.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewChild.Location = new System.Drawing.Point(299, 265);
            this.dataGridViewChild.Name = "dataGridViewChild";
            this.dataGridViewChild.Size = new System.Drawing.Size(664, 150);
            this.dataGridViewChild.TabIndex = 1;
            this.dataGridViewChild.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewChild_CellClick);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.Location = new System.Drawing.Point(820, 28);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 2;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // labelParent
            // 
            this.labelParent.AutoSize = true;
            this.labelParent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParent.Location = new System.Drawing.Point(12, 28);
            this.labelParent.Name = "labelParent";
            this.labelParent.Size = new System.Drawing.Size(52, 18);
            this.labelParent.TabIndex = 3;
            this.labelParent.Text = "label1";
            // 
            // labelChild
            // 
            this.labelChild.AutoSize = true;
            this.labelChild.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChild.Location = new System.Drawing.Point(296, 418);
            this.labelChild.Name = "labelChild";
            this.labelChild.Size = new System.Drawing.Size(52, 18);
            this.labelChild.TabIndex = 4;
            this.labelChild.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numele departamentului selectat";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // labelAngajatId
            // 
            this.labelAngajatId.AutoSize = true;
            this.labelAngajatId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAngajatId.Location = new System.Drawing.Point(386, 58);
            this.labelAngajatId.Name = "labelAngajatId";
            this.labelAngajatId.Size = new System.Drawing.Size(81, 18);
            this.labelAngajatId.TabIndex = 7;
            this.labelAngajatId.Text = "Angajat Id";
            // 
            // labelPrenumeAngajat
            // 
            this.labelPrenumeAngajat.AutoSize = true;
            this.labelPrenumeAngajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrenumeAngajat.Location = new System.Drawing.Point(386, 126);
            this.labelPrenumeAngajat.Name = "labelPrenumeAngajat";
            this.labelPrenumeAngajat.Size = new System.Drawing.Size(75, 18);
            this.labelPrenumeAngajat.TabIndex = 8;
            this.labelPrenumeAngajat.Text = "Prenume";
            // 
            // labelNumeAngajat
            // 
            this.labelNumeAngajat.AutoSize = true;
            this.labelNumeAngajat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeAngajat.Location = new System.Drawing.Point(386, 89);
            this.labelNumeAngajat.Name = "labelNumeAngajat";
            this.labelNumeAngajat.Size = new System.Drawing.Size(52, 18);
            this.labelNumeAngajat.TabIndex = 9;
            this.labelNumeAngajat.Text = "Nume";
            // 
            // textBoxNume
            // 
            this.textBoxNume.Location = new System.Drawing.Point(487, 90);
            this.textBoxNume.Name = "textBoxNume";
            this.textBoxNume.Size = new System.Drawing.Size(100, 20);
            this.textBoxNume.TabIndex = 10;
            // 
            // textBoxPrenume
            // 
            this.textBoxPrenume.Location = new System.Drawing.Point(487, 127);
            this.textBoxPrenume.Name = "textBoxPrenume";
            this.textBoxPrenume.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenume.TabIndex = 11;
            // 
            // textBoxFunctie
            // 
            this.textBoxFunctie.Location = new System.Drawing.Point(487, 159);
            this.textBoxFunctie.Name = "textBoxFunctie";
            this.textBoxFunctie.Size = new System.Drawing.Size(100, 20);
            this.textBoxFunctie.TabIndex = 12;
            // 
            // labelFunctie
            // 
            this.labelFunctie.AutoSize = true;
            this.labelFunctie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFunctie.Location = new System.Drawing.Point(386, 159);
            this.labelFunctie.Name = "labelFunctie";
            this.labelFunctie.Size = new System.Drawing.Size(63, 18);
            this.labelFunctie.TabIndex = 13;
            this.labelFunctie.Text = "Functie";
            // 
            // labelMagazinId
            // 
            this.labelMagazinId.AutoSize = true;
            this.labelMagazinId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMagazinId.Location = new System.Drawing.Point(386, 199);
            this.labelMagazinId.Name = "labelMagazinId";
            this.labelMagazinId.Size = new System.Drawing.Size(89, 18);
            this.labelMagazinId.TabIndex = 14;
            this.labelMagazinId.Text = "Id Magazin";
            // 
            // labelSectieId
            // 
            this.labelSectieId.AutoSize = true;
            this.labelSectieId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSectieId.Location = new System.Drawing.Point(386, 228);
            this.labelSectieId.Name = "labelSectieId";
            this.labelSectieId.Size = new System.Drawing.Size(71, 18);
            this.labelSectieId.TabIndex = 15;
            this.labelSectieId.Text = "Id sectie";
            // 
            // textBoxSectieId
            // 
            this.textBoxSectieId.Location = new System.Drawing.Point(487, 229);
            this.textBoxSectieId.Name = "textBoxSectieId";
            this.textBoxSectieId.Size = new System.Drawing.Size(100, 20);
            this.textBoxSectieId.TabIndex = 16;
            // 
            // textBoxMagazinId
            // 
            this.textBoxMagazinId.Location = new System.Drawing.Point(487, 197);
            this.textBoxMagazinId.Name = "textBoxMagazinId";
            this.textBoxMagazinId.Size = new System.Drawing.Size(100, 20);
            this.textBoxMagazinId.TabIndex = 17;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(766, 89);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(184, 38);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Adauga inregistrare";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(766, 154);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(184, 38);
            this.buttonUpdate.TabIndex = 19;
            this.buttonUpdate.Text = "Modifica inregistrare";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.DarkGreen;
            this.buttonDelete.Location = new System.Drawing.Point(766, 213);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(184, 36);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Sterge inregistrare";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = global::lab1.Properties.Resources._106100880_spring;
            this.ClientSize = new System.Drawing.Size(975, 463);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxMagazinId);
            this.Controls.Add(this.textBoxSectieId);
            this.Controls.Add(this.labelSectieId);
            this.Controls.Add(this.labelMagazinId);
            this.Controls.Add(this.labelFunctie);
            this.Controls.Add(this.textBoxFunctie);
            this.Controls.Add(this.textBoxPrenume);
            this.Controls.Add(this.textBoxNume);
            this.Controls.Add(this.labelNumeAngajat);
            this.Controls.Add(this.labelPrenumeAngajat);
            this.Controls.Add(this.labelAngajatId);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelChild);
            this.Controls.Add(this.labelParent);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.dataGridViewChild);
            this.Controls.Add(this.dataGridViewParent);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Name = "Form1";
            this.Text = "Gospodarul - lab1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewChild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewParent;
        private System.Windows.Forms.DataGridView dataGridViewChild;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelParent;
        private System.Windows.Forms.Label labelChild;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelAngajatId;
        private System.Windows.Forms.Label labelPrenumeAngajat;
        private System.Windows.Forms.Label labelNumeAngajat;
        private System.Windows.Forms.TextBox textBoxNume;
        private System.Windows.Forms.TextBox textBoxPrenume;
        private System.Windows.Forms.TextBox textBoxFunctie;
        private System.Windows.Forms.Label labelFunctie;
        private System.Windows.Forms.Label labelMagazinId;
        private System.Windows.Forms.Label labelSectieId;
        private System.Windows.Forms.TextBox textBoxSectieId;
        private System.Windows.Forms.TextBox textBoxMagazinId;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDelete;
    }
}

