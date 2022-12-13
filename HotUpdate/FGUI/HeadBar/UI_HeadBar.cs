/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace FGUI.HeadBar
{
    public partial class UI_HeadBar : GComponent
    {
        public GTextField m_Tex_Level;
        public GTextField m_Tex_PlayerName;
        public GProgressBar m_Bar_HP;
        public GProgressBar m_Bar_MP;
        public GImage m_Img_Gap;
        public const string URL = "ui://ny5r4rwcqrur4";

        public static UI_HeadBar CreateInstance()
        {
            return (UI_HeadBar)UIPackage.CreateObject("HeadBar", "HeadBar");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_Tex_Level = (GTextField)GetChildAt(1);
            m_Tex_PlayerName = (GTextField)GetChildAt(2);
            m_Bar_HP = (GProgressBar)GetChildAt(4);
            m_Bar_MP = (GProgressBar)GetChildAt(5);
            m_Img_Gap = (GImage)GetChildAt(6);
        }
    }
}