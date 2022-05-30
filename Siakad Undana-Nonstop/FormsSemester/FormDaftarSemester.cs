﻿using Siakad_Undana_Nonstop.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Siakad_Undana_Nonstop.Entity;
using System.Data.SqlClient;

namespace Siakad_Undana_Nonstop.FormsSemester
{
    public partial class FormDaftarSemester : BaseForm
    {
        FormTambahUbahSemester FormChangesemester;
        FormHapusSemester FormDeleteSemester;
        FormUbahSemester FormUpdateSemester;
      
        public FormDaftarSemester()
        {
            InitializeComponent();

            labelJudul.Text = "Data Semester";
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            if (FormChangesemester == null || FormChangesemester.IsDisposed)
            {
                FormChangesemester = new FormTambahUbahSemester();
            }

            FormChangesemester.LabelJudulUbahtambah.Text = "Tambah Semester";
            FormChangesemester.Adding_Operation = true;
            FormChangesemester.Show();
            FormChangesemester.BringToFront();
            Hide();
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            if (FormUpdateSemester == null || FormUpdateSemester.IsDisposed)
            {
                FormUpdateSemester = new FormUbahSemester();
            }

            FormUpdateSemester.LabelJudulUbahtambah.Text = "Ubah Semester";
            FormUpdateSemester.Adding_Operation = false;
            FormUpdateSemester.Show();
            FormUpdateSemester.BringToFront();
            Hide();
        }

        protected override void buttonClose_Click(object sender, EventArgs e)
        {
             base.buttonClose_Click(sender, e);
             
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            if (FormDeleteSemester == null || FormDeleteSemester.IsDisposed)
            {
                FormDeleteSemester = new FormHapusSemester();
            }

            FormDeleteSemester.LabelJudulUbahtambah.Text = "Hapus Data Semester";
            FormDeleteSemester.Adding_Operation = false;
            FormDeleteSemester.Show();
            FormDeleteSemester.BringToFront();
            
        }
        private void ShowData()
        {

            SqlConnection connecting = new SqlConnection(@"Data Source=DESKTOP-QTP4H8O;Initial Catalog=SiakadDB;Integrated Security=True");
            connecting.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Semester_Table", connecting);

            SqlDataAdapter AdapterDate = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            AdapterDate.Fill(dt);
            BaseFormdataGridViewData.DataSource = dt;
        }

        private void ShowDataButton_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}

