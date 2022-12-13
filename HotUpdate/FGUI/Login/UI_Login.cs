/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace FGUI.Login
{
    public partial class UI_Login : GComponent
    {
        public GButton m_Btn_Login;
        public GGroup m_Gro_LoginInfo;
        public Transition m_Tween_LoginPanelFlyIn;
        public const string URL = "ui://2jxt4hn8pdjl9";

        public static UI_Login CreateInstance()
        {
            return (UI_Login)UIPackage.CreateObject("Login", "Login");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_Btn_Login = (GButton)GetChildAt(1);
            m_Gro_LoginInfo = (GGroup)GetChildAt(3);
            m_Tween_LoginPanelFlyIn = GetTransitionAt(0);
        }
    }
}