/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace FGUI.Room
{
    public partial class UI_RoomData : GComponent
    {
        public GTextField m_RoomName;
        public GTextField m_PlayerNum;
        public GButton m_JoinButton;
        public GTextField m_RoomId;
        public const string URL = "ui://hya28zzrbp61d";

        public static UI_RoomData CreateInstance()
        {
            return (UI_RoomData)UIPackage.CreateObject("Room", "RoomData");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_RoomName = (GTextField)GetChildAt(0);
            m_PlayerNum = (GTextField)GetChildAt(2);
            m_JoinButton = (GButton)GetChildAt(3);
            m_RoomId = (GTextField)GetChildAt(4);
        }
    }
}