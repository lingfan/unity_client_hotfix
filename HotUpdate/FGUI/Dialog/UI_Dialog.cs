/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace FGUI.Dialog
{
    public partial class UI_Dialog : GComponent
    {
        public GTextField m_Tittle;
        public GTextField m_Conten;
        public GButton m_tow_cancel;
        public GButton m_tow_confirm;
        public GGroup m_towmode;
        public GButton m_one_confirm;
        public GGroup m_onemode;
        public const string URL = "ui://3gqem46sifyf1";

        public static UI_Dialog CreateInstance()
        {
            return (UI_Dialog)UIPackage.CreateObject("Dialog", "Dialog");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_Tittle = (GTextField)GetChildAt(1);
            m_Conten = (GTextField)GetChildAt(2);
            m_tow_cancel = (GButton)GetChildAt(3);
            m_tow_confirm = (GButton)GetChildAt(4);
            m_towmode = (GGroup)GetChildAt(5);
            m_one_confirm = (GButton)GetChildAt(6);
            m_onemode = (GGroup)GetChildAt(7);
        }
    }
}