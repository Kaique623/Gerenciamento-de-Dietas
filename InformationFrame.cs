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
                frameCount ++;
            }
            if (Information.Count > 0)
            {
                mainPanel.Location = new Point(x, y);
                mainPanel.Name = "mainPanel";
                mainPanel.Size = new Size(300, 214);
                mainPanel.TabIndex = 0;
            }
        }
    }
}
