namespace hrd
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainTree = new System.Windows.Forms.TreeView();
            this.HidedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainTree
            // 
            this.MainTree.Location = new System.Drawing.Point(12, 12);
            this.MainTree.Name = "MainTree";
            this.MainTree.Size = new System.Drawing.Size(193, 426);
            this.MainTree.TabIndex = 1;
            this.MainTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MainTree_AfterSelect);
            // 
            // HidedButton
            // 
            this.HidedButton.Location = new System.Drawing.Point(342, 415);
            this.HidedButton.Name = "HidedButton";
            this.HidedButton.Size = new System.Drawing.Size(446, 23);
            this.HidedButton.TabIndex = 3;
            this.HidedButton.Text = "Костыль, чтобы не открывалась дочерняя форма при запуске";
            this.HidedButton.UseVisualStyleBackColor = true;
            this.HidedButton.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HidedButton);
            this.Controls.Add(this.MainTree);
            this.Name = "MainForm";
            this.Text = "Отдел кадров";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TreeView MainTree;
        private System.Windows.Forms.Button HidedButton;
    }
}

