using Life;

using Life.Network;
using Life.UI;
using MyMécaMenu;
using UnityEngine;



namespace MyMécaMenu
{
    public class MyMécaMenu : Plugin
    {
        public MyMécaMenu(IGameAPI aPI) : base(aPI)
        {
        }

        public override void OnPluginInit()
        {
            base.OnPluginInit();
            Debug.Log("Le Plugin MyMécaMenu est initialisé avec succès ! Amusez-vous .");
        }

        public override void OnPlayerInput(Player player, KeyCode keyCode, bool onUI)
        {
            base.OnPlayerInput(player, keyCode, onUI);

            if (keyCode == KeyCode.F7)
            {

                player.Notify("MyMécaMenu", "Seulement les Employé on le droit le lancer se menu. Une amende de 1500€ peut étre appliqué en cas de rentrer dans le menu sans autorisation...");

                UIPanel panel = new UIPanel("MyMécaMenu", UIPanel.PanelType.Tab);
                panel.SetTitle("Menu MyMécaMenu");
                panel.AddButton("Quitter le menu", ui => player.ClosePanel(ui));
                panel.AddTabLine("Contacter le personnel", ui => player.Notify("MyMécaMemu", "En Développement"));
                panel.AddTabLine("En savoir plus sur ce panel", ui => player.SendText("Panel développé par Bastien Brefort . Pour le métier de Mécanicien . Je ne suis ni cértifié ni reconnu sur le serveur Nova-Life de MOD.... Je Tiens à remercier Martinxeur14 Pour ce plugin XD ."));

                player.ShowPanelUI(panel);
            }
        }
    }
}
