using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblMensagem.Visible = false;
                txtDestino.Text = "";
                txtOrigem.Text = "";
            }
            else
            {
                lblMensagem.Visible = true;
            }
            
        }
        

        protected void btnBackup_Click(object sender, EventArgs e)
        {
            string diretorioOrigem = txtOrigem.Text;
            string diretorioDestino = txtDestino.Text;
            DirectoryInfo dirOrigem = new DirectoryInfo(diretorioOrigem);
            DirectoryInfo dirDestino = new DirectoryInfo(diretorioDestino);
            CopyAll(dirOrigem, dirDestino);
            lblMensagem.Visible = true;
            lblMensagem.Text = "BackUp efetuado com sucesso!";

        }

        public void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            if (source.FullName.ToLower() == target.FullName.ToLower())
            {
                return;
            }

            //Check if the target directory exists, if not, create it.
            if (Directory.Exists(target.FullName) == false)
            {
                Directory.CreateDirectory(target.FullName);
            }

            // Copy each file into it's new directory.
            foreach (FileInfo arquivo in source.GetFiles())
            {
                Console.WriteLine(@"Copying {0}\{1}", target.FullName, arquivo.Name);
                arquivo.CopyTo(Path.Combine(target.ToString(), arquivo.Name), true);
            }


            //Copy each subdirectory using recursion.

            foreach (DirectoryInfo diSourceSubDir in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir =
                target.CreateSubdirectory(diSourceSubDir.Name);
                CopyAll(diSourceSubDir, nextTargetSubDir);
            }


        }



    }



}


