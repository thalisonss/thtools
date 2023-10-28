using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ThTools.Screens
{
    public partial class frmMainScreen : Form
    { 
        public frmMainScreen()
        {
            InitializeComponent();
            CarregarPlanosEnergia();
            AtualizarPlanoEnergiaAtivo();
        }

        #region | Modelo |
        public class PlanoEnergia
        {
            public string Nome { get; set; }
            public string Codigo { get; set; }

            public override string ToString()
            {
                return Nome;
            }
        }
        #endregion
        
        #region | Controles |
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            AplicarPlanoEnergiaSelecionado();

        }
        #endregion

        #region | Funções |
        private void CarregarPlanosEnergia()
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c powercfg /l";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.CreateNoWindow = true;
            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();

            string[] lines = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                Regex regex = new Regex(@"\b[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}\b");
                Match match = regex.Match(line);

                if (match.Success)
                {
                    string codigo = match.Value;
                    string nome = line.Replace(match.Value, "").Trim();

                    // Remover parênteses e asterisco do nome
                    nome = nome.Replace("(", "").Replace(")", "").Replace("GUID do Esquema de Energia:", "").Trim();

                    PlanoEnergia plano = new PlanoEnergia
                    {
                        Nome = nome,
                        Codigo = codigo
                    };

                    cboPowerPlan.Items.Add(plano);
                }
            }

            if (cboPowerPlan.Items.Count > 0)
            {
                cboPowerPlan.SelectedIndex = 0;
            }
            else
            {
                cboPowerPlan.Items.Add("Nenhum plano de energia disponível");
                cboPowerPlan.SelectedIndex = 0;
            }
        }

        private void AplicarPlanoEnergiaSelecionado()
        {
            if (cboPowerPlan.SelectedItem != null)
            {
                PlanoEnergia planoSelecionado = (PlanoEnergia)cboPowerPlan.SelectedItem;
                string codigo = planoSelecionado.Codigo;

                Process process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = $"/c powercfg -setactive {codigo}";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                process.WaitForExit();
                lblPlanoAtivo.Text = "Plano de Energia Ativo: " + planoSelecionado;

            }
            else
            {
                MessageBox.Show("Nenhum plano de energia selecionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AtualizarPlanoEnergiaAtivo()
        {
            string planoAtivo = "Nenhum plano de energia ativo";

            foreach (PlanoEnergia plano in cboPowerPlan.Items)
            {
                if (plano.Nome.EndsWith("*"))
                {
                    // Remove o asterisco do nome antes de exibir
                    planoAtivo = plano.Nome.TrimEnd('*').Trim();
                    break;
                }
            }

            lblPlanoAtivo.Text = "Plano de Energia Ativo: " + planoAtivo;
        }
        #endregion
    }
}
