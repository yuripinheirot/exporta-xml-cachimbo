using System;
using System.IO;
using System.Windows.Forms;

namespace exportaXML
{
    public partial class frmMain : Form
    {
        Functions functions = new Functions();

        public frmMain()
        {
            InitializeComponent();
        }

        void resetProgressBar()
        {
            progressBar.Value = 0;
            progressBar.Maximum = functions.xmlsFromDirectoryOrigin.Count;
        }
        void enableLoadingStatusForm()
        {
            btnExportar.Enabled = false;
            tbxSaveOn.ReadOnly = true;
            tbxYearMonth.Enabled = false;
            btnExportar.Text = "Aguarde...";
        }
        void disableLoadingStatusForm()
        {
            btnExportar.Enabled = true;
            btnExportar.Text = "&Exportar";
            tbxSaveOn.ReadOnly = false;
            tbxYearMonth.Enabled = true;
        }

        private void incrementProgressBar()
        {
            progressBar.Value++;
            lblProgress.Text = $"{progressBar.Value}/{progressBar.Maximum}";
        }

        private void tbxSalvarEm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    tbxSaveOn.Text = folder.SelectedPath;
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            tbxYearMonth.Value = new DateTime(currentDate.Year, currentDate.Month, 1).AddMonths(-1);
        }

        private async void btnExportar_Click(object sender, EventArgs e)
        {
            try
            {
                string month = tbxYearMonth.Text.Substring(0, 2);
                string year = tbxYearMonth.Text.Substring(3, 4);
                string lastDay = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month),
        DateTime.DaysInMonth(Convert.ToInt32(year), Convert.ToInt32(month))).ToShortDateString().Replace("/", ".");
                string directoryFrom = Properties.Settings.Default.processosExportar + $@"\{year}\{month}";
                string directoryTo = tbxSaveOn.Text + $@"\{year}-{month}\";

                if (!Directory.Exists(directoryFrom))
                {
                    MessageBox.Show("Diretório de origem não existe, verifique.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (string.IsNullOrWhiteSpace(tbxSaveOn.Text) || !Directory.Exists(tbxSaveOn.Text))
                {
                    MessageBox.Show("Diretório de destino não existe, verifique.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                enableLoadingStatusForm();
                functions.loadFilesFromDirectory(directoryFrom);
                resetProgressBar();

                await functions.handleExport(year, month, lastDay, directoryTo, incrementProgressBar, this);

                MessageBox.Show("Processo concluído com sucesso!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ops! Algo inesperado aconteceu, contate o seu suporte." + "\n" + "\n" + erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                disableLoadingStatusForm();
            }
        }
    }
}
