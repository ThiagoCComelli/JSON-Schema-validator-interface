using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Schema;
using System.IO;
using System.Diagnostics;
using System.Linq.Expressions;

namespace JSON_SHACL
{
    public class Global
    {
        public static void verificar(TextBox textbox,Label labeltext)
        {
            try
            {
                JSchema schema = JSchema.Parse(textbox.Text);
                labeltext.Text = "Valid JSON Schema!";
                labeltext.ForeColor = System.Drawing.Color.Green;
            } catch
            {
                labeltext.Text = "Invalid JSON Schema!";
                labeltext.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
