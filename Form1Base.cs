using System;

namespace _Development_Version_WinApp
{
    public class Form1Base
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button ErrorHyouji;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// エラーを表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ErrorHyouji_Click(object sender, EventArgs e);
        {

        
        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ErrorHyouji = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ErrorHyouji
            // 
            this.ErrorHyouji.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorHyouji.Location = new System.Drawing.Point(276, 175);
            this.ErrorHyouji.Name = "ErrorHyouji";
            this.ErrorHyouji.Size = new System.Drawing.Size(203, 74);
            this.ErrorHyouji.TabIndex = 0;
            this.ErrorHyouji.Text = "エラーを表示";
            this.ErrorHyouji.UseVisualStyleBackColor = true;
            this.ErrorHyouji.Click += new System.EventHandler(this.ErrorHyouji_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ErrorHyouji);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}