namespace OrdersServiceRaports
{
    partial class Form_Main
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label programInformation;
            this.linkLabelXml = new System.Windows.Forms.LinkLabel();
            this.linkLabelCsv = new System.Windows.Forms.LinkLabel();
            programInformation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // programInformation
            // 
            programInformation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            programInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            programInformation.ForeColor = System.Drawing.Color.Navy;
            programInformation.Location = new System.Drawing.Point(-12, -13);
            programInformation.Name = "programInformation";
            programInformation.Size = new System.Drawing.Size(574, 89);
            programInformation.TabIndex = 8;
            programInformation.Text = "Program odczytujący zamówienia z plików *.csv i *.xml i dający możliwość generowa" +
    "nia raportów na ich podstawie";
            programInformation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkLabelXml
            // 
            this.linkLabelXml.AutoSize = true;
            this.linkLabelXml.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelXml.Location = new System.Drawing.Point(24, 103);
            this.linkLabelXml.Name = "linkLabelXml";
            this.linkLabelXml.Size = new System.Drawing.Size(164, 16);
            this.linkLabelXml.TabIndex = 9;
            this.linkLabelXml.TabStop = true;
            this.linkLabelXml.Text = "Przykładowy plik *.xml";
            this.linkLabelXml.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelXml_LinkClicked);
            // 
            // linkLabelCsv
            // 
            this.linkLabelCsv.AutoSize = true;
            this.linkLabelCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabelCsv.Location = new System.Drawing.Point(307, 103);
            this.linkLabelCsv.Name = "linkLabelCsv";
            this.linkLabelCsv.Size = new System.Drawing.Size(165, 16);
            this.linkLabelCsv.TabIndex = 9;
            this.linkLabelCsv.TabStop = true;
            this.linkLabelCsv.Text = "Przykładowy plik *.csv";
            this.linkLabelCsv.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCsv_LinkClicked);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 444);
            this.Controls.Add(this.linkLabelCsv);
            this.Controls.Add(this.linkLabelXml);
            this.Controls.Add(programInformation);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderSR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelXml;
        private System.Windows.Forms.LinkLabel linkLabelCsv;
    }
}

