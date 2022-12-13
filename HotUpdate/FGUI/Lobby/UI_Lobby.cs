/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace FGUI.Lobby
{
    public partial class UI_Lobby : GComponent
    {
        public GButton m_shop;
        public GButton m_team;
        public GButton m_backpacket;
        public GButton m_achievemen;
        public GButton m_hero;
        public GButton m_prebattle;
        public GButton m_friend;
        public GButton m_watch;
        public GButton m_activity;
        public GGroup m_Bottom;
        public GTextField m_m_gemInfo;
        public GGroup m_gem;
        public GTextField m_m_goldenInfo;
        public GGroup m_golden;
        public GTextField m_m_pointInfo;
        public GGroup m_point;
        public GImage m_mail;
        public GImage m_setting;
        public GGroup m_RightTop;
        public GButton m_Btn_PVP;
        public GGroup m_nomalpvp;
        public GButton m_Btn_PVE;
        public GGroup m_pve;
        public GButton m_Btn_RoomMode;
        public GGroup m_seriviouspvp;
        public GGroup m_Right;
        public GImage m_UserAvatar;
        public GTextField m_userName;
        public GTextField m_UserLevel;
        public GGroup m_LeftTop;
        public const string URL = "ui://9ta7gv7krfuv0";

        public static UI_Lobby CreateInstance()
        {
            return (UI_Lobby)UIPackage.CreateObject("Lobby", "Lobby");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_shop = (GButton)GetChildAt(2);
            m_team = (GButton)GetChildAt(3);
            m_backpacket = (GButton)GetChildAt(4);
            m_achievemen = (GButton)GetChildAt(5);
            m_hero = (GButton)GetChildAt(6);
            m_prebattle = (GButton)GetChildAt(7);
            m_friend = (GButton)GetChildAt(8);
            m_watch = (GButton)GetChildAt(9);
            m_activity = (GButton)GetChildAt(10);
            m_Bottom = (GGroup)GetChildAt(11);
            m_m_gemInfo = (GTextField)GetChildAt(15);
            m_gem = (GGroup)GetChildAt(17);
            m_m_goldenInfo = (GTextField)GetChildAt(20);
            m_golden = (GGroup)GetChildAt(22);
            m_m_pointInfo = (GTextField)GetChildAt(25);
            m_point = (GGroup)GetChildAt(27);
            m_mail = (GImage)GetChildAt(28);
            m_setting = (GImage)GetChildAt(29);
            m_RightTop = (GGroup)GetChildAt(30);
            m_Btn_PVP = (GButton)GetChildAt(34);
            m_nomalpvp = (GGroup)GetChildAt(35);
            m_Btn_PVE = (GButton)GetChildAt(39);
            m_pve = (GGroup)GetChildAt(40);
            m_Btn_RoomMode = (GButton)GetChildAt(44);
            m_seriviouspvp = (GGroup)GetChildAt(45);
            m_Right = (GGroup)GetChildAt(46);
            m_UserAvatar = (GImage)GetChildAt(47);
            m_userName = (GTextField)GetChildAt(48);
            m_UserLevel = (GTextField)GetChildAt(49);
            m_LeftTop = (GGroup)GetChildAt(51);
        }
    }
}