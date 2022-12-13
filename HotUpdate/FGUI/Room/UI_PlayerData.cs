/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace FGUI.Room
{
    public partial class UI_PlayerData : GComponent
    {
        public Controller m_IsMaster;
        public Controller m_HasAdminFunc;
        public GTextField m_RoomPlayerLevel;
        public GTextField m_RoomPlayerName;
        public GButton m_KickButton;
        public GTextField m_PlayerId;
        public const string URL = "ui://hya28zzrbp616";

        public static UI_PlayerData CreateInstance()
        {
            return (UI_PlayerData)UIPackage.CreateObject("Room", "PlayerData");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_IsMaster = GetControllerAt(0);
            m_HasAdminFunc = GetControllerAt(1);
            m_RoomPlayerLevel = (GTextField)GetChildAt(0);
            m_RoomPlayerName = (GTextField)GetChildAt(1);
            m_KickButton = (GButton)GetChildAt(3);
            m_PlayerId = (GTextField)GetChildAt(4);
        }
    }
}