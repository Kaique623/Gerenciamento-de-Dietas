using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_de_Dietas
{
    public class InformationFrame
    {
        public CustomPanel mainPanel = new CustomPanel();

        Dictionary<string, Label> labeldict = new Dictionary<string, Label>(); 

        public void userMain(Dictionary<string, string> Information, int x = 0, int y = 0)
        {
            int frameCount = 0;
            mainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))); ;

            foreach (string key in Information.Keys)
            {
                int xpos = 20;
                int ypos = 30 + (25 * frameCount);

                if (frameCount / 4 > 0)
                {
                    xpos = 165;
                    ypos = 30 + (25 * (frameCount - 4));
                }

                labeldict[key] = new Label();
                labeldict[key].BackColor = System.Drawing.SystemColors.Window;
                labeldict[key].Location = new System.Drawing.Point(xpos, ypos);
                labeldict[key].AutoSize = true;
                labeldict[key].Text = $"{key}: {Information[key]}";
                mainPanel.Controls.Add(labeldict[key]);
                labeldict[key].Click += new System.EventHandler(PanelClick);
                frameCount ++;
                labeldict[key].ForeColor = Color.Black;
            }

            mainPanel.Location = new Point(x, y);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(300, 214);
            mainPanel.TabIndex = 0;
            

            mainPanel.Click += new System.EventHandler(PanelClick);
        }
        
        public void PanelClick(object sender, EventArgs e)
        {
            CustomPanel panel = new CustomPanel();
            string id = "";

            try
            {
                if (((CustomPanel)sender).Name == "mainPanel")
                    panel = (CustomPanel)sender;
            }
            catch
            {
                panel = (CustomPanel)((Label)sender).Parent;
            }

            foreach (var c in panel.Controls)
            {
                if (c.GetType() == typeof(Label))
                {
                    if (((Label)c).Text.StartsWith("Id: "))
                    {
                        id = ((Label)c).Text.Replace("Id: ", "");
                        OpenUserEditScreen(id, "usuario");
                    }
                }
            }

        }
        public void OpenUserEditScreen(string id, string currentTab)
        {
            var ValuesList = new List<string>();
            foreach (string value in labeldict.Keys)
            {
                if (value != "Id")
                {
                    ValuesList.Add(value);
                }
            }

            AddForm addScreen = new AddForm();
            addScreen.startup(ValuesList, currentTab, id);
            addScreen.ShowDialog();
        }
    }
}
