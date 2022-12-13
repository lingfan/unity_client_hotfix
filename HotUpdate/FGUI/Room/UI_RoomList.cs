/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace FGUI.Room
{
    public partial class UI_RoomList : GComponent
    {
        public GButton m_CreateButton;
        public GList m_RoomList;
        public GButton m_RefreshButton;
        public GButton m_QutiButton;
        public const string URL = "ui://hya28zzrbp61c";

        public static UI_RoomList CreateInstance()
        {
            return (UI_RoomList)UIPackage.CreateObject("Room", "RoomList");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_CreateButton = (GButton)GetChildAt(2);
            m_RoomList = (GList)GetChildAt(3);
            m_RefreshButton = (GButton)GetChildAt(4);
            m_QutiButton = (GButton)GetChildAt(5);
        }
    }
}