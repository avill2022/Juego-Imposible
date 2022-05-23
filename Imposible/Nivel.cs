using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Imposible
{
    partial class Nivel : Form
    {
        private Form1 form;

        public Nivel()
        {
            InitializeComponent();
        }
        public Nivel(Form1 form1,int nivel)
        {
            form = form1;
            InitializeComponent();
            IniciaRadioButton(nivel);
        }
        public void IniciaRadioButton(int actual)
        {
            switch (actual)
            { 
                case 1:
                    Facil.Checked = true;
                    break;
                case 2:
                    Intermedio.Checked = true;
                    break;
                case 3:
                    Dificil.Checked = true;
                    break;
                case 4:
                    Imposible.Checked = true;
                    break;
                    
            }
        }
        #region Descriptores de acceso de atributos de ensamblado

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void Facil_Click(object sender, EventArgs e)
        {
            form._nivel = 20;
        }

        private void Intermedio_Click(object sender, EventArgs e)
        {
            form._nivel = 30;
        }

        private void Dificil_Click(object sender, EventArgs e)
        {
            form._nivel = 40;
        }

        private void Imposible_Click(object sender, EventArgs e)
        {
            form._nivel = 60;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            form.deshacer_Click(this,null);
        }
    }
}
