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
            Debug.Log("MyMécaMenu est initialisé avec succès !");
        }

        public override void OnPlayerInput(Player player, KeyCode keyCode, bool onUI)
        {
            base.OnPlayerInput(player, keyCode, onUI);

            if (keyCode == KeyCode.F7)
            {

                player.Notify("MyMécaMenu", "Seulement les Employé on le droit le lancer se menu");

                UIPanel panel = new UIPanel("MyMécaMenu", UIPanel.PanelType.Tab);
                panel.SetTitle("Menu MyMécaMenu");
                panel.Addbutton("Fermer", ui => player.ClosePanel(ui));
                panel.AddTabLine("Contacter le personnel", ui => player.Notify("MyMécaMemu", "Vous avez contacté le personnel , veuillez patienter quelques secondes."));

                player.ShowPanelUI(panel);
            }
        }
    }
}