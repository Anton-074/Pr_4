using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Pr_4.Models;
using System.Windows.Forms;

namespace Pr_4
{
    public partial class Form1 : Form
    {
        //private SubsystemPartnersContext? db;
        public Form1()
        {
            InitializeComponent();
        }

        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            using(SubsystemPartnersContext db = new SubsystemPartnersContext())
            {
                var partners = db.Partners.Include(u => u.IdTypePartnerNavigation).ThenInclude(c => c.IdPartnerNavigation).ToList();
                int yOffset = 10;
                foreach (Partner u in partners)
                {
                    Panel panel = new Panel
                    {
                        Width = 500,
                        Height = 70,
                        BackColor = Color.LightGray,
                        Location = new System.Drawing.Point(15, yOffset)

                    };

                    Label lb1 = new Label
                    {
                        Text = $"{u.IdTypePartnerNavigation.TypeOfPartner} | " +
                        $"{u.NamePartner}\n" +
                        $"{u.DirectorFullName}\n" +
                        $"{u.Phone}\n" +
                        $"Рейтинг: {u.Rating}",
                        AutoSize = true
                        
                    };
                    Label lb2 = new Label
                    {
                        Dock = DockStyle.Right,
                        Width = 100,
                        TextAlign = ContentAlignment.MiddleCenter,
                        Text = "10%"
                    };
                    
                    panel.Controls.Add(lb1);
                    panel.Controls.Add(lb2);
                    panelFill.Controls.Add(panel);

                    yOffset += panel.Height + 10;
                }
            }
            
        }
    }
}
