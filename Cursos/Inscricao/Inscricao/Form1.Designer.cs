﻿namespace Inscricao
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label id_alunoLabel;
            System.Windows.Forms.Label nome_alunoLabel;
            System.Windows.Forms.Label idade_alunoLabel;
            System.Windows.Forms.Label email_alunoLabel;
            System.Windows.Forms.Label telefone_alunoLabel;
            System.Windows.Forms.Label cursoLabel;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inscriçaoDataSet = new Inscricao.InscriçaoDataSet();
            this.inscricaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inscricaoTableAdapter = new Inscricao.InscriçaoDataSetTableAdapters.InscricaoTableAdapter();
            this.tableAdapterManager = new Inscricao.InscriçaoDataSetTableAdapters.TableAdapterManager();
            this.inscricaoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.inscricaoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.id_alunoTextBox = new System.Windows.Forms.TextBox();
            this.nome_alunoTextBox = new System.Windows.Forms.TextBox();
            this.idade_alunoTextBox = new System.Windows.Forms.TextBox();
            this.email_alunoTextBox = new System.Windows.Forms.TextBox();
            this.telefone_alunoTextBox = new System.Windows.Forms.TextBox();
            this.cursoTextBox = new System.Windows.Forms.TextBox();
            id_alunoLabel = new System.Windows.Forms.Label();
            nome_alunoLabel = new System.Windows.Forms.Label();
            idade_alunoLabel = new System.Windows.Forms.Label();
            email_alunoLabel = new System.Windows.Forms.Label();
            telefone_alunoLabel = new System.Windows.Forms.Label();
            cursoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriçaoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoBindingNavigator)).BeginInit();
            this.inscricaoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(419, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // inscriçaoDataSet
            // 
            this.inscriçaoDataSet.DataSetName = "InscriçaoDataSet";
            this.inscriçaoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inscricaoBindingSource
            // 
            this.inscricaoBindingSource.DataMember = "Inscricao";
            this.inscricaoBindingSource.DataSource = this.inscriçaoDataSet;
            // 
            // inscricaoTableAdapter
            // 
            this.inscricaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CursosTableAdapter = null;
            this.tableAdapterManager.InscricaoTableAdapter = this.inscricaoTableAdapter;
            this.tableAdapterManager.UpdateOrder = Inscricao.InscriçaoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inscricaoBindingNavigator
            // 
            this.inscricaoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.inscricaoBindingNavigator.BindingSource = this.inscricaoBindingSource;
            this.inscricaoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.inscricaoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.inscricaoBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.inscricaoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.inscricaoBindingNavigatorSaveItem});
            this.inscricaoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.inscricaoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.inscricaoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.inscricaoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.inscricaoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.inscricaoBindingNavigator.Name = "inscricaoBindingNavigator";
            this.inscricaoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.inscricaoBindingNavigator.Size = new System.Drawing.Size(800, 33);
            this.inscricaoBindingNavigator.TabIndex = 1;
            this.inscricaoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 20);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 25);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // inscricaoBindingNavigatorSaveItem
            // 
            this.inscricaoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inscricaoBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("inscricaoBindingNavigatorSaveItem.Image")));
            this.inscricaoBindingNavigatorSaveItem.Name = "inscricaoBindingNavigatorSaveItem";
            this.inscricaoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.inscricaoBindingNavigatorSaveItem.Text = "Save Data";
            this.inscricaoBindingNavigatorSaveItem.Click += new System.EventHandler(this.inscricaoBindingNavigatorSaveItem_Click);
            // 
            // id_alunoLabel
            // 
            id_alunoLabel.AutoSize = true;
            id_alunoLabel.Location = new System.Drawing.Point(60, 124);
            id_alunoLabel.Name = "id_alunoLabel";
            id_alunoLabel.Size = new System.Drawing.Size(68, 20);
            id_alunoLabel.TabIndex = 2;
            id_alunoLabel.Text = "id aluno:";
            // 
            // id_alunoTextBox
            // 
            this.id_alunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricaoBindingSource, "id_aluno", true));
            this.id_alunoTextBox.Location = new System.Drawing.Point(180, 121);
            this.id_alunoTextBox.Name = "id_alunoTextBox";
            this.id_alunoTextBox.Size = new System.Drawing.Size(177, 26);
            this.id_alunoTextBox.TabIndex = 3;
            // 
            // nome_alunoLabel
            // 
            nome_alunoLabel.AutoSize = true;
            nome_alunoLabel.Location = new System.Drawing.Point(60, 156);
            nome_alunoLabel.Name = "nome_alunoLabel";
            nome_alunoLabel.Size = new System.Drawing.Size(96, 20);
            nome_alunoLabel.TabIndex = 4;
            nome_alunoLabel.Text = "nome aluno:";
            // 
            // nome_alunoTextBox
            // 
            this.nome_alunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricaoBindingSource, "nome_aluno", true));
            this.nome_alunoTextBox.Location = new System.Drawing.Point(180, 153);
            this.nome_alunoTextBox.Name = "nome_alunoTextBox";
            this.nome_alunoTextBox.Size = new System.Drawing.Size(177, 26);
            this.nome_alunoTextBox.TabIndex = 5;
            // 
            // idade_alunoLabel
            // 
            idade_alunoLabel.AutoSize = true;
            idade_alunoLabel.Location = new System.Drawing.Point(60, 188);
            idade_alunoLabel.Name = "idade_alunoLabel";
            idade_alunoLabel.Size = new System.Drawing.Size(95, 20);
            idade_alunoLabel.TabIndex = 6;
            idade_alunoLabel.Text = "idade aluno:";
            // 
            // idade_alunoTextBox
            // 
            this.idade_alunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricaoBindingSource, "idade_aluno", true));
            this.idade_alunoTextBox.Location = new System.Drawing.Point(180, 185);
            this.idade_alunoTextBox.Name = "idade_alunoTextBox";
            this.idade_alunoTextBox.Size = new System.Drawing.Size(177, 26);
            this.idade_alunoTextBox.TabIndex = 7;
            // 
            // email_alunoLabel
            // 
            email_alunoLabel.AutoSize = true;
            email_alunoLabel.Location = new System.Drawing.Point(60, 220);
            email_alunoLabel.Name = "email_alunoLabel";
            email_alunoLabel.Size = new System.Drawing.Size(93, 20);
            email_alunoLabel.TabIndex = 8;
            email_alunoLabel.Text = "email aluno:";
            // 
            // email_alunoTextBox
            // 
            this.email_alunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricaoBindingSource, "email_aluno", true));
            this.email_alunoTextBox.Location = new System.Drawing.Point(180, 217);
            this.email_alunoTextBox.Name = "email_alunoTextBox";
            this.email_alunoTextBox.Size = new System.Drawing.Size(177, 26);
            this.email_alunoTextBox.TabIndex = 9;
            // 
            // telefone_alunoLabel
            // 
            telefone_alunoLabel.AutoSize = true;
            telefone_alunoLabel.Location = new System.Drawing.Point(60, 252);
            telefone_alunoLabel.Name = "telefone_alunoLabel";
            telefone_alunoLabel.Size = new System.Drawing.Size(114, 20);
            telefone_alunoLabel.TabIndex = 10;
            telefone_alunoLabel.Text = "telefone aluno:";
            // 
            // telefone_alunoTextBox
            // 
            this.telefone_alunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricaoBindingSource, "telefone_aluno", true));
            this.telefone_alunoTextBox.Location = new System.Drawing.Point(180, 249);
            this.telefone_alunoTextBox.Name = "telefone_alunoTextBox";
            this.telefone_alunoTextBox.Size = new System.Drawing.Size(177, 26);
            this.telefone_alunoTextBox.TabIndex = 11;
            // 
            // cursoLabel
            // 
            cursoLabel.AutoSize = true;
            cursoLabel.Location = new System.Drawing.Point(60, 284);
            cursoLabel.Name = "cursoLabel";
            cursoLabel.Size = new System.Drawing.Size(52, 20);
            cursoLabel.TabIndex = 12;
            cursoLabel.Text = "curso:";
            // 
            // cursoTextBox
            // 
            this.cursoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inscricaoBindingSource, "curso", true));
            this.cursoTextBox.Location = new System.Drawing.Point(180, 281);
            this.cursoTextBox.Name = "cursoTextBox";
            this.cursoTextBox.Size = new System.Drawing.Size(177, 26);
            this.cursoTextBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(id_alunoLabel);
            this.Controls.Add(this.id_alunoTextBox);
            this.Controls.Add(nome_alunoLabel);
            this.Controls.Add(this.nome_alunoTextBox);
            this.Controls.Add(idade_alunoLabel);
            this.Controls.Add(this.idade_alunoTextBox);
            this.Controls.Add(email_alunoLabel);
            this.Controls.Add(this.email_alunoTextBox);
            this.Controls.Add(telefone_alunoLabel);
            this.Controls.Add(this.telefone_alunoTextBox);
            this.Controls.Add(cursoLabel);
            this.Controls.Add(this.cursoTextBox);
            this.Controls.Add(this.inscricaoBindingNavigator);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscriçaoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inscricaoBindingNavigator)).EndInit();
            this.inscricaoBindingNavigator.ResumeLayout(false);
            this.inscricaoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private InscriçaoDataSet inscriçaoDataSet;
        private System.Windows.Forms.BindingSource inscricaoBindingSource;
        private InscriçaoDataSetTableAdapters.InscricaoTableAdapter inscricaoTableAdapter;
        private InscriçaoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator inscricaoBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton inscricaoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox id_alunoTextBox;
        private System.Windows.Forms.TextBox nome_alunoTextBox;
        private System.Windows.Forms.TextBox idade_alunoTextBox;
        private System.Windows.Forms.TextBox email_alunoTextBox;
        private System.Windows.Forms.TextBox telefone_alunoTextBox;
        private System.Windows.Forms.TextBox cursoTextBox;
    }
}

