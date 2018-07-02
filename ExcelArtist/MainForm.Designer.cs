namespace ExcelArtist
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            VisualPlus.Structure.TextStyle textStyle2 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle4 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle5 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle1 = new VisualPlus.Structure.TextStyle();
            VisualPlus.Structure.TextStyle textStyle3 = new VisualPlus.Structure.TextStyle();
            this.visualGroupBox1 = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.visualGroupBox2 = new VisualPlus.Toolkit.Controls.Layout.VisualGroupBox();
            this.TaskButton = new VisualPlus.Toolkit.Controls.Interactivity.VisualButton();
            this.ImageTextBox = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
            this.DocumentTextBox = new VisualPlus.Toolkit.Controls.Editors.VisualTextBox();
            this.visualGroupBox1.SuspendLayout();
            this.visualGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // visualGroupBox1
            // 
            this.visualGroupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.visualGroupBox1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualGroupBox1.BackColorState.Enabled = System.Drawing.Color.WhiteSmoke;
            this.visualGroupBox1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualGroupBox1.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualGroupBox1.Border.HoverVisible = true;
            this.visualGroupBox1.Border.Rounding = 6;
            this.visualGroupBox1.Border.Thickness = 1;
            this.visualGroupBox1.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualGroupBox1.Border.Visible = true;
            this.visualGroupBox1.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.visualGroupBox1.Controls.Add(this.ImageTextBox);
            this.visualGroupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualGroupBox1.Image = null;
            this.visualGroupBox1.Location = new System.Drawing.Point(40, 45);
            this.visualGroupBox1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualGroupBox1.Name = "visualGroupBox1";
            this.visualGroupBox1.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.visualGroupBox1.Separator = true;
            this.visualGroupBox1.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualGroupBox1.Size = new System.Drawing.Size(360, 70);
            this.visualGroupBox1.TabIndex = 0;
            this.visualGroupBox1.Text = "   选择图像路径：";
            this.visualGroupBox1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.visualGroupBox1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.visualGroupBox1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle2.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle2.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle2.Hover = System.Drawing.Color.Empty;
            textStyle2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualGroupBox1.TextStyle = textStyle2;
            this.visualGroupBox1.TitleBoxHeight = 24;
            // 
            // visualGroupBox2
            // 
            this.visualGroupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.visualGroupBox2.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualGroupBox2.BackColorState.Enabled = System.Drawing.Color.WhiteSmoke;
            this.visualGroupBox2.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.visualGroupBox2.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.visualGroupBox2.Border.HoverVisible = true;
            this.visualGroupBox2.Border.Rounding = 6;
            this.visualGroupBox2.Border.Thickness = 1;
            this.visualGroupBox2.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.visualGroupBox2.Border.Visible = true;
            this.visualGroupBox2.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.visualGroupBox2.Controls.Add(this.DocumentTextBox);
            this.visualGroupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.visualGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualGroupBox2.Image = null;
            this.visualGroupBox2.Location = new System.Drawing.Point(40, 125);
            this.visualGroupBox2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualGroupBox2.Name = "visualGroupBox2";
            this.visualGroupBox2.Padding = new System.Windows.Forms.Padding(5, 26, 5, 5);
            this.visualGroupBox2.Separator = true;
            this.visualGroupBox2.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.visualGroupBox2.Size = new System.Drawing.Size(360, 70);
            this.visualGroupBox2.TabIndex = 1;
            this.visualGroupBox2.Text = "   选择表格文件存储路径：";
            this.visualGroupBox2.TextAlignment = System.Drawing.StringAlignment.Near;
            this.visualGroupBox2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.visualGroupBox2.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle4.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle4.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle4.Hover = System.Drawing.Color.Empty;
            textStyle4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.visualGroupBox2.TextStyle = textStyle4;
            this.visualGroupBox2.TitleBoxHeight = 24;
            // 
            // TaskButton
            // 
            this.TaskButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TaskButton.BackColorState.Enabled = System.Drawing.Color.White;
            this.TaskButton.BackColorState.Hover = System.Drawing.Color.WhiteSmoke;
            this.TaskButton.BackColorState.Pressed = System.Drawing.Color.Gainsboro;
            this.TaskButton.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TaskButton.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TaskButton.Border.HoverVisible = true;
            this.TaskButton.Border.Rounding = 6;
            this.TaskButton.Border.Thickness = 1;
            this.TaskButton.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.TaskButton.Border.Visible = true;
            this.TaskButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TaskButton.Image = null;
            this.TaskButton.Location = new System.Drawing.Point(150, 209);
            this.TaskButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TaskButton.Name = "TaskButton";
            this.TaskButton.Size = new System.Drawing.Size(140, 45);
            this.TaskButton.TabIndex = 2;
            this.TaskButton.Text = "生成";
            this.TaskButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.TaskButton.TextLineAlignment = System.Drawing.StringAlignment.Center;
            textStyle5.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle5.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle5.Hover = System.Drawing.Color.Empty;
            textStyle5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TaskButton.TextStyle = textStyle5;
            this.TaskButton.Click += new System.EventHandler(this.TaskButton_Click);
            // 
            // ImageTextBox
            // 
            this.ImageTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ImageTextBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ImageTextBox.BackColorState.Enabled = System.Drawing.Color.White;
            this.ImageTextBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ImageTextBox.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.ImageTextBox.Border.HoverVisible = true;
            this.ImageTextBox.Border.Rounding = 6;
            this.ImageTextBox.Border.Thickness = 1;
            this.ImageTextBox.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.ImageTextBox.Border.Visible = true;
            this.ImageTextBox.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ImageTextBox.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.ImageTextBox.ButtonBorder.HoverVisible = true;
            this.ImageTextBox.ButtonBorder.Rounding = 6;
            this.ImageTextBox.ButtonBorder.Thickness = 1;
            this.ImageTextBox.ButtonBorder.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.ImageTextBox.ButtonBorder.Visible = true;
            this.ImageTextBox.ButtonColor.Disabled = System.Drawing.Color.Empty;
            this.ImageTextBox.ButtonColor.Enabled = System.Drawing.Color.Empty;
            this.ImageTextBox.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.ImageTextBox.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.ImageTextBox.ButtonFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ImageTextBox.ButtonIndent = 10;
            this.ImageTextBox.ButtonText = "选择";
            this.ImageTextBox.ButtonVisible = true;
            this.ImageTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ImageTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ImageTextBox.ImageSize = new System.Drawing.Size(16, 16);
            this.ImageTextBox.ImageVisible = false;
            this.ImageTextBox.ImageWidth = 35;
            this.ImageTextBox.Location = new System.Drawing.Point(15, 35);
            this.ImageTextBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ImageTextBox.Name = "ImageTextBox";
            this.ImageTextBox.PasswordChar = '\0';
            this.ImageTextBox.ReadOnly = false;
            this.ImageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ImageTextBox.Size = new System.Drawing.Size(332, 25);
            this.ImageTextBox.TabIndex = 1;
            this.ImageTextBox.TextBoxWidth = 280;
            textStyle1.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle1.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle1.Hover = System.Drawing.Color.Empty;
            textStyle1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ImageTextBox.TextStyle = textStyle1;
            this.ImageTextBox.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ImageTextBox.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ImageTextBox.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.ImageTextBox.Watermark.Text = "请选择图像路径...";
            this.ImageTextBox.Watermark.Visible = true;
            this.ImageTextBox.ButtonClicked += new VisualPlus.Toolkit.Controls.Editors.VisualTextBox.ButtonClickedEventHandler(this.ImageTextBox_ButtonClicked);
            // 
            // DocumentTextBox
            // 
            this.DocumentTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DocumentTextBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.DocumentTextBox.BackColorState.Enabled = System.Drawing.Color.White;
            this.DocumentTextBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.DocumentTextBox.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.DocumentTextBox.Border.HoverVisible = true;
            this.DocumentTextBox.Border.Rounding = 6;
            this.DocumentTextBox.Border.Thickness = 1;
            this.DocumentTextBox.Border.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.DocumentTextBox.Border.Visible = true;
            this.DocumentTextBox.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.DocumentTextBox.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.DocumentTextBox.ButtonBorder.HoverVisible = true;
            this.DocumentTextBox.ButtonBorder.Rounding = 6;
            this.DocumentTextBox.ButtonBorder.Thickness = 1;
            this.DocumentTextBox.ButtonBorder.Type = VisualPlus.Enumerators.ShapeType.Rounded;
            this.DocumentTextBox.ButtonBorder.Visible = true;
            this.DocumentTextBox.ButtonColor.Disabled = System.Drawing.Color.Empty;
            this.DocumentTextBox.ButtonColor.Enabled = System.Drawing.Color.Empty;
            this.DocumentTextBox.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.DocumentTextBox.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.DocumentTextBox.ButtonFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DocumentTextBox.ButtonIndent = 10;
            this.DocumentTextBox.ButtonText = "选择";
            this.DocumentTextBox.ButtonVisible = true;
            this.DocumentTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DocumentTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DocumentTextBox.ImageSize = new System.Drawing.Size(16, 16);
            this.DocumentTextBox.ImageVisible = false;
            this.DocumentTextBox.ImageWidth = 35;
            this.DocumentTextBox.Location = new System.Drawing.Point(15, 35);
            this.DocumentTextBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.DocumentTextBox.Name = "DocumentTextBox";
            this.DocumentTextBox.PasswordChar = '\0';
            this.DocumentTextBox.ReadOnly = false;
            this.DocumentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DocumentTextBox.Size = new System.Drawing.Size(332, 25);
            this.DocumentTextBox.TabIndex = 2;
            this.DocumentTextBox.TextBoxWidth = 280;
            textStyle3.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            textStyle3.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            textStyle3.Hover = System.Drawing.Color.Empty;
            textStyle3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.DocumentTextBox.TextStyle = textStyle3;
            this.DocumentTextBox.Watermark.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DocumentTextBox.Watermark.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.DocumentTextBox.Watermark.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.DocumentTextBox.Watermark.Text = "请选择表格文件存储路径...";
            this.DocumentTextBox.Watermark.Visible = true;
            this.DocumentTextBox.ButtonClicked += new VisualPlus.Toolkit.Controls.Editors.VisualTextBox.ButtonClickedEventHandler(this.DocumentTextBox_ButtonClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CanResize = false;
            this.ClientSize = new System.Drawing.Size(440, 272);
            this.Controls.Add(this.TaskButton);
            this.Controls.Add(this.visualGroupBox2);
            this.Controls.Add(this.visualGroupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShadowWidth = 5;
            this.ShowDrawIcon = false;
            this.Text = "Excel Artist";
            this.TitleColor = System.Drawing.Color.OrangeRed;
            this.visualGroupBox1.ResumeLayout(false);
            this.visualGroupBox1.PerformLayout();
            this.visualGroupBox2.ResumeLayout(false);
            this.visualGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox visualGroupBox1;
        private VisualPlus.Toolkit.Controls.Layout.VisualGroupBox visualGroupBox2;
        private VisualPlus.Toolkit.Controls.Interactivity.VisualButton TaskButton;
        private VisualPlus.Toolkit.Controls.Editors.VisualTextBox ImageTextBox;
        private VisualPlus.Toolkit.Controls.Editors.VisualTextBox DocumentTextBox;
    }
}

