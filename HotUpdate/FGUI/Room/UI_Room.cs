/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace FGUI.Room
{
    public partial class UI_Room : GComponent
    {
        public Controller m_IsMaster;
        public GTextField m_RoomName;
        public GButton m_Btn_QuitRoom;
        public GList m_Team1;
        public GList m_Team2;
        public GButton m_Btn_StartGame;
        public const string URL = "ui://hya28zzrbp610";

        public static UI_Room CreateInstance()
        {
            return (UI_Room)UIPackage.CreateObject("Room", "Room");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_IsMaster = GetControllerAt(0);
            m_RoomName = (GTextField)GetChildAt(2);
            m_Btn_QuitRoom = (GButton)GetChildAt(3);
            m_Team1 = (GList)GetChildAt(4);
            m_Team2 = (GList)GetChildAt(5);
            m_Btn_StartGame = (GButton)GetChildAt(6);
        }
    }
}