namespace ChangeQueryText
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxTemplate = new System.Windows.Forms.TextBox();
            this.buttonTemplateToQuery = new System.Windows.Forms.Button();
            this.buttonQueryToTemplate = new System.Windows.Forms.Button();
            this.textBoxQuery = new System.Windows.Forms.TextBox();
            this.checkBoxOnlyComment = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 41);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxTemplate);
            this.splitContainer1.Panel1.Controls.Add(this.buttonTemplateToQuery);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonQueryToTemplate);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxQuery);
            this.splitContainer1.Size = new System.Drawing.Size(760, 452);
            this.splitContainer1.SplitterDistance = 379;
            this.splitContainer1.TabIndex = 1;
            // 
            // textBoxTemplate
            // 
            this.textBoxTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTemplate.Location = new System.Drawing.Point(3, 4);
            this.textBoxTemplate.Multiline = true;
            this.textBoxTemplate.Name = "textBoxTemplate";
            this.textBoxTemplate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxTemplate.Size = new System.Drawing.Size(373, 411);
            this.textBoxTemplate.TabIndex = 0;
            // 
            // buttonTemplateToQuery
            // 
            this.buttonTemplateToQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTemplateToQuery.Location = new System.Drawing.Point(3, 419);
            this.buttonTemplateToQuery.Name = "buttonTemplateToQuery";
            this.buttonTemplateToQuery.Size = new System.Drawing.Size(373, 25);
            this.buttonTemplateToQuery.TabIndex = 2;
            this.buttonTemplateToQuery.Text = "Текст макета в запрос -->\r\n";
            this.buttonTemplateToQuery.UseVisualStyleBackColor = true;
            this.buttonTemplateToQuery.Click += new System.EventHandler(this.buttonTemplateToQuery_Click);
            // 
            // buttonQueryToTemplate
            // 
            this.buttonQueryToTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQueryToTemplate.Location = new System.Drawing.Point(3, 419);
            this.buttonQueryToTemplate.Name = "buttonQueryToTemplate";
            this.buttonQueryToTemplate.Size = new System.Drawing.Size(371, 25);
            this.buttonQueryToTemplate.TabIndex = 3;
            this.buttonQueryToTemplate.Text = "<-- Текст запроса в макет";
            this.buttonQueryToTemplate.UseVisualStyleBackColor = true;
            this.buttonQueryToTemplate.Click += new System.EventHandler(this.buttonQueryToTemplate_Click);
            // 
            // textBoxQuery
            // 
            this.textBoxQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQuery.Location = new System.Drawing.Point(3, 4);
            this.textBoxQuery.Multiline = true;
            this.textBoxQuery.Name = "textBoxQuery";
            this.textBoxQuery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxQuery.Size = new System.Drawing.Size(371, 411);
            this.textBoxQuery.TabIndex = 0;
            // 
            // checkBoxOnlyComment
            // 
            this.checkBoxOnlyComment.AutoSize = true;
            this.checkBoxOnlyComment.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxOnlyComment.Location = new System.Drawing.Point(15, 13);
            this.checkBoxOnlyComment.Name = "checkBoxOnlyComment";
            this.checkBoxOnlyComment.Size = new System.Drawing.Size(178, 17);
            this.checkBoxOnlyComment.TabIndex = 2;
            this.checkBoxOnlyComment.Text = "Только удалить комментарии";
            this.checkBoxOnlyComment.UseVisualStyleBackColor = true;
            this.checkBoxOnlyComment.CheckedChanged += new System.EventHandler(this.checkBoxOnlyComment_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 505);
            this.Controls.Add(this.checkBoxOnlyComment);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Запрос из правил конвертации";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxTemplate;
        private System.Windows.Forms.TextBox textBoxQuery;
        private System.Windows.Forms.Button buttonTemplateToQuery;
        private System.Windows.Forms.Button buttonQueryToTemplate;
        private System.Windows.Forms.CheckBox checkBoxOnlyComment;
    }
}

